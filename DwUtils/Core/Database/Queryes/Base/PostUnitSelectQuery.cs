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

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand selectCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                reader = selectCommand.ExecuteReader();

                T data = ParseResponse(reader);

                reader.Close();
                selectCommand.Dispose();
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
                reader?.Close();
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
