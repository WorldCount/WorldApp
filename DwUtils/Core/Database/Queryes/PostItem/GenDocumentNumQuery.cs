using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Queryes.Base;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class GenDocumentNumQuery : PostItemSelectQuery<string>
    {
        private readonly int _reestrTypeId;
        private readonly int _placeId;

        public GenDocumentNumQuery(PostItemConnect connect, int placeId, int reestrTypeId = 12, bool debugMode = false) 
            : base(connect, debugMode)
        {
            _placeId = placeId;
            _reestrTypeId = reestrTypeId;
        }

        public override string GetQuery()
        {
            return $"select * from reestrnum_gen({_reestrTypeId}, {_placeId})";
        }

        protected override string ParseResponse(FbDataReader reader)
        {
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");

            reader.Read();

            string docNum = reader.GetString(0);

            if (DebugMode)
                Logger.Debug($"Запрос вернул: '{docNum}'");

            return docNum;
        }
    }
}
