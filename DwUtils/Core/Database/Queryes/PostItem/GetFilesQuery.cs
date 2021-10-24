using System.Collections.Generic;
using System.Text;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;
using DwUtils.Core.Database.Requests;
using FirebirdSql.Data.FirebirdClient;
using NLog.Layouts;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class GetFilesQuery : PostItemSelectQuery<List<RpoFile>>
    {
        private readonly RpoFileRequest _request;

        public GetFilesQuery(FbConnect connect, RpoFileRequest request, bool debugMode = false) : base(connect, debugMode)
        {
            _request = request;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select");

            if (_request != null && _request.Limit != 0)
                sb.Append($" first {_request.Limit}");

            sb.Append(" sendid, name, senddate, senduserid from send");
            sb.Append(" where sendtypeid = 1");

            if (_request != null)
            {
                if (_request.UserId != 0)
                    sb.Append($" and senduserid = {_request.UserId}");

                if(_request.FilterDate)
                    sb.Append($" and senddate >= '{_request.StartDate:dd.MM.yyyy}' and senddate < '{_request.EndDate.AddDays(1):dd.MM.yyyy}'");
            }

            sb.Append(" order by senddate desc");
            return sb.ToString();
        }

        protected override List<RpoFile> ParseResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<RpoFile> data = new List<RpoFile>();

            while (reader.Read())
            {
                RpoFile rpoFile = new RpoFile
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Date = reader.GetDateTime(2),
                    UserId = reader.GetInt32(3)
                };

                rpoFile.Count = new GetCountRpoQuery(Connect, rpoFile.Id, DebugMode).Run();
                data.Add(rpoFile);
            }

            if (DebugMode)
                Logger.Debug($"Запрос вернул записей: {data.Count}");

            return data;
        }
    }
}
