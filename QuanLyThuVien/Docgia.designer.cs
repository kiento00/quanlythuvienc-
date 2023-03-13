
namespace QuanLyThuVien
{
    partial class frmDocgia
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
            this.dgvdg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoadg = new System.Windows.Forms.Button();
            this.btnthemsuadg = new System.Windows.Forms.Button();
            this.txttimdg = new System.Windows.Forms.TextBox();
            this.txtsdtdg = new System.Windows.Forms.TextBox();
            this.txtdiachidg = new System.Windows.Forms.TextBox();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.txttendg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotimdg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdg
            // 
            this.dgvdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvdg.Location = new System.Drawing.Point(6, 331);
            this.dgvdg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvdg.Name = "dgvdg";
            this.dgvdg.ReadOnly = true;
            this.dgvdg.RowHeadersWidth = 51;
            this.dgvdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdg.Size = new System.Drawing.Size(1495, 507);
            this.dgvdg.TabIndex = 9;
            this.dgvdg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdg_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MADOCGIA";
            this.Column1.HeaderText = "Mã Độc Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDOCGIA";
            this.Column2.HeaderText = "Tên Độc Giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDTDOCGIA";
            this.Column4.HeaderText = "SĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbotimdg);
            this.groupBox1.Controls.Add(this.dgvdg);
            this.groupBox1.Controls.Add(this.btnxoadg);
            this.groupBox1.Controls.Add(this.btnthemsuadg);
            this.groupBox1.Controls.Add(this.txttimdg);
            this.groupBox1.Controls.Add(this.txtsdtdg);
            this.groupBox1.Controls.Add(this.txtdiachidg);
            this.groupBox1.Controls.Add(this.txtmadg);
            this.groupBox1.Controls.Add(this.txttendg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1507, 838);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đọc Giả";
            // 
            // btnxoadg
            // 
            this.btnxoadg.Location = new System.Drawing.Point(459, 250);
            this.btnxoadg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoadg.Name = "btnxoadg";
            this.btnxoadg.Size = new System.Drawing.Size(87, 43);
            this.btnxoadg.TabIndex = 2;
            this.btnxoadg.Text = "Xoá";
            this.btnxoadg.UseVisualStyleBackColor = true;
            this.btnxoadg.Click += new System.EventHandler(this.btnxoadg_Click);
            // 
            // btnthemsuadg
            // 
            this.btnthemsuadg.Location = new System.Drawing.Point(240, 250);
            this.btnthemsuadg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemsuadg.Name = "btnthemsuadg";
            this.btnthemsuadg.Size = new System.Drawing.Size(173, 43);
            this.btnthemsuadg.TabIndex = 2;
            this.btnthemsuadg.Text = "Thêm / Sửa";
            this.btnthemsuadg.UseVisualStyleBackColor = true;
            this.btnthemsuadg.Click += new System.EventHandler(this.btnthemsuadg_Click);
            // 
            // txttimdg
            // 
            this.txttimdg.Location = new System.Drawing.Point(592, 250);
            this.txttimdg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimdg.Name = "txttimdg";
            this.txttimdg.Size = new System.Drawing.Size(399, 42);
            this.txttimdg.TabIndex = 1;
            this.txttimdg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimdg_KeyUp);
            // 
            // txtsdtdg
            // 
            this.txtsdtdg.Location = new System.Drawing.Point(872, 146);
            this.txtsdtdg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsdtdg.Name = "txtsdtdg";
            this.txtsdtdg.Size = new System.Drawing.Size(383, 42);
            this.txtsdtdg.TabIndex = 1;
            // 
            // txtdiachidg
            // 
            this.txtdiachidg.Location = new System.Drawing.Point(308, 146);
            this.txtdiachidg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdiachidg.Name = "txtdiachidg";
            this.txtdiachidg.Size = new System.Drawing.Size(383, 42);
            this.txtdiachidg.TabIndex = 1;
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(308, 79);
            this.txtmadg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(383, 42);
            this.txtmadg.TabIndex = 1;
            // 
            // txttendg
            // 
            this.txttendg.Location = new System.Drawing.Point(872, 79);
            this.txttendg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttendg.Name = "txttendg";
            this.txttendg.Size = new System.Drawing.Size(383, 42);
            this.txttendg.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Độc Giả";
            // 
            // cbotimdg
            // 
            this.cbotimdg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotimdg.FormattingEnabled = true;
            this.cbotimdg.Items.AddRange(new object[] {
            "Độc Giả",
            "Địa Chỉ",
            "SĐT"});
            this.cbotimdg.Location = new System.Drawing.Point(1037, 250);
            this.cbotimdg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotimdg.Name = "cbotimdg";
            this.cbotimdg.Size = new System.Drawing.Size(242, 44);
            this.cbotimdg.TabIndex = 17;
            // 
            // frmDocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 866);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDocgia";
            this.Text = "Docgia";
            this.Load += new System.EventHandler(this.frmDocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoadg;
        private System.Windows.Forms.Button btnthemsuadg;
        private System.Windows.Forms.TextBox txttimdg;
        private System.Windows.Forms.TextBox txtdiachidg;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.TextBox txttendg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsdtdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbotimdg;
    }
}