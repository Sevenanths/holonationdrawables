using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HolonationDrawablesEditor
{
    class appDpiDrawablesListGenerator
    {
        public void appDpiDrawablesGeneratorEvent(string appDrawablesPath, ComboBox cbx)
        {
           string[] files = Directory.GetDirectories(appDrawablesPath); /* create an array of all directories in the folder */
            foreach (string file in files) /* for each folder in folder...*/
            {
                string foldername = Path.GetFileNameWithoutExtension(file); /* get only the folder*/
                cbx.Items.Add(foldername);
            }
        }
    }
}
