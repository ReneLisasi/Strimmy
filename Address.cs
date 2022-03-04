using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geditor
{
    class Address
    {
        string Url = "";
        string eventUrl = "";
        string FilePath = "";

        public Address()
        {
            Url = eventUrl = FilePath = null;
        }

        public Address(string url, string eUrl, string filePath)
        {
            FilePath = filePath;
            Url = url;
            eventUrl = eUrl;
        }


        public string ToStringg()
        {
            //obselete
            return $"{Url}, {eventUrl}, {FilePath}";
        }
        //getters and setter
        public string getUrl() { return Url; }
        public void setUrl(string url) { Url=url; }
        public string getEventUrl() { return eventUrl; }
        public void setEventUrl(string eUrl) { eventUrl = eUrl; }
        public string getFilePath() { return FilePath; }
        public void setFilePath(string filePath) { FilePath=filePath; }

    }
}
