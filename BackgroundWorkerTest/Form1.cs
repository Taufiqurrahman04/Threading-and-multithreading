using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorkerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //---Memulai Backgorund Worker
            backgroundWorker1.RunWorkerAsync(23);
            listBox1.Items.Add( "Background worker dimulai");
        }
        //--Memanggil event do work
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            listBox1.Items.Add ("Background Worker Do Work :");
            //--Mendapatkan Argumen Background worker
            int loop = (int)e.Argument;
            listBox1.Items.Add ( "Pangkat kan Argument 5 kali");
            //--Mereturn value
            e.Result = Math.Pow(loop,5);
        }
        //--Memanggil Even Run Worker Complete
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //--Get Output
            if (e.Cancelled) listBox1.Items.Add("Canceled......... "); 
            else if (e.Error != null) listBox1.Items.Add("Error : " + e.Error.Message );
            else listBox1.Items.Add("Backgound worker finish dengan result : " +e.Result.ToString());
        }
    }

}
