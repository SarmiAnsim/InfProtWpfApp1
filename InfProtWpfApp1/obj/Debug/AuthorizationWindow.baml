   M S B A M L   `   `   `  ����I  EInfProtWpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:InfProtWpfApp1InfProtWpfApp1  5   	   M+clr-namespace:InfProtWpfApp1.MVVM.ViewModelInfProtWpfApp1.MVVM.ViewModel  5   	   (    "InfProtWpfApp1.AuthorizationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:InfProtWpfApp1     5   	   A	viewModel+clr-namespace:InfProtWpfApp1.MVVM.ViewModel     5   	     � Title$  AuthorizationWindow��5	   	   $	��350��6%   $	��500��62    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      :  4InfProtWpfApp1.MVVM.ViewModel.AuthorizationViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ���#303344$��2q�5      ._�5   
   �  � RowDefinitions 5      �� 5      $��70 �6    �� 5      �� 5      �� 5      .+�5!      �� $��Аунтификация��6   $��Center=�5"      $��Center=�5#      
�������$��25(�5%      $��20,0,0,0q�5&      �� 5(      $��1��6    �� Orientation$ 
Horizontal=�5)      .+�5*      �� $ ��Введите логин:��6   $��Center=�5+      $
��Left=�5,      
�������$��18(�5.      $��	20,10,0,0q�5/      �� 51      $	��300��6   $��40��52      $��Center=�53      $��Center=�54      $��	32,10,0,0q�55      	 �� 	MaxLength$	 14��56         ModernSimpleTextBox#��[  57      58      �� 5:      $��2��6   $ 
Horizontal=�5;      .+�5<      �� $"��Введите пароль:��6   $��Center=�5=      $
��Left=�5>      
�������$��18(�5@      $��	20,10,0,0q�5A      G� 5C      $	��300��6   $��40��5D      $��Center=�5E      $��Center=�5F      $��	20,10,0,0q�5G        ModernOldPasswordBox#��[ 5H      5I      �� 5K      $��3��6   $ 
Horizontal=�5L      $��Center=�5M      .+�5N      �� $��
Войти��6   $��50��5O      $	��150��5P      
�������$��14(�5R      
 �� 	IsDefault
 .   MyButtonTheme#��[ 5U      ��5T      �� *EnterCommand+5U      �� 5V      -   5        $��Отмена��5V      $��50��5W      $	��150��5X      
�������$��14(�5Z      $��40,0,0,0q�5[       �� IsCancel . #��[ 5^      5_      5c      5e      5f      