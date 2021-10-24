using System;
using System.Collections.Generic;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class GetPlaceQuery : PostItemSelectQuery<List<Place>>
    {
        public GetPlaceQuery(PostItemConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        public override string GetQuery()
        {
            return "select placeid, name from place";
        }

        protected override List<Place> ParseResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            List<Place> data = new List<Place>();

            while (reader.Read())
            {
                Place place = new Place
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1).Replace(" участок", "")
                };

                data.Add(place);
            }

            if (DebugMode)
                Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
