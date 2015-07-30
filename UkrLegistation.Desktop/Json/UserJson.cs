
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using UkrLegistation.Desktop.Model;

namespace UkrLegistation.Desktop.Json
{
    public static class UserJson
    {
        public static User UserData = new User();
        public static void GetData(out User user)
        {
            var url = "http://ukrlegislation-itevent.rhcloud.com/restserver/user/1/";

            var asyncClient = new WebClient();

            asyncClient.DownloadStringCompleted += asyncClient_DownloadStringComleted;
            asyncClient.DownloadStringAsync(new Uri(url));

            user = UserData;
        }

        private static void asyncClient_DownloadStringComleted(object sender, DownloadStringCompletedEventArgs e)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(User));

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(e.Result)))
            {
                UserData = (User) serializer.ReadObject(ms);
            }
        }
    }
}
