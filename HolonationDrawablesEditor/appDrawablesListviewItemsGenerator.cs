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
    class appDrawablesListviewItemsGenerator
    {
        public void appDrawablesListViewItemsGenerator(string appDrawablesPath, ComboBox cbx, ListView lvw, ImageList il, Dictionary<string, string> imagereferences, ToolStripStatusLabel label)
        {
            il.Images.Clear();
            il.ImageSize = new Size(48, 48);
            lvw.Clear();

            string[] files = Directory.GetFiles(appDrawablesPath + "/" + cbx.SelectedItem.ToString()); /* create an array of all the files in folder*/

            lvw.LargeImageList = il; /* bind the listview's image list to 'images'*/

            foreach (string file in files) /* for each file in the folder*/
            {
                if (file.Contains(".png"))
                {
                    string filename = Path.GetFileNameWithoutExtension(file); /* we fetch only the name of each file*/
                        ListViewItem item = new ListViewItem(); /* create a new listviewitem*/
                        il.Images.Add(file, Image.FromFile(file)); /* we add the name of the image to the image list, along with the image itself*/
                        //imagereferences.Add(file, filename); /* we add both the name and the full path to the dictionary for later use*/
                        item.ImageKey = file; /* we bind the item to the image we just added */
                        item.Tag = file;
                        item.Text = filename; /* we set the item's text to the file's filename */
                        lvw.Items.Add(item); /* finally, we add the item to the listbox */
                }
            }
            label.Text = "Finished loading app drawables.";
        }
    }
}
