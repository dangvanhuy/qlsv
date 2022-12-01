namespace Project
{
    partial class Frmdsmh
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
            this.dgvDSLH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLH
            // 
            this.dgvDSLH.AllowUserToAddRows = false;
            this.dgvDSLH.AllowUserToDeleteRows = false;
            this.dgvDSLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLH.Location = new System.Drawing.Point(0, 0);
            this.dgvDSLH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSLH.MultiSelect = false;
            this.dgvDSLH.Name = "dgvDSLH";
            this.dgvDSLH.ReadOnly = true;
            this.dgvDSLH.RowHeadersWidth = 51;
            this.dgvDSLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLH.Size = new System.Drawing.Size(1159, 643);
            this.dgvDSLH.TabIndex = 1;
            this.dgvDSLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLH_CellContentClick);
            // 
            // Frmdsmh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 643);
            this.Controls.Add(this.dgvDSLH);
            this.Name = "Frmdsmh";
            this.Text = "Danh sách môn học";
            this.Load += new System.EventHandler(this.Frmdsmh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSLH;
    }
}