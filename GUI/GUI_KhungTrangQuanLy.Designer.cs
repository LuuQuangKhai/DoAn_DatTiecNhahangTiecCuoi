namespace GUI
{
    partial class GUI_KhungTrangQuanLy
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
            menuStrip1 = new MenuStrip();
            qToolStripMenuItem = new ToolStripMenuItem();
            dịchVụToolStripMenuItem = new ToolStripMenuItem();
            dịchVụTínhPhíToolStripMenuItem = new ToolStripMenuItem();
            dịchVụƯuĐãiToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { qToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1230, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // qToolStripMenuItem
            // 
            qToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dịchVụToolStripMenuItem, dịchVụTínhPhíToolStripMenuItem, dịchVụƯuĐãiToolStripMenuItem });
            qToolStripMenuItem.Name = "qToolStripMenuItem";
            qToolStripMenuItem.Size = new Size(102, 20);
            qToolStripMenuItem.Text = "Quản lý dịch vụ";
            // 
            // dịchVụToolStripMenuItem
            // 
            dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            dịchVụToolStripMenuItem.Size = new Size(180, 22);
            dịchVụToolStripMenuItem.Text = "Dịch vụ";
            dịchVụToolStripMenuItem.Click += dịchVụToolStripMenuItem_Click;
            // 
            // dịchVụTínhPhíToolStripMenuItem
            // 
            dịchVụTínhPhíToolStripMenuItem.Name = "dịchVụTínhPhíToolStripMenuItem";
            dịchVụTínhPhíToolStripMenuItem.Size = new Size(180, 22);
            dịchVụTínhPhíToolStripMenuItem.Text = "Dịch vụ tính phí";
            // 
            // dịchVụƯuĐãiToolStripMenuItem
            // 
            dịchVụƯuĐãiToolStripMenuItem.Name = "dịchVụƯuĐãiToolStripMenuItem";
            dịchVụƯuĐãiToolStripMenuItem.Size = new Size(180, 22);
            dịchVụƯuĐãiToolStripMenuItem.Text = "Dịch vụ ưu đãi";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 771);
            panel1.TabIndex = 1;
            // 
            // GUI_KhungTrangQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 800);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "GUI_KhungTrangQuanLy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_KhungTrangQuanLy";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem qToolStripMenuItem;
        private ToolStripMenuItem dịchVụToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem dịchVụTínhPhíToolStripMenuItem;
        private ToolStripMenuItem dịchVụƯuĐãiToolStripMenuItem;
    }
}