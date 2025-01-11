using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gorev_Yonetim_Sistemi
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            giris.Show();
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string connectionString = ("Data Source=E\\SQLEXPRESS;Initial Catalog=ProjeDB;Integrated Security=True");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kullanıcı adı, şifre ve e-posta kontrolü
                if (string.IsNullOrWhiteSpace(textEdit1.Text) ||
                    string.IsNullOrWhiteSpace(textEdit3.Text) ||
                    string.IsNullOrWhiteSpace(textEdit2.Text)) // Email için yeni kontrol
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Aynı kullanıcı adıyla kayıt kontrolü
                string kontrolQuery = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi";
                SqlCommand kontrolCmd = new SqlCommand(kontrolQuery, conn);
                kontrolCmd.Parameters.AddWithValue("@KullaniciAdi", textEdit1.Text);

                int mevcutKullanici = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                if (mevcutKullanici > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcıyı eklerken Email'i de ekliyoruz
                string query = "INSERT INTO Kullanici (KullaniciAdi, Sifre, Email) VALUES (@KullaniciAdi, @Sifre, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", textEdit1.Text);
                cmd.Parameters.AddWithValue("@Sifre", textEdit3.Text);
                cmd.Parameters.AddWithValue("@Email", textEdit2.Text); // Email eklendi

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris frmGiris = new FrmGiris();
                    frmGiris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
