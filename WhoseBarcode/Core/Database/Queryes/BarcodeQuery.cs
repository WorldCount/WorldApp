using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using WhoseIsBarcode.Core.Database.Models;
using WhoseIsBarcode.Core.Database.Requests;

namespace WhoseIsBarcode.Core.Database.Queryes
{
    public class BarcodeQuery : Query
    {
        private readonly BarcodeRequest _request;

        public BarcodeQuery(Connect connect, BarcodeRequest request, bool debugMode = false) : base(connect, debugMode)
        {
            _request = request;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select");

            if (_request != null && _request.Limit != 0)
                sb.Append($" first {_request.Limit}");

            sb.Append(" r.barcode, r.index_from, r.num_month, r.num_seria, r.num_parcel, r.id_range_ei, re.date_info, f.firm_name, f.inn,  f.depcode, f.kpp, s.id, s.name from range r");
            sb.Append(" left join range_ei re on r.id_range_ei = re.id");
            sb.Append(" left join firms f on r.id_inn = f.id_inn");
            sb.Append(" left join range_state s on r.state = s.id");

            if (_request != null)
            {
                if(!string.IsNullOrEmpty(_request.Barcode))
                    sb.Append($" where barcode = '{_request.Barcode}'");

                if (_request.RangeId != 0)
                    sb.Append($" where r.id_range_ei = {_request.RangeId}");
            }

            return sb.ToString();
        }

        public List<DbBarcode> Run()
        {
            string query = GetQuery();
            if(DebugMode)
                Logger.Debug($"Запрос в БД:\n{query}");

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            List<DbBarcode> barcodes = new List<DbBarcode>();

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand selectCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
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

                    barcodes.Add(barcode);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                return barcodes;
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
