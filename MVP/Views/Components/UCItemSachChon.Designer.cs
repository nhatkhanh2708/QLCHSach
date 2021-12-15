
namespace MVP.Views
{
    partial class UCItemSachChon
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
            this.btnDel = new System.Windows.Forms.Button();
            this.lblSlNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.lblSlNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 88);
            this.panel1.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnDel.FlatAppearance.BorderSize = 2;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Image = global::MVP.Properties.Resources.icons8_delete_32;
            this.btnDel.Location = new System.Drawing.Point(222, 54);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(33, 32);
            this.btnDel.TabIndex = 37;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblSlNhap
            // 
            this.lblSlNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSlNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSlNhap.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSlNhap.Location = new System.Drawing.Point(39, 51);
            this.lblSlNhap.Name = "lblSlNhap";
            this.lblSlNhap.Size = new System.Drawing.Size(70, 37);
            this.lblSlNhap.TabIndex = 2;
            this.lblSlNhap.Text = "+10";
            this.lblSlNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Image = global::MVP.Properties.Resources.icons8_download_24;
            this.label2.Location = new System.Drawing.Point(0, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 37);
            this.label2.TabIndex = 1;
            // 
            // lblSach
            // 
            this.lblSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSach.Location = new System.Drawing.Point(0, 0);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(258, 51);
            this.lblSach.TabIndex = 0;
            this.lblSach.Text = "label1";
            this.lblSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCItemSachChon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10, 3, 15, 15);
            this.Name = "UCItemSachChon";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(262, 92);
            this.Load += new System.EventHandler(this.UCItemSachChon_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.Label lblSlNhap;
        private System.Windows.Forms.Button btnDel;
    }
}
