
namespace MVP.Views
{
    partial class UCNhaCungCap
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Nhà cung cấp";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlBody);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 70);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1275, 805);
            this.pnlContainer.TabIndex = 2;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Controls.Add(this.flp);
            this.pnlBody.Controls.Add(this.btnMore);
            this.pnlBody.Controls.Add(this.btnRefesh);
            this.pnlBody.Controls.Add(this.btnTimKiem);
            this.pnlBody.Controls.Add(this.btnAdd);
            this.pnlBody.Controls.Add(this.txtTimKiem);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Location = new System.Drawing.Point(0, 1);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1275, 802);
            this.pnlBody.TabIndex = 6;
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
            this.btnMore.Location = new System.Drawing.Point(1012, 18);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(55, 55);
            this.btnMore.TabIndex = 14;
            this.btnMore.UseVisualStyleBackColor = false;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnRefesh.FlatAppearance.BorderSize = 2;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefesh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefesh.Image = global::MVP.Properties.Resources.icons8_refresh_32;
            this.btnRefesh.Location = new System.Drawing.Point(1144, 16);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(108, 55);
            this.btnRefesh.TabIndex = 13;
            this.btnRefesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefesh.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnTimKiem.FlatAppearance.BorderSize = 2;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = global::MVP.Properties.Resources.icons8_magnifying_glass_32;
            this.btnTimKiem.Location = new System.Drawing.Point(927, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(55, 55);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Image = global::MVP.Properties.Resources.icons8_add_32;
            this.btnAdd.Location = new System.Drawing.Point(27, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 55);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = " Thêm NCC";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(361, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.Size = new System.Drawing.Size(554, 30);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(361, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 4);
            this.label3.TabIndex = 9;
            // 
            // UCNhaCungCap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCNhaCungCap";
            this.Size = new System.Drawing.Size(1275, 875);
            this.Load += new System.EventHandler(this.UCNhaCungCap_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
    }
}
