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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

     

        // beim schliessen (X drücken)
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            KundenScreen kundenScreen = new KundenScreen();
            kundenScreen.Show();

            this.Hide();
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            ArtikelScreen artikelScreen = new ArtikelScreen();
            artikelScreen.Show();

            this.Hide();
        }
    }
}
