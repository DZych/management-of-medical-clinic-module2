   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Przychodnia.Windows.DictionariesHandling(Przychodnia.Windows.DictionariesHandling  5   	   C    =Przychodnia.Windows.DictionariesHandling.PageViewListOfOffice   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Przychodnia.Windows.DictionariesHandling     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	     MaterialDesignPaper  N� 
Background#  �  5
   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	    N� Title$ List of doctors��5   	   $	��581��6!   $	��358��6.    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��20q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   $	��359��6s   .��5      �� $��Center=�6   $��Center=�63   $��List Of Office��6P   $��30(�6f   
�������6t   5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridListOfOffice��5      $	��430��65   $	��357��6B      AutoGenerateColumns$ False��6N   	   CanUserAddRows$	 False��6j   
   CanUserDeleteRows$
 False��6�      SelectionMode$ Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68      
IsReadOnly$
 True��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
OfficeId+6a     5      $
 Name��68   $
 True��6g    6F   �� *OfficeNumber+6g   5      � 5       � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5       $��* �6'   .+�5"      �� -   5        $��	ButtonAdd��5"      $	��Add��6B   $��15(�6P   
�������$	��100��6w   $��
0,10,120,0q�6�   $��2��6�   �� 5#      -   5         ��Name$ 
ButtonEdit��5#      $
��Edit��6G   $��15(�6V   
�������$��1��6}   $��0,10,0,0q�6�   $	��100��6�   �� 5$      -   5        $ ButtonRemove��5$      $��Remove��6K   $��15(�6\   
�������$��
120,10,0,0q�6�   $	��100��6�   $��1��6�   $��2��6�   $��32��6�   $	��Top=�6�   5%      5&      5'      5(      