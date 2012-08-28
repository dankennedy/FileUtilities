using System;
using System.IO;
using System.Windows.Forms;

namespace FileUtilities
{
    public partial class MainFileForm : Form
    {
        private int childFormNumber;

        public MainFileForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            var childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
                Filter = "Text Files (*.txt)|*.txt|" +
                        "Text Files (*.csv)|*.csv|" +
                        "All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;

            var childForm = new FileForm(openFileDialog.FileName)
                                {
                                    MdiParent = this
                                };
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}