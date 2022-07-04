
using System;

namespace ERPdemo
{
    partial class ArtikelScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtikelScreen));
            this.labelArtikel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tWorkOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iB34DB_AppCore_20220609DataSet = new ERPdemo.IB34DB_AppCore_20220609DataSet();
            this.tArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBE_ERPDataSet1 = new ERPdemo.IBE_ERPDataSet1();
            this.dboTArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBE_ERPDataSet = new ERPdemo.IBE_ERPDataSet();
            this.dbo_T_ArtikelTableAdapter = new ERPdemo.IBE_ERPDataSetTableAdapters.dbo_T_ArtikelTableAdapter();
            this.dboTArtikelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iBEERPDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBEERPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ArtikelTableAdapter = new ERPdemo.IBE_ERPDataSet1TableAdapters.T_ArtikelTableAdapter();
            this.Auswahlbtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.t_WorkOrderTableAdapter = new ERPdemo.IB34DB_AppCore_20220609DataSetTableAdapters.T_WorkOrderTableAdapter();
            this.picBox_iv = new System.Windows.Forms.PictureBox();
            this.picBox_hv = new System.Windows.Forms.PictureBox();
            this.picBox_sa = new System.Windows.Forms.PictureBox();
            this.label_iv_text = new System.Windows.Forms.Label();
            this.label_iv_title = new System.Windows.Forms.Label();
            this.label_sa_title = new System.Windows.Forms.Label();
            this.label_sa_text = new System.Windows.Forms.Label();
            this.label_hv_title = new System.Windows.Forms.Label();
            this.label_hv_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iB34DB_AppCore_20220609DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tArtikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_iv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArtikel
            // 
            this.labelArtikel.AutoSize = true;
            this.labelArtikel.BackColor = System.Drawing.Color.Transparent;
            this.labelArtikel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtikel.Location = new System.Drawing.Point(231, 57);
            this.labelArtikel.Name = "labelArtikel";
            this.labelArtikel.Size = new System.Drawing.Size(61, 24);
            this.labelArtikel.TabIndex = 0;
            this.labelArtikel.Text = "Artikel";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.DataSource = this.tWorkOrderBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(452, 32);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tWorkOrderBindingSource
            // 
            this.tWorkOrderBindingSource.DataMember = "T_WorkOrder";
            this.tWorkOrderBindingSource.DataSource = this.iB34DB_AppCore_20220609DataSet;
            // 
            // iB34DB_AppCore_20220609DataSet
            // 
            this.iB34DB_AppCore_20220609DataSet.DataSetName = "IB34DB_AppCore_20220609DataSet";
            this.iB34DB_AppCore_20220609DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tArtikelBindingSource
            // 
            this.tArtikelBindingSource.DataMember = "T_Artikel";
            this.tArtikelBindingSource.DataSource = this.iBE_ERPDataSet1;
            // 
            // iBE_ERPDataSet1
            // 
            this.iBE_ERPDataSet1.DataSetName = "IBE_ERPDataSet1";
            this.iBE_ERPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dboTArtikelBindingSource
            // 
            this.dboTArtikelBindingSource.DataMember = "dbo_T_Artikel";
            this.dboTArtikelBindingSource.DataSource = this.iBE_ERPDataSet;
            // 
            // iBE_ERPDataSet
            // 
            this.iBE_ERPDataSet.DataSetName = "IBE_ERPDataSet";
            this.iBE_ERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbo_T_ArtikelTableAdapter
            // 
            this.dbo_T_ArtikelTableAdapter.ClearBeforeFill = true;
            // 
            // dboTArtikelBindingSource1
            // 
            this.dboTArtikelBindingSource1.DataMember = "dbo_T_Artikel";
            this.dboTArtikelBindingSource1.DataSource = this.iBE_ERPDataSet;
            // 
            // iBEERPDataSet1BindingSource
            // 
            this.iBEERPDataSet1BindingSource.DataSource = this.iBE_ERPDataSet1;
            this.iBEERPDataSet1BindingSource.Position = 0;
            // 
            // iBEERPDataSetBindingSource
            // 
            this.iBEERPDataSetBindingSource.DataSource = this.iBE_ERPDataSet;
            this.iBEERPDataSetBindingSource.Position = 0;
            // 
            // t_ArtikelTableAdapter
            // 
            this.t_ArtikelTableAdapter.ClearBeforeFill = true;
            // 
            // Auswahlbtn
            // 
            this.Auswahlbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Auswahlbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Auswahlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auswahlbtn.Location = new System.Drawing.Point(820, 53);
            this.Auswahlbtn.Name = "Auswahlbtn";
            this.Auswahlbtn.Size = new System.Drawing.Size(103, 32);
            this.Auswahlbtn.TabIndex = 10;
            this.Auswahlbtn.Text = "Auswählen";
            this.Auswahlbtn.UseVisualStyleBackColor = false;
            this.Auswahlbtn.Click += new System.EventHandler(this.Auswahlbtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(28, 553);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(231, 39);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<  Zurück zum Hauptmenu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // t_WorkOrderTableAdapter
            // 
            this.t_WorkOrderTableAdapter.ClearBeforeFill = true;
            // 
            // picBox_iv
            // 
            this.picBox_iv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_iv.BackgroundImage")));
            this.picBox_iv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_iv.InitialImage = null;
            this.picBox_iv.Location = new System.Drawing.Point(235, 150);
            this.picBox_iv.Name = "picBox_iv";
            this.picBox_iv.Size = new System.Drawing.Size(211, 372);
            this.picBox_iv.TabIndex = 12;
            this.picBox_iv.TabStop = false;
            // 
            // picBox_hv
            // 
            this.picBox_hv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_hv.BackgroundImage")));
            this.picBox_hv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_hv.InitialImage = null;
            this.picBox_hv.Location = new System.Drawing.Point(61, 150);
            this.picBox_hv.Name = "picBox_hv";
            this.picBox_hv.Size = new System.Drawing.Size(493, 372);
            this.picBox_hv.TabIndex = 13;
            this.picBox_hv.TabStop = false;
            this.picBox_hv.Visible = false;
            // 
            // picBox_sa
            // 
            this.picBox_sa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_sa.BackgroundImage")));
            this.picBox_sa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_sa.InitialImage = null;
            this.picBox_sa.Location = new System.Drawing.Point(52, 150);
            this.picBox_sa.Name = "picBox_sa";
            this.picBox_sa.Size = new System.Drawing.Size(502, 372);
            this.picBox_sa.TabIndex = 14;
            this.picBox_sa.TabStop = false;
            this.picBox_sa.Visible = false;
            // 
            // label_iv_text
            // 
            this.label_iv_text.AutoSize = true;
            this.label_iv_text.BackColor = System.Drawing.Color.Transparent;
            this.label_iv_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iv_text.Location = new System.Drawing.Point(593, 224);
            this.label_iv_text.Name = "label_iv_text";
            this.label_iv_text.Size = new System.Drawing.Size(507, 240);
            this.label_iv_text.TabIndex = 15;
            this.label_iv_text.Text = resources.GetString("label_iv_text.Text");
            // 
            // label_iv_title
            // 
            this.label_iv_title.AutoSize = true;
            this.label_iv_title.BackColor = System.Drawing.Color.Transparent;
            this.label_iv_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iv_title.Location = new System.Drawing.Point(592, 150);
            this.label_iv_title.Name = "label_iv_title";
            this.label_iv_title.Size = new System.Drawing.Size(570, 50);
            this.label_iv_title.TabIndex = 16;
            this.label_iv_title.Text = "Installationsverteiler nach VDE und zuständiger TAB \r\nder Energieversorger\r\n";
            // 
            // label_sa_title
            // 
            this.label_sa_title.AutoSize = true;
            this.label_sa_title.BackColor = System.Drawing.Color.Transparent;
            this.label_sa_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sa_title.Location = new System.Drawing.Point(592, 150);
            this.label_sa_title.Name = "label_sa_title";
            this.label_sa_title.Size = new System.Drawing.Size(216, 25);
            this.label_sa_title.TabIndex = 17;
            this.label_sa_title.Text = "Steuerungsanlagen";
            this.label_sa_title.Visible = false;
            // 
            // label_sa_text
            // 
            this.label_sa_text.AutoSize = true;
            this.label_sa_text.BackColor = System.Drawing.Color.Transparent;
            this.label_sa_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sa_text.Location = new System.Drawing.Point(599, 200);
            this.label_sa_text.Name = "label_sa_text";
            this.label_sa_text.Size = new System.Drawing.Size(697, 264);
            this.label_sa_text.TabIndex = 18;
            this.label_sa_text.Text = resources.GetString("label_sa_text.Text");
            this.label_sa_text.Visible = false;
            // 
            // label_hv_title
            // 
            this.label_hv_title.AutoSize = true;
            this.label_hv_title.BackColor = System.Drawing.Color.Transparent;
            this.label_hv_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hv_title.Location = new System.Drawing.Point(598, 150);
            this.label_hv_title.Name = "label_hv_title";
            this.label_hv_title.Size = new System.Drawing.Size(210, 25);
            this.label_hv_title.TabIndex = 19;
            this.label_hv_title.Text = "Hochstromverteiler";
            this.label_hv_title.Visible = false;
            // 
            // label_hv_text
            // 
            this.label_hv_text.AutoSize = true;
            this.label_hv_text.BackColor = System.Drawing.Color.Transparent;
            this.label_hv_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hv_text.Location = new System.Drawing.Point(593, 200);
            this.label_hv_text.Name = "label_hv_text";
            this.label_hv_text.Size = new System.Drawing.Size(612, 384);
            this.label_hv_text.TabIndex = 20;
            this.label_hv_text.Text = resources.GetString("label_hv_text.Text");
            this.label_hv_text.Visible = false;
            // 
            // ArtikelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.label_hv_text);
            this.Controls.Add(this.label_hv_title);
            this.Controls.Add(this.label_sa_text);
            this.Controls.Add(this.label_sa_title);
            this.Controls.Add(this.label_iv_title);
            this.Controls.Add(this.label_iv_text);
            this.Controls.Add(this.picBox_sa);
            this.Controls.Add(this.picBox_hv);
            this.Controls.Add(this.picBox_iv);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Auswahlbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelArtikel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtikelScreen";
            this.Text = "Artikel";
            this.Load += new System.EventHandler(this.ArtikelScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tWorkOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iB34DB_AppCore_20220609DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tArtikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_iv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_hv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label labelArtikel;
        private System.Windows.Forms.ComboBox comboBox1;
        private IBE_ERPDataSet iBE_ERPDataSet;
        private System.Windows.Forms.BindingSource dboTArtikelBindingSource;
        private IBE_ERPDataSetTableAdapters.dbo_T_ArtikelTableAdapter dbo_T_ArtikelTableAdapter;
        private System.Windows.Forms.BindingSource dboTArtikelBindingSource1;
        private System.Windows.Forms.BindingSource iBEERPDataSetBindingSource;
        private IBE_ERPDataSet1 iBE_ERPDataSet1;
        private System.Windows.Forms.BindingSource iBEERPDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tArtikelBindingSource;
        private IBE_ERPDataSet1TableAdapters.T_ArtikelTableAdapter t_ArtikelTableAdapter;
        private System.Windows.Forms.Button Auswahlbtn;
        private System.Windows.Forms.Button btnBack;
        private IB34DB_AppCore_20220609DataSet iB34DB_AppCore_20220609DataSet;
        private System.Windows.Forms.BindingSource tWorkOrderBindingSource;
        private IB34DB_AppCore_20220609DataSetTableAdapters.T_WorkOrderTableAdapter t_WorkOrderTableAdapter;
        private System.Windows.Forms.PictureBox picBox_iv;
        private System.Windows.Forms.PictureBox picBox_hv;
        private System.Windows.Forms.PictureBox picBox_sa;
        private System.Windows.Forms.Label label_iv_text;
        private System.Windows.Forms.Label label_iv_title;
        private System.Windows.Forms.Label label_sa_title;
        private System.Windows.Forms.Label label_sa_text;
        private System.Windows.Forms.Label label_hv_title;
        private System.Windows.Forms.Label label_hv_text;
    }
}