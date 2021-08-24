using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using WhoseIsBarcode.Core.Database.Models;

namespace WhoseIsBarcode.Core.Database.Queryes
{
    public class BarcodeQuery : Query
    {
        private readonly string _barcode;

        public BarcodeQuery(Connect connect, string barcode, bool debugMode = false) : base(connect, debugMode)
        {
            _barcode = barcode;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select first 1 r.barcode, r.index_from, r.num_month, r.num_seria, r.num_parcel, r.id_range_ei, re.date_info, f.firm_name, f.inn,  f.depcode, f.kpp, s.id, s.name from range r");
            sb.Append(" left join range_ei re on r.id_range_ei = re.id");
            sb.Append(" left join firms f on r.id_inn = f.id_inn");
            sb.Append(" left join range_state s on r.state = s.id");
            sb.Append($" where barcode = '{_barcode}'");

            return sb.ToString();
        }

        public DbBarcode Run()
        {
            string query = GetQuery();
            if(DebugMode)
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

                DbBarcode barcode = new DbBarcode
                {
                    Barcode = reader.GetString(0),
                    Ops = reader.GetString(1),
                    Month = reader.GetInt32(2),
                    Seria = reader.GetInt32(3),
                    Num = reader.GetString(4),
                    RangeId = reader.GetInt32(5),
                    Date = reader.GetDateTime(6),
                    FirmName = reader.GetString(7),
                    FirmInn = reader.GetString(8),
                    FirmDepcode = reader.GetString(9),
                    FirmKpp = reader.GetString(10),
                    StateId = reader.GetInt32(11),
                    State = reader.GetString(12)
                };

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                return barcode;
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
