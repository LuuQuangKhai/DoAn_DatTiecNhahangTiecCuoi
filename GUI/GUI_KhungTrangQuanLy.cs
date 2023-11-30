using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_KhungTrangQuanLy : Form
    {
        public GUI_KhungTrangQuanLy()
        {
            InitializeComponent();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            GUI_QuanLyDichVu gui = new GUI_QuanLyDichVu();
            gui.Show();
            this.panel1.Controls.Add(gui);
        }
    }
}
