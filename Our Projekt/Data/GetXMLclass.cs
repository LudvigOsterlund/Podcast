using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Net;

namespace HamtaData
{
    public class GetXML
    {
        List<PodcastsInfo> podcastAvsnittsLista = new List<PodcastsInfo>();
        List<PodFeed> podFeedsLista = new List<PodFeed>();
        List<Category> kategoriLista = new List<Category>();


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

                podcastAvsnittsLista.Add(new PodcastsInfo() { title = title.InnerText, description = beskrivning.InnerText.Replace("<br/>", ""), url = dlURL.Attributes["url"].Value, uppspelad = false });
            }

            return podcastAvsnittsLista;

        }


        public void skrivTillLokalXML()
        {
            var ser = new XmlSerializer(typeof(List<Category>));

            using (var stream = new StreamWriter("Podcasts.xml"))
            {
                ser.Serialize(stream, kategoriLista);

            }
        }

        public List<Category> LasFranLokalXML()
        {
            var deSer = new XmlSerializer(typeof(List<Category>));

            using (var stream = new StreamReader("Podcasts.xml"))
            {
                kategoriLista = (List<Category>)deSer.Deserialize(stream);
                return kategoriLista;
            }
        }

        public List<PodFeed> getPodFeed(string namn, string uppdateURL)
        {
            PodFeed podFeedObjekt = new PodFeed() { podNamn = namn, uppdateringsURL = uppdateURL };
            foreach (var pod in podcastAvsnittsLista)
            {
                podFeedObjekt.laggTillIListan(pod);
            }

            podFeedsLista.Add(podFeedObjekt);
            return podFeedsLista;
        }

        public List<Category> laggTillPrenumIKategori(string namn, string uppdateURL, int index)
        {
            PodFeed podFeedObjekt = new PodFeed() { podNamn = namn, uppdateringsURL = uppdateURL };
            foreach (var pod in podcastAvsnittsLista)
            {
                podFeedObjekt.laggTillIListan(pod);
            }

            kategoriLista[index].laggTillIKategoriListan(podFeedObjekt);
            return kategoriLista;
        }

        public List<Category> LaggTillKategori(string namn)
        {
            Category kategori = new Category() { kategoriNamn = namn };

            kategoriLista.Add(kategori);
            return kategoriLista;
        }
    }
}
