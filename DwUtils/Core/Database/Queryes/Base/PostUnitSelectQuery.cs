using System;
using System.Data;
using DwUtils.Core.Database.Connects;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.Base
{
    public abstract class PostUnitSelectQuery<T> : Query
    {
        protected PostUnitSelectQuery(FbConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        public abstract override string GetQuery();

        protected abstract T ParseResponse(FbDataReader reader);

        public T Run()
        {
            string query = GetQuery();

            try
            {
                using (FbConnection fbConnection = new FbConnection(Connect.ToString()))
                {
                    if (fbConnection.State == ConnectionState.Closed)
                        fbConnection.Open();

                    using (FbTransaction fbTransaction = fbConnection.BeginTransaction(IsolationLevel.ReadUncommitted))
                    {
                        using (FbCommand cmd = new FbCommand(query, fbConnection, fbTransaction))
                        {
                            using (FbDataReader reader = cmd.ExecuteReader())
                            {
                                T data = ParseResponse(reader);
                                fbTransaction.Commit();
                                return data;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (DebugMode)
                {
                    Logger.Error($"Ошибка при запросе: {query}");
                    Logger.Error(e);
                }

                return default;
            }
        }
    }
}
