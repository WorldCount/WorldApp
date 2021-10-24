using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;
using DwUtils.Core.Database.Requests;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class GetFreeRpoQuery : PostItemSelectQuery<List<FreeRpo>>
    {
        private readonly FreeRpoRequest _request;

        public GetFreeRpoQuery(PostItemConnect connect, FreeRpoRequest request, bool debugMode = false) : base(connect, debugMode)
        {
            _request = request;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select d.docid, d.doctypeid, d.pstypecategoryid, d.extcode, d.postofficeret, d.docdate, v.placeid, v.createuserid from doc d");
            sb.Append(" left join docval v on d.docid = v.docid");
            sb.Append(" left join place p on v.placeid = p.placeid");
            sb.Append(" where lastdocvalid = 1 and reestrid is null");

            if (_request != null)
            {
                if (_request.PlaceId != 0)
                    sb.Append($" and placeid = {_request.PlaceId}");

                if(_request.UserId != 0)
                    sb.Append($" and createuserid = {_request.UserId}");

                if(_request.TypeId != 0)
                    sb.Append($" and doctypeid = {_request.TypeId}");

                if (_request.FilterDate)
                    sb.Append($" and docdate >= '{_request.StartDate:dd.MM.yyyy}' and docdate < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");
            }

            sb.Append(" order by docdate");

            return sb.ToString();
        }

        protected override List<FreeRpo> ParseResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<FreeRpo> data = new List<FreeRpo>();

            while (reader.Read())
            {
                FreeRpo rpo = new FreeRpo
                {
                    Id = reader.GetInt32(0),
                    Type = reader.GetInt32(1),
                    TypeCategory = reader.GetInt32(2),
                    Barcode = reader.GetString(3),
                    IndexTo = reader.GetString(4),
                    LoadDate = reader.GetDateTime(5),
                    PlaceId = reader.GetInt32(6),
                    UserId = reader.GetInt32(7)
                };

                data.Add(rpo);
            }

            if (DebugMode)
                Logger.Debug($"Запрос вернул записей: {data.Count}");

            return data;
        }
    }
}
