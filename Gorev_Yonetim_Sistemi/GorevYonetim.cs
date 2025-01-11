using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors; // DevExpress kontrolünü kullanmak için gerekli ad alanını ekleyin.
using System.Data.SqlClient;
using System.IO;


namespace Gorev_Yonetim_Sistemi
{
    public partial class GorevYonetim : Form
    {
        private TimeSpan gecenSure = TimeSpan.Zero;
        private bool sayacCalisiyor = false;

        public GorevYonetim()
        {
            InitializeComponent();
            lblSayac.Text = "00:00:00";
            lblKaydedilenSure.Text = "Süre";
            btnTamamlandi.Click += new EventHandler(btnTamamlandi_Click);
        }

        private void GorevYonetim_Load(object sender, EventArgs e)
        {
            timer1.Start();

            listView1.View = View.Details;
            listView2.View = View.Details;
            listView3.View = View.Details;

            // Kolonları ekle
            listView1.Columns.Add("Plan Detayı", 1000);

            listView2.Columns.Add("Görev Adı", 300);
            listView2.Columns.Add("Son Tarih", 200);
            listView2.Columns.Add("Öncelik", 200);
            listView2.Columns.Add("Kategori", 300);

            listView3.Columns.Add("Görev Adı", 300);
            listView3.Columns.Add("Tarih", 200);
            listView3.Columns.Add("Öncelik", 200);
            listView3.Columns.Add("Kategori", 300);

            GorevleriListele();

            // Tamamlanan görevleri listele
            listView3.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=E\\SQLEXPRESS;Initial Catalog=ProjeDB;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT GorevAdi, Tarih, Oncelik, Kategori FROM Gorevler WHERE KullaniciID = @KullaniciID AND Tamamlandi = 1 AND Tarih >= GETDATE()";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciID", OturumBilgileri.KullaniciID);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["GorevAdi"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["Tarih"]).ToString("dd.MM.yyyy"));
                    item.SubItems.Add(reader["Oncelik"].ToString());
                    item.SubItems.Add(reader["Kategori"].ToString());
                    listView3.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Sayaç zamanını günceller
            gecenSure = gecenSure.Add(TimeSpan.FromSeconds(1));
            lblSayac.Text = gecenSure.ToString(@"hh\:mm\:ss");
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (!sayacCalisiyor)
            {
                timer2.Start();
                sayacCalisiyor = true;
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (sayacCalisiyor)
            {
                timer2.Stop();
                sayacCalisiyor = false;
            }
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            if (!sayacCalisiyor)
            {
                timer2.Start();
                sayacCalisiyor = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lblKaydedilenSure.Text = lblSayac.Text;
            MessageBox.Show($"Kaydedilen Süre: {lblKaydedilenSure.Text}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            gecenSure = TimeSpan.Zero;
            lblSayac.Text = "00:00:00";
            sayacCalisiyor = false;
        }

        private void dateNavigator1_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = dateNavigator1.SelectionStart.ToShortDateString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTarih.Text) ||
                 string.IsNullOrWhiteSpace(TxtGorev.Text) ||
                 comboBoxEdit1.SelectedIndex == -1 ||
                 comboBoxEdit2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gorevMetni = $"{TxtTarih.Text} - {TxtGorev.Text} ({comboBoxEdit2.SelectedItem})";
            ListViewItem item = new ListViewItem(gorevMetni);
            listView1.Items.Add(item);
        }

