using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    public partial class fThanhToan : Form
    {
        public fThanhToan()
        {
            InitializeComponent();
            ThanhToanLabel.Text = null;
        }

        [Obsolete]
        private void fThanhToan_Load(object sender, EventArgs e)
        {
            string mapdpGanNhat = PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH);
            var temp = HoaDonBUS.Instance.KHCountRentalFee(mapdpGanNhat);

            chuyenKhoanTBox.Text += "Vui lòng chuyển khoản tiền cọc vào tài khoản sau, chậm nhất là vào ngày đến\r\n" +
                                    "Momo: 0856353295\r\n" +
                                    "Tên tài khoản: Lâm Nhựt Trường\r\n" +
                                   $"Số tiền: {(temp * 0.3).ToString()}.000 vnd\r\n" +
                                   $"Nội dung: Tien coc phieu dat phong {mapdpGanNhat}\r\n" +
                                   $"(Lưu ý: Nếu khách hàng không chuyển đúng nội dung, hệ thống sẽ không thể tự cập nhật hóa đơn)";
            ChuYTBox.Text += "+ Chúng tôi không chịu trách nhiệm với những đơn hàng chuyển không đủ tiền.\r\n" +
                            "+ Chúng tôi không chịu trách nhiệm với những giao dịch chuyển sai số tài khoản, chuyển bằng Nickname.\r\n" +
                            "+ Sau khi nhận được thông báo từ ngân hàng, hệ thống sẽ tự động gửi mã thẻ sau 2-5 phút.\r\n" +
                            "+ Trong trường hợp bạn điền sai thông tin hoặc có bất kỳ sự cố gì khiến hệ thống không thể tự động kích hoạt, vui lòng liên hệ 0856253294 để được hỗ trợ sớm nhất.";
        }
    }
}
