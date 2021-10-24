using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    class UpdateFreeRposPlaceQuery : PostItemUpdateQuery<bool>
    {
        private readonly List<FreeRpo> _rpos;
        private readonly int _placeId;

        public UpdateFreeRposPlaceQuery(PostItemConnect connect, List<FreeRpo> rpos, int placeId, bool debugMode = false) : base(connect, debugMode)
        {
            _rpos = rpos;
            _placeId = placeId;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(String.Join(", ", _rpos.Select(rpo => rpo.Id.ToString()).ToArray()));
            sb.Append(")");

            return $"update docval set placeid = {_placeId} where docid in {sb}";
        }

        protected override bool ParseResponse(int updateCount)
        {
            if (DebugMode)
            {
                Logger.Debug($"Запрос в БД:\n{GetQuery()}");
                Logger.Debug($"Запрос обновил строк: {updateCount}");
            }

            return updateCount > 0;
        }
    }
}
