
using System.Net;
using System.Runtime.InteropServices;

namespace UkrLegistation.Desktop.Json
{
    public static class UserJson
    {
        public static void GetData()
        {
            var url = "http://ukrlegislation-itevent.rhcloud.com/restserver/user/1/";

            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

        }
    }
}
