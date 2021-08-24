using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using WhoseIsBarcode.Core.Database.Response;

namespace WhoseIsBarcode.Core.Database.Queryes
{
    public class RangeDataQuery : Query
    {
        private readonly int _rangeId;

        public RangeDataQuery(Connect connect, int rangeId, bool debugMode = false) : base(connect, debugMode)
        {
            _rangeId = rangeId;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select (select count(*) from range where range.id_range_ei = r.id),");
            sb.Append(" (select count(*) from range where range.id_range_ei = r.id and range.state = 1),");
            sb.Append(" (select count(*) from range where range.id_range_ei = r.id and range.state = 2),");
            sb.Append(" (select first 1 num_parcel from range where range.id_range_ei = r.id order by num_parcel),");
            sb.Append(" (select first 1 num_parcel from range where range.id_range_ei= r.id order by num_parcel desc),");
            sb.Append(" (select first 1 num_month from range where range.id_range_ei= r.id) as num_month,");
            sb.Append(" (select first 1 num_seria from range where range.id_range_ei= r.id) as num_seria");
            sb.Append($" from range_ei r where id = {_rangeId}");

            return sb.ToString();
        }

        public RangeData Run()
        {
            string query = GetQuery();
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{query}");

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand selectCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                reader = selectCommand.ExecuteReader();

                reader.Read();

                RangeData data = new RangeData
                {
                    Count = reader.GetInt32(0),
                    FreeCount = reader.GetInt32(1),
                    BusyCount = reader.GetInt32(2),
                    FirstNum = reader.GetString(3),
                    LastNum = reader.GetString(4),
                    Month = reader.GetString(5),
                    Seria = reader.GetString(6)
                };

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                return data;
            }
            catch (Exception e)
            {
                if (DebugMode)
                {
                    Logger.Error($"Ошибка при запросе: {query}");
                    Logger.Error(e);
                }

                fbTransaction?.Rollback();
                return null;
            }
            finally
            {
                reader?.Close();
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
