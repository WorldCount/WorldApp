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
    class GetAllStatRpoQuery : PostItemSelectQuery<List<AllStatRpo>>
    {
        private readonly AllStatRpoRequest _request;

        public GetAllStatRpoQuery(FbConnect connect, AllStatRpoRequest request, bool debugMode = false) : base(connect, debugMode)
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

        #region Queryes

        private string GetGeneralQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select CAST(docval.createtime as DATE),");
            sb.Append(" count(case when docstateid=1 and docvalid != 2 then 1 else null end),");
            sb.Append(" count(case when docstateid=6 then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid not in (5, 9, 12, 20, 24, 28, 41, 44, 47, 50, 53, 64, 72, 74, 75, 79, 83, 85, 87) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid in (5, 9, 12, 20, 24, 28, 41, 44, 47, 50, 53, 64, 72, 74, 75, 79, 83, 85, 87) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid in (18, 19, 20, 21, 22, 23, 24, 25, 36, 37, 78, 79, 80, 81) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=1 then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=2 then 1 else null end),");
            sb.Append(" sum(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=2 then paysum else null end),");
            sb.Append(" count(case when docstateid=10 then 1 else null end),");
            sb.Append(" count(case when docstateid=2 then 1 else null end)");
            sb.Append(" from docval");
            sb.Append(" left join doc d on docval.docid = d.docid");
            sb.Append(" where docstateid in (1, 2, 6, 10)");
            sb.Append($" and createtime >= '{_request.StartDate:dd.MM.yyyy}'  and createtime < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");

            if (_request.UserId != 0)
                sb.Append($" and createuserid = {_request.UserId}");

            sb.Append(" group by 1");

            return sb.ToString();
        }

        private string GetOperatorQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select createuserid,");
            sb.Append(" count(case when docstateid=1 and docvalid != 2 then 1 else null end),");
            sb.Append(" count(case when docstateid=6 then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid not in (5, 9, 12, 20, 24, 28, 41, 44, 47, 50, 53, 64, 72, 74, 75, 79, 83, 85, 87) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid in (5, 9, 12, 20, 24, 28, 41, 44, 47, 50, 53, 64, 72, 74, 75, 79, 83, 85, 87) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid in (18, 19, 20, 21, 22, 23, 24, 25, 36, 37, 78, 79, 80, 81) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=1 then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=2 then 1 else null end),");
            sb.Append(" sum(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=2 then paysum else null end),");
            sb.Append(" count(case when docstateid=10 then 1 else null end),");
            sb.Append(" count(case when docstateid=2 then 1 else null end)");
            sb.Append(" from docval");
            sb.Append(" left join doc d on docval.docid = d.docid");
            sb.Append(" where docstateid in (1, 2, 6, 10)");
            sb.Append($" and createtime >= '{_request.StartDate:dd.MM.yyyy}'  and createtime < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");
            sb.Append(" group by 1");

            return sb.ToString();
        }

        private string GetInHoursQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select extract(hour from createtime),");
            sb.Append(" count(case when docstateid=1 and docvalid != 2 then 1 else null end),");
            sb.Append(" count(case when docstateid=6 then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid not in (5, 9, 12, 20, 24, 28, 41, 44, 47, 50, 53, 64, 72, 74, 75, 79, 83, 85, 87) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid in (5, 9, 12, 20, 24, 28, 41, 44, 47, 50, 53, 64, 72, 74, 75, 79, 83, 85, 87) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and pstypecategoryid in (18, 19, 20, 21, 22, 23, 24, 25, 36, 37, 78, 79, 80, 81) then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=1 then 1 else null end),");
            sb.Append(" count(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=2 then 1 else null end),");
            sb.Append(" sum(case when docstateid=1 and client is not null and docvalid != 2 and postofficef30 is null and psissuetypeid=2 then paysum else null end),");
            sb.Append(" count(case when docstateid=10 then 1 else null end),");
            sb.Append(" count(case when docstateid=2 then 1 else null end)");
            sb.Append(" from docval");
            sb.Append(" left join doc d on docval.docid = d.docid");
            sb.Append(" where docstateid in (1, 2, 6, 10)");
            sb.Append($" and createtime >= '{_request.StartDate:dd.MM.yyyy}'  and createtime < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");

            if (_request.UserId != 0)
                sb.Append($" and createuserid = {_request.UserId}");

            sb.Append(" group by 1");

            return sb.ToString();
        }

        #endregion

        protected override List<AllStatRpo> ParseResponse(FbDataReader reader)
        {
            if (_request.Type == ReceiveRpoRequestType.ПоОператорам)
                return ParseOperatorResponse(reader);

            if (_request.Type == ReceiveRpoRequestType.ПоЧасам)
                return ParseInHoursResponse(reader);

            return ParseGeneralResponse(reader);
        }

        #region Parsers

        private List<AllStatRpo> ParseGeneralResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<AllStatRpo> data = new List<AllStatRpo>();

            while (reader.Read())
            {
                AllStatRpo rpo = new AllStatRpo
                {
                    Date = reader.GetDateTime(0),
                    AllCount = reader.GetInt32(1),
                    SentCount = reader.GetInt32(2),
                    AllReceivedCount = reader.GetInt32(3),
                    ReceivedNoValueCount = reader.GetInt32(4),
                    ValueCount = reader.GetInt32(5),
                    FirstClassCount = reader.GetInt32(6),
                    ReceivedCount = reader.GetInt32(7),
                    ReturnCount = reader.GetInt32(8),
                    NotifyCount = reader.GetInt32(10),
                    HandedCount = reader.GetInt32(11)
                };

                try
                {
                    rpo.ReturnPay = (double)reader.GetInt64(9) / 100;
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

        private List<AllStatRpo> ParseOperatorResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<AllStatRpo> data = new List<AllStatRpo>();

            while (reader.Read())
            {
                AllStatRpo rpo = new AllStatRpo
                {
                    UserId = reader.GetInt32(0),
                    AllCount = reader.GetInt32(1),
                    SentCount = reader.GetInt32(2),
                    AllReceivedCount = reader.GetInt32(3),
                    ReceivedNoValueCount = reader.GetInt32(4),
                    ValueCount = reader.GetInt32(5),
                    FirstClassCount = reader.GetInt32(6),
                    ReceivedCount = reader.GetInt32(7),
                    ReturnCount = reader.GetInt32(8),
                    NotifyCount = reader.GetInt32(10),
                    HandedCount = reader.GetInt32(11)
                };

                User user = _request.Users.FirstOrDefault(u => u.Id == rpo.UserId);
                rpo.UserName = user != null ? user.Name : rpo.UserId.ToString();

                try
                {
                    rpo.ReturnPay = (double)reader.GetInt64(9) / 100;
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

        private List<AllStatRpo> ParseInHoursResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<AllStatRpo> data = new List<AllStatRpo>();

            while (reader.Read())
            {
                AllStatRpo rpo = new AllStatRpo
                {
                    Hour = reader.GetInt32(0),
                    AllCount = reader.GetInt32(1),
                    SentCount = reader.GetInt32(2),
                    AllReceivedCount = reader.GetInt32(3),
                    ReceivedNoValueCount = reader.GetInt32(4),
                    ValueCount = reader.GetInt32(5),
                    FirstClassCount = reader.GetInt32(6),
                    ReceivedCount = reader.GetInt32(7),
                    ReturnCount = reader.GetInt32(8),
                    NotifyCount = reader.GetInt32(10),
                    HandedCount = reader.GetInt32(11)
                };

                try
                {
                    rpo.ReturnPay = (double)reader.GetInt64(9) / 100;
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
    }
}
