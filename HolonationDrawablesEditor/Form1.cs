using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HolonationDrawablesEditor
{
    public partial class frmMainScreen : Form
    {
        public string previousCbxText;

        public string appDrawablesPath;
        public string googleDrawablesPath;
        public ImageList holoimagelist = null;
        public ImageList appimagelist = null;
        public Dictionary<string, string> imagereferences;
        public bool replaceMode = false;
        public bool changesmade = false;
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void linkGoogleDrawablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           googleLink potato = new googleLink();
           string result = potato.googleLinkEvent(googleDrawablesPath);
           if (!(result == ""))
           {
               googleDrawablesPath = result;
               this.linkGoogleDrawablesToolStripMenuItem.Image = Properties.Resources.checkmark;
           }
        }

        private void linkAppDrawablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appLink potato = new appLink();
            string result = potato.appLinker(appDrawablesPath);
            if (!(result== ""))
            {
                appDrawablesPath = result;
                this.linkAppDrawablesToolStripMenuItem.Image = Properties.Resources.checkmark;
               
                appDpiDrawablesListGenerator listGenerator = new appDpiDrawablesListGenerator();
                listGenerator.appDpiDrawablesGeneratorEvent(appDrawablesPath, cbxAppDrawables);
            }
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            holoimagelist = new ImageList();
            appimagelist = new ImageList();
            imagereferences = new Dictionary<string, string>();
        }

        private void pnlGoogleDrawables_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (!(cbxGoogleDrawables.Text == "")){
                 bgwGenerateGoogle.RunWorkerAsync();
             }
        }
        private void rbnLight_CheckedChanged(object sender, EventArgs e)
        {
            if (!(cbxGoogleDrawables.Text == ""))
            {
                bgwGenerateGoogle.RunWorkerAsync();
            }
        }

        private void cbxAppDrawables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changesmade == true)
            {
                if (MessageBox.Show("You have unsaved changes! Switching to the new dpi will erase ALL your modifications! Are you sure you want to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes){
                    changesmade = false;
                    bgwGenerateApp.RunWorkerAsync();
                }
                else
                {
                    cbxAppDrawables.Text = previousCbxText;
                }
            }
            else
            {
                previousCbxText = cbxAppDrawables.Text;
                bgwGenerateApp.RunWorkerAsync();
            }
                
        }

        private void lvwAppDrawables_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvwAppDrawables.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    cmsListView.Show(Cursor.Position);
                }
            } 
        }

        private void openSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process imageStarter = new Process();
            imageStarter.StartInfo.FileName = lvwAppDrawables.FocusedItem.Tag.ToString();
            imageStarter.Start();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replaceMode = true;
            replaceModeToggle();
        }
        void replaceModeToggle()
        {
            if (replaceMode == true)
            {
                exitReplaceModeToolStripMenuItem.Visible = true;
                   lvwAppDrawables.Enabled = false;
            }
            else
            {
                exitReplaceModeToolStripMenuItem.Visible = false;
                lvwAppDrawables.Enabled = true;
            }

            if (changesmade == true)
            {
                writeChangesToFolderToolStripMenuItem.Visible = true;
            }
        }
        private void lvwGoogleDrawables_DoubleClick(object sender, EventArgs e)
        {
            if (replaceMode == true)
            {
                if (!(lvwGoogleDrawables.SelectedItems[0] == null))
                {
                    appimagelist.Images.Add(lvwGoogleDrawables.SelectedItems[0].Tag.ToString(), Image.FromFile(lvwGoogleDrawables.SelectedItems[0].Tag.ToString()));
                    lvwAppDrawables.SelectedItems[0].ImageKey = lvwGoogleDrawables.SelectedItems[0].Tag.ToString();
                    changesmade = true;
                    replaceMode = false;
                    replaceModeToggle();
                }
            }
        }

        private void exitReplaceModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replaceMode = false;
            replaceModeToggle();
        }

        private void revertToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwAppDrawables.SelectedItems[0].ImageKey = lvwAppDrawables.SelectedItems[0].Tag.ToString();
            replaceModeToggle();
        }

        private void bgwGenerateGoogle_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread T1 = new System.Threading.Thread(generateGoogle);
            T1.Start();
        }
        private void generateGoogle()
        {
            if (InvokeRequired)
            {

            }
            this.Invoke(new MethodInvoker(delegate
            {
                googleDrawablesListViewItemsGenerator listViewItemsGenerator = new googleDrawablesListViewItemsGenerator();
                listViewItemsGenerator.googleDrawablesListViewItemsGeneratorEvent(googleDrawablesPath, cbxGoogleDrawables, lvwGoogleDrawables, rbnDark, rbnLight, holoimagelist, imagereferences, lblStatus);
            }));
        }
        private void bgwGenerateGoogle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Loading Google drawables.. If the window freezes, please wait.";
        }

        private void bgwGenerateApp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Loading app drawables. If the window freezes, please wait.";
        }

        private void bgwGenerateApp_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread T2 = new System.Threading.Thread(generateApp);
            T2.Start();
        }
        private void generateApp()
         {
            if (InvokeRequired)
            {

            }
            this.Invoke(new MethodInvoker(delegate
            {
            appDrawablesListviewItemsGenerator listviewItemsGenerator = new appDrawablesListviewItemsGenerator();
            listviewItemsGenerator.appDrawablesListViewItemsGenerator(appDrawablesPath, cbxAppDrawables, lvwAppDrawables, appimagelist, imagereferences, lblStatus);
            }));
        }

        private void writeChangesToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Writing all changes will NOT be reversible and if you mess up it's all messed up. Please revise all your icons before continuing. Are you sure you want to write the changes?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                writeChanges changeWriter = new writeChanges();
                changeWriter.changeWrite(lvwAppDrawables);
            }
        }
        void changeColors()
        {
            if (rbnADark.Checked == true)
            {
                lvwAppDrawables.BackColor = Color.FromArgb(133, 133, 133);
                lvwAppDrawables.ForeColor = Color.White;
            }
            if (rbnALight.Checked == true)
            {
                lvwAppDrawables.BackColor = Color.White;
                lvwAppDrawables.ForeColor = Color.Black;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changeColors();
        }

        private void rbnADark_CheckedChanged(object sender, EventArgs e)
        {
            changeColors();
        }
    }
}
