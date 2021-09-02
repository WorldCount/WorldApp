using System.Collections.Generic;
using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.PostItem;
using DwUtils.Core.Database.Queryes.PostUnit;

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
        public List<FreeRpo> GetFreeRpos()
        {
            GetFreeRpoQuery query = new GetFreeRpoQuery(_postItemConnect, _debugMode);
            return query.Run();
        }

        public async Task<List<FreeRpo>> GetFreeRposAsync()
        {
            return await Task.Run(GetFreeRpos);
        }
    }
}
