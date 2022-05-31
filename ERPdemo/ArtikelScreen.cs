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

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=HC-SQL\SQL2017;Initial Catalog=IBE_ERP;Persist Security Info=True;User ID=sa;Password=1234#abc");

        string selectedArtikel;



        public ArtikelScreen()
        {
            InitializeComponent();

        }

        private void showMaterials()
        {
            databaseConnection.Open();

            string query = "SELECT T_BOM_Stückliste.BOM_Stückzahl AS Menge, Mat_Material_Bez AS Material FROM T_Artikel JOIN T_BOM_Stückliste ON T_Artikel.Art_idx = T_BOM_Stückliste.BOM_Art_idx JOIN T_Material ON T_BOM_Stückliste.BOM_Mat_idx = T_Material.Mat_idx WHERE T_Artikel.Art_Artikel_Bez = '" + selectedArtikel + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            ArtMatDGV.DataSource = dataSet.Tables[0];

            databaseConnection.Close();
        }

        private void ArtikelScreen_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "iBE_ERPDataSet1.T_Artikel". Sie können sie bei Bedarf verschieben oder entfernen.
            this.t_ArtikelTableAdapter.Fill(this.iBE_ERPDataSet1.T_Artikel);

        }

        private void Auswahlbtn_Click(object sender, EventArgs e)
        {
            selectedArtikel = comboBox1.Text;
            showMaterials();
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (sender is ComboBox cb )
        //    {
        //        var selectedArtikel = cb.SelectedItem;
        //    }
        //}


    }
}
