using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamtaData
{
    public class Category
    {
        public List<PodFeed> listOverPodFeed = new List<PodFeed>();

        public string kategoriNamn { get; set; }

        public override string ToString()
        {
            return kategoriNamn;
        }

        public void laggTillIKategoriListan(PodFeed podfeed)
        {
            listOverPodFeed.Add(podfeed);
        }
    }
}
