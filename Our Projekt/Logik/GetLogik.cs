using HamtaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logik
{
    public class GetLogik : Validering
    {
        GetXML dataObjekt = new GetXML();
        
        public List<PodcastsInfo> returneraXML(string url)
        {
            return dataObjekt.HamtaXML(url);
        }

        public void LaggTillXML()
        {
            dataObjekt.skrivTillLokalXML();
        }
        
        public List<PodFeed> skickaVidarePodFeed(string namn, string updateURL)
        {
            return dataObjekt.getPodFeed(namn, updateURL);
        }

        public List<Category> skickaVidareKategoriLista(string namn)
        {
            return dataObjekt.LaggTillKategori(namn);
        }

        public List<Category> skickaVidareLaggTillPrenumIKategorilista(string namn, string updateURL, int index)
        {
            return dataObjekt.laggTillPrenumIKategori(namn, updateURL, index);
        }

        public List<Category> SkickavidareUppdateringAvXML()
        {
            return dataObjekt.LasFranLokalXML();
        }
    }
}
