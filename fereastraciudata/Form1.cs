using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fereastraciudata
{
    public partial class Form1 : Form
    {
        Form2 f;
        public Form1()
        {
            InitializeComponent();
           

        }
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                // Convert HTCLIENT to HTCAPTION
                if (m.Result.ToInt32() == HTCLIENT)
                {
                    m.Result = (IntPtr)HTCAPTION;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void Label2_Click(object sender, EventArgs e)
        {
             f = new Form2();
            f.Show();
            f.Left = 1200;
            f.Top =200;
            timer1.Enabled = true;
        
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form1.ActiveForm.Close();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            f.Left+=10;
        }
    }
}
