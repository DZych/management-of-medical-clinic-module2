   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Przychodnia.Windows.DictionariesHandling(Przychodnia.Windows.DictionariesHandling  5   	   G    APrzychodnia.Windows.DictionariesHandling.WindowViewListOfEmployee   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Przychodnia.Windows.DictionariesHandling     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	     MaterialDesignPaper  N� 
Background#  �  5
   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	    N� Title$ List Of Employees��5   	   $	��571��6#   $	��778��60    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   �� .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'   $��20q�69   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6F   .��5      �� $��Center=�6   $��Center=�67   $��List Of Employee��6T   $��30(�6l   
�������6z   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridListOfEmployee��5      $	��400��67   $	��660��6D      AutoGenerateColumns$ False��6P   $��0,20,0,0q�6l   	   CanUserAddRows$	 False��6~   
   CanUserDeleteRows$
 False��6�      SelectionMode$ Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68      
IsReadOnly$
 True��6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
EmployeeId+6c     5      $
 Name��68   $
 True��6_    6F   �� *Name+6_     5      $ Surname��68   $
 True��6e    6I   �� *	Surname+6e     5      $ Phone number��68   $
 True��6n    6N   �� *PhoneNumber+6n     5      $ Date of birth��68   $
 True��6r    6O   �� *StrDateOfBirth+6r   5      � 5       � ColumnDefinitions 5       �� 5!      $��* �6'   �� 5"      $��* �6'   �� 5#      $��* �6'   .+�5%      �� -   5        $��	ButtonAdd��5%      $	��Add��6*   $��15(�68   
�������$	��190��6_   $��0��6k   $��Center=�6{   $��Center=�6�   6�   �� 5&      -   5        $��
ButtonEdit��5&      $
��Edit��6+   $��15(�6:   
�������$	��190��6a   $��1��6m   $��20q�6}   6�   �� 5'      -   5        $��ButtonRemove��5'      $��Remove��6-   $��15(�6>   
�������$��3��6e   $	��190��6u   $��Center=�6�   $��Center=�6�   6�   5(      5)      5*      5+      