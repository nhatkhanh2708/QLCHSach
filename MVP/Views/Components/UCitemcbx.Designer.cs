
namespace MVP.Views
{
    partial class UCitemcbx
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblitem
            // 
            this.lblitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblitem.Location = new System.Drawing.Point(0, 0);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(220, 32);
            this.lblitem.TabIndex = 0;
            this.lblitem.Text = "Nguyen Nhat Anh";
            this.lblitem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Image = global::MVP.Properties.Resources.icons8_close_22;
            this.btnDelete.Location = new System.Drawing.Point(180, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // UCitemcbx
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblitem);
            this.Name = "UCitemcbx";
            this.Size = new System.Drawing.Size(220, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Button btnDelete;
    }
}
