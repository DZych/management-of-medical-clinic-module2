   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Przychodnia.Windows.DictionariesHandling(Przychodnia.Windows.DictionariesHandling  5      @    :Przychodnia.Windows.DictionariesHandling.WindowOverlapping   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Hlocal6clr-namespace:Przychodnia.Windows.DictionariesHandling     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$  Doctor Data��5      $	��700��6   $	��550��6"   .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $	��520��6"   $��Center=�6.   $��Center=�6K   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'   $��20q�69   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6F   .��5      �� $��Center=�6   $��Center=�67   $��List Of Appointment��6T   $��30(�6o   
�������6}   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridListOfDoctors��5      $	��470��66      AutoGenerateColumns$ False��6C      CanUserAddRows$ False��6_      CanUserDeleteRows$ False��6v      SelectionMode$ Single=�6�   	   Columns	 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��68      
IsReadOnly$
 True��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *Name+6_     5      $
 Surname��68   $
 True��6e    6I   �� *	Surname+6e     5      $

 Date��68   $
 True��6e    6F   �� *
DateString+6e     5      $
 
Old Office��68   $
 True��6m    6L   �� *OfficeNumber+6m     5      $
 
New Office��68   $
 True��6v    6L   �� *NewOfficeNumberString+6v   5      5       �� 5!   
   $��1��6   .+�5"      �  � ColumnDefinitions 5#      �� 5$      $��1* �6'   �� 5%      $��1* �6'   .+�5'      �� -   5         ��Name$ ButtonChange��5'      $��0��6/   $��Change��6?   $��20(�6P   
�������$��70��6w   $��10q�6�   $	��156��6�   6�   �� 5(      -   5        $ ButtonClose��5(      $��1��6.   $��Close��6>   $��20(�6N   
�������$��70��6u   $��10q�6�   $	��156��6�   6�   5)      5*      5+      5,      