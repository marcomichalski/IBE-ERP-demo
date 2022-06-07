
namespace ERPdemo
{
    partial class KundenScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundenScreen));
            this.btnBack = new System.Windows.Forms.Button();
            this.KundenDGV = new System.Windows.Forms.DataGridView();
            this.tKundenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iBE_ERPDataSet = new ERPdemo.IBE_ERPDataSet();
            this.t_KundenTableAdapter = new ERPdemo.IBE_ERPDataSetTableAdapters.T_KundenTableAdapter();
            this.tKundenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKundenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iBE_ERPDataSet2 = new ERPdemo.IBE_ERPDataSet2();
            this.iBEERPDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKundenBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.t_KundenTableAdapter1 = new ERPdemo.IBE_ERPDataSet2TableAdapters.T_KundenTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientAddress = new System.Windows.Forms.TextBox();
            this.tbClientMail = new System.Windows.Forms.TextBox();
            this.tbClientPLZ = new System.Windows.Forms.TextBox();
            this.tbClientTel = new System.Windows.Forms.TextBox();
            this.labelArtikel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.iBE_ERPDataSet3 = new ERPdemo.IBE_ERPDataSet3();
            this.tKundenBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.t_KundenTableAdapter2 = new ERPdemo.IBE_ERPDataSet3TableAdapters.T_KundenTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKnr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KundenDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 626);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(231, 39);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<  Zurück zum Hauptmenu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // KundenDGV
            // 
            this.KundenDGV.AllowUserToAddRows = false;
            this.KundenDGV.AllowUserToDeleteRows = false;
            this.KundenDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KundenDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.KundenDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KundenDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.KundenDGV.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.KundenDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KundenDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KundenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KundenDGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KundenDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.KundenDGV.Location = new System.Drawing.Point(2, 296);
            this.KundenDGV.MultiSelect = false;
            this.KundenDGV.Name = "KundenDGV";
            this.KundenDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KundenDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.KundenDGV.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KundenDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.KundenDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KundenDGV.Size = new System.Drawing.Size(1129, 307);
            this.KundenDGV.TabIndex = 13;
            this.KundenDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KundenDGV_CellContentClick);
            // 
            // tKundenBindingSource1
            // 
            this.tKundenBindingSource1.DataMember = "T_Kunden";
            this.tKundenBindingSource1.DataSource = this.iBE_ERPDataSet;
            // 
            // iBE_ERPDataSet
            // 
            this.iBE_ERPDataSet.DataSetName = "IBE_ERPDataSet";
            this.iBE_ERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_KundenTableAdapter
            // 
            this.t_KundenTableAdapter.ClearBeforeFill = true;
            // 
            // tKundenBindingSource
            // 
            this.tKundenBindingSource.DataMember = "T_Kunden";
            this.tKundenBindingSource.DataSource = this.iBE_ERPDataSet;
            // 
            // tKundenBindingSource2
            // 
            this.tKundenBindingSource2.DataMember = "T_Kunden";
            this.tKundenBindingSource2.DataSource = this.iBE_ERPDataSet;
            // 
            // iBE_ERPDataSet2
            // 
            this.iBE_ERPDataSet2.DataSetName = "IBE_ERPDataSet2";
            this.iBE_ERPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iBEERPDataSet2BindingSource
            // 
            this.iBEERPDataSet2BindingSource.DataSource = this.iBE_ERPDataSet2;
            this.iBEERPDataSet2BindingSource.Position = 0;
            // 
            // tKundenBindingSource3
            // 
            this.tKundenBindingSource3.DataMember = "T_Kunden";
            this.tKundenBindingSource3.DataSource = this.iBEERPDataSet2BindingSource;
            // 
            // t_KundenTableAdapter1
            // 
            this.t_KundenTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 80);
            this.label1.TabIndex = 14;
            this.label1.Text = "KUNDENMENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbClientAddress
            // 
            this.tbClientAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientAddress.ForeColor = System.Drawing.Color.Black;
            this.tbClientAddress.Location = new System.Drawing.Point(459, 194);
            this.tbClientAddress.Name = "tbClientAddress";
            this.tbClientAddress.Size = new System.Drawing.Size(210, 29);
            this.tbClientAddress.TabIndex = 15;
            // 
            // tbClientMail
            // 
            this.tbClientMail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbClientMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientMail.ForeColor = System.Drawing.Color.Black;
            this.tbClientMail.Location = new System.Drawing.Point(459, 240);
            this.tbClientMail.Name = "tbClientMail";
            this.tbClientMail.Size = new System.Drawing.Size(210, 29);
            this.tbClientMail.TabIndex = 16;
            // 
            // tbClientPLZ
            // 
            this.tbClientPLZ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbClientPLZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientPLZ.ForeColor = System.Drawing.Color.Black;
            this.tbClientPLZ.Location = new System.Drawing.Point(774, 194);
            this.tbClientPLZ.Name = "tbClientPLZ";
            this.tbClientPLZ.Size = new System.Drawing.Size(136, 29);
            this.tbClientPLZ.TabIndex = 17;
            // 
            // tbClientTel
            // 
            this.tbClientTel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbClientTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientTel.ForeColor = System.Drawing.Color.Black;
            this.tbClientTel.Location = new System.Drawing.Point(774, 240);
            this.tbClientTel.Name = "tbClientTel";
            this.tbClientTel.Size = new System.Drawing.Size(136, 29);
            this.tbClientTel.TabIndex = 18;
            // 
            // labelArtikel
            // 
            this.labelArtikel.AutoSize = true;
            this.labelArtikel.BackColor = System.Drawing.Color.Transparent;
            this.labelArtikel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtikel.Location = new System.Drawing.Point(374, 199);
            this.labelArtikel.Name = "labelArtikel";
            this.labelArtikel.Size = new System.Drawing.Size(80, 24);
            this.labelArtikel.TabIndex = 19;
            this.labelArtikel.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "PLZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kundenname";
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.ForeColor = System.Drawing.Color.Black;
            this.tbClientName.Location = new System.Drawing.Point(459, 149);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(210, 29);
            this.tbClientName.TabIndex = 23;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(51, 146);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(156, 32);
            this.btnAddClient.TabIndex = 25;
            this.btnAddClient.Text = "Hinzufügen";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(51, 191);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(156, 32);
            this.btnEditClient.TabIndex = 26;
            this.btnEditClient.Text = "Bearbeiten";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(51, 235);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(156, 32);
            this.btnDeleteClient.TabIndex = 28;
            this.btnDeleteClient.Text = "Löschen";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.Location = new System.Drawing.Point(962, 237);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(156, 32);
            this.btnClearForm.TabIndex = 27;
            this.btnClearForm.Text = "Felder leeren";
            this.btnClearForm.UseVisualStyleBackColor = false;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // iBE_ERPDataSet3
            // 
            this.iBE_ERPDataSet3.DataSetName = "IBE_ERPDataSet3";
            this.iBE_ERPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKundenBindingSource4
            // 
            this.tKundenBindingSource4.DataMember = "T_Kunden";
            this.tKundenBindingSource4.DataSource = this.iBE_ERPDataSet3;
            // 
            // t_KundenTableAdapter2
            // 
            this.t_KundenTableAdapter2.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(728, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "K-Nr";
            // 
            // tbKnr
            // 
            this.tbKnr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbKnr.Cursor = System.Windows.Forms.Cursors.No;
            this.tbKnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKnr.ForeColor = System.Drawing.Color.Black;
            this.tbKnr.Location = new System.Drawing.Point(774, 151);
            this.tbKnr.Name = "tbKnr";
            this.tbKnr.ReadOnly = true;
            this.tbKnr.Size = new System.Drawing.Size(136, 29);
            this.tbKnr.TabIndex = 29;
            // 
            // KundenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ERPdemo.Properties.Resources.meeting_room2TP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 677);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKnr);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelArtikel);
            this.Controls.Add(this.tbClientTel);
            this.Controls.Add(this.tbClientPLZ);
            this.Controls.Add(this.tbClientMail);
            this.Controls.Add(this.tbClientAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KundenDGV);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1150, 716);
            this.MinimumSize = new System.Drawing.Size(1150, 716);
            this.Name = "KundenScreen";
            this.Text = "Kunden";
            this.Load += new System.EventHandler(this.KundenScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KundenDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBEERPDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBE_ERPDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKundenBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView KundenDGV;
        private IBE_ERPDataSetTableAdapters.T_KundenTableAdapter t_KundenTableAdapter;
        private IBE_ERPDataSet iBE_ERPDataSet;
        private System.Windows.Forms.BindingSource tKundenBindingSource;
        private System.Windows.Forms.BindingSource tKundenBindingSource1;
        private System.Windows.Forms.BindingSource iBEERPDataSet2BindingSource;
        private IBE_ERPDataSet2 iBE_ERPDataSet2;
        private System.Windows.Forms.BindingSource tKundenBindingSource2;
        private System.Windows.Forms.BindingSource tKundenBindingSource3;
        private IBE_ERPDataSet2TableAdapters.T_KundenTableAdapter t_KundenTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientAddress;
        private System.Windows.Forms.TextBox tbClientMail;
        private System.Windows.Forms.TextBox tbClientPLZ;
        private System.Windows.Forms.TextBox tbClientTel;
        private System.Windows.Forms.Label labelArtikel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnClearForm;
        private IBE_ERPDataSet3 iBE_ERPDataSet3;
        private System.Windows.Forms.BindingSource tKundenBindingSource4;
        private IBE_ERPDataSet3TableAdapters.T_KundenTableAdapter t_KundenTableAdapter2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKnr;
    }
}