using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;
using DwUtils.Core.Database.Queryes.Base;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class DeleteFreeRposQuery : PostItemUpdateQuery<bool>
    {
        private readonly List<FreeRpo> _rpos;

        public DeleteFreeRposQuery(PostItemConnect connect, List<FreeRpo> rpos, bool debugMode = false) : base(connect, debugMode)
        {
            _rpos = rpos;
        }

        public override string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(String.Join(", ", _rpos.Select(rpo => rpo.Id.ToString()).ToArray()));
            sb.Append(")");

            return $"delete from doc where docid in {sb}";
        }

        protected override bool ParseResponse(int updateCount)
        {
            return updateCount > 0;
        }
    }
}
