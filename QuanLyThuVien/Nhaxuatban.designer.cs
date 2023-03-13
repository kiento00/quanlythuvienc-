
namespace QuanLyThuVien
{
    partial class frmNxb
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimkiemnxb = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtIDNXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvnhaxuatban = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbotimnxb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaxuatban)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnThem.Location = new System.Drawing.Point(234, 318);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(215, 48);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm / Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXoa.Location = new System.Drawing.Point(485, 317);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 48);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbotimnxb);
            this.groupBox1.Controls.Add(this.txtTimkiemnxb);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenNXB);
            this.groupBox1.Controls.Add(this.txtIDNXB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvnhaxuatban);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1508, 838);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhà Xuất Bản";
            // 
            // txtTimkiemnxb
            // 
            this.txtTimkiemnxb.Location = new System.Drawing.Point(608, 323);
            this.txtTimkiemnxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimkiemnxb.Name = "txtTimkiemnxb";
            this.txtTimkiemnxb.Size = new System.Drawing.Size(383, 43);
            this.txtTimkiemnxb.TabIndex = 15;
            this.txtTimkiemnxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(955, 193);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(383, 43);
            this.txtSDT.TabIndex = 15;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(377, 193);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(383, 43);
            this.txtDiachi.TabIndex = 15;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(955, 114);
            this.txtTenNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(383, 43);
            this.txtTenNXB.TabIndex = 15;
            // 
            // txtIDNXB
            // 
            this.txtIDNXB.Location = new System.Drawing.Point(377, 114);
            this.txtIDNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNXB.Name = "txtIDNXB";
            this.txtIDNXB.Size = new System.Drawing.Size(383, 43);
            this.txtIDNXB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(828, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Địa Chỉ NXB";
            // 
            // dgvnhaxuatban
            // 
            this.dgvnhaxuatban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhaxuatban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhaxuatban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvnhaxuatban.Location = new System.Drawing.Point(0, 414);
            this.dgvnhaxuatban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvnhaxuatban.Name = "dgvnhaxuatban";
            this.dgvnhaxuatban.ReadOnly = true;
            this.dgvnhaxuatban.RowHeadersWidth = 51;
            this.dgvnhaxuatban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhaxuatban.Size = new System.Drawing.Size(1508, 417);
            this.dgvnhaxuatban.TabIndex = 13;
            this.dgvnhaxuatban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhaxuatban_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANXB";
            this.Column1.HeaderText = "Mã NXB";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNXB";
            this.Column2.HeaderText = "Tên NXB";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHINXB";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DIENTHOAIXB";
            this.Column4.HeaderText = "SĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // cbotimnxb
            // 
            this.cbotimnxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotimnxb.FormattingEnabled = true;
            this.cbotimnxb.Items.AddRange(new object[] {
            "Nhà Xuất Bản",
            "Địa Chỉ",
            "SĐT"});
            this.cbotimnxb.Location = new System.Drawing.Point(1027, 317);
            this.cbotimnxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotimnxb.Name = "cbotimnxb";
            this.cbotimnxb.Size = new System.Drawing.Size(242, 45);
            this.cbotimnxb.TabIndex = 16;
            this.cbotimnxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // frmNxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 866);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNxb";
            this.Text = "Nhaxuatban";
            this.Load += new System.EventHandler(this.Nhaxuatban_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaxuatban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvnhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiemnxb;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtIDNXB;
        private System.Windows.Forms.ComboBox cbotimnxb;
    }
}