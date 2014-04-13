using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HolonationDrawablesEditor
{
    class writeChanges
    {
        public void changeWrite(ListView lvw)
        {
            foreach (ListViewItem item in lvw.Items){
                if (!(item.ImageKey.ToString() == item.Tag.ToString())){
                    File.Copy(item.ImageKey.ToString(), item.Tag.ToString(),true);
                }
            }
            MessageBox.Show("Done!");
        
        }
    }
}
