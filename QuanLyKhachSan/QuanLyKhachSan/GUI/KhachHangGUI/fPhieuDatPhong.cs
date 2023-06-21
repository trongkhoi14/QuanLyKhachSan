using QuanLyKhachSan.BUS;
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

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    public partial class fPhieuDatPhong : Form
    {
        public fPhieuDatPhong()
        {
            InitializeComponent();
            DsPhongDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DsPhongDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        

            var checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DefaultCellStyle.NullValue = false;
            DsPhongDataGridView.Columns.Add(checkBoxColumn);
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "Select";
        }

        [Obsolete]
        private void fPhieuDatPhong_Load(object sender, EventArgs e)
        {
            DsPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayDanhSachPDP();
            label10.Visible = false;
            SoNgTrongDoanTBox.Visible = false;
            NotiLabel.Text = null;
            label1.Visible = false;
        }
        private void DsPhongDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int checkedColumnIndex = DsPhongDataGridView.Columns["Select"].Index;
            foreach (DataGridViewRow row in this.DsPhongDataGridView.Rows)
            {
                if (row.Cells[checkedColumnIndex].Value == null)
                {
                    bool isChecked = (bool)row.Cells[checkedColumnIndex].FormattedValue;
                    row.Cells[checkedColumnIndex].Value = isChecked;
                }
            }
        }
        [Obsolete]
        private async void HoanThanhBtn_Click(object sender, EventArgs e)
        {
            PhieuDatPhongBUS pdp = new PhieuDatPhongBUS();

            pdp.MAPDP = PhieuDatPhongBUS.Instance.KHLayMaPDP();
            pdp.NGAYDEN = NgaydenTimePicker.Value;
            pdp.NGAYLAP = DateTime.Today;
            pdp.SODEMLUUTRU = SoDemLuuTruTBox.Text;

            if (doanCheckBox.Checked) pdp.SONGUOI = SoNgTrongDoanTBox.Text;
            else{
                pdp.SONGUOI = "1";
            }


            int check = PhieuDatPhongBUS.Instance.KHKiemTraThongTinPDP(pdp, DsPhongDataGridView, doanCheckBox.Checked);
            if (check == 0)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Vui lòng điền đầy đủ thông tin";

            }
            else if (check == 1)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Số người trong đoàn hoặc số đêm lưu trú phải là số nguyên dương";
            }
            else if (check == 2)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = $"Ngày đến phải sau ngày hiện tại: {DateTime.Now.Date.ToString("dd/MM/yyyy")}" ;
            }
            else if (check == 3)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Vui long chọn 1 trong các phòng trên";
            }
            else if (check == 4)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Số người trong đoàn phải lớn hơn 1";
            }
            else
            {
                MessageBox.Show("Đặt phòng thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotiLabel.Text = null;

                //Lưu phiếu đặt phòng
                PhieuDatPhongBUS.Instance.KHThemPDP(pdp);

                //Lấy ds các mã phòng đã chọn
                List<string> MaPhongChecked = new List<string>();
                foreach (DataGridViewRow row in DsPhongDataGridView.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(checkBoxCell.Value) == true)
                    {
                        MaPhongChecked.Add(row.Cells["MAPHONG"].Value.ToString());
                    }
                }
                //Lưu chi tiết phiếu đặt phòng
                for (int i = 0; i < MaPhongChecked.Count(); i++)
                {
                    CTPhieuDatPhongBUS.Instance.KHThemCtPDP(pdp.MAPDP, MaPhongChecked[i]);
                }


                DsPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayDanhSachPDP();
                SoDemLuuTruTBox.Text = "";
                if (doanCheckBox.Checked)
                {
                    doanCheckBox.Checked = false;
                }
            }
        }

        private void doanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(label10.Visible == false) {
                label10.Visible = true;
                SoNgTrongDoanTBox.Visible = true;
                label1.Visible = true;
            }
            else
            {
                label10.Visible = false;
                SoNgTrongDoanTBox.Visible = false;
                label1.Visible = false;
            }
        }
    }
}
