using System;
using System.Data;
using DwUtils.Core.Database.Connects;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Queryes.PostUnit
{
    public class SetLkApiQuery : Query
    {
        private readonly string _value;

        public SetLkApiQuery(PostUnitConnect connect, string value, bool debugMode = false) : base(connect, debugMode)
        {
            _value = value;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public new string GetQuery()
        {
            return $"update setupparam set vals = '{_value}' where paramid = 40060";
        }

        public bool Run()
        {
            string query = GetQuery();
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{query}");

            FbConnection fbConnection = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                var updateCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                int count = updateCommand.ExecuteNonQuery();

                updateCommand.Dispose();
                fbTransaction.Commit();

                if (DebugMode)
                    Logger.Debug($"Запрос обновил строк: {count}");

                return true;
            }
            catch (Exception e)
            {
                if (DebugMode)
                {
                    Logger.Error($"Ошибка при запросе: {query}");
                    Logger.Error(e);
                }

                fbTransaction?.Rollback();
                return false;
            }
            finally
            {
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
