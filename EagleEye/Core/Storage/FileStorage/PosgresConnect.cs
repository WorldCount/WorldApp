﻿using System.Data;
using System.IO;
using System.Threading.Tasks;
using Npgsql;
using WcApi.Cryptography;
using WcApi.Xml;

namespace EagleEye.Core.Storage.FileStorage
{
    public class PosgresConnect
    {
        public string Host { get; set; }
        public int Port { get; set; } = 5432;
        public string Login { get; set; } = "EagleEyeUser";
        public string Password { get; set; }
        public string Database { get; set; } = "EagleEyeDb";

        public PosgresConnect() { }

        public PosgresConnect(string login, string password, string host, int port = 5432, string database = "EagleEyeDb")
        {
            Host = host;
            Login = login;
            Password = password;
            Port = port;
            Database = database;
        }

        public override string ToString()
        {
            return $"Host={Host};Port={Port};Database={Database};Username={Login};Password={Password}";
        }

        public bool TestConnect()
        {
            NpgsqlConnection conn = null;

            bool status = WcApi.Net.Ping.GetPing(Host);
            if (!status)
                return false;

            try
            {
                conn = new NpgsqlConnection(ToString());
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn?.Close();
            }

        }

        public async Task<bool> TestConnectAsync()
        {
            return await Task.Run(TestConnect);
        }

        public void Save()
        {
            PosgresConnect connect = new PosgresConnect
            {
                Login = Login, 
                Password = CryptText.EncryptText(Password, AuthKey.Key), 
                Host = Host, 
                Port = Port, 
                Database = Database
            };

            Serializer.Save(PathManager.PostgresConnectPath, connect);
        }

        public static PosgresConnect Load()
        {
            if(!File.Exists(PathManager.PostgresConnectPath))
                return null;
            PosgresConnect connect = Serializer.Load<PosgresConnect>(PathManager.PostgresConnectPath);
            connect.Password = CryptText.DecryptText(connect.Password, AuthKey.Key);
            return connect;
        }
    }
}
