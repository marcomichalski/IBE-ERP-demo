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
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            ArtikelScreen artikelScreen = new ArtikelScreen();
            artikelScreen.Show();

            this.Hide();
        }
    }
}
