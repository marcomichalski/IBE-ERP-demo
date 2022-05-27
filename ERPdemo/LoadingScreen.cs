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
    public partial class LoadingScreen : Form
    {

        private int loadingbarValue;


        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }
        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingbarValue += 1;

            loadingProgress.Text = loadingbarValue.ToString() + " %";
            loadingProgressBar.Value = loadingbarValue;

            if (loadingbarValue >= loadingProgressBar.Maximum)
            {
                loadingbarTimer.Stop();

                // Finish Loading
            }
         }

       
    }
}
