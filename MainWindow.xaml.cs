using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QLBanHang.Models;

namespace QLBanHang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHangContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new QLBanHangContext();
            LoadData();
        }
        
        public void LoadData() { 
            
            cboLoaiSP.ItemsSource= _context.LoaiSps.ToList();
            cboLoaiSP.DisplayMemberPath = "TenLoai";
            cboLoaiSP.SelectedValuePath = "MaLoai";
            cboLoaiSP.SelectedIndex = 0;

            dgSanPham.ItemsSource = _context.SanPhams.Select(sp=> new
            {
                sp.MaSp,
                sp.TenSp,
                sp.DonGia,
                sp.SoLuong,
                sp.MaLoai,
                TenLoaiSP = sp.MaLoaiNavigation != null ? sp.MaLoaiNavigation.TenLoai : "",
                ThanhTien = sp.DonGia * sp.SoLuong
            }).ToList(); ;

            
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            long donGia = long.Parse(txtDonGia.Text);
            short soLuong = short.Parse(txtSoLuong.Text);
            string maLoai = cboLoaiSP.SelectedValue.ToString();

            SanPham sp = new SanPham()
            {
                MaSp = maSP,
                TenSp = tenSP,
                DonGia = donGia,
                SoLuong = soLuong,
                MaLoai = maLoai
            };

            _context.SanPhams.Add(sp);
            _context.SaveChanges();
            LoadData();

        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {

            if (dgSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var sp = _context.SanPhams.FirstOrDefault(s=> s.MaSp.Equals(txtMaSP.Text));

            if (sp == null)
            {
                MessageBox.Show("Không tìm thấy mã sản phẩm", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            sp.TenSp = txtTenSP.Text;
            sp.DonGia = long.Parse(txtDonGia.Text);
            sp.SoLuong = short.Parse(txtSoLuong.Text);
            sp.MaLoai = cboLoaiSP.SelectedValue.ToString();

            _context.SaveChanges();
            MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadData();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var sp = _context.SanPhams.FirstOrDefault(s => s.MaSp.Equals(txtMaSP.Text));

            if (sp == null)
            {
                MessageBox.Show("Không tìm thấy mã sản phẩm", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBoxResult result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {sp.TenSp} không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                _context.SanPhams.Remove(sp);
                _context.SaveChanges();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadData();
            }


        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            TimKiem timKiem = new TimKiem();
            timKiem.Show();
        }

        private void DgSanPham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          

            if (dgSanPham.SelectedItem != null)
            {
                var selectedRow = dgSanPham.SelectedItem;

                txtMaSP.Text = selectedRow.GetType().GetProperty("MaSp")?.GetValue(selectedRow, null).ToString();
                txtTenSP.Text = selectedRow.GetType().GetProperty("TenSp")?.GetValue(selectedRow, null).ToString();
                txtDonGia.Text = selectedRow.GetType().GetProperty("DonGia")?.GetValue(selectedRow, null).ToString();
                txtSoLuong.Text = selectedRow.GetType().GetProperty("SoLuong")?.GetValue(selectedRow, null).ToString();
                cboLoaiSP.SelectedValue = selectedRow.GetType().GetProperty("MaLoai")?.GetValue(selectedRow,null);

            }
        }

        private void btnThongke_Click(object sender, RoutedEventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.Show();
        }
    }
}