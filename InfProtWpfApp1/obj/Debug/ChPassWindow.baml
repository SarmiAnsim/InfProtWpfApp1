   M S B A M L   `   `   `  ����I  EInfProtWpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:InfProtWpfApp1InfProtWpfApp1  5   	   M+clr-namespace:InfProtWpfApp1.MVVM.ViewModelInfProtWpfApp1.MVVM.ViewModel  5   	   !    InfProtWpfApp1.ChPassWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:InfProtWpfApp1     5   	   A	viewModel+clr-namespace:InfProtWpfApp1.MVVM.ViewModel     5   	     � Title$  ChPassWindow��5	   	   $	��505��6   $	��700��6+    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      ;  5InfProtWpfApp1.MVVM.ViewModel.ChangePasswordViewModel  5   
   .��5      �� -   5        ���#272537 �� CornerRadius$ 20��5      ���#303344$��2q�5      ._�5   
   �  � RowDefinitions 5      �� 5      $��80 �6    �� 5      �� 5      �� 5      �� 5      .+�5"      �� .+�5#      �� $����Наличие цифр, знаков препинания и знаков арифметических операций в новом пароле��6   $��Center=�5$      $
��Left=�5%      
�������$��15(�5'      $��	30,20,0,0q�5(      �� 5*      $��Center=�5+      $
��Left=�5,      
�������$��15(�5.      $��30,4,0,0q�5/      ��5*      �� *ConfinedStatus+5/      50      �� 52      $��1��6   .+�53      �� $/��)Введите старый пароль:��6   $��Center=�54      $��Center=�55      
�������$��18(�57      $��	20,10,0,0q�58      G� 5:      $	��500��6   $��40��5;      $��Center=�5<      $��Center=�5=      $��10, 10, 0, 1q�5>         ModernOldPasswordBox#��[  5?      5@      �� 5B      $��2��6   .+�5C      �� $-��'Введите новый пароль:��6   $��Center=�5D      $��Center=�5E      
�������$��18(�5G      $��	20,10,0,0q�5H      G� 5J      $	��500��6   $��40��5K      $��Center=�5L      $��Center=�5M      $��10, 10, 0, 2q�5N        ModernNewPasswordBox#��[ 5O      5P      �� 5R      $��3��6   .+�5S      �� $1��+Повторите новый пароль:��6   $��Center=�5T      $��Center=�5U      
�������$��18(�5W      $��	20,10,0,0q�5X      G� 5Z      $	��500��6   $��40��5[      $��Center=�5\      $��Center=�5]      $��10, 10, 0, 3q�5^        ModernRepeatPasswordBox#��[ 5_      5`      �� 5b      $��4��6    �� Orientation$ 
Horizontal=�5c      $��Center=�5d      .+�5f      �� $��4��6   $��Изменить��5g      $��50��5h      $	��150��5i      
�������$��14(�5k      $
��Left=�5l      	 �� 	IsDefault	 .   MyButtonTheme#��[ 5o      ��5n      �� *ChangeCommand+5o      �� 5q      -   5        $��4��5q      $��Отмена��5r      $��50��5s      $	��150��5t      
�������$��40,0,0,0q�5v      $��14(�5w      $
��Left=�5x      
 �� IsCancel
 . #��[ 5z      6@   5{      5|      5}      5~      