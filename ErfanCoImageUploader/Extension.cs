using System;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Net.Sockets;
namespace ErfanCoImageUploader
{
    public static class Extension
    {
        public static string IP = @"192.168.1.6";//@"192.168.1.6";//@"192.168.1.135";//@"94.183.149.112";

        public static string GetEfConnectionString(string modelNameSpace)
        {
            var entityConnectionStringBuilder1 = new EntityConnectionStringBuilder
            {
                Provider = @"System.Data.SqlClient",
                ProviderConnectionString =
                    string.Concat(string.Format(@"Data Source={0},1485;UID=OldApiUser;Password=AqqAwF3VxwDB8Uv6jB3Qma6Hf8R6Xxqk7c4bc346SuAWBZZdX7PnNmUrxxctcbRbvC9FSEfYLKh;Database=PTC_MIS_DB", IP), @";MultipleActiveResultSets=True"),
                Metadata = string.Concat(new[]
                {
                    @"res://*/", modelNameSpace, @".csdl|res://*/", modelNameSpace, @".ssdl|res://*/",
                    modelNameSpace, @".msl"
                })
            };
            return entityConnectionStringBuilder1.ToString();
        }

        public static bool IsSqlServerAvailable()
        {
            string ip = IP;
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.SendTimeout = tcpClient.ReceiveTimeout = 1000;
                    tcpClient.Connect(ip, 1485);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
//test
