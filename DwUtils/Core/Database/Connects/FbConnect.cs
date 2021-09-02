﻿using System.Data;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Database.Connects
{
    public class FbConnect
    {
        public string Host { get; set; }
        public string Path { get; set; }
        public int Port { get; set; } = 3050;
        public string Login { get; set; }
        public string Password { get; set; }
        public int ServerType { get; set; } = 0;
        public string Charset { get; set; } = "WIN1251";

        public override string ToString()
        {
            FbConnectionStringBuilder fbConnection = new FbConnectionStringBuilder
            {
                Charset = Charset,
                UserID = Login,
                Password = Password,
                Database = Path,
                DataSource = Host,
                ServerType = (FbServerType)ServerType,
                Port = Port
            };

            return fbConnection.ToString();
        }

        private bool TestConnect()
        {
            FbConnection fbConnection = null;
            bool status = WcApi.Net.Ping.GetPing(Host);

            if (!status)
                return false;

            try
            {
                fbConnection = new FbConnection(ToString());
                if (fbConnection.State == ConnectionState.Closed)
                {
                    fbConnection.Open();
                    return true;
                }

                return false;
            }
            catch
            {

                return false;
            }
            finally
            {
                fbConnection?.Close();
            }
        }

        public async Task<bool> TestConnectAsync()
        {
            return await Task.Run(TestConnect);
        }
    }
}
