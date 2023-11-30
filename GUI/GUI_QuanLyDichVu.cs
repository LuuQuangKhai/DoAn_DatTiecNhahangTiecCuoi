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
        int luachon = 0;
        public GUI_QuanLyDichVu()
        {
            InitializeComponent();
        }

        private async void LayDanhSach()
        {
            dataGridView1.DataSource = await bll_loaidichvu.GetLoaiDichVu();
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
            if(luachon ==2)
            {
                Xoa();
            }
            if(luachon == 3)
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
        }
    }
}
