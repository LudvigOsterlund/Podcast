using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamtaData
{
    public class PodcastsInfo
    {
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public bool uppspelad { get; set; }
        public override string ToString()
        {
            return title;
        }
    }
}
