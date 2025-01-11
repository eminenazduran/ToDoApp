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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmKayit kayit = new FrmKayit();
            kayit.Show();
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ("Data Source=E\\SQLEXPRESS;Initial Catalog=ProjeDB;Integrated Security=True;");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    if (string.IsNullOrWhiteSpace(textEdit1.Text) || string.IsNullOrWhiteSpace(textEdit2.Text))
                    {
                        MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "SELECT KullaniciID FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre COLLATE Turkish_CI_AS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = textEdit1.Text;
                    cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = textEdit2.Text;

                    object result = cmd.ExecuteScalar();
                    conn.Close();
                    if (result != null)
                    {
                        OturumBilgileri.KullaniciID = Convert.ToInt32(result);
                        MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SistemGiris sistemgiris = new SistemGiris();
                        sistemgiris.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Hatası: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
