   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Przychodnia.Windows.DictionariesHandling(Przychodnia.Windows.DictionariesHandling  5   	   =    7Przychodnia.Windows.DictionariesHandling.WindowUserList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Przychodnia.Windows.DictionariesHandling     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          N� 
Background
  ���_�   MaterialDesignBody#���   5   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	   $	��819��5   	    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �  � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��2* �6   .+�5   
   � $��0��6   .+�5      ��   MaterialDesignPaper#���  6   $��Center=�6L   $	��821��6g   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6+   $��20q�6=   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6J   .��5      �� $��Center=�6    $��Center=�6;   $��List Of Users��6X   $��30(�6m   
�������6{   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridListOfUser��5      $	��500��67   $	��665��6D      AutoGenerateColumns$ False��6P   $��0,20,0,0q�6l   	   CanUserAddRows$	 False��6~   
   CanUserDeleteRows$
 False��6�      SelectionMode$ Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      
IsReadOnly$
 True��6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *	User_id+6d     5       $ Login��6<   $
 True��6e    6K   �� *Login+6e     5!      $ Password��6<   $
 True��6k    6N   �� *
Password+6k     5"      $ Email��6<   $
 True��6e    6K   �� *Email+6e     5#      $ 
Permission��6<   $
 True��6o    6P   �� *
Permission+6o   5%      � 5&       5'      �� 5(      $��* �6+   �� 5)      $��* �6+   �� 5*      $��* �6+   .+�5,      �� -   5        $��	ButtonAdd��5,      $	��Add��6/   $��15(�6=   
�������$��0��6d   $��20q�6t    � Cursor$
 Hand��6�   6�   �� 5-      -   5        $��
ButtonEdit��5-      $
��Edit��60   $��15(�6?   
�������$��1��6f   $��20q�6v   $
 Hand��6�   6�   �� 5.      -   5        $��ButtonRemove��5.      $��Remove��61   $��15(�6B   
�������$��3��6i   $��20q�6y   $
 Hand��6�   6�   5/      50      51      � 52   
   $��1��6   $��20,0,0,0q�6    � RowDefinitions 53      �� 54      $	��23* �6    �� 55      $
��796* �6    .+�57      �� #���  6   $��
0,52,54,73q�6L   $��1��6`   .+�58        $ 
PrimaryMid=�6+   $��1��6=     MaterialDesignShadowDepth5 J� Effect# �  6J   $��75��6�   .��59      �� $��16q�6    $��List Of Permissions��6,   $��Center=�6G   $��Center=�6b   $��25(�6   5:        5;      -   5        $ DataGridListOfPermission��5;      $	��515��6=   $ False��6J   $��0,20,0,0q�6f   $	 False��6x   $
 False��6�   $ Single=�6�    5<        5=      $ ID��6<   $
 True��6i    6H   �� *PermissionId+6i     5>      $ 
Permission��6<   $
 True��6o    6P   �� *
Permission+6o   5@      � 5A      $��0��6   $
��left=�6$   $��10,0,0,0q�6?   .+�5B      �� -   5         * &MaterialDesignFloatingActionMiniButton#��[ 5B      $��	120,0,0,0q�6]   ��6p   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�   Size 106�   �� 5C      -   5        #��[ 5C      $��	220,0,0,0q�6^   ��6q     $ Minus=� 106�   �� 5D      -	   5         ��Name$ TextBoxPermission��5D      $
��Left=�69   )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ 
Permission��6T   $	��150��6�   $��14(�6�   5E      5F      5G      5H      5I      