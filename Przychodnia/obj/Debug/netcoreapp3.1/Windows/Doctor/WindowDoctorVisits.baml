   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Przychodnia.Windows.DoctorPrzychodnia.Windows.Doctor  5      3    -Przychodnia.Windows.Doctor.WindowDoctorVisits   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Przychodnia.Windows.Doctor     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        N� 
Background
  ���_�   MaterialDesignBody#���   5
      $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	   $	��780��5   	    N� Title$ WindowDoctorVisits��5      $
��1400��6"    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � $��Center=�6   $��Stretch=�6(    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $��0��6%   $	��500��62   $��Center=�6>   $��0,0,5,0q�6[     MaterialDesignPaper#���  6l   $��2��6�   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'     MaterialDesignShadowDepth2 J� Effect# �  69   $��75��6o   .��5      �� $��Center=�6   $��Center=�67   $��Visits��6T   $��30(�6b   
�������6p   5       �� 5!      -   5         ��Name$ DateVisitComboBox��5!      $	��500��62   $��50��6>   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$
	 Date��6J   $��18(�6p   $��Center=�6�      MaterialDesignFilledComboBox#��[ 6�   6�   &   System.Windows.Controls.DataGrid  5"      -   5        
  Name$
 Visits��5"      $	��600��6'   $	��450��64      AutoGenerateColumns$ False��6@   $��0,20,0,0q�6\      CanUserAddRows$ False��6n      CanUserDeleteRows$ False��6�      SelectionMode$ Single=�6�      Columns 5#      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$
 Time��68      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6d      
IsReadOnly$
 True��6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *	StartTime+6n     5%      $
 Name��68   $ * 6n   $
 True��6x    6F   �� *PatientNameDataGrid+6x     5&      $ Surname��68   $ * 6t   $
 True��6~    6I   �� *PatientSurnameDataGrid+6~     5'      $ PESEL��68   $	 150 6p   $
 True��6|    6G   �� *PatientPESELDataGrid+6|   5,      5.      �� 5/   
   $��1��6   $��0��6%   $	��500��62   $��Center=�6>   $��5,0,5,0q�6[   #���  6l   $��2��6�   .+�50        $ 
PrimaryMid=�6'   # �  69   $��75��6o   .��51      �� $��Center=�6   $��Center=�67   $��History��6T   $��30(�6c   
�������6q   52        53      -   5        $
 HistoryofPacient��53      $	��600��61   $	��450��6>   $ False��6J   $ False��6f   $ False��6}   $ Single=�6�    54        55      $
 Date��68   $	 120 6g   $
 True��6s    6F   �� *DateDataGrid+6s     56      $ Doctor��68   $ 2* 6k   $
 True��6v    6H   �� *DoctorDataGrid+6v     57      $ Topic��68   $	 200 6a   $
 True��6m    6G   �� *Topic+6m   5=      5@      �� 5A   
   $��2��6   $��0��6%   $	��450��62   $��Center=�6>   $��5,0,0,0q�6[   #���  6l   $��2��6�   .+�5B        $ 
PrimaryMid=�6'   # �  69   $��75��6o   .��5C      �� $��Center=�6   $��Center=�67   $��Description��6T   $��30(�6g   
�������6u   5D      � 5E      $��35��6   $��0,15,0,0q�6    5F      �� 5G      $	��135 �6'   65   �� 5H      $��* �6'   63   .+�5J      �� $��	0,11,40,0q�6   $��Name:��6/   $��0��6<   $��Right=�6L   �� 5K      -   5         ��Name$ NamePatient��5K      $�� ��61   $��1��69   $��	0,11,40,0q�6I   $
��Left=�6\   5L      � 5M       5N      �� 5O      $	��135 �6'   65   �� 5P      $��* �6'   63   .+�5R      �� $��	0,11,40,0q�6   $��Surname:��6/   $��0��6?   $��Right=�6O   �� 5S      -   5        $ SurnamePatient��5S      $�� ��64   $��1��6<   $��	0,11,40,0q�6L   $
��Left=�6_   5T      � 5U       5V      �� 5W      $	��135 �6'   65   �� 5X      $��* �6'   63   .+�5Z      �� $��	0,11,40,0q�6   $��PESEL:��6/   $��0��6=   $��Right=�6M   �� 5[      -   5        $ PESELpatient��5[      $�� ��62   $��1��6:   $��	0,11,40,0q�6K   $
��Left=�6^   5\      � 5^       5_      �� 5`      $	��135 �6'   65   �� 5a      $��* �6'   63   .+�5c      �� $��	0,11,40,0q�6   $��Topic :��6/   $��0��6>   $��Right=�6N   �� 5d      -   5         ��Name$ TopicResult��5d      $�� ��6/   $��1��67   $��	0,11,40,0q�6G   $
��Left=�6Z   $��13(�6u    �� 
IsReadOnly$
 True��6�    �� 	MaxLength$	 200��6�   $	��200��6�   5g      � 5h       5i      �� 5j      $	��135 �6'   65   �� 5k      $��* �6'   63   .+�5m      �� $��	0,11,40,0q�6   $��Description:��6/   $��0��6C   $��Right=�6S   �� 5n      -   5        $ ResultOfVisit��5n      $�� ��61   $��1��69   $
��Left=�6I   $
 1000��6d   $	��200��6u   $	��300��6�    �� TextWrapping$
 Wrap=�6�    � Cursor$ IBeam��6�    �� AcceptsReturn$
 True��6�   $
 True��6�   $��13(�6�   5p      �� 5q      -	   5        $��
ChangeData��5q      $��	20,30,0,0q�6)   $��Change Data��6<   6n   �� 5r      -
   5        $��ConfirmResult��5r      $	��300��6*   $��50��66   $��50q�6B   $��Confirm��6N   $��16(�6`   
�������$
 Hand��6�   $y�Hidden=�6�   5u      5w      5�      