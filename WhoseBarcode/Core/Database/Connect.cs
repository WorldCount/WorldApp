using System.Data;
using System.IO;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using WcApi.Xml;
using WhoseIsBarcode.Core.Storage;

namespace WhoseIsBarcode.Core.Database
{
    public class Connect
    {
        public int Id { get; set; }
        public string Name { get; set; }
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

        public static Connect GetConnect()
        {
            if (!File.Exists(PathManager.ConnectFile))
                return new Connect();
            return Serializer.Load<Connect>(PathManager.ConnectFile);
        }

        public void Save()
        {
            Serializer.Save(PathManager.ConnectFile, this);
        }
    }
}
