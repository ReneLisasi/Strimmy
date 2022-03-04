using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geditor
{
    public class PersonList
    {
        //data properties
        Address address = new Address();
        string[] data = new string[1000];
        string[] eventData = new string[100];

        public int countList = 0; //number of sections in this list
        //public Person[] PList = new Person[1000];
        List<string> plist = new List<string>();
        List<string> elist= new List<string>();

        //player properties
        HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
        String scrape = "";
        int count = 0;
        int max = 0;
        string dataTrim = "";
        string source = "";

        //event properties
        String escrape = "";
        string esource = "";
        string eventTrim = "";
        string month = "";
        string year = "";
        string date = "";
        string Filter = "";

        /*public void addPerson(Person p1)
        {
            PList[countList] = p1; //add new section to the list
            countList++; //increment count by 1 to reflect this new addition
        }*/
        //get initial raw data
        public void Lookup(string url)
        {
            string tName= getBetween(url, "tournament/", "/");
            address.setUrl("https://smash.gg/tournament/"+tName+"/attendees");
            address.setEventUrl("https://smash.gg/tournament/"+tName+"/events");
            HtmlAgilityPack.HtmlDocument doc = web.Load(address.getUrl());
            HtmlAgilityPack.HtmlDocument edoc = web.Load(address.getEventUrl());

            //get max and raw source
            foreach (var item in doc.DocumentNode.SelectNodes("//*[@id='app_feature_canvas']"))
            {
                try
                {
                    scrape = item.InnerText;
                    System.Diagnostics.Debug.WriteLine(scrape);

                    source = scrape;
                    string maxi = getBetween(source, "of ", " ");
                    max = int.Parse(maxi, System.Globalization.NumberStyles.AllowThousands);
                    System.Diagnostics.Debug.WriteLine(max);
                }catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            //get eventstrim
            foreach (var eitem in edoc.DocumentNode.SelectNodes("//*[@id='app_feature_canvas']"))
            {
                escrape = eitem.InnerText;
                System.Diagnostics.Debug.WriteLine("event scrape: " + escrape);

                esource = escrape;
                /*string emaxi = getBetween(esource, "of ", " ");
                emax = int.Parse(emaxi, System.Globalization.NumberStyles.AllowThousands);
                System.Diagnostics.Debug.WriteLine(emax);*/
            }
            //get month and year
            month = DateTime.Now.ToString("MMMM");
            year = DateTime.Now.Year.ToString();
            //get all events
            eventTrim = getBetween(esource, "Event ", " Events");
            System.Diagnostics.Debug.WriteLine("\n raw event data: " + eventTrim + "\n");

            //get date
            date = month + " " + getBetween(eventTrim, month + " ", " " + year) + " " + year;
            System.Diagnostics.Debug.WriteLine("\ndate: " + date);

            //player trims
            //get all names
            dataTrim = getBetween(source, "Events", "Displaying");
            System.Diagnostics.Debug.WriteLine("\n" + dataTrim + "\n");
        }

        public List<string> LookupFilters(String url1)
        {
            Lookup(url1);
            try
            {
            //get first event
            eventData[0] = getBetween(eventTrim, "Scheduleevents", date);
            System.Diagnostics.Debug.WriteLine("\nFirst event: " + eventData[0] + "\n");
            elist.Add(eventData[0]);
            count++;
            //get second player
            eventData[1] = getBetween(eventTrim, eventData[0] + date, date);
            System.Diagnostics.Debug.WriteLine("\n second event: " + eventData[1] + "\n" + (count + 1));
            elist.Add(eventData[1]);
            count++;
            
                while (count <= 20)
                {
                    eventData[count] = getBetween(eventTrim, eventData[count - 1] + date, date);
                    System.Diagnostics.Debug.WriteLine("\n Events: " + eventData[count] + "\n" + (count - 1));
                    elist.Add(eventData[count]);
                    count++;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            return elist;
        }


            public List<string> LookupPlayers(String url2, string filter)
            {
            Lookup(url2);
            //Filter = elist[filter];
            Filter = filter;
            count = 0;
            //get first player
            data[0] = getBetween(dataTrim, " ", Filter);
            System.Diagnostics.Debug.WriteLine("\nFirst Player:" + data[0] + "\n" + (count + 1));
            plist.Add(data[0]);
            count++;
            //get second player
            data[1] = getBetween(dataTrim, data[0] + Filter, " "+Filter);
            System.Diagnostics.Debug.WriteLine("\n PlayerLoop: " + data[1] + "\n" + (count));
            plist.Add(data[1]);
            //set count to 2 so that 1 count can be subtracted
            count++;
            try
            {
                while (count <= max)
                {
                    data[count] = getBetween(dataTrim, data[count - 1] + Filter, Filter);
                    System.Diagnostics.Debug.WriteLine("\n Player:" + data[count] + "\n" + (count - 1));
                    plist.Add(data[count]);
                    count++;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            return plist;
        }
        //get data
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }
        //print event data
        public string eventToStringg()
        {
            return $"{Filter}";
        }
        //display data
        public string playerToStringg(int count)
        {
            return $"{plist[count]}";
        }
    }

}
