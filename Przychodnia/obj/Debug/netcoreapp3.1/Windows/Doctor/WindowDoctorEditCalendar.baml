   M S B A M L   `   `   `  ����  Przychodnia9    3Przychodnia.Windows.Doctor.WindowDoctorEditCalendar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     N� 
Background
  ���_�   MaterialDesignBody#���   5
   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	   $	��819��5   	    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � $��Center=�6   $��Stretch=�6(    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $��0��6%   $	��300��62   $��0,0,5,0q�6>   $��Right=�6O     MaterialDesignPaper#���  6k   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'     MaterialDesignShadowDepth2 J� Effect# �  69   $��75��6o   .��5       �� $��Center=�6   $��Center=�67   $��My Calendar��6T   $��30(�6g   
�������6u   5!      � 5#       5$      �� 5%      $��* �6'    5'      �� 5(      $��* �6$   �� 5)      $��* �6$   .+�5.      &   System.Windows.Controls.DataGrid  -   5        $��CurrentMonthDataGrid��5.      $��0��67   $��0��6G   $	��600��6T   $	��300��6a   $   HorizontalScrollBarVisibility$ Disabled=�6o   	   AutoGenerateColumns$	 False��6�   
   CanUserAddRows$
 False��6�      CanUserDeleteRows$ False��6�      SelectionMode$ Single=�6�   $��Stretch=�6�   $��Stretch=�6     RowStyle 5/      �� 50       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6      MaterialDesignDataGridRow �� BasedOn# [ 69    �� Triggers 51      �� 52   "    �� Binding 6.   �� *IsWorkingDay+ �� Value	 False6O   .a�53   &   ��  �� Property � �� �� Value �#cf32326C   �� 54   &    � ��
 �����6C   55   #   57         Columns 59      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6<      
IsReadOnly$
 True��6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *
DateString+6i     5;      $	 Day��6<   $
 True��6g    6I   �� *	DayOfWeek+6g     5<      $ Start��6<   $
 True��6o    6K   �� *StartTimeString+6o     5=      $	 End��6<   $
 True��6k    6I   �� *EndTimeString+6k     5>      $ IsWorkingDay��6<   $
 True��6s      
Visibility$ Hidden=�6�    6R   �� *IsWorkingDay+6�   5@      �� 5B      -   5        $��0��5B      $��1��6*   $	��200��68   $��Add a new day��6D   $��16(�6\   
�������$��10q�6�    � Cursor$
 Hand��6�   6�   5C      5E      �� 5H   
   $��1��6   $��0��6%   $	��400��63   $��5,0,0,0q�6?   $
��Left=�6P   #���  6k   .+�5I        $ 
PrimaryMid=�6'   # �  69   $��75��6o   .��5J      �� $��16q�6   $��Details��6(   $��Center=�67   $��Center=�6R   $��25(�6o   
�������6}   5K      � 5M       5N      �� 5O      $��* �6'   �� 5P      $��* �6'    5R      �� 5S      $��* �6$   �� 5T      $��* �6$   �� 5U      $��* �6$   �� 5V      $��* �6$   �� 5W      $��* �6$   .+�5\      �� -   5        $��
workingDay��5\      $��2��6-   $��0��6A   $��15q�6N   $��16(�6Z   $��Working day��6h   6�   �� 5`      -   5        $��workingDayFrom��5`      ${�False��61   $��0��6C   $��1��6S   $��50��6`   $	��150��6l   $��Center=�6y   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 From��6�   $y�Visible=�6�      MaterialDesignFilledComboBox#��[ 6�   6  �� 5a      -   5        $��workingDayTo��5a      ${�False��60   $��1��6B   $��1��6R   $��50��6_   $	��150��6k   $��Center=�6x   $ To��6�   $y�Visible=�6�   #��[ 6�   6  �� 5d      -   5        $��checkBoxChangeDay��5d      $��2��64   $��2��6H   $��15q�6U   $��
Change day��6a   $��16(�6v   6�   �� 5g      -   5        $��availableDates��5g      ${�False��61   $��2��6C   $��3��6W   $��50��6d   $	��340��6p   $��Center=�6}   $ Available dates��6�   #��[ 6�   6  5k      5l      �� 5o   
   $��2��6   $��1��6)   $	��710��67   $��80��6C   $��Center=�6P   $��Center=�6m   #���  6�   $��0,5,0,0q�6�   .+�5p      �� -   5        $	��300��5p      $��50��6!   $��15q�6-   $��Accept changes��69   $��16(�6R   
�������$
 Hand��6y   6�   5q      5r      5s      