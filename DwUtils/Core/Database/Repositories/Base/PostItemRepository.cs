using DwUtils.Core.Database.Connects;

namespace DwUtils.Core.Database.Repositories.Base
{
    public abstract class PostItemRepository
    {
        #region Private Fields

        private readonly PostItemConnect _connect;
        private readonly bool _debugMode;

        #endregion

        protected PostItemRepository(PostItemConnect connect, bool debugMode)
        {
            _connect = connect;
            _debugMode = debugMode;
        }

        #region Public Properties

        public PostItemConnect Connect => _connect;
        public bool DebugMode => _debugMode;

        #endregion
    }
}
