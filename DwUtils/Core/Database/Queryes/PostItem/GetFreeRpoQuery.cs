using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using DwUtils.Core.Database.Connects;
using DwUtils.Core.Database.Models;

namespace DwUtils.Core.Database.Queryes.PostItem
{
    public class GetFreeRpoQuery : Query
    {
        public GetFreeRpoQuery(PostItemConnect connect, bool debugMode = false) : base(connect, debugMode)
        {
        }


        // ReSharper disable once MemberCanBePrivate.Global
        public new string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select d.docid, d.doctypeid, d.pstypecategoryid, d.extcode, d.postofficeret, d.docdate, v.placeid, v.createuserid from doc d");
            sb.Append(" left join docval v on d.docid = v.docid");
            sb.Append(" where lastdocvalid = 1 and clienttypeid = 2");

            return sb.ToString();
        }

        public List<FreeRpo> Run()
        {
            string query = GetQuery();
            if (DebugMode)
                Logger.Debug($"Запрос в БД:\n{query}");

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            List<FreeRpo> rpos = new List<FreeRpo>();

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
                    FreeRpo rpo = new FreeRpo
                    {
                        Id = reader.GetInt32(0),
                        Type = reader.GetInt32(1),
                        TypeCategory = reader.GetInt32(2),
                        Barcode = reader.GetString(3),
                        IndexTo = reader.GetString(4),
                        LoadDate = reader.GetDateTime(5),
                        PlaceId = reader.GetInt32(6),
                        UserId = reader.GetInt32(7)
                    };

                    rpos.Add(rpo);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();

                if (DebugMode)
                    Logger.Debug($"Запрос вернул записей: {rpos.Count}");

                return rpos;
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
