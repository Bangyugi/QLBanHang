﻿using System;
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

namespace QLBanHang
{
    /// <summary>
    /// Interaction logic for TimKiem.xaml
    /// </summary>
    public partial class TimKiem : Window
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            KetQua ketQua = new KetQua();
            ketQua.SetData(txtKeyword.Text);
            ketQua.Show();
        }
    }
}
