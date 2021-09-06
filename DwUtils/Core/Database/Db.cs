using System.Collections.Generic;
using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.PostItem;
using DwUtils.Core.Database.Queryes.PostUnit;
using DwUtils.Core.Database.Requests;

namespace DwUtils.Core.Database
{
    public class Db
    {
        #region Private Fields

        private readonly PostUnitConnect _postUnitConnect;
        private readonly PostItemConnect _postItemConnect;
        private readonly bool _debugMode;

        #endregion

        public Db(PostItemConnect postItemConnect, PostUnitConnect postUnitConnect, bool debugMode = false)
        {
            _postItemConnect = postItemConnect;
            _postUnitConnect = postUnitConnect;
            _debugMode = debugMode;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public string GetLkApiUrl()
        {
            GetLkApiQuery query = new GetLkApiQuery(_postUnitConnect, _debugMode);
            return query.Run();
        }

        public async Task<string> GetLkApiUrlAsync()
        {
            return await Task.Run(GetLkApiUrl);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public bool SetLkApiUrl(string value)
        {
            SetLkApiQuery query = new SetLkApiQuery(_postUnitConnect, value, _debugMode);
            return query.Run();
        }

        public async Task<bool> SetLkApiUrlAsync(string value)
        {
            return await Task.Run(() => SetLkApiUrl(value));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<FreeRpo> GetFreeRpos(FreeRpoResponse response)
        {
            GetFreeRpoQuery query = new GetFreeRpoQuery(_postItemConnect, response, _debugMode);
            return query.Run();
        }

        public async Task<List<FreeRpo>> GetFreeRposAsync(FreeRpoResponse response)
        {
            return await Task.Run(() => GetFreeRpos(response));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<User> GetUsers()
        {
            GetUsersQuery query = new GetUsersQuery(_postUnitConnect, _debugMode);
            return query.Run();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await Task.Run(GetUsers);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public bool DeleteFreeRpos(List<FreeRpo> rpos)
        {
            DeleteFreeRposQuery query = new DeleteFreeRposQuery(_postItemConnect, rpos, _debugMode);
            return query.Run();
        }

        public async Task<bool> DeleteFreeRposAsync(List<FreeRpo> rpos)
        {
            return await Task.Run(() => DeleteFreeRpos(rpos));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<Place> GetPlaces()
        {
            GetPlaceQuery query = new GetPlaceQuery(_postItemConnect, _debugMode);
            return query.Run();
        }

        public async Task<List<Place>> GetPlacesAsync()
        {
            return await Task.Run(GetPlaces);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public bool UpdateFreeRposPlace(List<FreeRpo> rpos, int placeId)
        {
            UpdateFreeRposPlaceQuery query = new UpdateFreeRposPlaceQuery(_postItemConnect, rpos, placeId, _debugMode);
            return query.Run();
        }

        public async Task<bool> UpdateFreeRposPlaceAsync(List<FreeRpo> rpos, int placeId)
        {
            return await Task.Run(() => UpdateFreeRposPlace(rpos, placeId));
        }
    }
}
