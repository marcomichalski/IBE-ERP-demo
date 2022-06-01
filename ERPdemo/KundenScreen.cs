using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPdemo
{
    public partial class KundenScreen : Form
    {
        public KundenScreen()
        {
            InitializeComponent();
        }


        // beim schliessen (X drücken)
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
