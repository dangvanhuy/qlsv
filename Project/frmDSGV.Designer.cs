namespace Project
{
    partial class frmDSGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.Button();
            this.txthuy = new System.Windows.Forms.Button();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimkiem.BackColor = System.Drawing.Color.Brown;
            this.txttimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txttimkiem.Location = new System.Drawing.Point(595, 55);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(97, 40);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.Text = "Tìm Kiếm";
            this.txttimkiem.UseVisualStyleBackColor = false;
            this.txttimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txthuy
            // 
            this.txthuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txthuy.BackColor = System.Drawing.Color.Brown;
            this.txthuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txthuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthuy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txthuy.Location = new System.Drawing.Point(698, 55);
            this.txthuy.Name = "txthuy";
            this.txthuy.Size = new System.Drawing.Size(90, 40);
            this.txthuy.TabIndex = 2;
            this.txthuy.Text = "Hủy";
            this.txthuy.UseVisualStyleBackColor = false;
            // 
            // txttukhoa
            // 
            this.txttukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttukhoa.Location = new System.Drawing.Point(410, 62);
            this.txttukhoa.Multiline = true;
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(171, 31);
            this.txttukhoa.TabIndex = 3;
            this.txttukhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.AllowUserToAddRows = false;
            this.dgvDSGV.AllowUserToDeleteRows = false;
            this.dgvDSGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Location = new System.Drawing.Point(0, 111);
            this.dgvDSGV.MultiSelect = false;
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.ReadOnly = true;
            this.dgvDSGV.RowHeadersWidth = 51;
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSGV.Size = new System.Drawing.Size(800, 339);
            this.dgvDSGV.TabIndex = 4;
            this.dgvDSGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellContentClick);
            // 
            // frmDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDSGV);
            this.Controls.Add(this.txttukhoa);
            this.Controls.Add(this.txthuy);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label1);
            this.Name = "frmDSGV";
            this.Text = "Danh Sách Giáo Viên";
            this.Load += new System.EventHandler(this.frmDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txttimkiem;
        private System.Windows.Forms.Button txthuy;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.DataGridView dgvDSGV;
    }
}