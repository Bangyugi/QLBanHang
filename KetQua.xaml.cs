using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using QLBanHang.Models;

namespace QLBanHang
{
    /// <summary>
    /// Interaction logic for KetQua.xaml
    /// </summary>
    public partial class KetQua : Window
    {
        QLBanHangContext _context = new QLBanHangContext();
        string keyword = null;

        public KetQua()
        {
            InitializeComponent();
  
        }

        public void SetData(string keyword)
        {
            keyword = keyword.ToLower();
            var sanpham = _context.SanPhams.Select(x=>new
            {
                x.MaSp,
                x.TenSp,
                x.MaLoai,
                x.DonGia,
                x.SoLuong,
                TenLoaiSP = x.MaLoaiNavigation != null ? x.MaLoaiNavigation.ToString() : "",
                ThanhTien = x.DonGia * x.SoLuong
            }).Where(s=> s.TenSp.ToLower().Contains(keyword)).ToList();
            dgKetQua.ItemsSource = sanpham;
        }

     
    }
}
