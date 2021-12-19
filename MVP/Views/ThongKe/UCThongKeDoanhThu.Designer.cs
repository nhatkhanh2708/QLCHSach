
namespace MVP.Views
{
    partial class UCThongKeDoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 75);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1275, 3);
            this.label1.TabIndex = 1;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1275, 70);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1275, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thống kê doanh thu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlBody);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 75);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1275, 800);
            this.pnlContainer.TabIndex = 4;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.dateTo);
            this.pnlBody.Controls.Add(this.dateFrom);
            this.pnlBody.Controls.Add(this.flp);
            this.pnlBody.Controls.Add(this.btnMore);
            this.pnlBody.Controls.Add(this.btnTimKiem);
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1275, 802);
            this.pnlBody.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Image = global::MVP.Properties.Resources.icons8_calendar_32;
            this.label3.Location = new System.Drawing.Point(634, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 38);
            this.label3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(872, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(903, 26);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(178, 31);
            this.dateTo.TabIndex = 17;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(687, 26);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(179, 31);
            this.dateFrom.TabIndex = 16;
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Location = new System.Drawing.Point(25, 120);
            this.flp.Name = "flp";
            this.flp.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.flp.Size = new System.Drawing.Size(1225, 661);
            this.flp.TabIndex = 15;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnMore.FlatAppearance.BorderSize = 2;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Image = global::MVP.Properties.Resources.icons8_more_32;
            this.btnMore.Location = new System.Drawing.Point(1195, 16);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(55, 55);
            this.btnMore.TabIndex = 14;
            this.btnMore.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnTimKiem.FlatAppearance.BorderSize = 2;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = global::MVP.Properties.Resources.icons8_magnifying_glass_32;
            this.btnTimKiem.Location = new System.Drawing.Point(1109, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(55, 55);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // UCThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Name = "UCThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1275, 875);
            this.Load += new System.EventHandler(this.UCThongKeDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
