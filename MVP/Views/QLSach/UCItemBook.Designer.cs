
namespace MVP.Views
{
    partial class UCItemBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTG = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 137);
            this.panel1.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(116, 137);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(118, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(240, 43);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Toi thay hoa vang tren co xanh";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTG
            // 
            this.lblTG.BackColor = System.Drawing.SystemColors.Control;
            this.lblTG.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTG.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTG.Location = new System.Drawing.Point(118, 45);
            this.lblTG.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(240, 32);
            this.lblTG.TabIndex = 2;
            this.lblTG.Text = "Nguyen Nhat Anh";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblGiaBan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(118, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 31);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(172, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "70000";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Image = global::MVP.Properties.Resources.icons8_low_price_24;
            this.label4.Location = new System.Drawing.Point(131, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 30);
            this.label4.TabIndex = 7;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiaBan.Location = new System.Drawing.Point(45, 0);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(68, 31);
            this.lblGiaBan.TabIndex = 6;
            this.lblGiaBan.Text = "70000";
            this.lblGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Image = global::MVP.Properties.Resources.icons8_price_tag_24;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 31);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblSoLuong);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(118, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 31);
            this.panel4.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoLuong.Location = new System.Drawing.Point(45, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(195, 31);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "1";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = global::MVP.Properties.Resources.icons8_sum_24;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 31);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCItemBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTG);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.Name = "UCItemBook";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(360, 141);
            this.Click += new System.EventHandler(this.UCItemBook_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTG;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoLuong;
    }
}
