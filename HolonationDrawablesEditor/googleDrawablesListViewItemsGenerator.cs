using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace HolonationDrawablesEditor
{
    class googleDrawablesListViewItemsGenerator
    {
        public void googleDrawablesListViewItemsGeneratorEvent(string googleDrawablesPath, ComboBox cbx, ListView lv, RadioButton rbnDark, RadioButton rbnLight, ImageList il, Dictionary<string,string> imagereferences, ToolStripStatusLabel label)
        {
            imagereferences.Clear();
            il.Images.Clear();
            il.ImageSize = new Size(48, 48); /* I think 48x48 looks the best for the hdpi images. The lower res images will look less nice but idc*/
            lv.Items.Clear(); /* if there were previous items in the listview, erase them */

            string rb = ""; /* declare a string for which color to use in a future file path */
            if (rbnDark.Checked == true) /* if it is dark..*/
            {
                rb = "holo_dark"; /* ..set the variable to holo_dark (as in the folder's name)*/
                lv.BackColor = Color.FromArgb(133, 133, 133);
                lv.ForeColor = Color.White;
            }
            else if (rbnLight.Checked == true) /* if it is light..*/
            {
                rb = "holo_light"; /* ..set the variable to holo_light (as in the folder's name)*/
                lv.BackColor = Color.White;
                lv.ForeColor = Color.Black;
            }

            lv.LargeImageList = il; /* bind the listview's image list to 'images'*/

            string[] directories = Directory.GetDirectories(googleDrawablesPath + "/" + rb); /* create an array of all folders in the folder the user has selected */
            foreach (string folder in directories)
            { /* for each folder in the directory.. */
                string prinsessenwafel; /* don't mind about the name of this string as I just typed a random nonesense word in dutch */
                prinsessenwafel = folder + "/" + cbx.SelectedItem.ToString(); /* we add the selected dpi to the path (fuck you Google.
                                                                                            * your file structure really sucks :p)*/
                string[] files = Directory.GetFiles(prinsessenwafel); /* we don't actually need to get every file in the folder this way since there is only one,*/
                foreach (string file in files)                       /* but there is not such thing as a wildcard in .NET apprently. I just want the png.*/
                {
                    string filename = Path.GetFileNameWithoutExtension(file); /* because it is possible for a Thumbs file to generate on older systems, we filter it*/
                    if (filename == "Thumbs") /* if the filename we found it "Thumbs", do nothing.*/
                    {
                    }
                    else /* in all other cases we can start adding the item to the listview*/
                    {
                        ListViewItem item = new ListViewItem(); /* create a new listview item */
                        il.Images.Add(file, Image.FromFile(file)); /* create a new entry in the imagelist, the name is the filename, the image the entire path*/
                        imagereferences.Add(file, filename);
                        item.Text = filename; /* we set the text of the item to the filename */
                        item.Tag = file;
                        item.ImageKey = file; /* we bind the item to the image we just added */
                        lv.Items.Add(item); /* finally, we add the item to the listview */
                    }
                }
            }
            label.Text = "Finished loading Google Drawables.";
        }
    }
}
