using System.Collections.Generic;
using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.PostItem;
using DwUtils.Core.Database.Repositories.Base;
using DwUtils.Core.Database.Requests;

namespace DwUtils.Core.Database.Repositories
{
    public class FileRepository : PostItemRepository
    {
        public FileRepository(PostItemConnect connect, bool debugMode) : base(connect, debugMode) { }

        #region Public Methods

        // ReSharper disable once MemberCanBePrivate.Global
        public List<RpoFile> GetFiles(RpoFileRequest request)
        {
            GetFilesQuery query = new GetFilesQuery(Connect, request, DebugMode);
            return query.Run();
        }

        public async Task<List<RpoFile>> GetFilesAsync(RpoFileRequest request)
        {
            return await Task.Run(() => GetFiles(request));
        }

        #endregion
    }
}
