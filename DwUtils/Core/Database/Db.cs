using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Repositories;

namespace DwUtils.Core.Database
{
    public class Db
    {
        #region Private Fields

        private PostUnitConnect _postUnitConnect;
        private PostItemConnect _postItemConnect;
        private bool _debugMode;

        #endregion

        #region Public Fields

        public SettingRepository Settings;
        public RpoRepository Rpos;
        public UserRepository Users;
        public PlaceRepository Places;
        public DocumentRepository Documents;
        public FileRepository Files;

        #endregion

        public Db(bool debugMode = false)
        {
            LoadConnects();
            SetDebug(debugMode);
            InitRepositories();
        }

        #region Private Methods

        private void LoadConnects()
        {
            _postItemConnect = PostItemConnect.GetConnect();
            _postUnitConnect = PostUnitConnect.GetConnect();
        }

        private void InitRepositories()
        {
            Settings = new SettingRepository(_postUnitConnect, _debugMode);
            Rpos = new RpoRepository(_postItemConnect, _debugMode);
            Users = new UserRepository(_postUnitConnect, _debugMode);
            Places = new PlaceRepository(_postItemConnect, _debugMode);
            Documents = new DocumentRepository(_postItemConnect, _debugMode);
            Files = new FileRepository(_postItemConnect, _debugMode);
        }

        #endregion

        #region Public Methods

        public void Refresh()
        {
            LoadConnects();
            InitRepositories();
        }

        public void SetDebug(bool debugMode)
        {
            _debugMode = debugMode;
            InitRepositories();
        }

        #endregion
    }
}
