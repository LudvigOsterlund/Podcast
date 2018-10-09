using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamtaData
{
    public class PodFeed : GetXML
    {

        public List<PodcastsInfo> podcastsLista = new List<PodcastsInfo>();
        public string podNamn { get; set; }
        public string uppdateringsURL { get; set; }

        public override string ToString()
        {
            return podNamn;
        }

        public void laggTillIListan(PodcastsInfo pod)
        {
            podcastsLista.Add(pod);
        }

    }
}
