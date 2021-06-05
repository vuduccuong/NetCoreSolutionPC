using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoutLocs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var folderName = folderBrowserDialog1.SelectedPath;
            var dictInfo = new DirectoryInfo(folderName);
            FileInfo[] files = dictInfo.GetFiles("*.cs", SearchOption.AllDirectories);
            var i = 0;
            dataGridView1.Columns.Add("FileName", "OK");
            foreach (var file in files)
            {
                i++;
                dataGridView1.Rows.Add(file.FullName);
            }
        }
    }
}
