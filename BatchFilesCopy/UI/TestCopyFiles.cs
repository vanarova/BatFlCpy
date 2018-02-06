using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchCopyCore
{
    public partial class TestCopyFiles : Form
    {
        public string SelectedFile { get; set; }
        public List<string> OriginalFileList { get; set; }

        public TestCopyFiles()
        {
            InitializeComponent();
        }

        private void PopulateGrid()
        {
            //lstCSVList.Items.Clear();
            //lstCSVList.Items.AddRange(Library.Helper.GetOrAdjustFilesList(txtPrefix.Text,txtPostfix.Text).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string msg;
            //List<string> filesList = new List<string>();
            //txtCSVFile.Text = SelectedFile;
            //label4.Text = Library.Helper.xCopyFilesInList(SelectedFile, txtDestination.Text, out msg).ToString();
            //label5.Text = msg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string msg = string.Empty;
           //if( (openFileDialog1.ShowDialog())== DialogResult.OK)
           // {
           //     SelectedFile = openFileDialog1.FileName;
           //     txtCSVFile.Text = SelectedFile;
           //     Library.Helper.SimpleTextFileRead(SelectedFile, out msg);
           //     OriginalFileList= Library.Helper.GetOrAdjustFilesList("", "");
           //     PopulateGrid();
           // }
           //if(!string.IsNullOrEmpty(msg))
           // {
           //     MessageBox.Show(msg);
           // }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //PopulateGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //if ((folderBrowserDialog1.ShowDialog()) == DialogResult.OK)
            //    txtDestination.Text = folderBrowserDialog1.SelectedPath;
        }

        private void txtPostfix_TextChanged(object sender, EventArgs e)
        {
            //PopulateGrid();
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            //List<string> destList = new List<string>();
            //foreach (var item in Library.Helper.GetOriginalFilesList())
            //{
            //    destList.Add(txtDestination.Text + item);
            //}
            //lstDestFileslist.Items.Clear();
            //lstDestFileslist.Items.AddRange(destList.ToArray());
            //lblNoOfFiles.Text = destList.Count.ToString() + " files";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
