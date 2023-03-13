
namespace QuanLyThuVien
{
    partial class frmTheloai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTentheloai = new System.Windows.Forms.TextBox();
            this.txtTimtl = new System.Windows.Forms.TextBox();
            this.txtMatheloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTheloai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtTentheloai);
            this.groupBox1.Controls.Add(this.txtTimtl);
            this.groupBox1.Controls.Add(this.txtMatheloai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvTheloai);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1507, 849);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thể Loại";
            // 
            // txtTentheloai
            // 
            this.txtTentheloai.Location = new System.Drawing.Point(969, 78);
            this.txtTentheloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTentheloai.Name = "txtTentheloai";
            this.txtTentheloai.Size = new System.Drawing.Size(383, 43);
            this.txtTentheloai.TabIndex = 11;
            // 
            // txtTimtl
            // 
            this.txtTimtl.Location = new System.Drawing.Point(729, 183);
            this.txtTimtl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimtl.Name = "txtTimtl";
            this.txtTimtl.Size = new System.Drawing.Size(383, 43);
            this.txtTimtl.TabIndex = 11;
            this.txtTimtl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimtl_KeyUp);
            // 
            // txtMatheloai
            // 
            this.txtMatheloai.Location = new System.Drawing.Point(366, 78);
            this.txtMatheloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatheloai.Name = "txtMatheloai";
            this.txtMatheloai.Size = new System.Drawing.Size(383, 43);
            this.txtMatheloai.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Thể Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Thể Loại";
            // 
            // dgvTheloai
            // 
            this.dgvTheloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTheloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTheloai.Location = new System.Drawing.Point(7, 262);
            this.dgvTheloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTheloai.Name = "dgvTheloai";
            this.dgvTheloai.ReadOnly = true;
            this.dgvTheloai.RowHeadersWidth = 51;
            this.dgvTheloai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheloai.Size = new System.Drawing.Size(1500, 578);
            this.dgvTheloai.TabIndex = 8;
            this.dgvTheloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheloai_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATHELOAI";
            this.Column1.HeaderText = "Mã Thể Loại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTHELOAI";
            this.Column2.HeaderText = "Tên Thể Loại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnThem.Location = new System.Drawing.Point(396, 178);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 47);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm / Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXoa.Location = new System.Drawing.Point(597, 178);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 47);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 866);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTheloai";
            this.Text = "Theloai";
            this.Load += new System.EventHandler(this.Theloai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTheloai;
        private System.Windows.Forms.TextBox txtTimtl;
        private System.Windows.Forms.TextBox txtMatheloai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTentheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}