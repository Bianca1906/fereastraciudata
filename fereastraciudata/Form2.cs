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
    public partial class Form2 : Form
    {
        public Form2()
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
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
