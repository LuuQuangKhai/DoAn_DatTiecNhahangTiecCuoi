using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GUI_QuanLyDichVu : UserControl
    {
        BLL_LoaiDichVu bll_loaidichvu = new BLL_LoaiDichVu();
        BLL_DichVu bll_dichvu = new BLL_DichVu();

        int luachon = 0;
        int luachon2 = 0;
        public GUI_QuanLyDichVu()
        {
            InitializeComponent();
        }

        private async void LayDanhSach()
        {
            dataGridView1.DataSource = await bll_loaidichvu.GetLoaiDichVu();
        }

        private async void LayDanhSachDichVu()
        {
            dataGridView2.DataSource = await bll_dichvu.GetAll();
        }

        private async void LoadComboBoxDichVu()
        {
            cboMaLoaiDichVu.Items.Clear();
            List<DTO_LoaiDichVu> ds = await bll_loaidichvu.GetLoaiDichVu();

            foreach(DTO_LoaiDichVu d in ds)
            {
                cboMaLoaiDichVu.Items.Add(d.MaLoaiDichVu);
            }
        }

        private async void Them()
        {
            if (txtMaLoaiDichVu.Text.Trim().Equals("") || txtTenLoaiDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (await bll_loaidichvu.FindLoaiDichVu(txtMaLoaiDichVu.Text.Trim()) == true)
                {
                    MessageBox.Show("Mã loại dịch vụ đã tồn tại!");
                }
                else
                {
                    DTO_LoaiDichVu dto = new DTO_LoaiDichVu();
                    dto.MaLoaiDichVu = txtMaLoaiDichVu.Text.Trim();
                    dto.TenLoaiDichVu = txtTenLoaiDichVu.Text.Trim();

                    bool ketqua = await bll_loaidichvu.AddLoaiDichVu(dto);

                    if (ketqua == true)
                    {
                        MessageBox.Show("Thêm thành công.");
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!!");
                    }
                }
            }
        }

        private async void Xoa()
        {
            if (txtMaLoaiDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại dịch vụ không được để trống!");
            }
            else
            {
                if (await bll_loaidichvu.FindLoaiDichVu(txtMaLoaiDichVu.Text.Trim()) == true)
                {
                    bool ketqua = await bll_loaidichvu.DeleteLoaiDichVu(txtMaLoaiDichVu.Text.Trim());
                    if (ketqua == true)
                    {
                        MessageBox.Show("Xóa thành công.");
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã loại dịch vụ không tồn tại");
                }
            }
        }

        private async void Sua()
        {
            if (txtMaLoaiDichVu.Text.Trim().Equals("") || txtTenLoaiDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else
            {
                if (await bll_loaidichvu.FindLoaiDichVu(txtMaLoaiDichVu.Text.Trim()) == true)
                {
                    DTO_LoaiDichVu dto = new DTO_LoaiDichVu();
                    dto.MaLoaiDichVu = txtMaLoaiDichVu.Text.Trim();
                    dto.TenLoaiDichVu = txtTenLoaiDichVu.Text.Trim();

                    bool ketqua = await bll_loaidichvu.UpdateLoaiDichVu(dto);

                    if (ketqua == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã loại dịch vụ không tồn tại!");
                }
            }
        }

        private async void ThemDichVu()
        {
            if (txtMaDichVu.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals("") || txtHinhAnh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin dịch vụ không được để trống!");
            }
            else
            {
                if (await bll_dichvu.Find(txtMaDichVu.Text.Trim()) == true)
                {
                    MessageBox.Show("Mã dịch vụ đã tồn tại!");
                }
                else
                {
                    DTO_DichVu dto = new DTO_DichVu();
                    dto.MaDichVu = txtMaDichVu.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.HinhAnh = txtHinhAnh.Text.Trim();
                    dto.MaLoaiDichVu = cboMaLoaiDichVu.Text;    

                    bool ketqua = await bll_dichvu.Add(dto);

                    if (ketqua == true)
                    {
                        MessageBox.Show("Thêm thành công.");
                        LamMoiDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!!");
                    }
                }
            }
        }

        private async void XoaDichVu()
        {
            if (txtMaDichVu.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals("") || txtHinhAnh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã dịch vụ không được để trống!");
            }
            else
            {
                if (await bll_dichvu.Find(txtMaDichVu.Text.Trim()) == true)
                {
                    bool ketqua = await bll_dichvu.Delete(txtMaDichVu.Text.Trim());
                    if (ketqua == true)
                    {
                        MessageBox.Show("Xóa thành công.");
                        LamMoiDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ không tồn tại");
                }
            }
        }

        private async void SuaDichVu()
        {
            if (txtMaDichVu.Text.Trim().Equals("") || txtTenDichVu.Text.Trim().Equals("") || txtHinhAnh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã dịch vụ không được để trống!");
            }
            else
            {
                if (await bll_dichvu.Find(txtMaDichVu.Text.Trim()) == true)
                {
                    DTO_DichVu dto = new DTO_DichVu();
                    dto.MaDichVu = txtMaDichVu.Text.Trim();
                    dto.TenDichVu = txtTenDichVu.Text.Trim();
                    dto.HinhAnh = txtHinhAnh.Text.Trim();
                    dto.MaLoaiDichVu = cboMaLoaiDichVu.Text;

                    bool ketqua = await bll_dichvu.Update(dto);

                    if (ketqua == true)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        LamMoiDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ không tồn tại");
                }
            }
        }


        private void LamMoi()
        {
            txtMaLoaiDichVu.Enabled = false;
            txtTenLoaiDichVu.Enabled = false;

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            txtMaLoaiDichVu.Text = "";
            txtTenLoaiDichVu.Text = "";

            LayDanhSach();
        }

        private void LamMoiDichVu()
        {
            txtMaDichVu.Enabled = false;
            txtTenDichVu.Enabled = false;
            txtHinhAnh.Enabled = false;
            cboMaLoaiDichVu.Enabled = false;

            btnLuu2.Enabled = false;
            btnThem2.Enabled = true;
            btnXoa2.Enabled = true;
            btnSua2.Enabled = true;

            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            txtHinhAnh.Text = "";
            cboMaLoaiDichVu.Text = "";

            LayDanhSachDichVu();
            LoadComboBoxDichVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLoaiDichVu.Enabled = true;
            txtTenLoaiDichVu.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            luachon = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaLoaiDichVu.Enabled = true;
            txtTenLoaiDichVu.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            luachon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaLoaiDichVu.Enabled = true;
            txtTenLoaiDichVu.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            luachon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luachon == 1)
            {
                Them();
            }
            if (luachon == 2)
            {
                Xoa();
            }
            if (luachon == 3)
            {
                Sua();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaLoaiDichVu.Text = row.Cells["MaLoaiDichVu"].Value.ToString();
                txtTenLoaiDichVu.Text = row.Cells["TenLoaiDichVu"].Value.ToString();
            }
        }

        private void GUI_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            LamMoi();
            LamMoiDichVu();
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtHinhAnh.Enabled = true;
            cboMaLoaiDichVu.Enabled = true;

            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnSua2.Enabled = false;

            luachon2 = 1;
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = true;
            txtTenDichVu.Enabled = false;
            txtHinhAnh.Enabled = false;
            cboMaLoaiDichVu.Enabled = false;

            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnSua2.Enabled = false;

            luachon2 = 2;
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtHinhAnh.Enabled = true;
            cboMaLoaiDichVu.Enabled = true;

            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnSua2.Enabled = false;

            luachon2 = 3;
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            if(luachon2==1)
            {
                ThemDichVu();
            }
            if(luachon2==2)
            {
                XoaDichVu();
            }
            if(luachon2==3)
            {
                SuaDichVu();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                txtMaDichVu.Text = row.Cells["MaDichVu"].Value.ToString();
                txtTenDichVu.Text = row.Cells["TenDichVu"].Value.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                cboMaLoaiDichVu.Text = row.Cells["MaLoaiDichVu"].Value.ToString();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    txtHinhAnh.Text = selectedImagePath;
                }
            }
        }
    }
}
