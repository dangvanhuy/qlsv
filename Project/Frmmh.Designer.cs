namespace Project
{
    partial class Frmmh
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
            this.dgvmh = new System.Windows.Forms.DataGridView();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmh
            // 
            this.dgvmh.AllowUserToAddRows = false;
            this.dgvmh.AllowUserToDeleteRows = false;
            this.dgvmh.AllowUserToResizeRows = false;
            this.dgvmh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmh.Location = new System.Drawing.Point(0, 143);
            this.dgvmh.Name = "dgvmh";
            this.dgvmh.ReadOnly = true;
            this.dgvmh.RowHeadersWidth = 51;
            this.dgvmh.RowTemplate.Height = 24;
            this.dgvmh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmh.ShowRowErrors = false;
            this.dgvmh.Size = new System.Drawing.Size(800, 307);
            this.dgvmh.TabIndex = 0;
            this.dgvmh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmh_CellContentClick);
            // 
            // txttukhoa
            // 
            this.txttukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttukhoa.Location = new System.Drawing.Point(352, 100);
            this.txttukhoa.Multiline = true;
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(203, 33);
            this.txttukhoa.TabIndex = 1;
            this.txttukhoa.TextChanged += new System.EventHandler(this.txttukhoa_TextChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntimkiem.BackColor = System.Drawing.Color.Brown;
            this.btntimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntimkiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btntimkiem.Location = new System.Drawing.Point(561, 100);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(109, 37);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.BackColor = System.Drawing.Color.Brown;
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnthem.Location = new System.Drawing.Point(688, 100);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 37);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ khóa";
            // 
            // Frmmh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttukhoa);
            this.Controls.Add(this.dgvmh);
            this.Name = "Frmmh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm môn học";
            this.Load += new System.EventHandler(this.Frmmh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmh;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
    }
}