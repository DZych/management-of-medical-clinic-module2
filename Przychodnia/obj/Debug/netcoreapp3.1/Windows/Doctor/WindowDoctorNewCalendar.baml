   M S B A M L   `   `   `  ����  Przychodnia8    2Przychodnia.Windows.Doctor.WindowDoctorNewCalendar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     N� 
Background
  ���_�   MaterialDesignBody#���   5   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	   $	��819��5   	    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $��0��6%   $	��600��62   $��0,0,5,0q�6>   $��Right=�6O     MaterialDesignPaper#���  6k   .+�5       (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'     MaterialDesignShadowDepth2 J� Effect# �  69   $��75��6o   .��5!      �� $��Center=�6   $��Center=�67   $��New Calendar��6T   $��30(�6h   
�������6v   5"      � 5$       5%      �� 5&      $��* �6'   �� 5'      $��* �6'    5)      �� 5*      $��* �6$   �� 5+      $��* �6$   �� 5,      $��* �6$   �� 5-      $��* �6$   �� 5.      $��* �6$   .+�52      �� $��0��6   $��	0,20,10,0q�6,   $��Center=�6?   $��Right=�6Z   $��Pick calendar:��6v   �� 53      -   5        $��ComboBoxPickCalendar��53      $��1��68   $��50��6H   $	��200��6T   $��	10,20,0,2q�6`   $
��Left=�6s   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Date��6�      MaterialDesignFilledComboBox#��[ 6�   6�   �� 56      $��2��6   $��1��6,   $��10q�69   $��1q�6E   
�������$	��500��6q   $��1��6}   �� 59      $��0��6   $��2��6,   $��8q�69   $��Previous month��6D   $��Center=�6Z   $��Center=�6u   $��16(�6�   	 J� Opacity$		 0.5Q�6�   �� 5:      $��1��6   $��2��6,   $��8q�69   $��Current month��6D   $��Center=�6Y   $��Center=�6t   $��16(�6�   &   System.Windows.Controls.DataGrid  5?      -   5        $��PreviousMonthDataGrid��5?      $��0��69   $
   HorizontalScrollBarVisibility$
 Hidden=�6I   $��3��6p   $	��450��6}   $	��300��6�      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6�      SelectionMode$ Single=�6�   $��Stretch=�6�   $��Stretch=�6  $	 0.525Q�66     Columns 5@      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6<      
IsReadOnly$
 True��6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *
DateString+6i     5B      $	 Day��6<   $
 True��6g    6I   �� *	DayOfWeek+6g     5C      $ Start��6<   $
 True��6o    6K   �� *StartTimeString+6o     5D      $	 End��6<   $
 True��6k    6I   �� *EndTimeString+6k   5F        5I      -   5        $��CurrentMonthDataGrid��5I      $��1��67   $��3��6G   $	��450��6T   $	��300��6a   $ False��6n   $
 Hidden=�6�   $ False��6�   $ False��6�   $ Single=�6�   $��Stretch=�6�   $��Stretch=�6     SelectionUnit$ FullRow=�6I     RowStyle 5J      �� 5K       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6      MaterialDesignDataGridRow �� BasedOn# [ 69    �� Triggers 5L      �� 5M   "    �� Binding 6.   �� *IsWorkingDay+ �� Value true6O   .a�5N   &   ��  �� Property � �� �� Value �#32CFCF6C   5O   #   5Q       5S        5T      $
 Date��6<   $
 True��6d    6J   �� *Date+6d     5U      $	 Day��6<   $
 True��6h    6J   �� *	DayOfWeek+6h     5V      $ Start��6<   $
 True��6o    6K   �� *StartTimeString+6o     5W      $	 End��6<   $
 True��6k    6I   �� *EndTimeString+6k     5X      $ IsWorkingDay��6<   $
 True��6s      
Visibility$ Hidden=�6�    6R   �� *IsWorkingDay+6�   5Z      �� 5]      -   5        $��2��5]      $��4��6-   $	��300��6;   $��Copy previous month��6G   $��16(�6e   
�������$��20q�6�    � Cursor$
 Hand��6�   6�   5_      5a      �� 5d   
   $��1��6   $��0��6%   $	��400��63   $��5,0,0,0q�6?   $
��Left=�6P   #���  6k   .+�5e        $ 
PrimaryMid=�6'   # �  69   $��75��6o   .��5f      �� $��16q�6   $��Details��6(   $��Center=�67   $��Center=�6R   $��25(�6o   
�������6}   5g      � 5i       5j      �� 5k      $��* �6'   �� 5l      $��* �6'    5n      �� 5o      $��* �6$   �� 5p      $��* �6$   .+�5t      �� -   5        $��
workingDay��5t      $��2��6-   $��0��6A   $��15q�6N   $��16(�6Z   $��Working day��6h   6�   �� 5w      -   5        $��workingDayFrom��5w      ${�False��61   $��0��6C   $��2��6S   $��50��6`   $	��150��6l   $��Center=�6y   $
 From��6�   #��[ 6�   6�   �� 5x      -   5        $��workingDayTo��5x      ${�False��6/   $��1��6A   $��2��6Q   $��50��6^   $	��150��6j   $��Center=�6w   $ To��6�   #��[ 6�   6�   5y      �� 5z      -   5        $��label1��5z      $��Label��6#   $y�Hidden=�63   5{      �� 5~   
   $��2��6   $��1��6)   $
��1010��67   $��80��6D   $��	0,5,200,0q�6P   $��Center=�6c   #���  6�   .+�5      �� -	   5        $	��300��5      $��50��6"   $��15q�6.   $��Accept calendar��6:   $��16(�6T   
�������$
 Hand��6{   6�   5�      5�      5�      