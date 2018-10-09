using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logik
{
    public abstract class Validering
    {
        static public bool kollaTextruta(string textruta)
        {

            if (textruta == "")
            {
                MessageBox.Show("Textfältet är tomt!");
                return false;
            }
             
                return true;
        }

        public static bool testaParseInt(string text)
        {

            int x;
            bool kolla = int.TryParse(text, out x);

            if (kolla)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Enter integer, ples");
                return false;
            }
        }

        public static bool testaURL(string text)
        {
            try
            {
                GetLogik kolla = new GetLogik();
                kolla.returneraXML(text);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
