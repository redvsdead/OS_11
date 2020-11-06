using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace OS_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dir1.Text = "C:\\Users\\Asus\\Desktop\\example\\folder1";
            dir2.Text = "C:\\Users\\Asus\\Desktop\\example\\folder2";
        }       

        void countSize()
        {
            Searcher searchOne = new Searcher(dir1.Text);
            Searcher searchTwo = new Searcher(dir2.Text);
            Thread threadOne = new Thread(new ThreadStart(searchOne.countSize));
            Thread threadTwo = new Thread(new ThreadStart(searchTwo.countSize));
            threadOne.Start();
            threadTwo.Start();
            threadOne.Join();
            threadTwo.Join();
            mem1.Text = searchOne.Size.ToString();
            mem2.Text = searchTwo.Size.ToString();
            if (searchOne.Size < searchTwo.Size)
            {
                MessageBox.Show("The size of the 2nd directory is bigger than the 1st's");
            }
            else if (searchOne.Size > searchTwo.Size)
            {
                MessageBox.Show("The size of the 1st directory is bigger than the 2nd's");
            }
            else
            {
                MessageBox.Show("Directory sizes are equal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dir1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void search2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                dir2.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void process_Click(object sender, EventArgs e)
        {
            Thread helpThread = new Thread(new ThreadStart(countSize));
            helpThread.Start();
        }

        private void dir1_TextChanged(object sender, EventArgs e)
        {
            process.Enabled = dir1.Text != "" && dir1.Text != "";
        }

        private void dir2_TextChanged(object sender, EventArgs e)
        {
            process.Enabled = (dir1.Text != "") && (dir2.Text != "");
        }
    }
}
