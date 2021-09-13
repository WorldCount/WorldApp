using System.Collections.Generic;
using System.Linq;
using System.Text;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;
using DwUtils.Core.Database.Requests;
using DwUtils.Core.Database.Requests.Types;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    class GetReceivedRpoQuery : PostItemSelectQuery<List<ReceivedRpo>>
    {
        private readonly ReceiveRpoRequest _request;

        public GetReceivedRpoQuery(FbConnect connect, ReceiveRpoRequest request, bool debugMode = false) : base(connect, debugMode)
        {
            _request = request;
        }

        public override string GetQuery()
        {
            if (_request.Type == ReceiveRpoRequestType.ПоЧасам)
                return GetInHoursQuery();

            if (_request.Type == ReceiveRpoRequestType.ПоОператорам)
                return GetOperatorQuery();

            return GetGeneralQuery();
        }

        #region Private Methods

        private string GetGeneralQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select UPPER(client), count(extcode), count(case when psissuetypeid=1 then 1 else null end),");
            sb.Append(" count(case when psissuetypeid=2 then 1 else null end), sum(paysum) from doc");
            sb.Append(" left join docval v on doc.docid = v.docid");
            sb.Append(" where v.docstateid = 1 and doc.client is not null and doc.lastdocvalid != 2 and v.docvalid = 1");
            sb.Append($" and doc.docdate >= '{_request.StartDate:dd.MM.yyyy}'  and doc.docdate < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");

            if (_request.UserId != 0)
                sb.Append($" and v.createuserid = {_request.UserId}");

            sb.Append(" group by client");

            return sb.ToString();
        }

        private string GetOperatorQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select v.createuserid, count(distinct client), count(extcode), count(case when psissuetypeid=1 then 1 else null end),");
            sb.Append(" count(case when psissuetypeid=2 then 1 else null end), sum(paysum)");
            sb.Append(" from doc left join docval v on doc.docid = v.docid");
            sb.Append(" where v.docstateid = 1 and doc.client is not null and doc.lastdocvalid != 2 and v.docvalid = 1");
            sb.Append($" and doc.docdate >= '{_request.StartDate:dd.MM.yyyy}'  and doc.docdate < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");
            sb.Append(" group by v.createuserid");

            return sb.ToString();
        }

        private string GetInHoursQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select extract(hour from v.createtime), count(distinct client), count(extcode),");
            sb.Append(" count(case when psissuetypeid=1 then 1 else null end), count(case when psissuetypeid=2 then 1 else null end),");
            sb.Append(" sum(paysum) from doc left join docval v on doc.docid = v.docid");
            sb.Append(" where v.docstateid = 1 and doc.client is not null and doc.lastdocvalid != 2 and v.docvalid = 1");
            sb.Append($" and doc.docdate >= '{_request.StartDate:dd.MM.yyyy}'  and doc.docdate < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");

            if (_request.UserId != 0)
                sb.Append($" and v.createuserid = {_request.UserId}");

            sb.Append(" group by 1");

            return sb.ToString();
        }

        private List<ReceivedRpo> ParseGeneralResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<ReceivedRpo> data = new List<ReceivedRpo>();

            while (reader.Read())
            {
                ReceivedRpo rpo = new ReceivedRpo
                {
                    ClientName = reader.GetString(0),
                    AllCount = reader.GetInt32(1),
                    ReceivedCount = reader.GetInt32(2),
                    ReturnCount = reader.GetInt32(3)
                };

                try
                {
                    rpo.ReturnPay = (double)reader.GetInt64(4) / 100;
                }
                catch
                {
                    //
                }

                data.Add(rpo);
            }

            if (DebugMode)
                Logger.Debug($"Запрос вернул записей: {data.Count}");

            return data;
        }

        private List<ReceivedRpo> ParseOperatorResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<ReceivedRpo> data = new List<ReceivedRpo>();

            while (reader.Read())
            {
                ReceivedRpo rpo = new ReceivedRpo
                {
                    UserId = reader.GetInt32(0),
                    DocumentCount = reader.GetInt32(1),
                    AllCount = reader.GetInt32(2),
                    ReceivedCount = reader.GetInt32(3),
                    ReturnCount = reader.GetInt32(4)
                };

                User user = _request.Users.FirstOrDefault(u => u.Id == rpo.UserId);
                if (user != null)
                    rpo.UserName = user.Name;
                else
                    rpo.UserName = rpo.UserId.ToString();

                try
                {
                    rpo.ReturnPay = (double)reader.GetInt64(5) / 100;
                }
                catch
                {
                    //
                }

                data.Add(rpo);
            }

            if (DebugMode)
                Logger.Debug($"Запрос вернул записей: {data.Count}");

            return data;
        }

        private List<ReceivedRpo> ParseInHoursResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<ReceivedRpo> data = new List<ReceivedRpo>();

            while (reader.Read())
            {
                ReceivedRpo rpo = new ReceivedRpo
                {
                    Hour = reader.GetInt32(0),
                    DocumentCount = reader.GetInt32(1),
                    AllCount = reader.GetInt32(2),
                    ReceivedCount = reader.GetInt32(3),
                    ReturnCount = reader.GetInt32(4)
                };

                try
                {
                    rpo.ReturnPay = (double)reader.GetInt64(5) / 100;
                }
                catch
                {
                    //
                }

                data.Add(rpo);
            }

            if (DebugMode)
                Logger.Debug($"Запрос вернул записей: {data.Count}");

            return data;
        }

        #endregion

        protected override List<ReceivedRpo> ParseResponse(FbDataReader reader)
        {
            if (_request.Type == ReceiveRpoRequestType.ПоОператорам)
                return ParseOperatorResponse(reader);

            if (_request.Type == ReceiveRpoRequestType.ПоЧасам)
                return ParseInHoursResponse(reader);

            return ParseGeneralResponse(reader);
        }
    }
}
