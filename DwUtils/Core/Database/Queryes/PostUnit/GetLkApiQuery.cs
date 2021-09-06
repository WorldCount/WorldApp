using FirebirdSql.Data.FirebirdClient;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Queryes.Base;

namespace DwUtils.Core.Database.Queryes.PostUnit
{
    public class GetLkApiQuery : PostUnitSelectQuery<string>
    {
        public GetLkApiQuery(PostUnitConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public override string GetQuery()
        {
            return "select vals from setupparam where paramid = 40060";
        }

        protected override string ParseResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            reader.Read();
            string response = reader.GetString(0);

            if (DebugMode)
                Logger.Debug($"Запрос вернул: '{response}'");
            return response;
        }
    }
}
