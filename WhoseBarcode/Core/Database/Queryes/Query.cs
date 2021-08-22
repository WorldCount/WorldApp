using System;
using NLog;
using WhoseBarcode.Core.Database.Interfaces;

namespace WhoseBarcode.Core.Database.Queryes
{
    public abstract class Query : IQueryable
    {
        private readonly Connect _connect;
        private readonly bool _debugMode;

        // ReSharper disable once MemberCanBeProtected.Global
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        // ReSharper disable once ConvertToAutoProperty
        protected Connect Connect => _connect;
        // ReSharper disable once ConvertToAutoProperty
        protected bool DebugMode => _debugMode;

        protected Query(Connect connect, bool debugMode = false)
        {
            _connect = connect;
            _debugMode = debugMode;
        }

        public virtual string GetQuery()
        {
            throw new NotImplementedException();
        }

        public Connect GetConnect()
        {
            return _connect;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
