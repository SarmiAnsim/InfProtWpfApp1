   M S B A M L   `   `   `  ����I  EInfProtWpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:InfProtWpfApp1.MVVM.ViewInfProtWpfApp1.MVVM.View  5      M+clr-namespace:InfProtWpfApp1.MVVM.ViewModelInfProtWpfApp1.MVVM.ViewModel  5      0    *InfProtWpfApp1.MVVM.View.ChangeDataKeyView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:InfProtWpfApp1.MVVM.View     5      A	viewmodel+clr-namespace:InfProtWpfApp1.MVVM.ViewModel     5      
������   � DataContext  5      :  4InfProtWpfApp1.MVVM.ViewModel.ChangeDataKeyViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� .+�5      �� $q��kПосле смены парольной фразы старая будет недействительна!��6   $��Center=�5      $
��Left=�5      
�������$��20(�5      $��	20,20,0,0q�5      5       �� 5"   
   $��1��6   .+�5#      �� $B��<Введите текущую парольную фразу:��6   $��Center=�5$      $
��Left=�5%      
�������$��18(�5'      $��	20,10,0,0q�5(      G� 5*      $	��500��6   $��40��5+      $��Center=�5,      $
��left=�5-      $��10, 10, 0, 1q�5.         ModernOldPasswordBox#��[  5/      50      �� 52   
   $��2��6   .+�53      �� $>��8Введите новую парольную фразу:��6   $��Center=�54      $
��Left=�55      
�������$��18(�57      $��	20,10,0,0q�58      G� 5:      $	��500��6   $��40��5;      $��Center=�5<      $
��left=�5=      $��10, 10, 0, 2q�5>        ModernNewPasswordBox#��[ 5?      5@      �� 5B   
   $��3��6   .+�5C      �� $B��<Повторите новую парольную фразу:��6   $��Center=�5D      $
��Left=�5E      
�������$��18(�5G      $��	20,10,0,0q�5H      G� 5J      $	��500��6   $��40��5K      $��Center=�5L      $
��left=�5M      $��10, 10, 0, 3q�5N        ModernRepeatPasswordBox#��[ 5O      5P      �� 5R   
   $��4��6   $��Изменить��5S      $��50��5T      $	��150��5U      
�������$��14(�5W      $��
171,10,0,0q�5X      $
��Left=�5Y       �� 	IsDefault .   MyButtonTheme#��[ 5\      ��5[      �� *ChangeCommand+5\      5^      5_      