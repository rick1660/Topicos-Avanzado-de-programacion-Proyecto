   M S B A M L   `   `   `  ����K  GGestor de gastor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Gestor_de_gastorGestor_de_gastor  5
   	   !    Gestor_de_gastor.MainWindow   5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5	   	   0localclr-namespace:Gestor_de_gastor     5
   	     � Title$  
MainWindow��5   	   $	��700��6   $	��700��6)   $	��900��69   $	��800��6E    � WindowStartupLocation$ CenterScreen=�6T    � WindowState$ Normal=�6y   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.8* �6   �� 5      $��1* �6    .+�5   
   � -   5         �Name$
 Left��5      ���#3F819D$��0��64   .+�5      �� $��Gestion de gastos��6   $��Center=�60   $��Center=�6M   $��Arial Black)�6h   $��36(�6�   $��
ExtraBlack"�6�   
�������6�   5      � 5   
   -   5        $ Right��5      ���#3F819D$��1��65    � RowDefinitions 5       �� 5!      $
��0.3* �6!   �� 5"      $��1* �6!   �� 5#      $
��0.3* �6!   .+�5&      � ���#EDEEEE$��1��6(   .+�5(      � $��Center=�6   $��Center=�64   $	��400��6P   $	��350��6\    5)      �� 5*      $
��0.4* �6(   �� 5+      $
��0.3* �6(   �� 5,      $
��0.3* �6(   �� 5-      $
��0.3* �6(   �� 5.      $
��0.3* �6(   �� 5/      $
��0.4* �6(   .+�51      �� $��0��6   $��Iniciar de sesion��6)   $��Center=�6E   $��Bottom=�6c   $��22(�6~   $
��Bold"�6�   $��Arial Black)�6�   �� 52      $��1��6   $��Correo��6)   $��Center=�6:   $��Center=�6X   $��20(�6s   $
��Bold"�6�   $��Arial Black)�6�   �� 53      -   5         ��Name$ 	txtCorreo��53      $��Center=�61   $��35��6N   $��2��6Z   $	��Top=�6g   $	��250��6    �� TextAlignment$ Center=�6�   $��19(�6�   �� 54      $��3��6   $��Contraseña��6)   $��Center=�6>   $��Center=�6\   $��20(�6w   $
��Bold"�6�   $��Arial Black)�6�   �� 55      -   5        $ txtPassword��55      $��Center=�63   $��35��6P   $��4��6\   $	��Top=�6i   $	��250��6�   $ Center=�6�   $��19(�6�   �� 56      $��5��6   $"��Haz Olvidado tu contraseña?��6)   $��center=�6O   $	��Top=�6n   $
��Bold"�6�   $��Arial Black)�6�   �� 57      -   5         ��Name$ BtnIngresar��57      $��5��62   $��Ingresar��6?   $��Center=�6R   $��Bottom=�6p   $	��150��6�   $��30��6�   $��15(�6�   $��Arial Black)�6�   ���#21414C
�������6�   5;      5=      5?      5B      5C      