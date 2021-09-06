using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class GetFreeRpoQuery : PostItemSelectQuery<List<FreeRpo>>
    {
        public GetFreeRpoQuery(PostItemConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select d.docid, d.doctypeid, d.pstypecategoryid, d.extcode, d.postofficeret, d.docdate, v.placeid, v.createuserid from doc d");
            sb.Append(" left join docval v on d.docid = v.docid");
            sb.Append(" where lastdocvalid = 1 and (clienttypeid is null or clienttypeid = 2) order by d.docdate");

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
