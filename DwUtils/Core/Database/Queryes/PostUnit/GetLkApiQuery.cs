using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using DwUtils.Core.Database.Connects;

namespace DwUtils.Core.Database.Queryes.PostUnit
{
    public class GetLkApiQuery : Query
    {
        public GetLkApiQuery(PostUnitConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public new string GetQuery()
        {
            return "select vals from setupparam where paramid = 40060";
        }

        public string Run()
        {
            string query = GetQuery();
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{query}");

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

                reader.Read();
                string response = reader.GetString(0);

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                if (DebugMode)
                    Logger.Debug($"Запрос вернул: '{response}'");

                return response;
            }
            catch (Exception e)
            {
                if (DebugMode)
                {
                    Logger.Error($"Ошибка при запросе: {query}");
                    Logger.Error(e);
                }

                fbTransaction?.Rollback();
                return null;
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
