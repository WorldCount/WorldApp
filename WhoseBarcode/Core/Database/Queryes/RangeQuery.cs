using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using WhoseBarcode.Core.Database.Models;

namespace WhoseBarcode.Core.Database.Queryes
{
    public class RangeQuery : Query
    {
        private readonly int _rangeId;

        public RangeQuery(Connect connect, int rangeId, bool debugMode = false) : base(connect, debugMode)
        {
            _rangeId = rangeId;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select re.id, re.date_info, re.is_external, r.index_from, r.num_month, r.num_seria, f.firm_name, f.inn,  f.depcode, f.kpp, count(*) from range_ei re");
            sb.Append(" left join range r on re.id = r.id_range_ei");
            sb.Append(" left join firms f on r.id_inn = f.id_inn");
            sb.Append($" where re.id = {_rangeId}");
            sb.Append(" group by re.id, re.date_info, re.is_external, r.index_from, r.num_month, r.num_seria, f.firm_name, f.inn,  f.depcode, f.kpp");

            return sb.ToString();
        }

        public DbRange Run()
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

                DbRange range = new DbRange
                {
                    Id = reader.GetInt32(0),
                    Date = reader.GetDateTime(1),
                    IsExternal = reader.GetChar(2) == 'T',
                    Ops = reader.GetString(3),
                    Month = reader.GetInt32(4),
                    Seria = reader.GetInt32(5),
                    FirmName = reader.GetString(6),
                    FirmInn = reader.GetString(7),
                    FirmDepcode = reader.GetString(8),
                    FirmKpp = reader.GetString(9),
                    Count = reader.GetInt32(10)
                };

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                return range;
            }
            catch (Exception e)
            {
                if (DebugMode)
                {
                    Logger.Error($"Ошибка при запросе: {query}");
                    Logger.Error(e);
                    Logger.Error(e.Message);
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
