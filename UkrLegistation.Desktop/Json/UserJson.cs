
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using UkrLegistation.Desktop.Model;

namespace UkrLegistation.Desktop.Json
{
    public static class UserJson
    {
        public static List<User> UserData = new List<User>();
        private static bool _flag;
        public static void GetData(out List<User> users, out bool flagNew)
        {
            var url = "http://ukrlegislation-itevent.rhcloud.com/restserver/user/";

            var asyncClient = new WebClient();
            asyncClient.DownloadStringCompleted += asyncClient_DownloadStringComleted;
            asyncClient.DownloadStringAsync(new Uri(url));
            flagNew = _flag;
            users = UserData;


        }

        private static void asyncClient_DownloadStringComleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof (List<User>));

                using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(e.Result)))
                {
                    UserData = (List<User>) serializer.ReadObject(ms);
                }
            }
            catch 
            {
                Window1 wind = new Window1();
                wind.Show();
                _flag = true;
            }
        }
    }
}
