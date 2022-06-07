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
    public partial class KundenScreen : Form
    {


        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=HC-SQL\SQL2017;Initial Catalog=IBE_ERP;Persist Security Info=True;User ID=sa;Password=1234#abc");

        private string lastSelectedClientID;

        public KundenScreen()
        {
            InitializeComponent();
            showClients();
        }


        private void showClients()
        {
            databaseConnection.Open();

            string query = "SELECT * FROM Kundenmenu";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);



            KundenDGV.DataSource = dataSet.Tables[0];

            databaseConnection.Close();
        }


        private void KundenDGV_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "iBE_ERPDataSet.T_Kunden". Sie können sie bei Bedarf verschieben oder entfernen.
            this.t_KundenTableAdapter.Fill(this.iBE_ERPDataSet.T_Kunden);

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

        private void KundenScreen_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "iBE_ERPDataSet3.T_Kunden". Sie können sie bei Bedarf verschieben oder entfernen.
            this.t_KundenTableAdapter2.Fill(this.iBE_ERPDataSet3.T_Kunden);
           

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

            if (tbClientName.Text == "" || tbClientAddress.Text == "" || tbClientPLZ.Text == "" || tbClientTel.Text == "" || tbClientMail.Text == "" )
            {

                MessageBox.Show("Bitte füllen Sie alle Felder aus !");
                return;
            }

            string clientName = tbClientName.Text;
            string clientAddress = tbClientAddress.Text;
            string clientPLZ = tbClientPLZ.Text;
            string clientTel = tbClientTel.Text;
            string clientEmail = tbClientMail.Text;

            string query = string.Format("INSERT INTO T_Kunden VALUES ('{0}','{1}','{2}','{3}','{4}')", clientName, clientAddress, clientPLZ, clientTel, clientEmail);

            ExecuteQuery(query);

            

            ClearAllFields();
            showClients();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            


            showClients();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {


            ClearAllFields();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

            if (tbKnr.Text == "")
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Zeile aus");
                return;
            }
            //else
            //{
            //    string query = string.Format("DELETE FROM T_Kunden WHERE ('{0}','{1}','{2}','{3}','{4}')", clientName, clientAddress, clientPLZ, clientTel, clientEmail);
            //    ExecuteQuery(query);

            //    showClients();
            //}
        }

        private void ClearAllFields ()
        {
            tbClientName.Text = "";
            tbClientAddress.Text = "";
            tbClientMail.Text = "";
            tbClientPLZ.Text = "";
            tbClientTel.Text = "";
            tbKnr.Text = " ";
        }

        private void ExecuteQuery (string query)
        {

            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();


        }

        private void KundenDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbKnr.Text = KundenDGV.SelectedRows[0].Cells[0].Value.ToString();
            tbClientName.Text = KundenDGV.SelectedRows[0].Cells[1].Value.ToString();
            tbClientAddress.Text = KundenDGV.SelectedRows[0].Cells[2].Value.ToString();
            tbClientPLZ.Text = KundenDGV.SelectedRows[0].Cells[3].Value.ToString();
            tbClientTel.Text = KundenDGV.SelectedRows[0].Cells[4].Value.ToString();
            tbClientMail.Text = KundenDGV.SelectedRows[0].Cells[5].Value.ToString();

            

           // lastSelectedClientID = KundenDGV.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
