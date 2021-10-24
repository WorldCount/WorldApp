using System.Data;
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
        public bool Pooling { get; set; } = true;
        public int MinPoolSize { get; set; } = 0;
        public int MaxPoolSize { get; set; } = 8;
        public int ConnectionLifeTime { get; set; } = 15;
        public int ConnectionTimeout { get; set; } = 5;

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
                Port = Port,
                Pooling = Pooling,
                MinPoolSize = MinPoolSize,
                MaxPoolSize = MaxPoolSize,
                ConnectionLifeTime = ConnectionLifeTime,
                ConnectionTimeout = ConnectionTimeout
            };

            return fbConnection.ToString();
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public bool TestConnect()
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
