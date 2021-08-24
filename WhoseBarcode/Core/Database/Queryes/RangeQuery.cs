using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using WhoseIsBarcode.Core.Database.Models;
using WhoseIsBarcode.Core.Database.Requests;

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

            sb.Append(" re.id, re.date_info, re.is_external, r.index_from, r.num_month, r.num_seria, f.firm_name, f.inn,  f.depcode, f.kpp,");
            sb.Append(" (select count(*) from range where range.id_range_ei = re.id) as count_all,");
            sb.Append(" (select count(*) from range where range.id_range_ei = re.id and range.state = 1) as count_free,");
            sb.Append(" (select count(*) from range where range.id_range_ei = re.id and range.state = 2) as count_busy");
            sb.Append(" from range_ei re");
            sb.Append(" left join range r on re.id = r.id_range_ei");
            sb.Append(" left join firms f on r.id_inn = f.id_inn");
            sb.Append(" where r.index_from is not null");

            if (_request != null)
            {
                if(_request.RangeId != 0)
                    sb.Append($" and re.id = {_request.RangeId}");

                if (_request.Firm != null && _request.Firm.InnId != 0)
                    sb.Append($" and re.inn = '{_request.Firm.Inn}' and re.kpp = '{_request.Firm.Kpp}' and re.depcode = '{_request.Firm.Depcode}'");
            }

            sb.Append(" group by re.id, re.date_info, re.is_external, r.index_from, r.num_month, r.num_seria, f.firm_name, f.inn,  f.depcode, f.kpp");
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
                        Month = reader.GetString(4),
                        Seria = reader.GetString(5),
                        FirmName = reader.GetString(6),
                        FirmInn = reader.GetString(7),
                        FirmDepcode = reader.GetString(8),
                        FirmKpp = reader.GetString(9),
                        Count = reader.GetInt32(10),
                        FreeCount = reader.GetInt32(11),
                        BusyCount = reader.GetInt32(12)
                    };

                    //int state = reader.GetInt32(11);

                    //DbRange oldRange = ranges.FirstOrDefault(r => r.Id == range.Id);
                    //if (oldRange == null)
                    //{
                    //    if (state == 1)
                    //        range.FreeCount = range.Count;
                    //    else
                    //        range.BusyCount = range.Count;

                    //    ranges.Add(range);
                    //}
                    //else
                    //{
                    //    if (state == 1)
                    //        oldRange.FreeCount = range.Count;
                    //    else
                    //        oldRange.BusyCount = range.Count;

                    //    oldRange.Count += range.Count;
                    //}

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
