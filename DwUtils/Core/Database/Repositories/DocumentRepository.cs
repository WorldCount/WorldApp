using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Queryes.PostItem;
using DwUtils.Core.Database.Repositories.Base;

namespace DwUtils.Core.Database.Repositories
{
    public class DocumentRepository : PostItemRepository
    {
        public DocumentRepository(PostItemConnect connect, bool debugMode) : base(connect, debugMode) { }

        #region Public Methods

        // ReSharper disable once MemberCanBePrivate.Global
        public string GenDocumentNum(int placeId, int reestrTypeId = 12)
        {
            GenDocumentNumQuery query = new GenDocumentNumQuery(Connect, placeId, reestrTypeId, DebugMode);
            return query.Run();
        }

        public async Task<string> GenDocumentNumAsync(int placeId, int reestrTypeId = 12)
        {
            return await Task.Run(() => GenDocumentNum(placeId, reestrTypeId));
        }

        #endregion
    }
}
