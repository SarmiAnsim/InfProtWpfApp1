   M S B A M L   `   `   `  ����I  EInfProtWpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:InfProtWpfApp1.MVVM.ViewInfProtWpfApp1.MVVM.View  5      M+clr-namespace:InfProtWpfApp1.MVVM.ViewModelInfProtWpfApp1.MVVM.ViewModel  5      1    +InfProtWpfApp1.MVVM.View.ChangePasswordView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:InfProtWpfApp1.MVVM.View     5      A	viewmodel+clr-namespace:InfProtWpfApp1.MVVM.ViewModel     5      
������   � DataContext  5      ;  5InfProtWpfApp1.MVVM.ViewModel.ChangePasswordViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� .+�5      �� $r��lПосле смены пароля Ваш старый пароль будет недействителен!��6   $��Center=�5      $
��Left=�5      
�������$��20(�5      $��20,0,0,0q�5      �� 5!      $����Наличие цифр, знаков препинания и знаков арифметических операций в новом пароле��6   $��Center=�5"      $
��Left=�5#      
�������$��15(�5%      $��30,4,0,0q�5&      �� 5(      $��Center=�5)      $
��Left=�5*      
�������$��15(�5,      $��30,4,0,0q�5-      ��5(      �� *ConfinedStatus+5-      5.      �� 50   
   $��1��6   .+�51      �� $/��)Введите старый пароль:��6   $��Center=�52      $
��Left=�53      
�������$��18(�55      $��	20,10,0,0q�56      G� 58      $	��500��6   $��40��59      $��Center=�5:      $
��left=�5;      $��10, 10, 0, 1q�5<         ModernOldPasswordBox#��[  5=      5>      �� 5@   
   $��2��6   .+�5A      �� $-��'Введите новый пароль:��6   $��Center=�5B      $
��Left=�5C      
�������$��18(�5E      $��	20,10,0,0q�5F      G� 5H      $	��500��6   $��40��5I      $��Center=�5J      $
��left=�5K      $��10, 10, 0, 2q�5L        ModernNewPasswordBox#��[ 5M      5N      �� 5P   
   $��3��6   .+�5Q      �� $1��+Повторите новый пароль:��6   $��Center=�5R      $
��Left=�5S      
�������$��18(�5U      $��	20,10,0,0q�5V      G� 5X      $	��500��6   $��40��5Y      $��Center=�5Z      $
��left=�5[      $��10, 10, 0, 3q�5\        ModernRepeatPasswordBox#��[ 5]      5^      �� 5`   
   $��4��6   $��Изменить��5a      $��50��5b      $	��150��5c      
�������$��14(�5e      $��
171,10,0,0q�5f      $
��Left=�5g       �� 	IsDefault .   MyButtonTheme#��[ 5j      ��5i      �� *ChangeCommand+5j      5l      5m      