
namespace QuanLyThuVien
{
    partial class frmTacgia
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
            this.dgvtacgia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoatg = new System.Windows.Forms.Button();
            this.btnthemsuatg = new System.Windows.Forms.Button();
            this.txtTimkiemtg = new System.Windows.Forms.TextBox();
            this.txttentg = new System.Windows.Forms.TextBox();
            this.txtmatg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgvtacgia);
            this.groupBox1.Controls.Add(this.btnxoatg);
            this.groupBox1.Controls.Add(this.btnthemsuatg);
            this.groupBox1.Controls.Add(this.txtTimkiemtg);
            this.groupBox1.Controls.Add(this.txttentg);
            this.groupBox1.Controls.Add(this.txtmatg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1505, 837);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Giả";
            // 
            // dgvtacgia
            // 
            this.dgvtacgia.AllowUserToAddRows = false;
            this.dgvtacgia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvtacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvtacgia.Location = new System.Drawing.Point(7, 262);
            this.dgvtacgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvtacgia.Name = "dgvtacgia";
            this.dgvtacgia.RowHeadersWidth = 51;
            this.dgvtacgia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtacgia.Size = new System.Drawing.Size(1505, 567);
            this.dgvtacgia.TabIndex = 1;
            this.dgvtacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtacgia_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATACGIA";
            this.Column1.HeaderText = "Mã Tác Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTACGIA";
            this.Column2.HeaderText = "Tên Tác Giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnxoatg
            // 
            this.btnxoatg.Location = new System.Drawing.Point(596, 180);
            this.btnxoatg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoatg.Name = "btnxoatg";
            this.btnxoatg.Size = new System.Drawing.Size(87, 43);
            this.btnxoatg.TabIndex = 2;
            this.btnxoatg.Text = "Xoá";
            this.btnxoatg.UseVisualStyleBackColor = true;
            this.btnxoatg.Click += new System.EventHandler(this.btnxoatg_Click);
            // 
            // btnthemsuatg
            // 
            this.btnthemsuatg.Location = new System.Drawing.Point(366, 180);
            this.btnthemsuatg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemsuatg.Name = "btnthemsuatg";
            this.btnthemsuatg.Size = new System.Drawing.Size(173, 43);
            this.btnthemsuatg.TabIndex = 2;
            this.btnthemsuatg.Text = "Thêm / Sửa";
            this.btnthemsuatg.UseVisualStyleBackColor = true;
            this.btnthemsuatg.Click += new System.EventHandler(this.btnthemsuatg_Click);
            // 
            // txtTimkiemtg
            // 
            this.txtTimkiemtg.Location = new System.Drawing.Point(739, 181);
            this.txtTimkiemtg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimkiemtg.Name = "txtTimkiemtg";
            this.txtTimkiemtg.Size = new System.Drawing.Size(399, 42);
            this.txtTimkiemtg.TabIndex = 1;
            this.txtTimkiemtg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimkiemtg_KeyUp);
            // 
            // txttentg
            // 
            this.txttentg.Location = new System.Drawing.Point(969, 78);
            this.txttentg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(383, 42);
            this.txttentg.TabIndex = 1;
            // 
            // txtmatg
            // 
            this.txtmatg.Location = new System.Drawing.Point(366, 78);
            this.txtmatg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatg.Name = "txtmatg";
            this.txtmatg.Size = new System.Drawing.Size(383, 42);
            this.txtmatg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tác Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tác Giả";
            // 
            // frmTacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 866);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTacgia";
            this.Text = "Tacgia";
            this.Load += new System.EventHandler(this.frmTacgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoatg;
        private System.Windows.Forms.Button btnthemsuatg;
        private System.Windows.Forms.TextBox txtTimkiemtg;
        private System.Windows.Forms.TextBox txttentg;
        private System.Windows.Forms.TextBox txtmatg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}