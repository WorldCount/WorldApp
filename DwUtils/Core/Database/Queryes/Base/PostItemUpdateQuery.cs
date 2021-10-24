using System;
using System.Data;
using DwUtils.Core.Database.Connects;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.Base
{
    public abstract class PostItemUpdateQuery<T> : Query
    {
        protected PostItemUpdateQuery(FbConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        public abstract override string GetQuery();

        protected abstract T ParseResponse(int updateCount);

        public T Run()
        {
            string query = GetQuery();

            try
            {
                using (FbConnection fbConnection = new FbConnection(Connect.ToString()))
                {
                    if (fbConnection.State == ConnectionState.Closed)
                        fbConnection.Open();

                    using (FbTransaction fbTransaction = fbConnection.BeginTransaction(IsolationLevel.ReadCommitted))
                    {
                        using (FbCommand cmd = new FbCommand(query, fbConnection, fbTransaction))
                        {
                            int count = cmd.ExecuteNonQuery();

                            T data = ParseResponse(count);
                            fbTransaction.Commit();
                            return data;
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
