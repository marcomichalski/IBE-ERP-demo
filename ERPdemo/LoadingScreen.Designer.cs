namespace ERPdemo
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingProgress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingbarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadingProgressBar.Location = new System.Drawing.Point(12, 303);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(660, 23);
            this.loadingProgressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadingProgress
            // 
            this.loadingProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadingProgress.AutoSize = true;
            this.loadingProgress.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingProgress.Location = new System.Drawing.Point(362, 276);
            this.loadingProgress.Name = "loadingProgress";
            this.loadingProgress.Size = new System.Drawing.Size(37, 21);
            this.loadingProgress.TabIndex = 2;
            this.loadingProgress.Text = "0 %";
            this.loadingProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ERPdemo.Properties.Resources.ib_pic;
            this.pictureBox1.InitialImage = global::ERPdemo.Properties.Resources.ib_pic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loadingbarTimer
            // 
            this.loadingbarTimer.Interval = 50;
            this.loadingbarTimer.Tick += new System.EventHandler(this.loadingbarTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadingProgressBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoBoard Europe intern ERPdemo";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loadingProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer loadingbarTimer;
    }
}

