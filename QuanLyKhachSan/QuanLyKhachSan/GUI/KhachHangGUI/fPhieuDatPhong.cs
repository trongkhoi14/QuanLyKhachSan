﻿using QuanLyKhachSan.BUS;
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
            DsPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayDanhSachPhongTrong();
            label10.Visible = false;
            SoNgTrongDoanTBox.Visible = false;
            NotiLabel.Text = null;
            label1.Visible = false;
        }
        [Obsolete]
        private async void HoanThanhBtn_Click(object sender, EventArgs e)
        {
            //tạo phiếu đặt phòng
            PhieuDatPhongBUS pdp = new PhieuDatPhongBUS();

            pdp.MAPDP = PhieuDatPhongBUS.Instance.KHLayMaPDP();
            pdp.NGAYDEN = NgaydenTimePicker.Value;
            pdp.NGAYLAP = DateTime.Today;
            pdp.SODEMLUUTRU = SoDemLuuTruTBox.Text;

            if (doanCheckBox.Checked) pdp.SONGUOI = SoNgTrongDoanTBox.Text;
            else{
                pdp.SONGUOI = "1";
            }



            int check = PhieuDatPhongBUS.Instance.KHKiemTraThongTinPDP(pdp, DsPhongDataGridView, doanCheckBox.Checked, PhuongThucThanhToanComboBox);
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
                NotiLabel.Text = $"Ngày đến phải là hoặc sau ngày hiện tại: {DateTime.Now.Date.ToString("dd/MM/yyyy")}" ;
            }
            else if (check == 3)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Vui long chọn ít nhất 1 phòng";
            }
            else if (check == 4)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Số người trong đoàn phải lớn hơn 1";
            }
            else if (check == 6)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Vui lòng chọn 1 phương thức thanh toán";
            }
            else if (check == 7)
            {
                NotiLabel.Text = null;
                await Task.Delay(300);
                NotiLabel.Text = "Hai lần đặt phòng gần nhất phải cách nhau ít nhất 5 ngày";
            }
            else
            {
                var ptttoan = "";
                if (PhuongThucThanhToanComboBox.SelectedIndex == 0) {
                    ptttoan = "Tien mat";
                }
                else if (PhuongThucThanhToanComboBox.SelectedIndex == 1)
                {
                    ptttoan = "The tin dung";
                }
                else
                {
                    ptttoan = "Chuyen khoan";
                }

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

                //xác nhận lại phiếu đặt phòng
                var xacnhan = new fXacNhanPDP(pdp, ptttoan, MaPhongChecked);
                this.Hide();
                xacnhan.ShowDialog();
                var choice = xacnhan.ReturnValue;
                this.Show();

                //xác nhận
                if (choice == 1)
                {
                    MessageBox.Show("Đặt phòng thành công\nVui lòng xem hướng dẫn thanh toán", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotiLabel.Text = null;

                    //Lưu phiếu đặt phòng
                    PhieuDatPhongBUS.Instance.KHThemPDP(pdp, PhieuDatPhongBUS.MAKH);

                    //Lưu chi tiết phiếu đặt phòng
                    for (int i = 0; i < MaPhongChecked.Count(); i++)
                    {
                        CTPhieuDatPhongBUS.Instance.KHThemCtPDP(pdp.MAPDP, MaPhongChecked[i]);
                    }

                    //tạo hóa đơn
                    var hoadon = new HoaDonBUS();
                    hoadon.MAHD = HoaDonBUS.Instance.KHGetInvoiceCode();
                    hoadon.MAPDP = pdp.MAPDP;
                    hoadon.NGAYCAPNHAT = DateTime.Today;
                    hoadon.TRANGTHAI = "Chua thanh toan";
                    HoaDonBUS.TIENPHONG = HoaDonBUS.Instance.KHCountRentalFee(hoadon.MAPDP);
                    hoadon.TIENCOC = 0;
                    hoadon.TIENDV = 0;
                    hoadon.PHUTHU = 0;
                    hoadon.TIENNHAN = 0;
                    hoadon.TIENHOAN = 0;
                    HoaDonBUS.PHUONGTHUCTHANHTOAN = ptttoan;

                    //lưu hóa đơn
                    HoaDonBUS.Instance.KHAddInvoice(hoadon,HoaDonBUS.PHUONGTHUCTHANHTOAN);


                    //set các textbox về null
                    DsPhongDataGridView.DataSource = PhieuDatPhongBUS.Instance.KHLayDanhSachPhongTrong();
                    SoDemLuuTruTBox.Text = "";
                    if (doanCheckBox.Checked)
                    {
                        doanCheckBox.Checked = false;
                    }
                    PhuongThucThanhToanComboBox.SelectedIndex = -1;
                }
                //Đặt lại
                else
                {

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
