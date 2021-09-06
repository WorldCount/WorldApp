using System.Collections.Generic;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.PostUnit
{
    public class GetUsersQuery : PostUnitSelectQuery<List<User>>
    {
        public GetUsersQuery(PostUnitConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        public override string GetQuery()
        {
            return "select userid, Upper(name), pass, isadmin, isvalid from users where isValid = 1 order by Upper(name)";
        }

        protected override List<User> ParseResponse(FbDataReader reader)
        {
            List<User> data = new List<User>();

            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            while (reader.Read())
            {
                User dbUser = new User
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Password = reader.GetString(2),
                    IsAdmin = reader.GetBoolean(3),
                    IsValid = reader.GetBoolean(4)
                };

                data.Add(dbUser);
            }

            if(DebugMode)
                Logger.Debug($"Запрос вернул записей: {data.Count}");
            return data;
        }
    }
}
