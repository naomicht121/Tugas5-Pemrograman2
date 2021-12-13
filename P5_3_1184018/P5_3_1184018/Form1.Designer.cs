namespace P5_3_1184018
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSimpan = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKur06 = new System.Windows.Forms.RadioButton();
            this.rbKur10 = new System.Windows.Forms.RadioButton();
            this.rbKur14 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMRP = new System.Windows.Forms.CheckBox();
            this.cbSisop = new System.Windows.Forms.CheckBox();
            this.cbJarkom = new System.Windows.Forms.CheckBox();
            this.cbLogistik = new System.Windows.Forms.CheckBox();
            this.cbPemrog7 = new System.Windows.Forms.CheckBox();
            this.cbPemrog6 = new System.Windows.Forms.CheckBox();
            this.cbPemrog5 = new System.Windows.Forms.CheckBox();
            this.cbPemrog4 = new System.Windows.Forms.CheckBox();
            this.cbPemrog3 = new System.Windows.Forms.CheckBox();
            this.cbPemrog2 = new System.Windows.Forms.CheckBox();
            this.cbPemrog1 = new System.Windows.Forms.CheckBox();
            this.cbMtk = new System.Windows.Forms.CheckBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnMataKuliah = new System.Windows.Forms.Button();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLakiLaki = new System.Windows.Forms.RadioButton();
            this.tbTahunAkademik = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNPM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericTextBox1 = new P5_3_1184018.NumericTextBox(this.components);
            this.tbNama = new P5_3_1184018.OnlyLetters();
            this.ntbSemester = new P5_3_1184018.NumericTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(475, 743);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 38);
            this.btnSimpan.TabIndex = 51;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            this.epError.Icon = ((System.Drawing.Icon)(resources.GetObject("epError.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKur06);
            this.groupBox1.Controls.Add(this.rbKur10);
            this.groupBox1.Controls.Add(this.rbKur14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 451);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(317, 242);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurikulum Pilihan";
            // 
            // rbKur06
            // 
            this.rbKur06.AutoSize = true;
            this.rbKur06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKur06.Location = new System.Drawing.Point(31, 46);
            this.rbKur06.Margin = new System.Windows.Forms.Padding(4);
            this.rbKur06.Name = "rbKur06";
            this.rbKur06.Size = new System.Drawing.Size(127, 21);
            this.rbKur06.TabIndex = 10;
            this.rbKur06.TabStop = true;
            this.rbKur06.Text = "Kurikulum 2006";
            this.rbKur06.UseVisualStyleBackColor = true;
            // 
            // rbKur10
            // 
            this.rbKur10.AutoSize = true;
            this.rbKur10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKur10.Location = new System.Drawing.Point(31, 121);
            this.rbKur10.Margin = new System.Windows.Forms.Padding(4);
            this.rbKur10.Name = "rbKur10";
            this.rbKur10.Size = new System.Drawing.Size(127, 21);
            this.rbKur10.TabIndex = 11;
            this.rbKur10.TabStop = true;
            this.rbKur10.Text = "Kurikulum 2010";
            this.rbKur10.UseVisualStyleBackColor = true;
            // 
            // rbKur14
            // 
            this.rbKur14.AutoSize = true;
            this.rbKur14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKur14.Location = new System.Drawing.Point(31, 192);
            this.rbKur14.Margin = new System.Windows.Forms.Padding(4);
            this.rbKur14.Name = "rbKur14";
            this.rbKur14.Size = new System.Drawing.Size(127, 21);
            this.rbKur14.TabIndex = 12;
            this.rbKur14.TabStop = true;
            this.rbKur14.Text = "Kurikulum 2014";
            this.rbKur14.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMRP);
            this.groupBox2.Controls.Add(this.cbSisop);
            this.groupBox2.Controls.Add(this.cbJarkom);
            this.groupBox2.Controls.Add(this.cbLogistik);
            this.groupBox2.Controls.Add(this.cbPemrog7);
            this.groupBox2.Controls.Add(this.cbPemrog6);
            this.groupBox2.Controls.Add(this.cbPemrog5);
            this.groupBox2.Controls.Add(this.cbPemrog4);
            this.groupBox2.Controls.Add(this.cbPemrog3);
            this.groupBox2.Controls.Add(this.cbPemrog2);
            this.groupBox2.Controls.Add(this.cbPemrog1);
            this.groupBox2.Controls.Add(this.cbMtk);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(434, 451);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(701, 242);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kurikulum Pilihan";
            // 
            // cbMRP
            // 
            this.cbMRP.AutoSize = true;
            this.cbMRP.Location = new System.Drawing.Point(469, 192);
            this.cbMRP.Margin = new System.Windows.Forms.Padding(4);
            this.cbMRP.Name = "cbMRP";
            this.cbMRP.Size = new System.Drawing.Size(213, 21);
            this.cbMRP.TabIndex = 11;
            this.cbMRP.Text = "Manajemen Rantai Pasok";
            this.cbMRP.UseVisualStyleBackColor = true;
            // 
            // cbSisop
            // 
            this.cbSisop.AutoSize = true;
            this.cbSisop.Location = new System.Drawing.Point(469, 145);
            this.cbSisop.Margin = new System.Windows.Forms.Padding(4);
            this.cbSisop.Name = "cbSisop";
            this.cbSisop.Size = new System.Drawing.Size(140, 21);
            this.cbSisop.TabIndex = 10;
            this.cbSisop.Text = "Sistem Operasi";
            this.cbSisop.UseVisualStyleBackColor = true;
            // 
            // cbJarkom
            // 
            this.cbJarkom.AutoSize = true;
            this.cbJarkom.Location = new System.Drawing.Point(469, 96);
            this.cbJarkom.Margin = new System.Windows.Forms.Padding(4);
            this.cbJarkom.Name = "cbJarkom";
            this.cbJarkom.Size = new System.Drawing.Size(167, 21);
            this.cbJarkom.TabIndex = 9;
            this.cbJarkom.Text = "Jaringan Komputer";
            this.cbJarkom.UseVisualStyleBackColor = true;
            // 
            // cbLogistik
            // 
            this.cbLogistik.AutoSize = true;
            this.cbLogistik.Location = new System.Drawing.Point(469, 48);
            this.cbLogistik.Margin = new System.Windows.Forms.Padding(4);
            this.cbLogistik.Name = "cbLogistik";
            this.cbLogistik.Size = new System.Drawing.Size(166, 21);
            this.cbLogistik.TabIndex = 8;
            this.cbLogistik.Text = "Pengantar Logistik";
            this.cbLogistik.UseVisualStyleBackColor = true;
            // 
            // cbPemrog7
            // 
            this.cbPemrog7.AutoSize = true;
            this.cbPemrog7.Location = new System.Drawing.Point(260, 192);
            this.cbPemrog7.Margin = new System.Windows.Forms.Padding(4);
            this.cbPemrog7.Name = "cbPemrog7";
            this.cbPemrog7.Size = new System.Drawing.Size(144, 21);
            this.cbPemrog7.TabIndex = 7;
            this.cbPemrog7.Text = "Pemrograman 7";
            this.cbPemrog7.UseVisualStyleBackColor = true;
            // 
            // cbPemrog6
            // 
            this.cbPemrog6.AutoSize = true;
            this.cbPemrog6.Location = new System.Drawing.Point(260, 145);
            this.cbPemrog6.Margin = new System.Windows.Forms.Padding(4);
            this.cbPemrog6.Name = "cbPemrog6";
            this.cbPemrog6.Size = new System.Drawing.Size(144, 21);
            this.cbPemrog6.TabIndex = 6;
            this.cbPemrog6.Text = "Pemrograman 6";
            this.cbPemrog6.UseVisualStyleBackColor = true;
            // 
            // cbPemrog5
            // 
            this.cbPemrog5.AutoSize = true;
            this.cbPemrog5.Location = new System.Drawing.Point(260, 96);
            this.cbPemrog5.Margin = new System.Windows.Forms.Padding(4);
            this.cbPemrog5.Name = "cbPemrog5";
            this.cbPemrog5.Size = new System.Drawing.Size(144, 21);
            this.cbPemrog5.TabIndex = 5;
            this.cbPemrog5.Text = "Pemrograman 5";
            this.cbPemrog5.UseVisualStyleBackColor = true;
            // 
            // cbPemrog4
            // 
            this.cbPemrog4.AutoSize = true;
            this.cbPemrog4.Location = new System.Drawing.Point(260, 48);
            this.cbPemrog4.Margin = new System.Windows.Forms.Padding(4);
            this.cbPemrog4.Name = "cbPemrog4";
            this.cbPemrog4.Size = new System.Drawing.Size(144, 21);
            this.cbPemrog4.TabIndex = 4;
            this.cbPemrog4.Text = "Pemrograman 4";
            this.cbPemrog4.UseVisualStyleBackColor = true;
            // 
            // cbPemrog3
            // 
            this.cbPemrog3.AutoSize = true;
            this.cbPemrog3.Location = new System.Drawing.Point(41, 192);
            this.cbPemrog3.Margin = new System.Windows.Forms.Padding(4);
            this.cbPemrog3.Name = "cbPemrog3";
            this.cbPemrog3.Size = new System.Drawing.Size(144, 21);
            this.cbPemrog3.TabIndex = 3;
            this.cbPemrog3.Text = "Pemrograman 3";
            this.cbPemrog3.UseVisualStyleBackColor = true;
            // 
            // cbPemrog2
            // 
            this.cbPemrog2.AutoSize = true;
            this.cbPemrog2.Location = new System.Drawing.Point(41, 145);
            this.cbPemrog2.Margin = new System.Windows.Forms.Padding(4);
            this.cbPemrog2.Name = "cbPemrog2";
            this.cbPemrog2.Size = new System.Drawing.Size(144, 21);
            this.cbPemrog2.TabIndex = 2;
            this.cbPemrog2.Text = "Pemrograman 2";
            this.cbPemrog2.UseVisualStyleBackColor = true;
            // 
            // cbPemrog1
            // 
            this.cbPemrog1.AutoSize = true;
            this.cbPemrog1.Location = new System.Drawing.Point(41, 96);
            this.cbPemrog1.Margin = new System.Windows.Forms.Padding(4);
            this.cbPemrog1.Name = "cbPemrog1";
            this.cbPemrog1.Size = new System.Drawing.Size(144, 21);
            this.cbPemrog1.TabIndex = 1;
            this.cbPemrog1.Text = "Pemrograman 1";
            this.cbPemrog1.UseVisualStyleBackColor = true;
            // 
            // cbMtk
            // 
            this.cbMtk.AutoSize = true;
            this.cbMtk.Location = new System.Drawing.Point(41, 47);
            this.cbMtk.Margin = new System.Windows.Forms.Padding(4);
            this.cbMtk.Name = "cbMtk";
            this.cbMtk.Size = new System.Drawing.Size(112, 21);
            this.cbMtk.TabIndex = 0;
            this.cbMtk.Text = "Matematika";
            this.cbMtk.UseVisualStyleBackColor = true;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(678, 743);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 38);
            this.btnBatal.TabIndex = 52;
            this.btnBatal.Text = "Bata&l";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click_1);
            // 
            // btnMataKuliah
            // 
            this.btnMataKuliah.Location = new System.Drawing.Point(979, 312);
            this.btnMataKuliah.Margin = new System.Windows.Forms.Padding(4);
            this.btnMataKuliah.Name = "btnMataKuliah";
            this.btnMataKuliah.Size = new System.Drawing.Size(155, 28);
            this.btnMataKuliah.TabIndex = 42;
            this.btnMataKuliah.Text = "&Pilih Mata Kuliah";
            this.btnMataKuliah.UseVisualStyleBackColor = true;
            this.btnMataKuliah.Click += new System.EventHandler(this.btnMataKuliah_Click);
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "DKV",
            "Akuntansi"});
            this.cbProdi.Location = new System.Drawing.Point(815, 126);
            this.cbProdi.Margin = new System.Windows.Forms.Padding(4);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(317, 24);
            this.cbProdi.TabIndex = 37;
            this.cbProdi.Text = "- Pilihan Program Studi -";
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(364, 253);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(4);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(102, 21);
            this.rbPerempuan.TabIndex = 34;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLakiLaki
            // 
            this.rbLakiLaki.AutoSize = true;
            this.rbLakiLaki.Location = new System.Drawing.Point(247, 253);
            this.rbLakiLaki.Margin = new System.Windows.Forms.Padding(4);
            this.rbLakiLaki.Name = "rbLakiLaki";
            this.rbLakiLaki.Size = new System.Drawing.Size(94, 21);
            this.rbLakiLaki.TabIndex = 32;
            this.rbLakiLaki.TabStop = true;
            this.rbLakiLaki.Text = "Laki - Laki";
            this.rbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // tbTahunAkademik
            // 
            this.tbTahunAkademik.Location = new System.Drawing.Point(815, 190);
            this.tbTahunAkademik.Margin = new System.Windows.Forms.Padding(4);
            this.tbTahunAkademik.Name = "tbTahunAkademik";
            this.tbTahunAkademik.Size = new System.Drawing.Size(317, 22);
            this.tbTahunAkademik.TabIndex = 40;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(247, 308);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(319, 69);
            this.tbAlamat.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(779, 254);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 48;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(779, 195);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(779, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(207, 312);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(207, 253);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(207, 194);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tahun Akademik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Program Studi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nama";
            // 
            // tbNPM
            // 
            this.tbNPM.AutoSize = true;
            this.tbNPM.Location = new System.Drawing.Point(82, 130);
            this.tbNPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbNPM.Name = "tbNPM";
            this.tbNPM.Size = new System.Drawing.Size(38, 17);
            this.tbNPM.TabIndex = 29;
            this.tbNPM.Text = "NPM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mattone 150", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "MATA KULIAH MAHASISWA";
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(815, 247);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(317, 22);
            this.numericTextBox1.TabIndex = 56;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(238, 189);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(228, 22);
            this.tbNama.TabIndex = 55;
            // 
            // ntbSemester
            // 
            this.ntbSemester.Location = new System.Drawing.Point(238, 126);
            this.ntbSemester.Name = "ntbSemester";
            this.ntbSemester.Size = new System.Drawing.Size(228, 22);
            this.ntbSemester.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 837);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.ntbSemester);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnMataKuliah);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLakiLaki);
            this.Controls.Add(this.tbTahunAkademik);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNPM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Input Matakuliah";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKur06;
        private System.Windows.Forms.RadioButton rbKur10;
        private System.Windows.Forms.RadioButton rbKur14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbMRP;
        private System.Windows.Forms.CheckBox cbSisop;
        private System.Windows.Forms.CheckBox cbJarkom;
        private System.Windows.Forms.CheckBox cbLogistik;
        private System.Windows.Forms.CheckBox cbPemrog7;
        private System.Windows.Forms.CheckBox cbPemrog6;
        private System.Windows.Forms.CheckBox cbPemrog5;
        private System.Windows.Forms.CheckBox cbPemrog4;
        private System.Windows.Forms.CheckBox cbPemrog3;
        private System.Windows.Forms.CheckBox cbPemrog2;
        private System.Windows.Forms.CheckBox cbPemrog1;
        private System.Windows.Forms.CheckBox cbMtk;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnMataKuliah;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLakiLaki;
        private System.Windows.Forms.TextBox tbTahunAkademik;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbNPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private NumericTextBox ntbSemester;
        private OnlyLetters tbNama;
        private NumericTextBox numericTextBox1;
    }
}

