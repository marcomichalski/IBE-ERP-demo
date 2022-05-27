
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
            this.btnArtikel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArtikel
            // 
            this.btnArtikel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArtikel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnArtikel.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikel.ForeColor = System.Drawing.Color.White;
            this.btnArtikel.Image = ((System.Drawing.Image)(resources.GetObject("btnArtikel.Image")));
            this.btnArtikel.Location = new System.Drawing.Point(145, 140);
            this.btnArtikel.Name = "btnArtikel";
            this.btnArtikel.Size = new System.Drawing.Size(336, 148);
            this.btnArtikel.TabIndex = 0;
            this.btnArtikel.Text = "Artikel verwalten";
            this.btnArtikel.UseVisualStyleBackColor = true;
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 677);
            this.Controls.Add(this.btnArtikel);
            this.Name = "MainMenuScreen";
            this.Text = "Hauptmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArtikel;
    }
}