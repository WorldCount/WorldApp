using System.Collections.Generic;
using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.PostUnit;
using DwUtils.Core.Database.Repositories.Base;

namespace DwUtils.Core.Database.Repositories
{
    public class UserRepository : PostUnitRepository
    {
        public UserRepository(PostUnitConnect connect, bool debugMode) : base(connect, debugMode) { }

        #region Public Methods

        // ReSharper disable once MemberCanBePrivate.Global
        public List<User> GetUsers()
        {
            GetUsersQuery query = new GetUsersQuery(Connect, DebugMode);
            return query.Run();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await Task.Run(GetUsers);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<ConnectUser> GetConnectUsers()
        {
            GetConnectUsersQuery query = new GetConnectUsersQuery(Connect, DebugMode);
            return query.Run();
        }

        public async Task<List<ConnectUser>> GetConnectUsersAsync()
        {
            return await Task.Run(GetConnectUsers);
        }

        #endregion
    }
}
