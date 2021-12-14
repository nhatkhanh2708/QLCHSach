
namespace MVP.Views
{
    partial class UCItemCbx
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
            this.lblitem = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblitem
            // 
            this.lblitem.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblitem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblitem.Location = new System.Drawing.Point(0, 0);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(136, 30);
            this.lblitem.TabIndex = 0;
            this.lblitem.Text = "Nguyen Nhat Anh";
            this.lblitem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::MVP.Properties.Resources.icons8_close_22;
            this.btnRemove.Location = new System.Drawing.Point(138, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UCItemCbx
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblitem);
            this.Name = "UCItemCbx";
            this.Size = new System.Drawing.Size(163, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Button btnRemove;
    }
}
