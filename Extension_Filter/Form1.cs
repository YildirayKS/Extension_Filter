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

namespace Extension_Filter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectPath_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowser.SelectedPath;
                folderPathLabel.Text = folderPath;
            }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            if (folderPathLabel.Text != "")
            {
                string folderPath = folderPathLabel.Text;

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string sortedFolderPath = Path.Combine(desktopPath, "Sorted Files");
                string[] files = Directory.GetFiles(folderPath);
                string[] extensions = { ".pdf", ".exe", ".docx", ".pptx", ".xlsx", ".txt", ".jpg" };

                // Dosyaların ayıklanması ve taşınması
                foreach (string file in files)
                {
                    string fileExtension = Path.GetExtension(file);
                    string destinationFolder = Path.Combine(sortedFolderPath, fileExtension.TrimStart('.'));
                    string destinationFile = Path.Combine(destinationFolder, Path.GetFileName(file));

                    foreach (var extension in extensions)
                    {
                        if (extension == fileExtension)
                        {
                            string movePath = Path.Combine(folderPath, file);

                            if (!Directory.Exists(destinationFolder))
                            {
                                Directory.CreateDirectory(destinationFolder);
                            }

                            File.Move(movePath, destinationFile); //move the file

                        }

                    }

                }

                DialogResult dialogResult = MessageBox.Show("Files have been moved succesfully!\nDo you want to filter again?", "Information", MessageBoxButtons.YesNo);
                folderPathLabel.Text = "";
                if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
