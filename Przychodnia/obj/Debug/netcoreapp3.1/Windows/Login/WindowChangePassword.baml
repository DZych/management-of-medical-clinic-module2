   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PrzychodniaPrzychodnia  5   	   4    .Przychodnia.Windows.login.WindowChangePassword   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Przychodnia     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	   	     MaterialDesignPaper  N� 
Background#  �  5
   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	    N� Title$ 
Clinic App��5      $	��450��6   $	��800��6%    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �  � ColumnDefinitions 5   
   �� 5      $��7* �6   �� 5      $
��793* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��20q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   $��2��6s   .��5      �� $��Center=�6   $��Center=�63   $��Change Password��6P   $��30(�6g   
�������6u   5      �� 5   
   $
��Left=�6   $	��Top=�60   $��222,154,0,0q�6H   $��1��6]   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 User=�6*   �� 5      $��Login: ��6   �� 5      -   5        
 ��Name$
 TextBlockLogin��5   #   $�� ��6   $	��100��6;   5       �� 5!      $ 
Horizontal=�6   $��0,15,0,0q�62   .+�5"        $	 Password=�6*   �� 5#      $��New Password: ��6   G� 5$      -   5        $��PasswordBoxPassword��5$      $	��100��69    � ToolTip$G AMust be 8-15 Charecters long, and consist of different charecters��6H    G� 	MaxLength$ 15��6�   5%      �� 5&      $ 
Horizontal=�6   $��0,15,0,0q�62   .+�5'        $	 Refresh=�6*   �� 5(      $��Retype Password: ��6   G� 5)      -   5        $ ��PasswordBox_RepeatPassword��5)      $	��100��6@   6O   5*      �� 5+      $ 
Horizontal=�6   $��Center=�62   $��0 50 0 0q�6O   .+�5,      �� -   5        $��Button_Save��5,      $��Change��6,   $	��100��6=   $��15(�6J   
�������${�False��6�   �� 5-      -   5        $��Button_Cancel��5-      $	��100��6.     MaterialDesignFlatButton#��[ 6:   $��Cancel��6l   $��Bottom=�6}   $��Center=�6�   $��15(�6�   $��30 0 0 0q�6�   6�   5/      50      53      54      