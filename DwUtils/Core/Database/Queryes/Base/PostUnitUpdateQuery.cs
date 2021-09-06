using System;
using System.Data;
using DwUtils.Core.Database.Connects;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.Base
{
    public abstract class PostUnitUpdateQuery<T> : Query
    {
        protected PostUnitUpdateQuery(FbConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        public abstract override string GetQuery();

        protected abstract T ParseResponse(int updateCount);

        public T Run()
        {
            string query = GetQuery();

            FbConnection fbConnection = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand updateCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                int count = updateCommand.ExecuteNonQuery();

                T data = ParseResponse(count);

                updateCommand.Dispose();
                fbTransaction.Commit();

                return data;
            }
            catch (Exception e)
            {
                if (DebugMode)
                {
                    Logger.Error($"Ошибка при запросе: {query}");
                    Logger.Error(e);
                }

                fbTransaction?.Rollback();
                return default;
            }
            finally
            {
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
