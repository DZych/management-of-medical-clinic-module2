   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Przychodnia.Windows.DictionariesHandling(Przychodnia.Windows.DictionariesHandling  5   	   F    @Przychodnia.Windows.DictionariesHandling.WindowViewListOfDoctors   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Przychodnia.Windows.DictionariesHandling     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5           MaterialDesignBody#���   5
   	     MaterialDesignPaper  N� 
Background#  �  5   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	    N� Title$ List of doctors��5   	   $	��600��6!   $
��1000��6.    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��20q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   .��5      �� $��Center=�6   $��Center=�63   $��List Of Doctors��6P   $��30(�6g   
�������6u   5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridListOfDoctors��5      $	��450��66   $
��1000��6C      AutoGenerateColumns$ False��6P   	   CanUserAddRows$	 False��6l   
   CanUserDeleteRows$
 False��6�      SelectionMode$ Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68      
IsReadOnly$
 True��6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	Doctor_id+6b     5      $
 Name��68   $
 True��6_    6F   �� *Name+6_     5      $ Surname��68   $
 True��6e    6I   �� *	Surname+6e     5      $ Phone number��68   $
 True��6n    6N   �� *PhoneNumber+6n   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Active��6-   $
 True��6X    6=   �� *Active+6X     5      $ Degree of doctor��68   $
 True��6m    6R   �� *Degree+6m     5       $ Specialization��68   $
 True��6s    6P   �� *Specialization+6s     5!      $ Type of specialization��68   $
 True��6�    6X   �� *TypeOfSpecialization+6�   5#      � 5$       � ColumnDefinitions 5%      �� 5&      $��* �6'   �� 5'      $��* �6'   �� 5(      $��* �6'   .+�5*      �� -   5        $��	ButtonAdd��5*      $	��Add��6B   $��15(�6P   
�������$��0��6w   $��20q�6�   �� 5+      -   5        $��
ButtonEdit��5+      $
��Edit��6D   $��15(�6S   
�������$��1��6z   $��20q�6�   �� 5,      -   5        $��ButtonViewDetails��5,      $��View details��6R   $��15(�6i   
�������$��2��6�   $��20q�6�   5-      5.      5/      50      