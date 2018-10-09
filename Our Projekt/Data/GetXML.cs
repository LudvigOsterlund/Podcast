using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HamtaData
{
    public class GetXML
    {
        List<PodcastsInfo> pods = new List<PodcastsInfo>();
        List<PodFeed> podFeedsLista = new List<PodFeed>();



        public List<PodcastsInfo> HamtaXML(string url)
        {
            var xml = "";

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            foreach (System.Xml.XmlNode item
            in dom.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
                var beskrivning = item.SelectSingleNode("description");
                var dlURL = item.SelectSingleNode("enclosure");

                pods.Add(new PodcastsInfo() { title = title.InnerText, description = beskrivning.InnerText.Replace("<br/>", ""), url = dlURL.Attributes["url"].Value});
                
                //lista.Add(title.InnerText + "$" + beskrivning.InnerText + "$" + dlURL.Attributes["url"].Value);
            }

            return pods;

        }


        public void LaggTillLokalXML()
        {
            var ser = new XmlSerializer(typeof(List<PodFeed>));

            using (var stream = new StreamWriter("Podcasts.xml"))
            {
                ser.Serialize(stream, podFeedsLista);
                
            }

            using (var stream = new StreamReader("Podcasts.xml"))
            {
                var dedust = (List<PodFeed>)ser.Deserialize(stream);
            }

        }

        public List<PodFeed> LasaFranLokalXML ()
        {
            var xml = XDocument.Load("Podcasts.xml");
            var feed = xml.Descendants("PodFeed");

            var titleObjects = feed.Select(element => new PodFeed
            {
                podNamn = element.Descendants("podNamn").Single().Value,
                podcastsLista = (from o in element.Element("podcastsLista").Elements("PodcastsInfo") select new PodcastsInfo
                {
                    title = (string)o.Element("title"),
                    description = (string)o.Element("description"),
                    url = (string)o.Element("url")

                }).ToList()
                
            });

            foreach (var item in titleObjects)
            {
                podFeedsLista.Add(item);
            }

            return podFeedsLista;
        }

        public List<PodFeed> getPodFeed(string namn)
        {
            PodFeed podObjekt = new PodFeed() { podNamn = namn };
            foreach (var pod in pods)
            {
                podObjekt.laggTillIListan(pod);
            }

            podFeedsLista.Add(podObjekt);
            return podFeedsLista;
        }
    }
}
