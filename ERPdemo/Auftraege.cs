using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPdemo
{
    public partial class Auftraege : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=HC-SQL\SQL2017;Initial Catalog=IBE_ERP;Persist Security Info=True;User ID=sa;Password=1234#abc");

        public Auftraege()
        {
            InitializeComponent();
        }

        // beim schliessen (X drücken)
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuScreen mainMenuScreen = new MainMenuScreen();
            mainMenuScreen.Show();

            this.Hide();
        }
    }
}
