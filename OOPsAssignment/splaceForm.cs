using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPsAssignment
{
    public partial class splaceForm : Form
    {
        int count = 0;
        public splaceForm()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                count += 1;
                backgroundWorker1.ReportProgress(i);
                System.Threading.Thread.Sleep(10);
                
            }
            
            Form1 load = new Form1();
            load.loadcomponent();
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbl_percent.Text = count.ToString();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
            
        }
    }
}
