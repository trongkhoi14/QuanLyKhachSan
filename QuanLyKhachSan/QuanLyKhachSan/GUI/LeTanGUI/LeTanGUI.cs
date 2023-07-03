using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.LeTanGUI
{
    public partial class LeTanGUI : Form
    {
        public LeTanGUI()
        {
            InitializeComponent();
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInGUI c = new CheckInGUI();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutGUI f = new CheckOutGUI();
        private void lậpPhiếuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuDichVu f = new LapPhieuDichVu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
