using System.Collections.Generic;
using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.PostItem;
using DwUtils.Core.Database.Repositories.Base;
using DwUtils.Core.Database.Requests;

namespace DwUtils.Core.Database.Repositories
{
    public class RpoRepository : PostItemRepository
    {
        public RpoRepository(PostItemConnect connect, bool debugMode) : base(connect, debugMode) { }

        #region Public Methods

        // ReSharper disable once MemberCanBePrivate.Global
        public List<FreeRpo> GetFreeRpos(FreeRpoRequest request)
        {
            GetFreeRpoQuery query = new GetFreeRpoQuery(Connect, request, DebugMode);
            return query.Run();
        }

        public async Task<List<FreeRpo>> GetFreeRposAsync(FreeRpoRequest response)
        {
            return await Task.Run(() => GetFreeRpos(response));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public bool DeleteFreeRpos(List<FreeRpo> rpos)
        {
            DeleteFreeRposQuery query = new DeleteFreeRposQuery(Connect, rpos, DebugMode);
            return query.Run();
        }

        public async Task<bool> DeleteFreeRposAsync(List<FreeRpo> rpos)
        {
            return await Task.Run(() => DeleteFreeRpos(rpos));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public bool UpdateFreeRposPlace(List<FreeRpo> rpos, int placeId)
        {
            UpdateFreeRposPlaceQuery query = new UpdateFreeRposPlaceQuery(Connect, rpos, placeId, DebugMode);
            return query.Run();
        }

        public async Task<bool> UpdateFreeRposPlaceAsync(List<FreeRpo> rpos, int placeId)
        {
            return await Task.Run(() => UpdateFreeRposPlace(rpos, placeId));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<ReceivedRpo> GetReceivedRpos(ReceiveRpoRequest request)
        {
            GetReceivedRpoQuery query = new GetReceivedRpoQuery(Connect, request, DebugMode);
            return query.Run();
        }

        public async Task<List<ReceivedRpo>> GetReceivedRposAsync(ReceiveRpoRequest request)
        {
            return await Task.Run(() => GetReceivedRpos(request));
        }

        #endregion
    }
}
