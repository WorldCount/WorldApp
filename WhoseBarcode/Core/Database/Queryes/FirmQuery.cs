using System;
using System.Collections.Generic;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using WhoseIsBarcode.Core.Database.Models;

namespace WhoseIsBarcode.Core.Database.Queryes
{
    public class FirmQuery : Query
    {
        public FirmQuery(Connect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public new string GetQuery()
        {
            return "select id_inn, Upper(firm_name), inn, depcode, kpp from firms order by Upper(firm_name)";
        }

        public List<DbFirm> Run()
        {
            string query = GetQuery();
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{query}");

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            List<DbFirm> firms = new List<DbFirm>();

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand selectCommand = new FbCommand(query, fbConnection) { Transaction = fbTransaction };
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    DbFirm firm = new DbFirm
                    {
                        InnId = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Inn = reader.GetString(2),
                        Depcode = reader.GetString(3),
                        Kpp = reader.GetString(4)
                    };

                    firms.Add(firm);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                if (DebugMode)
                    Logger.Debug($"Запрос вернул записей: {firms.Count}");

                return firms;
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
