namespace MVP.Views
{
    partial class SupportPickTacGia
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
            this.labelDSTG = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimKiem.Location = new System.Drawing.Point(11, 11);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(412, 43);
            this.textBoxTimKiem.TabIndex = 67;
            // 
            // labelDSTG
            // 
            this.labelDSTG.AutoSize = true;
            this.labelDSTG.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDSTG.Location = new System.Drawing.Point(11, 79);
            this.labelDSTG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDSTG.Name = "labelDSTG";
            this.labelDSTG.Size = new System.Drawing.Size(248, 37);
            this.labelDSTG.TabIndex = 83;
            this.labelDSTG.Text = "Danh Sách Tác Giả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(771, 396);
            this.dataGridView1.TabIndex = 84;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Image = global::MVP.Properties.Resources.search;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.Location = new System.Drawing.Point(316, 11);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(107, 43);
            this.buttonTimKiem.TabIndex = 93;
            this.buttonTimKiem.Text = "Tìm";
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // buttonChon
            // 
            this.buttonChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChon.ForeColor = System.Drawing.Color.White;
            this.buttonChon.Image = global::MVP.Properties.Resources.them;
            this.buttonChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChon.Location = new System.Drawing.Point(524, 558);
            this.buttonChon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(124, 63);
            this.buttonChon.TabIndex = 96;
            this.buttonChon.Text = "Chọn";
            this.buttonChon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChon.UseVisualStyleBackColor = true;
            // 
            // buttonHuy
            // 
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHuy.ForeColor = System.Drawing.Color.White;
            this.buttonHuy.Image = global::MVP.Properties.Resources.delete;
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(696, 558);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(102, 63);
            this.buttonHuy.TabIndex = 95;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // SupportPickTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 730);
            this.Controls.Add(this.buttonChon);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDSTG);
            this.Controls.Add(this.textBoxTimKiem);
            this.Name = "SupportPickTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupportPickTacGia";
            this.Load += new System.EventHandler(this.SupportPickTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label labelDSTG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Button buttonHuy;
    }
}