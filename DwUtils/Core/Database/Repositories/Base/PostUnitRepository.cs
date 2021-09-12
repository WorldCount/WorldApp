using DwUtils.Core.Database.Connects;

namespace DwUtils.Core.Database.Repositories.Base
{
    public abstract class PostUnitRepository
    {
        #region Private Fields

        private readonly PostUnitConnect _connect;
        private readonly bool _debugMode;

        #endregion

        protected PostUnitRepository(PostUnitConnect connect, bool debugMode)
        {
            _connect = connect;
            _debugMode = debugMode;
        }

        #region Public Properties

        public PostUnitConnect Connect => _connect;
        public bool DebugMode => _debugMode;

        #endregion
    }
}
