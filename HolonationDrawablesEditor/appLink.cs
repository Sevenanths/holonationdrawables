using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolonationDrawablesEditor
{
    class appLink
    {
        public string appLinker(string appDrawablesPath)
        {
            FolderBrowserDialog appDrawablesFolderDialog = new FolderBrowserDialog(); /* create a new FolderDialog*/
            appDrawablesFolderDialog.Description = "Select the folder with the following contents:\ndrawable, drawable-hdpi, drawable-xhdpi.. etc"; /*Description*/

            if (appDrawablesFolderDialog.ShowDialog() == DialogResult.OK) /* Test if the user has pressed OK*/
            {
                appDrawablesPath = appDrawablesFolderDialog.SelectedPath; /* set the variable for easier use later */
                return appDrawablesPath;
            }
            else
            {
                return "";
            }
        }
    }
}
