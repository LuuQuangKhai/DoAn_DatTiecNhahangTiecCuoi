namespace GUI
{
    partial class GUI_QuanLyDichVu
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
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtTenLoaiDichVu = new TextBox();
            txtMaLoaiDichVu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            btnLuu2 = new Button();
            btnSua2 = new Button();
            txtHinhAnh = new TextBox();
            btnXoa2 = new Button();
            btnChonAnh = new Button();
            btnThem2 = new Button();
            cboMaLoaiDichVu = new ComboBox();
            txtTenDichVu = new TextBox();
            txtMaDichVu = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenLoaiDichVu);
            groupBox1.Controls.Add(txtMaLoaiDichVu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 765);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý loại dịch vụ";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(366, 250);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(246, 250);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(126, 250);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 250);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoaiDichVu
            // 
            txtTenLoaiDichVu.Location = new Point(112, 139);
            txtTenLoaiDichVu.Name = "txtTenLoaiDichVu";
            txtTenLoaiDichVu.Size = new Size(329, 23);
            txtTenLoaiDichVu.TabIndex = 4;
            // 
            // txtMaLoaiDichVu
            // 
            txtMaLoaiDichVu.Location = new Point(112, 91);
            txtMaLoaiDichVu.Name = "txtMaLoaiDichVu";
            txtMaLoaiDichVu.Size = new Size(329, 23);
            txtMaLoaiDichVu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 142);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên loại dịch vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 94);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã loại dịch vụ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(437, 459);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(btnLuu2);
            groupBox2.Controls.Add(btnSua2);
            groupBox2.Controls.Add(txtHinhAnh);
            groupBox2.Controls.Add(btnXoa2);
            groupBox2.Controls.Add(btnChonAnh);
            groupBox2.Controls.Add(btnThem2);
            groupBox2.Controls.Add(cboMaLoaiDichVu);
            groupBox2.Controls.Add(txtTenDichVu);
            groupBox2.Controls.Add(txtMaDichVu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(458, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(769, 765);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quản lý dịch vụ";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 300);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(757, 459);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // btnLuu2
            // 
            btnLuu2.Location = new Point(525, 250);
            btnLuu2.Name = "btnLuu2";
            btnLuu2.Size = new Size(75, 23);
            btnLuu2.TabIndex = 12;
            btnLuu2.Text = "Lưu";
            btnLuu2.UseVisualStyleBackColor = true;
            btnLuu2.Click += btnLuu2_Click;
            // 
            // btnSua2
            // 
            btnSua2.Location = new Point(405, 250);
            btnSua2.Name = "btnSua2";
            btnSua2.Size = new Size(75, 23);
            btnSua2.TabIndex = 11;
            btnSua2.Text = "Sửa";
            btnSua2.UseVisualStyleBackColor = true;
            btnSua2.Click += btnSua2_Click;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(270, 151);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(238, 23);
            txtHinhAnh.TabIndex = 8;
            // 
            // btnXoa2
            // 
            btnXoa2.Location = new Point(285, 250);
            btnXoa2.Name = "btnXoa2";
            btnXoa2.Size = new Size(75, 23);
            btnXoa2.TabIndex = 10;
            btnXoa2.Text = "Xóa";
            btnXoa2.UseVisualStyleBackColor = true;
            btnXoa2.Click += btnXoa2_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(525, 150);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(75, 23);
            btnChonAnh.TabIndex = 7;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnThem2
            // 
            btnThem2.Location = new Point(165, 250);
            btnThem2.Name = "btnThem2";
            btnThem2.Size = new Size(75, 23);
            btnThem2.TabIndex = 9;
            btnThem2.Text = "Thêm";
            btnThem2.UseVisualStyleBackColor = true;
            btnThem2.Click += btnThem2_Click;
            // 
            // cboMaLoaiDichVu
            // 
            cboMaLoaiDichVu.FormattingEnabled = true;
            cboMaLoaiDichVu.Location = new Point(270, 205);
            cboMaLoaiDichVu.Name = "cboMaLoaiDichVu";
            cboMaLoaiDichVu.Size = new Size(330, 23);
            cboMaLoaiDichVu.TabIndex = 6;
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Location = new Point(270, 97);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(330, 23);
            txtTenDichVu.TabIndex = 5;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.Location = new Point(270, 43);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(330, 23);
            txtMaDichVu.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 208);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 3;
            label6.Text = "Mã loại dịch vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 154);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 2;
            label5.Text = "Hình ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 100);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 1;
            label4.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 46);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã dịch vụ";
            // 
            // GUI_QuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GUI_QuanLyDichVu";
            Size = new Size(1230, 771);
            Load += GUI_QuanLyDichVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtTenLoaiDichVu;
        private TextBox txtMaLoaiDichVu;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnLuu2;
        private Button btnSua2;
        private TextBox txtHinhAnh;
        private Button btnXoa2;
        private Button btnChonAnh;
        private Button btnThem2;
        private ComboBox cboMaLoaiDichVu;
        private TextBox txtTenDichVu;
        private TextBox txtMaDichVu;
        private DataGridView dataGridView2;
    }
}
