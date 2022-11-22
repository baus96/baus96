/*
 *  TAKLA protatip denemesi.
 *   Bu kodları SQL-C# bağlantısını daha iyi anlayın diye yazdım.
 *   Lütfen tüm satırları dikkatlice okuyun.
 *   Uygulamada hala hatalar olabilir.
 *   Genel olarak bağlantı tiplerini ve veri okumayı anlatıyor. 
 *   İyi çalışmalar.
 *                                          Saygılarımla, Fahri 22/11/2022
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Sql özel kütüphnesini ekliyor.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKLA
{
    public partial class Form2 : Form
    {
        public static Form2 instance; // Form2'yi tanımlıyoruz.
        public TextBox adminConnectionString; // TextBox değişkeni oluşturuyoruz. 
        public TextBox userConnectionString; // Textbox 2 değişkeni oluşturuyoruz.
        public Form2()
        {
            InitializeComponent();
            instance = this;
            adminConnectionString = serverTextBox;
            userConnectionString = serverTextBox2;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatınca anlayan kod.
        }

        private void adminButton_Click(object sender, EventArgs e) // Önemsiz animasyon işlevleri
        {
            label1.Show();
            serverTextBox.Show();
            label2.Show();
            şifreTextBox.Show();
            bağlantıButton.Show();
            geriButton.Show();
            sidebarAdmin.BringToFront(); // Önemsiz animasyon işlevleri
            for (int uzunluk = sidebarAdmin.MinimumSize.Width;  uzunluk <= sidebarAdmin.MaximumSize.Width ; uzunluk++)
            {
                Thread.Sleep(1);
                sidebarAdmin.Width = uzunluk;
            }
        } // Önemsiz animasyon işlevleri

        private void sidebarAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userButton_Click(object sender, EventArgs e) // Önemsiz animasyon işlevleri
        {
            sidebarUser.BringToFront();
            for (int uzunluk = sidebarUser.MinimumSize.Width; uzunluk <= sidebarUser.MaximumSize.Width; uzunluk++)
            {
                Thread.Sleep(1);
                sidebarUser.Width = uzunluk;
            }
        } // Önemsiz animasyon işlevleri

        private void geriButton_Click(object sender, EventArgs e) // Önemsiz animasyon işlevleri
        {
            
            for (int uzunluk = sidebarAdmin.MaximumSize.Width; uzunluk >= sidebarAdmin.MinimumSize.Width; uzunluk--)
            {
                Thread.Sleep(1);
                sidebarAdmin.Width = uzunluk;
            }

            label1.Hide();
            serverTextBox.Hide();
            label2.Hide();
            şifreTextBox.Hide();
            bağlantıButton.Hide();
            geriButton.Hide();
        } // Önemsiz animasyon işlevleri

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Hide();                  
            serverTextBox.Hide();
            label2.Hide();
            şifreTextBox.Hide();            
            bağlantıButton.Hide();
            geriButton.Hide();
        } // Önemsiz animasyon işlevleri

        private void geriButton2_Click(object sender, EventArgs e) // Önemsiz animasyon işlevleri
        {
            
            for (int uzunluk = sidebarUser.MaximumSize.Width; uzunluk >= sidebarUser.MinimumSize.Width; uzunluk--)
            {
                Thread.Sleep(1);
                sidebarUser.Width = uzunluk;
            }
        } // Önemsiz animasyon işlevleri

        SqlConnection bağlantı = new SqlConnection(); // Yeni sql bağlantısı açıyoruz. (form komutlarının dışında)

     
        private void bağlantıButton_Click(object sender, EventArgs e) // Admin bağlanma bölgesi.
        {
            try
            {
                bağlantı.ConnectionString =
                    "Data Source=" + serverTextBox.Text + ";" + // Bağlantıyı textbox üzerinden alıyor. (zorunlu değil)
                    "Initial Catalog=TAKLA;" + // Hangi database bağlanacağını belirliyor.
                    "User id=baus_admin;" + // Admin olarak bağlantıyı açıyor.
                    "Password=" + şifreTextBox.Text + ";"; // Eğer şifre database şifresi ile aynı ise bağlantıya izin veriyor
                bağlantı.Open(); // Bağlantıyı açıyor.
                şifreTextBox.Text = "başarıyla bağlantı oluşturuldu"; // Bağlantı başarılı mesajı.
                AdminForm adminForm = new AdminForm(); // Admin ana sayfa formu geçiş bağı yapılıyor.
                this.Hide(); // Bu formu gizliyor.
                adminForm.Show(); // Admin formunu gösteriyor.

            }
            catch (Exception hata) // 'Catch' eğer 'try' ifadesi içinde bir hata meydana gelirse hatayı atlayıp alttaki bölümü çalıştırıyor.
            { // Bu bölüm.
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString()); // MessageBox sayesinde hatayı ekrana yansıtıyor.
            } // Bu bölüm.
            finally // Kodu 'finally' bölümünü çalıştırmaya zorluyor.
            {
                if (bağlantı != null) // Eğer bir bağlantı varsa kapatıyor. (test amaçlı)
                {
                    bağlantı.Close();
                }
                    
            }


        }

        private void bağlantıButton2_Click(object sender, EventArgs e)
        {
            try
            {
                bağlantı.ConnectionString =
                    "Data Source=" + serverTextBox2.Text + ";" + // Bağlantıyı textbox üzerinden alıyor. (zorunlu değil)
                    "Initial Catalog=TAKLA;" +
                    "User id=baus_user;" + // Kullanıcı olarak database bağlanıyor. (Yetkileri daha az)
                    "Password=1234;"; // Şifreyi otomatik yerleştiriyor.
                bağlantı.Open();

                if (kullanıcıAdıTextBox.Text != "" && kullanıcıŞifreTextBox.Text != "" && serverTextBox2.Text != "") // Kutuların boş olmadığını kontrol ediyor.
                {
                    SqlCommand komut3 = new SqlCommand("SELECT * FROM Kullanıcı_Verileri WHERE KullanıcıAdı = @KullanıcıAdı AND Şifre = @Şifre ", bağlantı); // Girilen değerleri sql komutuna atıyor. ('@' değişken atamak için kullanılır.) 
                    komut3.Parameters.AddWithValue("@KullanıcıAdı", kullanıcıAdıTextBox.Text); // Kullanıcının girdiği değerleri programdan çekiyor.
                    komut3.Parameters.AddWithValue("@Şifre", kullanıcıŞifreTextBox.Text); // Kullanıcının girdiği değerleri programdan çekiyor.
                    SqlDataReader okuyucu2 = komut3.ExecuteReader(); // Okuyucuyu çalıştırarak sql'den verileri çekiyor. (sadece çalıştırmak için) 
                    
                    string sistemKullanıcıAdı = null;
                    string sistemŞifre = null;

                    while (okuyucu2.Read())   // Okuyucuyu başlatıyor.
                    {
                        sistemKullanıcıAdı = okuyucu2[0].ToString(); // Sql'deki değerleri değişkinlere atıyor.
                        sistemŞifre = okuyucu2[1].ToString(); // Sql'deki değerleri değişkinlere atıyor.
                    }

                    if (sistemKullanıcıAdı == null && sistemŞifre == null) // Eğer değerler uyuşmazsa kullanıcıyı uyarıyor.
                    {
                        kullanıcıAdıTextBox.Text = "";
                        kullanıcıŞifreTextBox.Text = "";
                        serverTextBox.Text = "";
                        MessageBox.Show("ŞİFRE YA DA KULLANICI ADI YANLIŞ!");
                    }
                    else // giriş başarılı olursa.  
                    {

                        kullanıcıAdıTextBox.Text = "giriş başarılı";
                        kullanıcıŞifreTextBox.Text = "";
                        serverTextBox.Text = "";
                        UserForm userForm = new UserForm(); // Kullanıcı ana sayfasına yönlendiriyor.
                        userForm.Show();
                        this.Hide();
                    }

                }
                else // Kutular boşsa uyarıyor.
                {
                    kullanıcıAdıTextBox.Text = "";
                    kullanıcıŞifreTextBox.Text = "";
                    serverTextBox.Text = "";
                    MessageBox.Show("KUTULAR BOŞ OLAMAZ!");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
            }
            finally
            {
                if (bağlantı != null)
                {
                    bağlantı.Close();
                }
            }



        }

        private void yeniHesapButton_Click(object sender, EventArgs e)
        {
          
            try // Kullanıcı bağlantısı açıyor. (yukarıdakinin aynısı)
            {
                bağlantı.ConnectionString =
                    "Data Source=" + serverTextBox2.Text + ";" +
                    "Initial Catalog=TAKLA;" +
                    "User id=baus_user;" +
                    "Password=1234;";
                bağlantı.Open();
                SqlCommand komut1 = new SqlCommand("SELECT MAX(Numara) FROM Kullanıcı_Verileri", bağlantı); // Sistemdeki en yüksek numarayı alıyor.
                SqlDataReader okuyucu1 = komut1.ExecuteReader();
                string yeniNumaraNo = null;

                while (okuyucu1.Read()) 
                {
                    yeniNumaraNo = okuyucu1[0].ToString(); // En yüksek numarayı değişkene atıyor.
                }

                int yeniNumaraNo2 = Int16.Parse(yeniNumaraNo); // String'i integer'e çeviriyor.
                int numaraNo = yeniNumaraNo2 + 1; // Sql'deki en büyük numaraya 1 ekliyor.
                /*
                  Böylece eğer sql'deki en yüksek numara 9 ise;
                  Yeni kullanıcıyı 10 numara olarak kaydedebiliyor.
                  Bu sayede kullanıcıları ve sınıfları ayırmak daha kolay oluyor.
                 */

                okuyucu1.Close(); // Okuyucuyu kapatıyor

                if (kullanıcıAdıTextBox.Text != "" && kullanıcıŞifreTextBox.Text != "" && serverTextBox2.Text != "") // Boş olup olmadığına bakıyor.
                {
                    SqlCommand komut2 = new SqlCommand("INSERT INTO Kullanıcı_Verileri VALUES (@KullanıcıAdı, @Şifre, @Numara)", bağlantı); // Verileri sql'e göndererek yeni kullanıcı oluşturuyor.
                    komut2.Parameters.AddWithValue("@KullanıcıAdı", kullanıcıAdıTextBox.Text);
                    komut2.Parameters.AddWithValue("@Şifre", kullanıcıŞifreTextBox.Text);
                    komut2.Parameters.AddWithValue("@Numara", numaraNo);
                    komut2.ExecuteNonQuery(); // Komutu gönderiyor.
                    kullanıcıAdıTextBox.Text = "";
                    kullanıcıŞifreTextBox.Text = "";
                    MessageBox.Show("Hesap Başarıyla Oluşturuldu.");
                }
                else 
                {
                    kullanıcıAdıTextBox.Text = "";
                    kullanıcıŞifreTextBox.Text = "";
                    serverTextBox.Text = "";
                    MessageBox.Show("KUTULAR BOŞ OLAMAZ!");
                }
                

            }
            catch (Exception hata)
            {
                MessageBox.Show("YAPTIĞINIZ BAĞLANTI GEÇERLİ DEĞİL!  HATA KODU:\n" + hata.ToString());
            }
            finally 
            { 
                if (bağlantı != null) 
                {
                    bağlantı.Close();
                }
            }
           
        }
    }
}
