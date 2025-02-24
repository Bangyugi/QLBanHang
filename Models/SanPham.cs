using System;
using System.Collections.Generic;

namespace QLBanHang.Models
{
    public partial class SanPham
    {
        public string MaSp { get; set; } = null!;
        public string? TenSp { get; set; }
        public long? DonGia { get; set; }
        public short? SoLuong { get; set; }
        public string? MaLoai { get; set; }

        public virtual LoaiSp? MaLoaiNavigation { get; set; }
    }
}
