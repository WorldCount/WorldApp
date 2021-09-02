using System;
using NLog;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Interfaces;


namespace DwUtils.Core.Database.Queryes
{
    public abstract class Query : IFbQueryable
    {
        #region Private Fields

        private readonly FbConnect _connect;
        private readonly bool _debugMode;

        // ReSharper disable once MemberCanBeProtected.Global
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        // ReSharper disable once ConvertToAutoProperty
        protected FbConnect Connect => _connect;
        // ReSharper disable once ConvertToAutoProperty
        protected bool DebugMode => _debugMode;


        protected Query(FbConnect connect, bool debugMode = false)
        {
            _connect = connect;
            _debugMode = debugMode;
        }

        public virtual string GetQuery()
        {
            throw new NotImplementedException();
        }

        public FbConnect GetConnect()
        {
            return _connect;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
