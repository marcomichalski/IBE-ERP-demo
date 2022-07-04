
namespace ERPdemo
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.btnArtikel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKunde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(353, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(438, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEMO  ERP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnArtikel
            // 
            this.btnArtikel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArtikel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnArtikel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikel.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnArtikel.Image = ((System.Drawing.Image)(resources.GetObject("btnArtikel.Image")));
            this.btnArtikel.Location = new System.Drawing.Point(12, 251);
            this.btnArtikel.Name = "btnArtikel";
            this.btnArtikel.Size = new System.Drawing.Size(352, 301);
            this.btnArtikel.TabIndex = 4;
            this.btnArtikel.Text = "Artikel";
            this.btnArtikel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArtikel.UseVisualStyleBackColor = true;
            this.btnArtikel.Click += new System.EventHandler(this.btnArtikel_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(765, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 301);
            this.button1.TabIndex = 2;
            this.button1.Text = "Auftrag erfassen";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKunde
            // 
            this.btnKunde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKunde.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKunde.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKunde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.btnKunde.Image = ((System.Drawing.Image)(resources.GetObject("btnKunde.Image")));
            this.btnKunde.Location = new System.Drawing.Point(388, 251);
            this.btnKunde.Name = "btnKunde";
            this.btnKunde.Size = new System.Drawing.Size(352, 301);
            this.btnKunde.TabIndex = 1;
            this.btnKunde.Text = "Kunden verwalten";
            this.btnKunde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKunde.UseVisualStyleBackColor = true;
            this.btnKunde.Click += new System.EventHandler(this.btnKunde_Click);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 677);
            this.Controls.Add(this.btnArtikel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKunde);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1150, 716);
            this.MinimumSize = new System.Drawing.Size(1150, 716);
            this.Name = "MainMenuScreen";
            this.Text = "Hauptmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKunde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArtikel;
    }
}