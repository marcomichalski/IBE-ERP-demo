
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtikelScreen));
            this.labelArtikel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelArtikelNr = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBE_ERPDataSet1 = new ERPdemo.IBE_ERPDataSet1();
            this.dboTArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBE_ERPDataSet = new ERPdemo.IBE_ERPDataSet();
            this.ArtMatDGV = new System.Windows.Forms.DataGridView();
            this.dbo_T_ArtikelTableAdapter = new ERPdemo.IBE_ERPDataSetTableAdapters.dbo_T_ArtikelTableAdapter();
            this.dboTArtikelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iBEERPDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBEERPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ArtikelTableAdapter = new ERPdemo.IBE_ERPDataSet1TableAdapters.T_ArtikelTableAdapter();
            this.Auswahlbtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tArtikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtMatDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArtikel
            // 
            this.labelArtikel.AutoSize = true;
            this.labelArtikel.BackColor = System.Drawing.Color.Transparent;
            this.labelArtikel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtikel.Location = new System.Drawing.Point(58, 38);
            this.labelArtikel.Name = "labelArtikel";
            this.labelArtikel.Size = new System.Drawing.Size(61, 24);
            this.labelArtikel.TabIndex = 0;
            this.labelArtikel.Text = "Artikel";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(911, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 29);
            this.textBox2.TabIndex = 3;
            // 
            // labelArtikelNr
            // 
            this.labelArtikelNr.AutoSize = true;
            this.labelArtikelNr.BackColor = System.Drawing.Color.Transparent;
            this.labelArtikelNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtikelNr.Location = new System.Drawing.Point(805, 35);
            this.labelArtikelNr.Name = "labelArtikelNr";
            this.labelArtikelNr.Size = new System.Drawing.Size(87, 24);
            this.labelArtikelNr.TabIndex = 2;
            this.labelArtikelNr.Text = "Artikel-Nr";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(58, 139);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(75, 24);
            this.l.TabIndex = 6;
            this.l.Text = "Material";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.DataSource = this.tArtikelBindingSource;
            this.comboBox1.DisplayMember = "Art_Artikel_Bez";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(452, 32);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // ArtMatDGV
            // 
            this.ArtMatDGV.AllowUserToAddRows = false;
            this.ArtMatDGV.AllowUserToDeleteRows = false;
            this.ArtMatDGV.AllowUserToResizeColumns = false;
            this.ArtMatDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtMatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ArtMatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArtMatDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ArtMatDGV.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ArtMatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArtMatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ArtMatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArtMatDGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArtMatDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ArtMatDGV.Location = new System.Drawing.Point(166, 139);
            this.ArtMatDGV.Name = "ArtMatDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArtMatDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ArtMatDGV.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArtMatDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ArtMatDGV.Size = new System.Drawing.Size(863, 307);
            this.ArtMatDGV.TabIndex = 9;
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
            this.Auswahlbtn.Location = new System.Drawing.Point(647, 30);
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
            // ArtikelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Auswahlbtn);
            this.Controls.Add(this.ArtMatDGV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelArtikelNr);
            this.Controls.Add(this.labelArtikel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ArtikelScreen";
            this.Text = "Artikel";
            this.Load += new System.EventHandler(this.ArtikelScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tArtikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtMatDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTArtikelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label labelArtikel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelArtikelNr;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView ArtMatDGV;
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
    }
}