namespace TAKLA
{
    partial class AdminForm
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
            this.komutTextBox = new System.Windows.Forms.RichTextBox();
            this.komutYeriLabel = new System.Windows.Forms.Label();
            this.komutGöndermeButton = new System.Windows.Forms.Button();
            this.çıkışTextBox = new System.Windows.Forms.RichTextBox();
            this.çıkışYeriLabel = new System.Windows.Forms.Label();
            this.duyuruLabel = new System.Windows.Forms.Label();
            this.duyuruİsimTextBox = new System.Windows.Forms.TextBox();
            this.duyuruTextBox = new System.Windows.Forms.RichTextBox();
            this.duyuruButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // komutTextBox
            // 
            this.komutTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.komutTextBox.Location = new System.Drawing.Point(12, 61);
            this.komutTextBox.Name = "komutTextBox";
            this.komutTextBox.Size = new System.Drawing.Size(411, 74);
            this.komutTextBox.TabIndex = 0;
            this.komutTextBox.Text = "";
            this.komutTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.komutTextBox_PreviewKeyDown);
            // 
            // komutYeriLabel
            // 
            this.komutYeriLabel.AutoSize = true;
            this.komutYeriLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.komutYeriLabel.Location = new System.Drawing.Point(128, 9);
            this.komutYeriLabel.Name = "komutYeriLabel";
            this.komutYeriLabel.Size = new System.Drawing.Size(162, 38);
            this.komutYeriLabel.TabIndex = 4;
            this.komutYeriLabel.Text = "Komut Yeri";
            // 
            // komutGöndermeButton
            // 
            this.komutGöndermeButton.BackColor = System.Drawing.Color.Gray;
            this.komutGöndermeButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.komutGöndermeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.komutGöndermeButton.Location = new System.Drawing.Point(73, 167);
            this.komutGöndermeButton.Name = "komutGöndermeButton";
            this.komutGöndermeButton.Size = new System.Drawing.Size(281, 46);
            this.komutGöndermeButton.TabIndex = 6;
            this.komutGöndermeButton.Text = "SQL Komut Gönder";
            this.komutGöndermeButton.UseVisualStyleBackColor = false;
            this.komutGöndermeButton.Click += new System.EventHandler(this.komutGöndermeButton_Click);
            // 
            // çıkışTextBox
            // 
            this.çıkışTextBox.Location = new System.Drawing.Point(486, 61);
            this.çıkışTextBox.Name = "çıkışTextBox";
            this.çıkışTextBox.Size = new System.Drawing.Size(366, 152);
            this.çıkışTextBox.TabIndex = 7;
            this.çıkışTextBox.Text = "";
            // 
            // çıkışYeriLabel
            // 
            this.çıkışYeriLabel.AutoSize = true;
            this.çıkışYeriLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.çıkışYeriLabel.Location = new System.Drawing.Point(581, 9);
            this.çıkışYeriLabel.Name = "çıkışYeriLabel";
            this.çıkışYeriLabel.Size = new System.Drawing.Size(134, 38);
            this.çıkışYeriLabel.TabIndex = 8;
            this.çıkışYeriLabel.Text = "Çıkış Yeri";
            // 
            // duyuruLabel
            // 
            this.duyuruLabel.AutoSize = true;
            this.duyuruLabel.Font = new System.Drawing.Font("Impact", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.duyuruLabel.Location = new System.Drawing.Point(295, 262);
            this.duyuruLabel.Name = "duyuruLabel";
            this.duyuruLabel.Size = new System.Drawing.Size(257, 45);
            this.duyuruLabel.TabIndex = 9;
            this.duyuruLabel.Text = "Duyuru Oluştur";
            // 
            // duyuruİsimTextBox
            // 
            this.duyuruİsimTextBox.Location = new System.Drawing.Point(581, 343);
            this.duyuruİsimTextBox.Name = "duyuruİsimTextBox";
            this.duyuruİsimTextBox.PlaceholderText = "Duyuruyu gönderenin ismi";
            this.duyuruİsimTextBox.Size = new System.Drawing.Size(217, 27);
            this.duyuruİsimTextBox.TabIndex = 10;
            // 
            // duyuruTextBox
            // 
            this.duyuruTextBox.Location = new System.Drawing.Point(12, 343);
            this.duyuruTextBox.Name = "duyuruTextBox";
            this.duyuruTextBox.Size = new System.Drawing.Size(499, 152);
            this.duyuruTextBox.TabIndex = 11;
            this.duyuruTextBox.Text = "Duyurunuz:";
            // 
            // duyuruButton
            // 
            this.duyuruButton.BackColor = System.Drawing.Color.Gray;
            this.duyuruButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.duyuruButton.ForeColor = System.Drawing.SystemColors.Control;
            this.duyuruButton.Location = new System.Drawing.Point(581, 420);
            this.duyuruButton.Name = "duyuruButton";
            this.duyuruButton.Size = new System.Drawing.Size(271, 46);
            this.duyuruButton.TabIndex = 12;
            this.duyuruButton.Text = "Duyuruyu Gönder";
            this.duyuruButton.UseVisualStyleBackColor = false;
            this.duyuruButton.Click += new System.EventHandler(this.duyuruButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.duyuruButton);
            this.Controls.Add(this.duyuruTextBox);
            this.Controls.Add(this.duyuruİsimTextBox);
            this.Controls.Add(this.duyuruLabel);
            this.Controls.Add(this.çıkışYeriLabel);
            this.Controls.Add(this.çıkışTextBox);
            this.Controls.Add(this.komutGöndermeButton);
            this.Controls.Add(this.komutYeriLabel);
            this.Controls.Add(this.komutTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Kontrol Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox komutTextBox;
        private Label komutYeriLabel;
        private Button komutGöndermeButton;
        private RichTextBox çıkışTextBox;
        private Label çıkışYeriLabel;
        private Label duyuruLabel;
        private TextBox duyuruİsimTextBox;
        private RichTextBox duyuruTextBox;
        private Button duyuruButton;
    }
}