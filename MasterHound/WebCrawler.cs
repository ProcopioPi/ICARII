using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace MasterHound
{
    public class WebCrawler
    {
        public static WebClient client;
        private InfoManager infoManager;

        public WebCrawler(InfoManager infoManager)
        {
            this.infoManager = infoManager;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            client = new WebClient();
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(infoManager.client_RetrievePubMedIDs);
        }

        public void WebQuery(string query)
        {
            client.DownloadStringAsync(new Uri(query));
        }

    }
}
