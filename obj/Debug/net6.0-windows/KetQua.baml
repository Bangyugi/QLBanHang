   M S B A M L   `   `   `  ����D  @QLBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLBanHang	QLBanHang  5   	       QLBanHang.KetQua   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:QLBanHang     5   	     � Title$  KetQua��5   	   $	��450��6   $	��800��6%    � 	Resources 5	       �� 
TargetType   
TitleStyle �� Property �� Value  
LabelStyle  TextBoxStyle  ComboBoxStyle&   System.Windows.Controls.DataGrid  DataGridStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader  HeaderStyle  ButtonStyle��%�  &	        &	 �     &	 _    &	 H    &	 1    &	     &	 �    �� 5
   
   " ��6   .�5      ��  � ��$ 35(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   �� 5       � ��$ 0 0 0 20q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 	0 0 30 10q�6'   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�69   5      �� 5   
   " ��6   .�5      ��  � ��$ 30��6'   �� 5       � ��$ 	0 0 20 10q�6'   �� 5       � ��$
 Left=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�69   5      �� 5   
   " ��6   .�5       ��  � ��$ 30��6'   �� 5!       � ��$ 	0 0 20 10q�6'   �� 5"       � ��$
 Left=�64   �� 5#       � ��$ Center=�62   �� 5$       � ��$ Center=�69   5%      �� 5'   
   "  6   .�5(      ��  � ��$	 300��6'   �� 5)       � ��$
 0 20q�6'   �� 5*       � ��$
 Left=�64   �� 5+       � ��$ Center=�62   �� 5,       � ��$ Center=�69   5-      �� 50   
   "  6   .�51      ��  � ��$
 Bold"�6+   �� 52       � ��$	 200��6&   �� 53       � ��$
 Left=�64   �� 54       � ��$ Center=�62   �� 55       � ��$ Center=�69   56      �� 58   
   " ��6   .�59      ��  � ��$
 Left=�64   �� 5:       � ��$ Center=�62   �� 5;       � ��$ Center=�69   5<      5=      .��5>      �  � ColumnDefinitions 5?   
   �� 5@      $��20 �6   �� 5A      $
��auto �6   �� 5B      $
��auto �6   �� 5C      $��* �6   �� 5D      $��20 �6    � RowDefinitions 5F   
   �� 5G      $��20 �6   �� 5H      $
��auto �6   �� 5I      $
��auto �6   �� 5J      $
��auto �6   �� 5K      $
��auto �6   �� 5L      $
��auto �6   �� 5M      $
��auto �6   �� 5N      $
��auto �6   �� 5O      $
��auto �6   �� 5P      $
��auto �6   �� 5Q      $��* �6   �� 5R      $��20 �6   .+�5T   
   �� $��1��6   $��1��6$   $��3��61   $��Kết quả tìm kiếm��6E   #��[  6]     5W   
   -   5        $��dgKetQua��5W   D   $��1��6   $��7��6#   $��3��60      CanUserAddRows$ False��5X         AutoGenerateColumns$ False��5Y      #��[ 6/   	   Columns	 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã sản phẩm��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6:      HeaderStyle# [ 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *MaSp+6_     5\      $
 Tên sản phẩm��6%   $	 180 6;   # [ 6b    6G   �� *TenSp+6b     5]      $
 Tên Loại sản phẩm��6%   $	 150 6@   # [ 6j    6L   �� *	TenLoaiSP+6j     5^      $
 
Đơn giá��6%   $	 100 66   # [ 6n    6B   �� *DonGia+ �� StringFormat$ N0��6n     5_      $
 Số lượng��6%   $	 100 67   # [ 6_    6C   �� *	SoLuong+6_     5`      $
 Thành Tiền��6%   $ * 69   # [ 6q    6C   �� *	ThanhTien+$ N0��   ElementStyle 5a      �� 5b      " ��6    .�5c      ��  � ��
 �  ��6;   5d      5f      5h      5k      5l      