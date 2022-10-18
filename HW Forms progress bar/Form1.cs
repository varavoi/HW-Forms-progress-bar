using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Forms_progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += progressBar1.Step;
                 Thread.Sleep(100);
            }
            
        }
    }
}
