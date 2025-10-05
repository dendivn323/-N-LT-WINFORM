using QLNhanVien.Modals;
using QLNhanVien.ViewModals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanVien.Froms.QuanLy
{
    public partial class FrmQuanLyNguoiDung : Form
    {
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
        }
        public List<NguoiDungView> dsNguoiDung = new List<NguoiDungView>();
        public QLNhanVienDBContext _dbContext = new QLNhanVienDBContext();

        bool isInsert = true;
        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            //Load dữ liệu chức vụ lên combobox
            var dsChucVu = _dbContext.ChucVu.ToList();
            cbbChucVu.DataSource = dsChucVu;
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";

            //Chuyển lstNguoiDung thành List NguoiDungView dùng Linq
            //Linq Method || linq query
            dsNguoiDung = (from ng in _dbContext.NguoiDung
                           select new NguoiDungView
                           {
                               MaNguoiDung = ng.MaNguoiDung,
                               HoTen = ng.HoTen,
                               MatKhau = ng.MatKhau,
                               TenChucVu = ng.ChucVu.TenChucVu,
                               HeSoLuong = ng.ChucVu.HeSoLuong,
                               SDT = ng.SDT
                           }).ToList();

            //Đổ dữ liệu lên gridview
            gridDSNguoiDung.DataSource = dsNguoiDung;
            gridDSNguoiDung.Refresh();

            //Xử lý UI
            //Disable groupbox chi tiết, và panel chi tiết
            grbChiTietNguoiDung.Enabled = false;
            plChiTiet.Enabled = false;
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Clear all textbox
            txtUserName.ReadOnly = false;
            txtFullName.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            txtUserName.Text = "";
            isInsert = true;
            //Tiến hành cho user nhập liệu
            //Enable groupbox, panel chi tiết
            grbChiTietNguoiDung.Enabled = true;
            plChiTiet.Enabled = true;
            //disable groupbox, panel danh sách
            grbDanhSachNguoiDung.Enabled = false;
            plDS.Enabled = false;
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            //Trở về ban đầu
            //Tiến hành cho user nhập liệu
            //disable groupbox, panel chi tiết
            grbChiTietNguoiDung.Enabled = false;
            plChiTiet.Enabled = false;
            //enable groupbox, panel danh sách
            grbDanhSachNguoiDung.Enabled = true;
            plDS.Enabled = true;

            //Clear all textbox
            txtFullName.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            txtUserName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isInsert)
            {
                //Tiến hành lưu dữ liệu thêm mới
                var ng = new NguoiDung();
                ng.MaNguoiDung = txtUserName.Text;
                ng.HoTen = txtFullName.Text;
                ng.MatKhau = txtPass.Text;
                ng.SDT = txtPhone.Text;
                ng.MaChucVu = cbbChucVu.SelectedValue.ToString();

                //Thêm vào DB
                _dbContext.NguoiDung.Add(ng);
                _dbContext.SaveChanges();

                MessageBox.Show("Thêm thành công");

                //Lấy lại DS người dùng view từ DS người dùng trong DB
                QLNhanVienDBContext db = new QLNhanVienDBContext();
                dsNguoiDung = (from nd in db.NguoiDung.ToList()
                               select new NguoiDungView
                               {
                                   MaNguoiDung = nd.MaNguoiDung,
                                   HoTen = nd.HoTen,
                                   MatKhau = nd.MatKhau,
                                   TenChucVu = nd.ChucVu.TenChucVu,
                                   HeSoLuong = nd.ChucVu.HeSoLuong,
                                   SDT = nd.SDT
                               }).ToList();

                //Gán lại datasource cho gridview
                gridDSNguoiDung.DataSource = null;
                gridDSNguoiDung.DataSource = dsNguoiDung;
                gridDSNguoiDung.Refresh();


                //Trở về ban đầu
                //Tiến hành cho user nhập liệu
                //disable groupbox, panel chi tiết
                grbChiTietNguoiDung.Enabled = false;
                plChiTiet.Enabled = false;
                //enable groupbox, panel danh sách
                grbDanhSachNguoiDung.Enabled = true;
                plDS.Enabled = true;

                //Clear all textbox
                txtFullName.Text = "";
                txtPass.Text = "";
                txtPhone.Text = "";
                txtUserName.Text = "";
            }
            else
            {
                //Trường hợp sửa
                //lấy ra user cần update
                var userEdit = dsNguoiDung.Where(s => s.MaNguoiDung == txtUserName.Text).First();
                userEdit.HoTen = txtFullName.Text;
                userEdit.MatKhau = txtPass.Text;
                userEdit.SDT = txtPhone.Text;
                gridDSNguoiDung.DataSource = null;
                gridDSNguoiDung.DataSource = dsNguoiDung;
                gridDSNguoiDung.Refresh();
                //disable groupbox, panel chi tiết
                grbChiTietNguoiDung.Enabled = false;
                plChiTiet.Enabled = false;
                //enable groupbox, panel danh sách
                grbDanhSachNguoiDung.Enabled = true;
                plDS.Enabled = true;
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Lấy vị trí dòng dữ liệu user chọn trên gridview
            var dongChon = gridDSNguoiDung.CurrentCell.RowIndex ;
            //lấy ra mã người dùng ở dòng chọn
            var dataChon = gridDSNguoiDung.Rows[dongChon].Cells[0].Value.ToString();

            //Sử dụng linq 
            //tìm user cần xóa
            var userXoa = dsNguoiDung.Where(s => s. MaNguoiDung == dataChon).First();
            //Xóa khỏi DS
            dsNguoiDung.Remove(userXoa);
            //Gán lại datasource cho gridview
            gridDSNguoiDung.DataSource = null;
            gridDSNguoiDung.DataSource = dsNguoiDung;
            gridDSNguoiDung.Refresh();
            //Xóa trong DB
            //Lấy ra dòng data cần xóa trong DB
            var nguoiDungXoa = _dbContext.NguoiDung.Where(s => s.MaNguoiDung == userXoa.MaNguoiDung).FirstOrDefault();
            _dbContext.NguoiDung.Remove(nguoiDungXoa);
            _dbContext.SaveChanges();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isInsert = false;
            //Tiến hành cho user nhập liệu
            //Enable groupbox, panel chi tiết
            grbChiTietNguoiDung.Enabled = true;
            plChiTiet.Enabled = true;
            //disable groupbox, panel danh sách
            grbDanhSachNguoiDung.Enabled = false;
            plDS.Enabled = false;
            txtUserName.ReadOnly = true;
        }

        private void gridDSNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy vị trí dòng dữ liệu user chọn trên gridview
            var dongChon = gridDSNguoiDung.CurrentCell.RowIndex;
            //lấy ra mã người dùng ở dòng chọn
            var dataChon = gridDSNguoiDung.Rows[dongChon].Cells[0].Value.ToString();

            //Sử dụng linq 
            //lấy ra user tại dòng được click
            var userSelected = dsNguoiDung.Where(s => s.MaNguoiDung == dataChon).FirstOrDefault();
            if(userSelected != null)
            {
                //Gán data vào textbox
                txtFullName.Text = userSelected.HoTen;
                txtUserName.Text = userSelected.MaNguoiDung;
                txtPass.Text = userSelected.MatKhau;
                txtPhone.Text = userSelected.SDT;
            }
        }

        private void txtUserNameSearch_TextChanged(object sender, EventArgs e)
        {
            //Tiến hành lọc dữ liệu nhân viên
            var dsNguoiDungLoc = dsNguoiDung.Where(s => s.MaNguoiDung.ToLower().Contains(txtUserNameSearch.Text.ToLower())).ToList();
            //Gán lại datasource cho gridview
            gridDSNguoiDung.DataSource = null;
            gridDSNguoiDung.DataSource = dsNguoiDungLoc;
            gridDSNguoiDung.Refresh();
        }

        private void gridDSNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            //Lấy vị trí dòng dữ liệu user chọn trên gridview
            var dongChon = gridDSNguoiDung.CurrentCell.RowIndex;
            //lấy ra mã người dùng ở dòng chọn
            var dataChon = gridDSNguoiDung.Rows[dongChon].Cells[0].Value.ToString();

            //Sử dụng linq 
            //lấy ra user tại dòng được click
            var userSelected = dsNguoiDung.Where(s => s.MaNguoiDung == dataChon).FirstOrDefault();
            if (userSelected != null)
            {
                //Gán data vào textbox
                txtFullName.Text = userSelected.HoTen;
                txtUserName.Text = userSelected.MaNguoiDung;
                txtPass.Text = userSelected.MatKhau;
                txtPhone.Text = userSelected.SDT;
                cbbChucVu.Text = userSelected.TenChucVu;
            }
        }
    }
}
