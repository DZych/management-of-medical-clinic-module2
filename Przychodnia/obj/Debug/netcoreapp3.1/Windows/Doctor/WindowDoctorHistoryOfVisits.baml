   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Przychodnia.Windows.DoctorPrzychodnia.Windows.Doctor  5      <    6Przychodnia.Windows.Doctor.WindowDoctorHistoryOfVisits   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Przychodnia.Windows.Doctor     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	        MaterialDesignPaper  N� 
Background#  �  5
       N� Title$! WindowDoctorHistoryOfVisits��5      $	��900��6+   $	��800��68    N� 
FontFamily 5      :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   �� .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'   $��20q�69   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6F   .��5      �� $��Center=�6   $��Center=�67   $��History of Visits��6T   $��30(�6m   
�������6{   5      5      �� 5   
   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��800* �6#   62   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ HistoryOfVisits��5      $	��800��60   $	��650��6<      AutoGenerateColumns$ False��6I   $��0,78,0,0q�6e      CanUserAddRows$ False��6w   	   CanUserDeleteRows$	 False��6�   
   SelectionMode$
 Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6k      
IsReadOnly$
 True��6u   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *AppointmendtId+6u     5      $
 Date��6<   $ * 6k   $
 True��6u    6J   �� *DateDataGrid+6u     5      $
 Name��6<   $ * 6r   $
 True��6|    6J   �� *PatientNameDataGrid+6|     5       $ Surname��6<   $ * 6x   $
 True��6�    6M   �� *PatientSurnameDataGrid+6�     5!      $ PESEL��6<   $ * 6t   $
 True��6~    6K   �� *PatientPESELDataGrid+6~     5"      $ Doctor��6<   $ * 6o   $
 True��6y    6L   �� *DoctorDataGrid+6y   5&      5+      � 5,   
   $��0,0,0,0q�6    5-      �� 5.      $
��200* �6#   62   �� 5/      $
��200* �6#   62   .+�51      �� -   5        $��ShowDetails��51      $	��300��6(   $��50��64   $��50q�6@   $��Show Details��6L   $��0��6c   $��16(�6s   
������� � Cursor$
 Hand��6�   6�   �� 52      -   5        $��SearchVisitsHistory��52      $	��300��60   $��50��6<   $��50q�6H   $��Search Visit��6T   $��1��6k   $��16(�6{   
�������$
 Hand��6�   6�   54      58      5<      5=      