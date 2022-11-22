namespace TAKLA
{
    partial class UserForm
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
            this.duyuruTextBox = new System.Windows.Forms.RichTextBox();
            this.duyuruLabel = new System.Windows.Forms.Label();
            this.duyuruGüncelleyici = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // duyuruTextBox
            // 
            this.duyuruTextBox.Location = new System.Drawing.Point(12, 75);
            this.duyuruTextBox.Name = "duyuruTextBox";
            this.duyuruTextBox.Size = new System.Drawing.Size(840, 406);
            this.duyuruTextBox.TabIndex = 0;
            this.duyuruTextBox.Text = "";
            // 
            // duyuruLabel
            // 
            this.duyuruLabel.AutoSize = true;
            this.duyuruLabel.Font = new System.Drawing.Font("Impact", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.duyuruLabel.Location = new System.Drawing.Point(347, 9);
            this.duyuruLabel.Name = "duyuruLabel";
            this.duyuruLabel.Size = new System.Drawing.Size(178, 45);
            this.duyuruLabel.TabIndex = 10;
            this.duyuruLabel.Text = "Duyurular";
            // 
            // duyuruGüncelleyici
            // 
            this.duyuruGüncelleyici.Interval = 10000;
            this.duyuruGüncelleyici.Tick += new System.EventHandler(this.duyuruGüncelleyici_Tick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.duyuruLabel);
            this.Controls.Add(this.duyuruTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox duyuruTextBox;
        private Label duyuruLabel;
        private System.Windows.Forms.Timer duyuruGüncelleyici;
    }
}