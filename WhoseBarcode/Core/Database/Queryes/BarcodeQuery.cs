using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using WhoseBarcode.Core.Database.Models;

namespace WhoseBarcode.Core.Database.Queryes
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
            sb.Append("select first 1 r.barcode, r.num_month, r.num_seria, r.num_parcel, r.id_range_ei, re.date_info, f.firm_name, f.inn,  f.depcode, f.kpp, s.id, s.name from range r");
            sb.Append(" left join range_ei re on r.id_range_ei = re.id");
            sb.Append(" left join firms f on r.id_inn = f.id_inn");
            sb.Append(" left join range_state s on r.state = s.id");
            sb.Append($" where barcode = '{_barcode}'");

            return sb.ToString();
        }

        public DbBarcode Run()
        {
            string query = GetQuery();
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
                    Month = reader.GetInt32(1),
                    Seria = reader.GetInt32(2),
                    Num = reader.GetString(3),
                    RangeId = reader.GetInt32(4),
                    Date = reader.GetDateTime(5),
                    FirmName = reader.GetString(6),
                    FirmInn = reader.GetString(7),
                    FirmDepcode = reader.GetString(8),
                    FirmKpp = reader.GetString(9),
                    StateId = reader.GetInt32(10),
                    State = reader.GetString(11)
                };

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                return barcode;
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при запросе: {query}");
                Logger.Error(e);
                Logger.Error(e.Message);

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
