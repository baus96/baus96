using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKLA
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection bağlantı = new SqlConnection();
        private void UserForm_Load(object sender, EventArgs e)
        {
            duyuruGüncelleyici.Start();

            string userBağlantıMetni = Form2.instance.userConnectionString.Text;
            try
            {
                bağlantı.ConnectionString =
                    "Data Source=" + userBağlantıMetni + ";" +
                    "Initial Catalog=TAKLA;" +
                    "User id=baus_user;" +
                    "Password=1234;";
                bağlantı.Open();

                try
                {
                    SqlCommand komut1 = new SqlCommand("SELECT * FROM Komut_Verileri", bağlantı);
                    SqlDataReader okuyucu1 = komut1.ExecuteReader();

                    duyuruTextBox.Text = "";

                    string metin = null;
                    string metin2 = null;
                    string metin3 = null;
                    while (okuyucu1.Read())
                    {
                        metin = okuyucu1[0].ToString();
                        metin2 = okuyucu1[1].ToString();
                        metin3 = okuyucu1[2].ToString();

                        duyuruTextBox.Text = duyuruTextBox.Text + "\n" + "Kullanıcı Adı: " + metin + "   " + "Şifre: " + metin2 + "   " + "Numara: " + metin3 + "\n";
                    }

                    okuyucu1.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
                }
            }
            catch (Exception hata) 
            {
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bağlantı.Close();
            Application.Exit();
        }

        private void duyuruGüncelleyici_Tick(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("SELECT * FROM Komut_Verileri", bağlantı);
                SqlDataReader okuyucu1 = komut1.ExecuteReader();

                duyuruTextBox.Text = "";

                string metin = null;
                string metin2 = null;
                string metin3 = null;
                while (okuyucu1.Read())
                {
                    metin = okuyucu1[0].ToString();
                    metin2 = okuyucu1[1].ToString();
                    metin3 = okuyucu1[2].ToString();
                    
                    duyuruTextBox.Text = duyuruTextBox.Text + "\n" + "Kullanıcı Adı: " + metin + "   " + "Şifre: " + metin2 + "   " + "Numara: " + metin3 + "\n";
                }

                okuyucu1.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
            }
        }
    }
}
