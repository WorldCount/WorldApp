using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Queryes.Base;

namespace DwUtils.Core.Database.Queryes.PostUnit
{
    public class SetLkApiQuery : PostUnitUpdateQuery<bool>
    {
        private readonly string _value;

        public SetLkApiQuery(PostUnitConnect connect, string value, bool debugMode = false) : base(connect, debugMode)
        {
            _value = value;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public override string GetQuery()
        {
            return $"update setupparam set vals = '{_value}' where paramid = 40060";
        }

        protected override bool ParseResponse(int updateCount)
        {
            return updateCount > 0;
        }
    }
}
