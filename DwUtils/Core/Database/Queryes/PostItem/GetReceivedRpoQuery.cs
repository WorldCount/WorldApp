using System;
using System.Collections.Generic;
using System.Text;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;
using DwUtils.Core.Database.Requests;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    class GetReceivedRpoQuery : PostItemSelectQuery<List<ReceivedRpo>>
    {
        private readonly ReceivedRpoRequest _request;

        public GetReceivedRpoQuery(FbConnect connect, ReceivedRpoRequest request, bool debugMode = false) : base(connect, debugMode)
        {
            _request = request;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select UPPER(client), count(extcode), count(retcounryid), count(paysum), sum(paysum) from doc");
            sb.Append(" left join docval v on doc.docid = v.docid");
            sb.Append(" where v.docstateid = 1 and doc.client is not null and doc.lastdocvalid != 2 and v.docvalid = 1");
            sb.Append($" and doc.docdate >= '{_request.StartDate:dd.MM.yyyy}'  and doc.docdate < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");

            if (_request.UserId != 0)
                sb.Append($" and v.createuserid = {_request.UserId}");

            sb.Append(" group by client");
            sb.Append(" order by client");

            return sb.ToString();
        }

        protected override List<ReceivedRpo> ParseResponse(FbDataReader reader)
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
                    rpo.ReturnPay = (double) reader.GetInt64(4) / 100;
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
    }
}
