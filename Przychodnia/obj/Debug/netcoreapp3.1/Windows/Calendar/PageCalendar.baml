   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Przychodnia.Windows.DictionariesHandling(Przychodnia.Windows.DictionariesHandling  5      ;    5Przychodnia.Windows.DictionariesHandling.PageCalendar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Hlocal6clr-namespace:Przychodnia.Windows.DictionariesHandling     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5      $��Medium"�5	      $��16(�5
        �� BitmapScalingMode$  HighQuality=�5       � UseLayoutRounding$
 True��5      $	��700��5       N� 
FontFamily 5      :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �  � ColumnDefinitions 5   
   �� 5      $
��7.5* �6   �� 5      $	��12* �6   �� 5      $
��7.5* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $��Center=�66   $	��300��6Q   $	��700��6]   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6+   $��20q�6=   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6J   .��5      �  5      �� 5      61   �� 5      $��50 �6/   6<   �� 5      $��50 �6/   6<   .+�5!      �� $��0��6$   $��Center=�64   $��Center=�6O   $
��Days��6l   $��30(�6x   
�������6�   �� 5"      -   5         ��Name$ 	ButtonAdd��5"   �   $��1��6!    * &MaterialDesignFloatingActionMiniButton#��[ 61   ��6q   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�   Size 106�   �� 5#      -   5        $ ButtonRemove��5#   �   $��2��6!   #��[ 61   ��6r     $ Minus=� 106�   5$      5%      �� 5&      .+�5'      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DataGridListOfDoctors��5'      $	��620��6>   $
��1000��6K   
   AutoGenerateColumns$
 False��6X      CanUserAddRows$ False��6t      CanUserDeleteRows$ False��6�      SelectionMode$ Single=�6�      Columns 5(      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6@      
IsReadOnly$
 True��6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *CalendarDayId+6n     5*      $
 Date��6@   $
 True��6g    6N   �� *Date+6g     5+      $ Start��6@   $
 True��6s    6O   �� *StartTimeString+6s     5,      $	 End��6@   $
 True��6o    6M   �� *EndTimeString+6o   5.      5/      50      51      � 52   
   $��1��6   .+�53      �� $��Center=�6   $��Center=�66   $	��500��6Q   $	��700��6]   .+�54        $ 
PrimaryMid=�6+   $��20q�6=   $ Depth3=�6J   .��55      �� $��Center=�6    $��Center=�6;   $��Calendar Doctor��6X   $��30(�6o   
�������6}   56      �� 57      .+�58        -   5        $"	 DataGridListOfCalendarDoctor��58      $	��620��6E   $	��500��6R   $
 False��6^   $ False��6z   $ False��6�   $ Single=�6�    59        5:      $ ID��6@   $
 True��6q    6L   �� *CalendarDoctorId+6q     5;      $
 Name��6@   $
 True��6g    6N   �� *Name+6g     5<      $ Surname��6@   $
 True��6m    6Q   �� *	Surname+6m     5=      $ Status��6@   $
 True��6q    6P   �� *StatusString+6q   5?      5@      5A      5B      � 5C   
   $��2��6   $��0,0,20,0q�6   ���#c3ecef � RowDefinitions 5D      �� 5E      $
��0.5* �6    �� 5F      $��1* �6    �� 5G      $��1* �6    �� 5H      $��1* �6    �� 5I      $��1* �6    �� 5J      $��1* �6    .+�5L      � $��0��6   .+�5M        $ 
PrimaryMid=�6+   $��20q�6=   $ Depth3=�6J   .��5N      �� $��Center=�6    $��Center=�6;   $��Status��6X   $��30(�6f   
�������6t   5O      5P      � 5Q      $��1��6    5R      �� 5S      $��1* �6'   �� 5T      $��1* �6'   �� 5U      $
��0.5* �6'   .+�5W      �� $��0��6   $��Pick a Month: ��6,   $��Center=�6B   $��20,0,0,0q�6]   $	��100��6o   $
��Left=�6~   �� 5X      -   5         ��Name$ ComboBoxPickDate��5X         MaterialDesignFilledComboBox#��[ 65   )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$
 Date��6k   .
  (MaterialDesignThemes.Wpf.TextFieldAssist 
  HasClearButton$
 True��6�   $��50��6�   $	��200��6�   $	��200��6�   $��1��6�    �� SelectedItem 5Y      �� 5Z       �� Path$ SelectedValidationFilled�6"    �� Mode$ TwoWay=�6B    �� UpdateSourceTrigger$ PropertyChanged=�6P    �� ValidationRules 5[      5]      5_      �� 5`      -   5        $ ButtonRemoveCalendar��5`   �   $��2��6   #��[ 6)   ��6j     $ Minus=� 106�   5b      � 5c      $��2��6    5d      �� 5e      $��1* �6'   �� 5f      $��1* �6'   .+�5h      �� $��0��6   $��Center=�6,   $
��Left=�6G   $��20q�6b   $��Status:��6n   $��30(�6}   ���#6f6fff6�   �� 5i      -   5         ��Name$ Status_Label��5i      $��Center=�62   $
��Left=�6M   $��	119,0,0,0q�6h   $	��...��6{   $��30(�6�   ���#6f6fff$��2��6�   5j      � 5k      $��3��6   .+�5l      � $��0��6   $��0,0,0,0q�6(   $	��120��69   $	��100��6H   .+�5m      �� -	   5        $��ButtonGenerate��5m      $��Generate��63   $��20(�6F   
�������$��0��6m   $��0,0,0,0q�6}   $��70��6�   6�   5n      5o      � 5p      $��5��6   .+�5q      � $��0��6   $��0,0,0,0q�6(   $	��120��69   $	��100��6H   .+�5r      �� -
   5        $��ButtonVerified��5r      $��Verify��63   $��20(�6D   
�������$��0��6k   $��0,0,0,0q�6{   $��70��6�   6�   5s      5t      � 5u      $��4��6   .+�5v      � $��0��6   $��0,0,0,0q�6(   $	��120��69   $	��100��6H   .+�5w      �� -   5        $��ButtonShare��5w      $��Share��60   $��20(�6@   
�������$��0��6g   $��0,0,0,0q�6w   $��70��6�   6�   5x      5y      5z      5{      5|      