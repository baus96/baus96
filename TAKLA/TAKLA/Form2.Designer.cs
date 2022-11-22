namespace TAKLA
{
    partial class Form2
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
            this.sidebarUser = new System.Windows.Forms.FlowLayoutPanel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.yeniHesapButton = new System.Windows.Forms.Button();
            this.kullanıcıŞifreTextBox = new System.Windows.Forms.TextBox();
            this.kullanıcıAdıTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.geriButton2 = new System.Windows.Forms.Button();
            this.serverTextBox2 = new System.Windows.Forms.TextBox();
            this.bağlantıButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.sidebarAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.geriButton = new System.Windows.Forms.Button();
            this.bağlantıButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.şifreTextBox = new System.Windows.Forms.TextBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.sidebarUser.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.sidebarAdmin.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarUser
            // 
            this.sidebarUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidebarUser.Controls.Add(this.userPanel);
            this.sidebarUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebarUser.Location = new System.Drawing.Point(514, 0);
            this.sidebarUser.MaximumSize = new System.Drawing.Size(764, 377);
            this.sidebarUser.MinimumSize = new System.Drawing.Size(250, 377);
            this.sidebarUser.Name = "sidebarUser";
            this.sidebarUser.Size = new System.Drawing.Size(250, 377);
            this.sidebarUser.TabIndex = 1;
            this.sidebarUser.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarUser_Paint);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.yeniHesapButton);
            this.userPanel.Controls.Add(this.kullanıcıŞifreTextBox);
            this.userPanel.Controls.Add(this.kullanıcıAdıTextBox);
            this.userPanel.Controls.Add(this.label5);
            this.userPanel.Controls.Add(this.label4);
            this.userPanel.Controls.Add(this.geriButton2);
            this.userPanel.Controls.Add(this.serverTextBox2);
            this.userPanel.Controls.Add(this.bağlantıButton2);
            this.userPanel.Controls.Add(this.label3);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(3, 3);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(782, 362);
            this.userPanel.TabIndex = 0;
            // 
            // yeniHesapButton
            // 
            this.yeniHesapButton.BackColor = System.Drawing.Color.Magenta;
            this.yeniHesapButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yeniHesapButton.ForeColor = System.Drawing.SystemColors.Control;
            this.yeniHesapButton.Location = new System.Drawing.Point(274, 313);
            this.yeniHesapButton.Name = "yeniHesapButton";
            this.yeniHesapButton.Size = new System.Drawing.Size(182, 46);
            this.yeniHesapButton.TabIndex = 12;
            this.yeniHesapButton.Text = "Yeni Hesap";
            this.yeniHesapButton.UseVisualStyleBackColor = false;
            this.yeniHesapButton.Click += new System.EventHandler(this.yeniHesapButton_Click);
            // 
            // kullanıcıŞifreTextBox
            // 
            this.kullanıcıŞifreTextBox.Location = new System.Drawing.Point(274, 240);
            this.kullanıcıŞifreTextBox.Name = "kullanıcıŞifreTextBox";
            this.kullanıcıŞifreTextBox.PlaceholderText = "ör: 123456";
            this.kullanıcıŞifreTextBox.Size = new System.Drawing.Size(170, 27);
            this.kullanıcıŞifreTextBox.TabIndex = 11;
            // 
            // kullanıcıAdıTextBox
            // 
            this.kullanıcıAdıTextBox.Location = new System.Drawing.Point(274, 122);
            this.kullanıcıAdıTextBox.Name = "kullanıcıAdıTextBox";
            this.kullanıcıAdıTextBox.PlaceholderText = "ör: baus";
            this.kullanıcıAdıTextBox.Size = new System.Drawing.Size(170, 27);
            this.kullanıcıAdıTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(274, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(274, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // geriButton2
            // 
            this.geriButton2.BackColor = System.Drawing.Color.SaddleBrown;
            this.geriButton2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.geriButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.geriButton2.Location = new System.Drawing.Point(507, 313);
            this.geriButton2.Name = "geriButton2";
            this.geriButton2.Size = new System.Drawing.Size(154, 46);
            this.geriButton2.TabIndex = 7;
            this.geriButton2.Text = "Geri";
            this.geriButton2.UseVisualStyleBackColor = false;
            this.geriButton2.Click += new System.EventHandler(this.geriButton2_Click);
            // 
            // serverTextBox2
            // 
            this.serverTextBox2.Location = new System.Drawing.Point(479, 122);
            this.serverTextBox2.Name = "serverTextBox2";
            this.serverTextBox2.PlaceholderText = "ör: baus96.duckdns.org, 49170";
            this.serverTextBox2.Size = new System.Drawing.Size(215, 27);
            this.serverTextBox2.TabIndex = 6;
            // 
            // bağlantıButton2
            // 
            this.bağlantıButton2.BackColor = System.Drawing.Color.Gray;
            this.bağlantıButton2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bağlantıButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.bağlantıButton2.Location = new System.Drawing.Point(507, 224);
            this.bağlantıButton2.Name = "bağlantıButton2";
            this.bağlantıButton2.Size = new System.Drawing.Size(154, 46);
            this.bağlantıButton2.TabIndex = 6;
            this.bağlantıButton2.Text = "Bağlan";
            this.bağlantıButton2.UseVisualStyleBackColor = false;
            this.bağlantıButton2.Click += new System.EventHandler(this.bağlantıButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(479, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server Adı";
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userButton.Location = new System.Drawing.Point(320, 48);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(121, 52);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.IndianRed;
            this.adminButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminButton.Location = new System.Drawing.Point(320, 218);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(121, 52);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // sidebarAdmin
            // 
            this.sidebarAdmin.BackColor = System.Drawing.Color.IndianRed;
            this.sidebarAdmin.Controls.Add(this.adminPanel);
            this.sidebarAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarAdmin.Location = new System.Drawing.Point(0, 0);
            this.sidebarAdmin.MaximumSize = new System.Drawing.Size(764, 377);
            this.sidebarAdmin.MinimumSize = new System.Drawing.Size(250, 377);
            this.sidebarAdmin.Name = "sidebarAdmin";
            this.sidebarAdmin.Size = new System.Drawing.Size(250, 377);
            this.sidebarAdmin.TabIndex = 0;
            this.sidebarAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarAdmin_Paint);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.geriButton);
            this.adminPanel.Controls.Add(this.bağlantıButton);
            this.adminPanel.Controls.Add(this.label2);
            this.adminPanel.Controls.Add(this.label1);
            this.adminPanel.Controls.Add(this.şifreTextBox);
            this.adminPanel.Controls.Add(this.serverTextBox);
            this.adminPanel.Location = new System.Drawing.Point(3, 3);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(761, 362);
            this.adminPanel.TabIndex = 7;
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.geriButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.geriButton.ForeColor = System.Drawing.SystemColors.Control;
            this.geriButton.Location = new System.Drawing.Point(9, 313);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(154, 46);
            this.geriButton.TabIndex = 6;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // bağlantıButton
            // 
            this.bağlantıButton.BackColor = System.Drawing.Color.Gray;
            this.bağlantıButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bağlantıButton.ForeColor = System.Drawing.SystemColors.Control;
            this.bağlantıButton.Location = new System.Drawing.Point(9, 221);
            this.bağlantıButton.Name = "bağlantıButton";
            this.bağlantıButton.Size = new System.Drawing.Size(154, 46);
            this.bağlantıButton.TabIndex = 5;
            this.bağlantıButton.Text = "Bağlan";
            this.bağlantıButton.UseVisualStyleBackColor = false;
            this.bağlantıButton.Click += new System.EventHandler(this.bağlantıButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Adı";
            // 
            // şifreTextBox
            // 
            this.şifreTextBox.Location = new System.Drawing.Point(9, 162);
            this.şifreTextBox.Name = "şifreTextBox";
            this.şifreTextBox.PlaceholderText = "ör: 1234";
            this.şifreTextBox.Size = new System.Drawing.Size(215, 27);
            this.şifreTextBox.TabIndex = 1;
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(9, 70);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.PlaceholderText = "ör: baus96.duckdns.org,49170";
            this.serverTextBox.Size = new System.Drawing.Size(215, 27);
            this.serverTextBox.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(764, 377);
            this.Controls.Add(this.sidebarUser);
            this.Controls.Add(this.sidebarAdmin);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.userButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oturum Açma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sidebarUser.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.sidebarAdmin.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel sidebarUser;
        private Button userButton;
        private Button adminButton;
        private FlowLayoutPanel sidebarAdmin;
        private Panel adminPanel;
        private TextBox serverTextBox;
        private Label label1;
        private TextBox şifreTextBox;
        private Button bağlantıButton;
        private Label label2;
        private Panel userPanel;
        private TextBox serverTextBox2;
        private Button bağlantıButton2;
        private Label label3;
        private Button geriButton;
        private Button geriButton2;
        private Button yeniHesapButton;
        private TextBox kullanıcıŞifreTextBox;
        private TextBox kullanıcıAdıTextBox;
        private Label label5;
        private Label label4;
    }
}