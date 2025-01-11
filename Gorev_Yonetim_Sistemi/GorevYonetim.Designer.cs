namespace Gorev_Yonetim_Sistemi
{
    partial class GorevYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevYonetim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.groupPlanlama = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGorevEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGorev = new DevExpress.XtraEditors.TextEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsaat = new DevExpress.XtraEditors.LabelControl();
            this.groupGorevler = new System.Windows.Forms.GroupBox();
            this.btnTamamlandi = new DevExpress.XtraEditors.SimpleButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSifirla = new DevExpress.XtraEditors.SimpleButton();
            this.lblKaydedilenSure = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevamEt = new DevExpress.XtraEditors.SimpleButton();
            this.btnDurdur = new DevExpress.XtraEditors.SimpleButton();
            this.btnBasla = new DevExpress.XtraEditors.SimpleButton();
            this.lblSayac = new DevExpress.XtraEditors.LabelControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupTamamlandi = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.btnRapor = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            this.groupPlanlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupGorevler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupTamamlandi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1544, 715);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.dateNavigator1.Appearance.Options.UseBackColor = true;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator1.Location = new System.Drawing.Point(38, 131);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(299, 292);
            this.dateNavigator1.TabIndex = 1;
            this.dateNavigator1.Click += new System.EventHandler(this.dateNavigator1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tarih:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(84, 39);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Size = new System.Drawing.Size(125, 26);
            this.TxtTarih.TabIndex = 3;
            // 
            // groupPlanlama
            // 
            this.groupPlanlama.BackColor = System.Drawing.Color.Wheat;
            this.groupPlanlama.Controls.Add(this.listView1);
            this.groupPlanlama.Controls.Add(this.comboBoxEdit2);
            this.groupPlanlama.Controls.Add(this.labelControl4);
            this.groupPlanlama.Controls.Add(this.comboBoxEdit1);
            this.groupPlanlama.Controls.Add(this.labelControl3);
            this.groupPlanlama.Controls.Add(this.BtnGorevEkle);
            this.groupPlanlama.Controls.Add(this.BtnEkle);
            this.groupPlanlama.Controls.Add(this.labelControl2);
            this.groupPlanlama.Controls.Add(this.TxtGorev);
            this.groupPlanlama.Controls.Add(this.labelControl1);
            this.groupPlanlama.Controls.Add(this.TxtTarih);
            this.groupPlanlama.Font = new System.Drawing.Font("Verdana", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupPlanlama.Location = new System.Drawing.Point(367, 23);
            this.groupPlanlama.Name = "groupPlanlama";
            this.groupPlanlama.Size = new System.Drawing.Size(625, 400);
            this.groupPlanlama.TabIndex = 4;
            this.groupPlanlama.TabStop = false;
            this.groupPlanlama.Text = "Planlama";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 151);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 208);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.EditValue = "Seçiniz";
            this.comboBoxEdit2.Location = new System.Drawing.Point(421, 80);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxEdit2.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.DropDownRows = 3;
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "İş",
            "Kişisel",
            "Hobi"});
            this.comboBoxEdit2.Size = new System.Drawing.Size(161, 26);
            this.comboBoxEdit2.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(335, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 20);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Kategori:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Seçiniz";
            this.comboBoxEdit1.Location = new System.Drawing.Point(421, 39);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownRows = 3;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Öncelikli",
            "Planlanmış",
            "Opsiyonel"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(161, 26);
            this.comboBoxEdit1.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(268, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(147, 20);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Öncelik Durumu:";
            // 
            // BtnGorevEkle
            // 
            this.BtnGorevEkle.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGorevEkle.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnGorevEkle.Appearance.Options.UseFont = true;
            this.BtnGorevEkle.Appearance.Options.UseForeColor = true;
            this.BtnGorevEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGorevEkle.ImageOptions.Image")));
            this.BtnGorevEkle.Location = new System.Drawing.Point(10, 365);
            this.BtnGorevEkle.Name = "BtnGorevEkle";
            this.BtnGorevEkle.Size = new System.Drawing.Size(199, 29);
            this.BtnGorevEkle.TabIndex = 8;
            this.BtnGorevEkle.Text = "Görevi Ekle";
            this.BtnGorevEkle.Click += new System.EventHandler(this.BtnGorevEkle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.Appearance.Options.UseForeColor = true;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(421, 112);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(161, 33);
            this.BtnEkle.TabIndex = 7;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Görev:";
            // 
            // TxtGorev
            // 
            this.TxtGorev.Location = new System.Drawing.Point(84, 80);
            this.TxtGorev.Name = "TxtGorev";
            this.TxtGorev.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGorev.Properties.Appearance.Options.UseFont = true;
            this.TxtGorev.Size = new System.Drawing.Size(125, 26);
            this.TxtGorev.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.lblsaat);
            this.panel1.Location = new System.Drawing.Point(38, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 78);
            this.panel1.TabIndex = 5;
            // 
            // lblsaat
            // 
            this.lblsaat.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsaat.Appearance.Options.UseFont = true;
            this.lblsaat.Location = new System.Drawing.Point(41, 27);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(11, 20);
            this.lblsaat.TabIndex = 5;
            this.lblsaat.Text = "0";
            // 
            // groupGorevler
            // 
            this.groupGorevler.BackColor = System.Drawing.Color.Moccasin;
            this.groupGorevler.Controls.Add(this.btnTamamlandi);
            this.groupGorevler.Controls.Add(this.listView2);
            this.groupGorevler.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupGorevler.ForeColor = System.Drawing.Color.Black;
            this.groupGorevler.Location = new System.Drawing.Point(38, 453);
            this.groupGorevler.Name = "groupGorevler";
            this.groupGorevler.Size = new System.Drawing.Size(977, 250);
            this.groupGorevler.TabIndex = 6;
            this.groupGorevler.TabStop = false;
            this.groupGorevler.Text = "Görevler";
            this.groupGorevler.Enter += new System.EventHandler(this.groupGorevler_Enter);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamlandi.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTamamlandi.Appearance.Options.UseFont = true;
            this.btnTamamlandi.Appearance.Options.UseForeColor = true;
            this.btnTamamlandi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTamamlandi.ImageOptions.Image")));
            this.btnTamamlandi.Location = new System.Drawing.Point(813, 31);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(158, 200);
            this.btnTamamlandi.TabIndex = 14;
            this.btnTamamlandi.Text = "Tamamlandı";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(20, 31);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(787, 200);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.btnSifirla);
            this.groupBox1.Controls.Add(this.lblKaydedilenSure);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnDevamEt);
            this.groupBox1.Controls.Add(this.btnDurdur);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Controls.Add(this.lblSayac);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1014, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayaç";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(317, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(154, 20);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Kaydedilen Süre";
            // 
            // btnSifirla
            // 
            this.btnSifirla.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSifirla.Appearance.Options.UseForeColor = true;
            this.btnSifirla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSifirla.ImageOptions.Image")));
            this.btnSifirla.Location = new System.Drawing.Point(377, 95);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(135, 64);
            this.btnSifirla.TabIndex = 6;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // lblKaydedilenSure
            // 
            this.lblKaydedilenSure.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydedilenSure.Appearance.Options.UseFont = true;
            this.lblKaydedilenSure.Location = new System.Drawing.Point(371, 57);
            this.lblKaydedilenSure.Name = "lblKaydedilenSure";
            this.lblKaydedilenSure.Size = new System.Drawing.Size(40, 20);
            this.lblKaydedilenSure.TabIndex = 5;
            this.lblKaydedilenSure.Text = "Süre";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(191, 130);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(177, 29);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDevamEt.Appearance.Options.UseForeColor = true;
            this.btnDevamEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDevamEt.ImageOptions.Image")));
            this.btnDevamEt.Location = new System.Drawing.Point(191, 95);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(177, 29);
            this.btnDevamEt.TabIndex = 3;
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDurdur.Appearance.Options.UseForeColor = true;
            this.btnDurdur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDurdur.ImageOptions.Image")));
            this.btnDurdur.Location = new System.Drawing.Point(12, 130);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(173, 29);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBasla.Appearance.Options.UseForeColor = true;
            this.btnBasla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBasla.ImageOptions.Image")));
            this.btnBasla.Location = new System.Drawing.Point(12, 95);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(173, 29);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başla";
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.Appearance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Appearance.Options.UseFont = true;
            this.lblSayac.Location = new System.Drawing.Point(93, 42);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(92, 22);
            this.lblSayac.TabIndex = 0;
            this.lblSayac.Text = "00:00:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupTamamlandi
            // 
            this.groupTamamlandi.BackColor = System.Drawing.Color.Moccasin;
            this.groupTamamlandi.Controls.Add(this.listView3);
            this.groupTamamlandi.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupTamamlandi.ForeColor = System.Drawing.Color.Black;
            this.groupTamamlandi.Location = new System.Drawing.Point(1014, 226);
            this.groupTamamlandi.Name = "groupTamamlandi";
            this.groupTamamlandi.Size = new System.Drawing.Size(518, 197);
            this.groupTamamlandi.TabIndex = 8;
            this.groupTamamlandi.TabStop = false;
            this.groupTamamlandi.Text = "Tamamlananlar";
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.Info;
            this.listView3.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(12, 31);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(489, 142);
            this.listView3.TabIndex = 14;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // btnRapor
            // 
            this.btnRapor.Appearance.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Appearance.Options.UseFont = true;
            this.btnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnRapor.Location = new System.Drawing.Point(168, 64);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(269, 148);
            this.btnRapor.TabIndex = 9;
            this.btnRapor.Text = "Günün Raporunu Al";
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnRapor);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1055, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 250);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // GorevYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 715);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupTamamlandi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupGorevler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupPlanlama);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GorevYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Yönetim Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GorevYonetim_FormClosing);
            this.Load += new System.EventHandler(this.GorevYonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            this.groupPlanlama.ResumeLayout(false);
            this.groupPlanlama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupGorevler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupTamamlandi.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private System.Windows.Forms.GroupBox groupPlanlama;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtGorev;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblsaat;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnGorevEkle;
        private System.Windows.Forms.GroupBox groupGorevler;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl lblKaydedilenSure;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnDevamEt;
        private DevExpress.XtraEditors.SimpleButton btnDurdur;
        private DevExpress.XtraEditors.SimpleButton btnBasla;
        private DevExpress.XtraEditors.LabelControl lblSayac;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSifirla;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private DevExpress.XtraEditors.SimpleButton btnTamamlandi;
        private System.Windows.Forms.GroupBox groupTamamlandi;
        private System.Windows.Forms.ListView listView3;
        private DevExpress.XtraEditors.SimpleButton btnRapor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}