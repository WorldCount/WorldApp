using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Queryes.PostUnit;
using DwUtils.Core.Database.Repositories.Base;

namespace DwUtils.Core.Database.Repositories
{
    public class SettingRepository : PostUnitRepository
    {
        public SettingRepository(PostUnitConnect connect, bool debugMode) : base(connect, debugMode) { }

        #region Public Methods

        // ReSharper disable once MemberCanBePrivate.Global
        public string GetLkApiUrl()
        {
            GetLkApiQuery query = new GetLkApiQuery(Connect, DebugMode);
            return query.Run();
        }

        public async Task<string> GetLkApiUrlAsync()
        {
            return await Task.Run(GetLkApiUrl);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public bool SetLkApiUrl(string value)
        {
            SetLkApiQuery query = new SetLkApiQuery(Connect, value, DebugMode);
            return query.Run();
        }

        public async Task<bool> SetLkApiUrlAsync(string value)
        {
            return await Task.Run(() => SetLkApiUrl(value));
        }

        #endregion
    }
}
