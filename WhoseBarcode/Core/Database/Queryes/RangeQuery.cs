using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using WhoseIsBarcode.Core.Database.Models;
using WhoseIsBarcode.Core.Database.Requests;
using WhoseIsBarcode.Core.Database.Response;

namespace WhoseIsBarcode.Core.Database.Queryes
{
    public class RangeQuery : Query
    {
        private readonly RangeRequest _request;

        public RangeQuery(Connect connect, RangeRequest request, bool debugMode = false) : base(connect, debugMode)
        {
            _request = request;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select");

            if (_request != null && _request.Limit > 0)
                sb.Append($" first {_request.Limit}");

            sb.Append(" re.id, re.date_info, re.is_external, re.index_from, f.firm_name, f.inn,  f.depcode, f.kpp");
            sb.Append(" from range_ei re");
            sb.Append(" left join firms f on re.inn = f.inn and re.kpp = f.kpp and re.depcode = f.depcode");
            sb.Append(" where re.index_from is not null");

            if (_request != null)
            {
                if(_request.RangeId != 0)
                    sb.Append($" and re.id = {_request.RangeId}");

                if (_request.Firm != null && _request.Firm.InnId != 0)
                    sb.Append($" and re.inn = '{_request.Firm.Inn}' and re.kpp = '{_request.Firm.Kpp}' and re.depcode = '{_request.Firm.Depcode}'");
            }

            sb.Append(" group by re.id, re.date_info, re.is_external, re.index_from, f.firm_name, f.inn,  f.depcode, f.kpp");
            sb.Append(" order by re.date_info desc");

            return sb.ToString();
        }

        public List<DbRange> Run()
        {
            string query = GetQuery();
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{query}");

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            List<DbRange> ranges = new List<DbRange>();

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
                    DbRange range = new DbRange
                    {
                        Id = reader.GetInt32(0),
                        Date = reader.GetDateTime(1),
                        IsExternal = reader.GetChar(2) == 'T',
                        Ops = reader.GetString(3),
                        FirmName = reader.GetString(4),
                        FirmInn = reader.GetString(5),
                        FirmDepcode = reader.GetString(6),
                        FirmKpp = reader.GetString(7)
                    };

                    RangeDataQuery subQuery = new RangeDataQuery(Connect, range.Id, DebugMode);
                    RangeData rangeData = subQuery.Run();
                    range.SetData(rangeData);

                    ranges.Add(range);
                }

                if (DebugMode)
                    Logger.Debug($"Запрос вернул записей: {ranges.Count}");

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                return ranges;
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

        private List<DbRange> GroupRange(List<DbRange> ranges)
        {
            List<DbRange> resultRanges = new List<DbRange>();

            foreach (DbRange range in ranges)
            {
                DbRange oldRange = resultRanges.FirstOrDefault(r => r.Id == range.Id);
                if(oldRange == null)
                    resultRanges.Add(range);
                else
                {

                }
            }

            return resultRanges;
        }
    }
}
