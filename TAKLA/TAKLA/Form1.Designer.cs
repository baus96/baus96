namespace TAKLA
{
    partial class giriş
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giriş));
            this.girişResmi = new System.Windows.Forms.PictureBox();
            this.girişTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.girişResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // girişResmi
            // 
            this.girişResmi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.girişResmi.Image = ((System.Drawing.Image)(resources.GetObject("girişResmi.Image")));
            this.girişResmi.Location = new System.Drawing.Point(-1, 0);
            this.girişResmi.Name = "girişResmi";
            this.girişResmi.Size = new System.Drawing.Size(802, 453);
            this.girişResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.girişResmi.TabIndex = 0;
            this.girişResmi.TabStop = false;
            // 
            // girişTimer
            // 
            this.girişTimer.Interval = 10;
            this.girişTimer.Tick += new System.EventHandler(this.girişTimer_Tick);
            // 
            // giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girişResmi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.giriş_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.girişResmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox girişResmi;
        private System.Windows.Forms.Timer girişTimer;
    }
}