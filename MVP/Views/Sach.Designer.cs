using System;

namespace MVP.Views
{
    partial class Sach
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
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.labelSach = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTừ = new System.Windows.Forms.Label();
            this.labelDen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelMaSach = new System.Windows.Forms.Label();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.labelNXBID = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelDonGiaXuat = new System.Windows.Forms.Label();
            this.labelDonGiaNhap = new System.Windows.Forms.Label();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.labelTacGia = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.buttonHoTroTG = new System.Windows.Forms.Button();
            this.buttonDatLai = new System.Windows.Forms.Button();
            this.buttonHoTroTL = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimKiem.Location = new System.Drawing.Point(133, 16);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(282, 39);
            this.textBoxTimKiem.TabIndex = 18;
            // 
            // labelSach
            // 
            this.labelSach.AutoSize = true;
            this.labelSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSach.Location = new System.Drawing.Point(15, 87);
            this.labelSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSach.Name = "labelSach";
            this.labelSach.Size = new System.Drawing.Size(0, 32);
            this.labelSach.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tác Giả",
            "NXB"});
            this.comboBox1.Location = new System.Drawing.Point(420, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 40);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Sách";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTen.Location = new System.Drawing.Point(15, 19);
            this.labelTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(114, 32);
            this.labelTen.TabIndex = 22;
            this.labelTen.Text = "Tìm kiếm";
            this.labelTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGia.Location = new System.Drawing.Point(754, 20);
            this.labelGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(81, 32);
            this.labelGia.TabIndex = 23;
            this.labelGia.Text = "Giá từ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(839, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 39);
            this.textBox1.TabIndex = 24;
            // 
            // labelTừ
            // 
            this.labelTừ.AutoSize = true;
            this.labelTừ.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTừ.Location = new System.Drawing.Point(790, 71);
            this.labelTừ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTừ.Name = "labelTừ";
            this.labelTừ.Size = new System.Drawing.Size(0, 32);
            this.labelTừ.TabIndex = 25;
            this.labelTừ.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelDen
            // 
            this.labelDen.AutoSize = true;
            this.labelDen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDen.Location = new System.Drawing.Point(996, 20);
            this.labelDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(58, 32);
            this.labelDen.TabIndex = 27;
            this.labelDen.Text = "Đến";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(1058, 17);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 39);
            this.textBox2.TabIndex = 26;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = global::MVP.Properties.Resources.search;
            this.buttonSearch.Location = new System.Drawing.Point(1215, 13);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(54, 48);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 351);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1305, 469);
            this.dataGridView1.TabIndex = 29;
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaSach.Location = new System.Drawing.Point(20, 92);
            this.labelMaSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(107, 32);
            this.labelMaSach.TabIndex = 34;
            this.labelMaSach.Text = "Mã Sách";
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTenSach.Location = new System.Drawing.Point(20, 142);
            this.labelTenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(110, 32);
            this.labelTenSach.TabIndex = 35;
            this.labelTenSach.Text = "Tên Sách";
            // 
            // labelNXBID
            // 
            this.labelNXBID.AutoSize = true;
            this.labelNXBID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNXBID.Location = new System.Drawing.Point(20, 195);
            this.labelNXBID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNXBID.Name = "labelNXBID";
            this.labelNXBID.Size = new System.Drawing.Size(62, 32);
            this.labelNXBID.TabIndex = 36;
            this.labelNXBID.Text = "NXB";
            this.labelNXBID.Click += new System.EventHandler(this.labelNXBID_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(131, 84);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 39);
            this.textBox3.TabIndex = 37;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(131, 139);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(284, 39);
            this.textBox4.TabIndex = 38;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(131, 192);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(284, 39);
            this.textBox5.TabIndex = 39;
            // 
            // labelDonGiaXuat
            // 
            this.labelDonGiaXuat.AutoSize = true;
            this.labelDonGiaXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDonGiaXuat.Location = new System.Drawing.Point(991, 85);
            this.labelDonGiaXuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDonGiaXuat.Name = "labelDonGiaXuat";
            this.labelDonGiaXuat.Size = new System.Drawing.Size(108, 32);
            this.labelDonGiaXuat.TabIndex = 40;
            this.labelDonGiaXuat.Text = "Giá Xuất";
            // 
            // labelDonGiaNhap
            // 
            this.labelDonGiaNhap.AutoSize = true;
            this.labelDonGiaNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDonGiaNhap.Location = new System.Drawing.Point(991, 138);
            this.labelDonGiaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDonGiaNhap.Name = "labelDonGiaNhap";
            this.labelDonGiaNhap.Size = new System.Drawing.Size(116, 32);
            this.labelDonGiaNhap.TabIndex = 41;
            this.labelDonGiaNhap.Text = "Giá Nhập";
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTrangThai.Location = new System.Drawing.Point(497, 199);
            this.labelTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(128, 32);
            this.labelTrangThai.TabIndex = 42;
            this.labelTrangThai.Text = "Trạng Thái";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(1111, 83);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 39);
            this.textBox6.TabIndex = 43;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(1111, 138);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(198, 39);
            this.textBox7.TabIndex = 44;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(629, 192);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(238, 39);
            this.textBox8.TabIndex = 45;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(629, 139);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(238, 39);
            this.textBox9.TabIndex = 47;
            // 
            // labelTacGia
            // 
            this.labelTacGia.AutoSize = true;
            this.labelTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTacGia.Location = new System.Drawing.Point(533, 142);
            this.labelTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTacGia.Name = "labelTacGia";
            this.labelTacGia.Size = new System.Drawing.Size(92, 32);
            this.labelTacGia.TabIndex = 46;
            this.labelTacGia.Text = "Tác Giả";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(629, 81);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(238, 39);
            this.textBox10.TabIndex = 49;
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTheLoai.Location = new System.Drawing.Point(525, 86);
            this.labelTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(100, 32);
            this.labelTheLoai.TabIndex = 48;
            this.labelTheLoai.Text = "Thể loại";
            // 
            // buttonHoTroTG
            // 
            this.buttonHoTroTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoTroTG.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHoTroTG.ForeColor = System.Drawing.Color.White;
            this.buttonHoTroTG.Image = global::MVP.Properties.Resources.gear_2_16;
            this.buttonHoTroTG.Location = new System.Drawing.Point(881, 139);
            this.buttonHoTroTG.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHoTroTG.Name = "buttonHoTroTG";
            this.buttonHoTroTG.Size = new System.Drawing.Size(54, 46);
            this.buttonHoTroTG.TabIndex = 50;
            this.buttonHoTroTG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoTroTG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHoTroTG.UseVisualStyleBackColor = true;
            this.buttonHoTroTG.Click += new System.EventHandler(this.buttonHoTroTG_Click);
            // 
            // buttonDatLai
            // 
            this.buttonDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDatLai.ForeColor = System.Drawing.Color.White;
            this.buttonDatLai.Image = global::MVP.Properties.Resources.refresh;
            this.buttonDatLai.Location = new System.Drawing.Point(868, 264);
            this.buttonDatLai.Name = "buttonDatLai";
            this.buttonDatLai.Size = new System.Drawing.Size(124, 56);
            this.buttonDatLai.TabIndex = 57;
            this.buttonDatLai.Text = "Đặt Lại";
            this.buttonDatLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDatLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDatLai.UseVisualStyleBackColor = true;
            // 
            // buttonHoTroTL
            // 
            this.buttonHoTroTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoTroTL.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHoTroTL.ForeColor = System.Drawing.Color.White;
            this.buttonHoTroTL.Image = global::MVP.Properties.Resources.gear_2_16;
            this.buttonHoTroTL.Location = new System.Drawing.Point(881, 78);
            this.buttonHoTroTL.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHoTroTL.Name = "buttonHoTroTL";
            this.buttonHoTroTL.Size = new System.Drawing.Size(54, 46);
            this.buttonHoTroTL.TabIndex = 51;
            this.buttonHoTroTL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoTroTL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHoTroTL.UseVisualStyleBackColor = true;
            this.buttonHoTroTL.Click += new System.EventHandler(this.buttonHoTroTL_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Image = global::MVP.Properties.Resources.search;
            this.buttonTimKiem.Location = new System.Drawing.Point(554, 13);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(71, 46);
            this.buttonTimKiem.TabIndex = 58;
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Image = global::MVP.Properties.Resources.edit_9_24;
            this.buttonSua.Location = new System.Drawing.Point(455, 264);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(94, 56);
            this.buttonSua.TabIndex = 59;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.IndianRed;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Image = global::MVP.Properties.Resources.delete;
            this.buttonXoa.Location = new System.Drawing.Point(647, 264);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(120, 56);
            this.buttonXoa.TabIndex = 60;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonThem
            // 
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Image = global::MVP.Properties.Resources.them;
            this.buttonThem.Location = new System.Drawing.Point(223, 264);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(123, 56);
            this.buttonThem.TabIndex = 61;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 835);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.buttonDatLai);
            this.Controls.Add(this.buttonHoTroTL);
            this.Controls.Add(this.buttonHoTroTG);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.labelTheLoai);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.labelTacGia);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.labelTrangThai);
            this.Controls.Add(this.labelDonGiaNhap);
            this.Controls.Add(this.labelDonGiaXuat);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelNXBID);
            this.Controls.Add(this.labelTenSach);
            this.Controls.Add(this.labelMaSach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelDen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelTừ);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSach);
            this.Controls.Add(this.textBoxTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Sach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label labelSach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTừ;
        private System.Windows.Forms.Label labelDen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMaSach;
        private System.Windows.Forms.Label labelTenSach;
        private System.Windows.Forms.Label labelNXBID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelDonGiaXuat;
        private System.Windows.Forms.Label labelDonGiaNhap;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label labelTacGia;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label labelTheLoai;
        private System.Windows.Forms.Button buttonHoTroTG;
        private System.Windows.Forms.Button buttonDatLai;
        private System.Windows.Forms.Button buttonHoTroTL;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
    }
}