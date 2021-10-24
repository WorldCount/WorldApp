using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Queryes.Base;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class GetCountRpoQuery : PostItemSelectQuery<int>
    {
        private readonly int _fileId;

        public GetCountRpoQuery(FbConnect connect, int fileId, bool debugMode = false) : base(connect, debugMode)
        {
            _fileId = fileId;
        }

        public override string GetQuery()
        {
            return $"select count(docid) from docval where sendid = {_fileId}";
        }

        protected override int ParseResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            reader.Read();

            int count = reader.GetInt32(0);

            if (DebugMode)
                Logger.Debug($"Запрос вернул: '{count}'");

            return count;
        }
    }
}
