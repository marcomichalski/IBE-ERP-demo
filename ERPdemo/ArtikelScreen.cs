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
    public partial class ArtikelScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=HC-SQL\SQL2017;Initial Catalog=IB34DB_AppCore_20220609;Persist Security Info=True;User ID=sa;Password=1234#abc");

        private string selectedArtikel;



        public ArtikelScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        //private void showMaterials()
        //{
        //    databaseConnection.Open();

        //    string query = "SELECT T_BOM_Stückliste.BOM_Stückzahl AS Menge, Mat_Material_Bez AS Material FROM T_Artikel JOIN T_BOM_Stückliste ON T_Artikel.Art_idx = T_BOM_Stückliste.BOM_Art_idx JOIN T_Material ON T_BOM_Stückliste.BOM_Mat_idx = T_Material.Mat_idx WHERE T_Artikel.Art_Artikel_Bez = '" + selectedArtikel + "'";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

        //    DataSet dataSet = new DataSet();
        //    sqlDataAdapter.Fill(dataSet);

        //    ArtMatDGV.DataSource = dataSet.Tables[0];

        //    databaseConnection.Close();
        //}

        private void ArtikelScreen_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "iB34DB_AppCore_20220609DataSet.T_WorkOrder". Sie können sie bei Bedarf verschieben oder entfernen.
            this.t_WorkOrderTableAdapter.Fill(this.iB34DB_AppCore_20220609DataSet.T_WorkOrder);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "iBE_ERPDataSet1.T_Artikel". Sie können sie bei Bedarf verschieben oder entfernen.
            this.t_ArtikelTableAdapter.Fill(this.iBE_ERPDataSet1.T_Artikel);

        }

        private void Auswahlbtn_Click(object sender, EventArgs e)
        {
            selectedArtikel = comboBox1.Text;
           // showMaterials();

            if (selectedArtikel.Contains ("Installationsverteiler"))
            {
                picBox_hv.Visible = false;
                label_hv_title.Visible = false;
                label_hv_text.Visible = false;
                
                picBox_sa.Visible = false;
                label_sa_title.Visible = false;
                label_sa_text.Visible = false;

                picBox_iv.Visible = true;
                label_iv_title.Visible = true;
                label_iv_text.Visible = true;
            
            }

            else if (selectedArtikel.Contains ("Hochstromverteiler") )
            {

                picBox_sa.Visible = false;
                label_sa_title.Visible = false;
                label_sa_text.Visible = false;

                picBox_iv.Visible = false;
                label_iv_title.Visible = false;
                label_iv_text.Visible = false;


                picBox_hv.Visible = true;
                label_hv_title.Visible = true;
                label_hv_text.Visible = true;

            }

            else if (selectedArtikel.Contains("Steuerungsanlage"))
            {

                picBox_iv.Visible = false;
                label_iv_title.Visible = false;
                label_iv_text.Visible = false;


                picBox_hv.Visible = false;
                label_hv_title.Visible = false;
                label_hv_text.Visible = false;

                picBox_sa.Visible = true;
                label_sa_title.Visible = true;
                label_sa_text.Visible = true;

            }

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (sender is ComboBox cb )
        //    {
        //        var selectedArtikel = cb.SelectedItem;
        //    }
        //}

        

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
