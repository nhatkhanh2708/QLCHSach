
namespace MVP.Views
{
    partial class UCItemSachNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSL);
            this.panel1.Controls.Add(this.lblGiaNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 84);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Image = global::MVP.Properties.Resources.icons8_sum_24;
            this.label2.Location = new System.Drawing.Point(156, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 32);
            this.label2.TabIndex = 4;
            // 
            // lblSL
            // 
            this.lblSL.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSL.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSL.Location = new System.Drawing.Point(194, 52);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(56, 32);
            this.lblSL.TabIndex = 3;
            this.lblSL.Text = "75";
            this.lblSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiaNhap.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGiaNhap.Location = new System.Drawing.Point(38, 52);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(98, 32);
            this.lblGiaNhap.TabIndex = 2;
            this.lblGiaNhap.Text = "75000";
            this.lblGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Image = global::MVP.Properties.Resources.icons8_low_price_24;
            this.label1.Location = new System.Drawing.Point(0, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 32);
            this.label1.TabIndex = 1;
            // 
            // lblSach
            // 
            this.lblSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSach.Location = new System.Drawing.Point(0, 0);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(250, 52);
            this.lblSach.TabIndex = 0;
            this.lblSach.Text = "label1";
            this.lblSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSach.Click += new System.EventHandler(this.lblSach_Click);
            // 
            // UCItemSachNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 25, 20);
            this.Name = "UCItemSachNhap";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(254, 88);
            this.Load += new System.EventHandler(this.UCItemSachNhap_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label label2;
    }
}
