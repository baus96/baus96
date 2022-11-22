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
    public partial class AdminForm : Form
    {
        public static AdminForm instance;
        public AdminForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bağlantı.Close(); // Uygulama kapatılırsa bağlantıyı kapatıyor.
            Application.Exit();
        }

        SqlConnection bağlantı = new SqlConnection(); // Yeni bağlantı açıyor.
        
        private void AdminForm_Load(object sender, EventArgs e)
        {
            string adminBağlantıMetni = Form2.instance.adminConnectionString.Text; // Form2'deki ile aynı server string'ini kullanıyor.
            try
            {
                bağlantı.ConnectionString =
                    "Data Source=" + adminBağlantıMetni + ";" +
                    "Initial Catalog=TAKLA;" +
                    "User id=baus_admin;" +
                    "Password=12345;";
                bağlantı.Open();
                
            }
            catch (Exception hata) 
            {
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
            }  

        }

        private void komutTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void komutGöndermeButton_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlCommand komut1 = new SqlCommand(komutTextBox.Text, bağlantı);
                SqlDataReader okuyucu1 = komut1.ExecuteReader(); // Sql'e komut gönderdiğimizde geri dönüşü sağlıyor.

                çıkışTextBox.Text = "";

                string metin = null;
                string metin2 = null;
                string metin3 = null;
                while (okuyucu1.Read())
                {
                    metin = okuyucu1[0].ToString();
                    metin2 = okuyucu1[1].ToString();
                    metin3 = okuyucu1[2].ToString();

                    çıkışTextBox.Text = çıkışTextBox.Text + "\n" + "Kullanıcı Adı:" + metin + " " + "Şifre:" + metin2 + " " + "Numara:" + metin3; // Gelen değerleri gurupluyor.
                }
                
                okuyucu1.Close();
            }
            catch (Exception hata) 
            {
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
            }
            
        }

        private void duyuruButton_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlCommand komut3 = new SqlCommand("SELECT MAX(numara) FROM Komut_Verileri", bağlantı); // EN yüksek komut numarasını buluyor. (Form2'deki ile çok benzer)
                SqlDataReader okuyucu2 = komut3.ExecuteReader();
                string yeniNumaraNo = null;

                while (okuyucu2.Read())
                {
                    yeniNumaraNo = okuyucu2[0].ToString();
                }

                int yeniNumaraNo2 = Int16.Parse(yeniNumaraNo);
                int numaraNo = yeniNumaraNo2 + 1;

                okuyucu2.Close();
                SqlCommand komut2 = new SqlCommand("INSERT INTO Komut_Verileri VALUES (@KullanıcıAdı, @Duyuru, @Numara)", bağlantı);
                komut2.Parameters.AddWithValue("@KullanıcıAdı", duyuruİsimTextBox.Text);
                komut2.Parameters.AddWithValue("@Duyuru", duyuruTextBox.Text);
                komut2.Parameters.AddWithValue("@Numara", numaraNo);
                komut2.ExecuteNonQuery();

                duyuruİsimTextBox.Text = "";
                duyuruTextBox.Text = "";
                MessageBox.Show("Duyuru Başarıyla Gönderildi");
                // bakınız Form2.
            }
            catch (Exception hata) 
            {
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
            }
           
        }
    }
}
