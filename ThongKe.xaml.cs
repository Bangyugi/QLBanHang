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
    /// Interaction logic for ThongKe.xaml
    /// </summary>
    public partial class ThongKe : Window
    {
        QLBanHangContext _context = new QLBanHangContext();
        public ThongKe()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var loaiSP = _context.LoaiSps.Join(_context.SanPhams,
                l => l.MaLoai,
                s => s.MaLoai,
                (l, s) => new { l.MaLoai, l.TenLoai, s.SoLuong })
            .GroupBy(x => new {x.MaLoai,x.TenLoai})
            .Select(g => new {
                MaLoai = g.Key.MaLoai,
                TenLoai = g.Key.TenLoai,
                SoLuongSP = g.Sum(x => x.SoLuong) 
            }).ToList();

            dgThongKe.ItemsSource = loaiSP;


        }
    }
}
