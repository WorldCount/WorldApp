using System.Collections.Generic;
using System.Threading.Tasks;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.PostItem;
using DwUtils.Core.Database.Repositories.Base;

namespace DwUtils.Core.Database.Repositories
{
    public class PlaceRepository : PostItemRepository
    {
        public PlaceRepository(PostItemConnect connect, bool debugMode) : base(connect, debugMode) { }

        #region Public Methods

        // ReSharper disable once MemberCanBePrivate.Global
        public List<Place> GetPlaces()
        {
            GetPlaceQuery query = new GetPlaceQuery(Connect, DebugMode);
            return query.Run();
        }

        public async Task<List<Place>> GetPlacesAsync()
        {
            return await Task.Run(GetPlaces);
        }

        #endregion
    }
}
