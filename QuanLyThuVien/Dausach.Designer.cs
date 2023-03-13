
namespace QuanLyThuVien
{
    partial class frmDausach
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
            this.cbotg = new System.Windows.Forms.ComboBox();
            this.cbotimds = new System.Windows.Forms.ComboBox();
            this.cbonxb = new System.Windows.Forms.ComboBox();
            this.cbotl = new System.Windows.Forms.ComboBox();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoads = new System.Windows.Forms.Button();
            this.btnthemsuads = new System.Windows.Forms.Button();
            this.txttimds = new System.Windows.Forms.TextBox();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.txtmads = new System.Windows.Forms.TextBox();
            this.txttends = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbotg);
            this.groupBox1.Controls.Add(this.cbotimds);
            this.groupBox1.Controls.Add(this.cbonxb);
            this.groupBox1.Controls.Add(this.cbotl);
            this.groupBox1.Controls.Add(this.dgvds);
            this.groupBox1.Controls.Add(this.btnxoads);
            this.groupBox1.Controls.Add(this.btnthemsuads);
            this.groupBox1.Controls.Add(this.txttimds);
            this.groupBox1.Controls.Add(this.txtnamxb);
            this.groupBox1.Controls.Add(this.txtmads);
            this.groupBox1.Controls.Add(this.txttends);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1505, 837);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đầu Sách";
            // 
            // cbotg
            // 
            this.cbotg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotg.FormattingEnabled = true;
            this.cbotg.Location = new System.Drawing.Point(976, 122);
            this.cbotg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotg.Name = "cbotg";
            this.cbotg.Size = new System.Drawing.Size(383, 44);
            this.cbotg.TabIndex = 3;
            // 
            // cbotimds
            // 
            this.cbotimds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotimds.FormattingEnabled = true;
            this.cbotimds.Items.AddRange(new object[] {
            "Sách",
            "Thể Loại",
            "Tác Giả",
            "Nhà Xuất Bản"});
            this.cbotimds.Location = new System.Drawing.Point(1071, 263);
            this.cbotimds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotimds.Name = "cbotimds";
            this.cbotimds.Size = new System.Drawing.Size(242, 44);
            this.cbotimds.TabIndex = 3;
            // 
            // cbonxb
            // 
            this.cbonxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonxb.FormattingEnabled = true;
            this.cbonxb.Location = new System.Drawing.Point(308, 191);
            this.cbonxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbonxb.Name = "cbonxb";
            this.cbonxb.Size = new System.Drawing.Size(383, 44);
            this.cbonxb.TabIndex = 3;
            // 
            // cbotl
            // 
            this.cbotl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotl.FormattingEnabled = true;
            this.cbotl.Location = new System.Drawing.Point(308, 123);
            this.cbotl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotl.Name = "cbotl";
            this.cbotl.Size = new System.Drawing.Size(383, 44);
            this.cbotl.TabIndex = 3;
            // 
            // dgvds
            // 
            this.dgvds.AllowUserToAddRows = false;
            this.dgvds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvds.Location = new System.Drawing.Point(0, 335);
            this.dgvds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvds.Name = "dgvds";
            this.dgvds.ReadOnly = true;
            this.dgvds.RowHeadersWidth = 51;
            this.dgvds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvds.Size = new System.Drawing.Size(1500, 502);
            this.dgvds.TabIndex = 1;
            this.dgvds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASACH";
            this.Column1.HeaderText = "Mã Đầu Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSACH";
            this.Column2.HeaderText = "Tên Đầu Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENTHELOAI";
            this.Column3.HeaderText = "Tên Thể Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TENTACGIA";
            this.Column4.HeaderText = "Tên Tác Giả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TENNXB";
            this.Column5.HeaderText = "Tên NXB";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NAMXUATBAN";
            this.Column6.HeaderText = "Năm Xuất Bản";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnxoads
            // 
            this.btnxoads.Location = new System.Drawing.Point(499, 263);
            this.btnxoads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoads.Name = "btnxoads";
            this.btnxoads.Size = new System.Drawing.Size(87, 43);
            this.btnxoads.TabIndex = 2;
            this.btnxoads.Text = "Xoá";
            this.btnxoads.UseVisualStyleBackColor = true;
            this.btnxoads.Click += new System.EventHandler(this.btnxoads_Click);
            // 
            // btnthemsuads
            // 
            this.btnthemsuads.Location = new System.Drawing.Point(283, 263);
            this.btnthemsuads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemsuads.Name = "btnthemsuads";
            this.btnthemsuads.Size = new System.Drawing.Size(173, 43);
            this.btnthemsuads.TabIndex = 2;
            this.btnthemsuads.Text = "Thêm / Sửa";
            this.btnthemsuads.UseVisualStyleBackColor = true;
            this.btnthemsuads.Click += new System.EventHandler(this.btnthemsuads_Click);
            // 
            // txttimds
            // 
            this.txttimds.Location = new System.Drawing.Point(629, 263);
            this.txttimds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimds.Name = "txttimds";
            this.txttimds.Size = new System.Drawing.Size(399, 42);
            this.txttimds.TabIndex = 1;
            this.txttimds.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimds_KeyUp);
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(976, 190);
            this.txtnamxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(383, 42);
            this.txtnamxb.TabIndex = 1;
            // 
            // txtmads
            // 
            this.txtmads.Location = new System.Drawing.Point(308, 57);
            this.txtmads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmads.Name = "txtmads";
            this.txtmads.Size = new System.Drawing.Size(383, 42);
            this.txtmads.TabIndex = 1;
            // 
            // txttends
            // 
            this.txttends.Location = new System.Drawing.Point(976, 57);
            this.txttends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttends.Name = "txttends";
            this.txttends.Size = new System.Drawing.Size(383, 42);
            this.txttends.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(765, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà Xuất Bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Đầu Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đầu Sách";
            // 
            // frmDausach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 866);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDausach";
            this.Text = "Dausach";
            this.Load += new System.EventHandler(this.frmDausach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.Button btnxoads;
        private System.Windows.Forms.Button btnthemsuads;
        private System.Windows.Forms.TextBox txttimds;
        private System.Windows.Forms.TextBox txttends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbotg;
        private System.Windows.Forms.ComboBox cbotimds;
        private System.Windows.Forms.ComboBox cbonxb;
        private System.Windows.Forms.ComboBox cbotl;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.TextBox txtmads;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}