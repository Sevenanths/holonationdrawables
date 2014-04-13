using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HolonationDrawablesEditor
{
    class googleLink
    {
        public string googleLinkEvent(string googleDrawablesPath)
        {
            FolderBrowserDialog googleDrawablesFolderDialog = new FolderBrowserDialog(); /* create a new FolderDialog*/
            googleDrawablesFolderDialog.Description = "Select the folder with the following contents:\n- holo_light\n- holo_dark"; /*Description*/

            if (googleDrawablesFolderDialog.ShowDialog() == DialogResult.OK) /* Test if the user has pressed OK*/
            {
                int resultyay = 0; /* to check if all the folders work, I declare an integer which will increment every time a test passes*/
                googleDrawablesPath = googleDrawablesFolderDialog.SelectedPath; /* store string for later use*/

                if (Directory.Exists(googleDrawablesPath + "/holo_dark")) /* if holo_dark folder exists, we increment the integer by one*/
                {
                    resultyay = resultyay + 1;
                }
                if (Directory.Exists(googleDrawablesPath + "/holo_light")) /* if holo_light folder exists, we increment the integer by one*/
                {
                    resultyay = resultyay + 1;
                }

                if (resultyay == 2)                                         /* if both tests passed (=2), it's all good*/
                {
                    return googleDrawablesPath;
                }
                else /* if not, sad times :( */
                {
                    MessageBox.Show("Invalid folder. Are you sure you selected the right path?"); /* inform the user*/
                    googleDrawablesPath = ""; /* we empty the string we declared earlier to prevent the program from working */
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }
}
