   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PrzychodniaPrzychodnia  5   	   )    #Przychodnia.Windows.Login.PageLogin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Przychodnia     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	   	     MaterialDesignPaper  N� 
Background#  �  5
   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	    N� Title$ 
Clinic App��5   	   $	��450��6   $	��800��6)    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��20q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   .��5      �� $��Center=�6   $��Center=�63   $��Login��6P   $��30(�6]   
�������6k   5      �� 5   
   $��Center=�6   $��Center=�62   $��
0,100,40,0q�6M   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6*   �� 5      $��Login: ��6   �� 5      -   5        $��TextBoxLogin��5      $	��100��6.   5       �� 5!      $ 
Horizontal=�6   $��0,15,0,0q�62   .+�5"        $ Password=�6*   �� 5#      $��Password:  ��6   G� 5$      -   5        $��PasswordBoxPassword��5$      $	��100��69   5%      �� 5&      -   5        $��Button_IForgotPassword��5&      	 � Cursor$
	 Hand��66   
����� �$��Forgot your password?��6�   $��	Underline{�6�   $��Center=�6�   $��0 15 0 0q�6�   �� 5'      $ 
Horizontal=�6   $��Center=�62   $��0 50 0 0q�6O   .+�5(      �� -   5        $��ButtonLogging��5(      $��Login��6.   $	��100��6>   $��15(�6K   
�������6r   �� 5)      -   5        $��Button_Cancel��5)      $	��100��6.     MaterialDesignFlatButton#��[ 6:   $��Cancel��6l   $��Bottom=�6}   $��Center=�6�   $��15(�6�   $��30 0 0 0q�6�   6�   5+      �� 5,      -   5        
 ��Name$
 TextBlockNextTry��5,      $��Next try available in:��62   $��15��6Q   $
��Left=�6]   $��	30,25,0,0q�6x   $	��Top=�6�   $��0��6�   $��12(�6�   $y�Hidden=�6�   5-      �� 50   
   $!��/Windows/Login/loginimg.png��6   $	��200��65   $	��200��6A   $��
0,0,40,100q�6N   $��Right=�6b   $��Bottom=�6~   52      53      