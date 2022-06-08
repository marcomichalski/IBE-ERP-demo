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

        private int lastSelectedClientKey;
        
        public KundenScreen()
        {
          

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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
            KundenDGV.Columns[0].Visible = false;

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
            if (lastSelectedClientKey == 0)
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Zeile aus");
                return;
            }
            else
            {

                string clientName = tbClientName.Text;
                string clientAddress = tbClientAddress.Text;
                string clientPLZ = tbClientPLZ.Text;
                string clientTel = tbClientTel.Text;
                string clientEmail = tbClientMail.Text;

                string query = string.Format("UPDATE T_Kunden SET Ku_Name='{0}', Ku_Adresse='{1}', PLZ='{2}', Ku_Telefon='{3}', [Ku_E-Mail]='{4}' WHERE Ku_idx = " + lastSelectedClientKey
                    , clientName, clientAddress, clientPLZ, clientTel, clientEmail);
                ExecuteQuery(query);
                ClearAllFields();

                NotifyBox frm = new NotifyBox(" Ihre Kundendaten wurden erfolgreich geändert", "");
                frm.Show();

                //MessageBox.Show("Ihre Kundendaten wurden erfolgreich geändert");
                showClients();

            }

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {


            ClearAllFields();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

            if (lastSelectedClientKey == 0)
            {


                NotifyBox frm = new NotifyBox(" Bitte wählen Sie zuerst eine Zeile aus", "");
                frm.Show();

                //MessageBox.Show("Bitte wählen Sie zuerst eine Zeile aus");
                return;
            }
            else
            {
                string query = string.Format("DELETE FROM T_Kunden WHERE Ku_idx = " + lastSelectedClientKey);
                string deleteConfirmName = tbClientName.Text;
                ExecuteQuery(query);

                ClearAllFields();
                showClients();
                NotifyBox frm = new NotifyBox("Der Kunde '" + deleteConfirmName + "' wurde erfolgreich gelöscht", "");
                frm.Show();

                //MessageBox.Show("Der Kunde '" + deleteConfirmName + "' wurde erfolgreich gelöscht");
            }
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
            
            tbKnr.Text = KundenDGV.SelectedRows[0].Cells[1].Value.ToString();
            tbClientName.Text = KundenDGV.SelectedRows[0].Cells[2].Value.ToString();
            tbClientAddress.Text = KundenDGV.SelectedRows[0].Cells[3].Value.ToString();
            tbClientPLZ.Text = KundenDGV.SelectedRows[0].Cells[4].Value.ToString();
            tbClientTel.Text = KundenDGV.SelectedRows[0].Cells[5].Value.ToString();
            tbClientMail.Text = KundenDGV.SelectedRows[0].Cells[6].Value.ToString();


            lastSelectedClientKey = (int)KundenDGV.SelectedRows[0].Cells[0].Value;
           
        }

       
    }
}