        private void groupGorevler_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGorevEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtGorev.Text) || comboBoxEdit1.SelectedItem == null || comboBoxEdit2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenGorev = TxtGorev.Text;
            string oncelik = comboBoxEdit1.SelectedItem.ToString();
            string kategori = comboBoxEdit2.SelectedItem.ToString();
            DateTime tarih;

            // Tarih kontrolü ve dönüşümü
            if (!DateTime.TryParse(TxtTarih.Text, out tarih))
            {
                MessageBox.Show("Geçerli bir tarih formatı giriniz! (Örn: 2025-01-10)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ListView2 için sütun bazlı ekleme
            ListViewItem item = new ListViewItem(secilenGorev);
            item.SubItems.Add(tarih.ToString("dd.MM.yyyy"));
            item.SubItems.Add(oncelik);
            item.SubItems.Add(kategori);

            // Öncelik seviyesine göre renklendirme
            switch (oncelik)
            {
                case "Öncelikli":
                    item.ForeColor = Color.Red;
                    break;
                case "Planlanmış":
                    item.ForeColor = Color.Orange;
                    break;
                default:
                    item.ForeColor = Color.Green;
                    break;
            }

            listView2.Items.Add(item);

            using (SqlConnection conn = new SqlConnection("Data Source=E\\SQLEXPRESS;Initial Catalog=ProjeDB;Integrated Security=True"))
            {
                conn.Open();
                string query = @"INSERT INTO Gorevler (GorevAdi, Tarih, Oncelik, Kategori, KullaniciID, Tamamlandi) 
                        VALUES (@GorevAdi, @Tarih, @Oncelik, @Kategori, @KullaniciID, 0)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GorevAdi", secilenGorev);
                    cmd.Parameters.AddWithValue("@Tarih", tarih);
                    cmd.Parameters.AddWithValue("@Oncelik", oncelik);
                    cmd.Parameters.AddWithValue("@Kategori", kategori);
                    cmd.Parameters.AddWithValue("@KullaniciID", OturumBilgileri.KullaniciID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Görev başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GorevleriListele();
        }


        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            // Seçili görevi kontrol et
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
                string gorevBilgisi = selectedItem.Text;

                // Görev bilgilerini ayır (Görev Adı, Kategori ve Tarih ayrımı)
                string[] parcalar = gorevBilgisi.Split(new string[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
                string gorevAdi = parcalar[0].Trim();
                string kategori = parcalar.Length > 1 ? parcalar[1].Trim() : "";

                // Görevi tamamlandı olarak işaretle (Veritabanında güncelleme)
                using (SqlConnection conn = new SqlConnection("Data Source=E\\SQLEXPRESS;Initial Catalog=ProjeDB;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "UPDATE Gorevler SET Tamamlandi = 1, TamamlanmaTarihi = GETDATE() WHERE GorevAdi = @GorevAdi AND KullaniciID = @KullaniciID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@GorevAdi", gorevAdi);
                    cmd.Parameters.AddWithValue("@KullaniciID", OturumBilgileri.KullaniciID);

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        // Görev başarıyla tamamlandı, listView3'e ekle
                        ListViewItem completedItem = (ListViewItem)selectedItem.Clone();
                        completedItem.ForeColor = Color.Black;
                        listView3.Items.Add(completedItem);

                        // Orijinal listeden kaldır
                        listView2.Items.Remove(selectedItem);

                        // ✅ 24 saat sonra otomatik silme
                        Timer deleteTimer = new Timer();
                        deleteTimer.Interval = 24 * 60 * 60 * 1000; // 24 saat
                        deleteTimer.Tick += (s, args) =>
                        {
                            using (SqlConnection deleteConn = new SqlConnection("Data Source=E\\SQLEXPRESS;Initial Catalog=ProjeDB;Integrated Security=True"))
                            {
                                deleteConn.Open();
                                string deleteQuery = "DELETE FROM Gorevler WHERE GorevAdi = @GorevAdi AND KullaniciID = @KullaniciID AND Tamamlandi = 1";
                                SqlCommand deleteCmd = new SqlCommand(deleteQuery, deleteConn);
                                deleteCmd.Parameters.AddWithValue("@GorevAdi", gorevAdi);
                                deleteCmd.Parameters.AddWithValue("@KullaniciID", OturumBilgileri.KullaniciID);
                                deleteCmd.ExecuteNonQuery();
                            }

                            if (listView3.Items.Contains(completedItem))
                            {
                                listView3.Items.Remove(completedItem);
                            }
                            deleteTimer.Stop();
                            deleteTimer.Dispose();
                        };
                        deleteTimer.Start();

                        MessageBox.Show("Görev başarıyla tamamlandı ve 24 saat içinde silinecek!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Görev veritabanında güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tamamlanan bir görev seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void GorevleriListele()
        {
            listView2.Items.Clear(); // Mevcut verileri temizler
            using (SqlConnection conn = new SqlConnection("Data Source=E\\SQLEXPRESS;Initial Catalog=ProjeDB;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT GorevAdi, Tarih, Oncelik, Kategori FROM Gorevler WHERE KullaniciID = @KullaniciID AND Tamamlandi = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciID", OturumBilgileri.KullaniciID);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["GorevAdi"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["Tarih"]).ToString("dd.MM.yyyy"));
                    item.SubItems.Add(reader["Oncelik"].ToString());
                    item.SubItems.Add(reader["Kategori"].ToString());

                    // Öncelik rengine göre renklendirme
                    if (reader["Oncelik"].ToString() == "Öncelikli")
                        item.ForeColor = Color.Red;
                    else if (reader["Oncelik"].ToString() == "Planlanmış")
                        item.ForeColor = Color.Orange;
                    else
                        item.ForeColor = Color.Green;

                    listView2.Items.Add(item);
                }
                conn.Close();
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            string raporDosyaAdi = $"GunlukRapor_{OturumBilgileri.KullaniciID}_{DateTime.Now:yyyyMMdd}.txt";
            string dosyaYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), raporDosyaAdi);

            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                // Tamamlanan Görevler
                sw.WriteLine("Tamamlanan Görevler:");
                sw.WriteLine("--------------------");
                foreach (ListViewItem item in listView3.Items)
                {
                    sw.WriteLine($"{item.SubItems[0].Text} - Son Tarih: {item.SubItems[1].Text}");
                }

                // Tarihi Geçen Görevler
                sw.WriteLine("\nTarihi Geçen Görevler:");
                sw.WriteLine("-----------------------");
                foreach (ListViewItem item in listView2.Items)
                {
                    DateTime sonTarih = DateTime.Parse(item.SubItems[1].Text);
                    if (sonTarih < DateTime.Now)
                    {
                        sw.WriteLine($"{item.SubItems[0].Text} ({item.SubItems[3].Text}) - Son Tarih: {sonTarih:dd.MM.yyyy}");
                    }
                }

                // Göreve Ayrılan Süre
                sw.WriteLine("\nGöreve Ayrılan Süre:");
                sw.WriteLine("---------------------");
                sw.WriteLine(lblKaydedilenSure.Text);
            }

            // Dosyayı aç
            MessageBox.Show($"Rapor başarıyla oluşturuldu: {dosyaYolu}", "Rapor Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("notepad.exe", dosyaYolu); // Not Defteri ile dosyayı açar
        }

        private void GorevYonetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Sistemden çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true; // Kapatmayı iptal et
            }
        }
    }

}
