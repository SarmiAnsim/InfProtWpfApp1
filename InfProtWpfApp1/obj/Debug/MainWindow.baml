   M S B A M L   `   `   `  ����I  EInfProtWpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:InfProtWpfApp1InfProtWpfApp1  5   	   M+clr-namespace:InfProtWpfApp1.MVVM.ViewModelInfProtWpfApp1.MVVM.ViewModel  5   	       InfProtWpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:InfProtWpfApp1     5   	   A	viewModel+clr-namespace:InfProtWpfApp1.MVVM.ViewModel     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      1  +InfProtWpfApp1.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ���#303344$��2q�5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5       $��75 �6    �� 5!      .+�5$      �� $��Center=�5%      $
��Left=�5&      
�������$��22(�5(      $��20,0,0,0q�5)      ��5$      �� *
User.Login+5)      �� 5+      -   5        $��1��5+      
������ ._�5/      ��  �� Orientation$ 
Horizontal=�6   $��Right=�50      $��0,0,15,0q�51      .+�53      �� -   5        $��
Выйти��53      $��50��54      $	��150��55      
�������$��14(�57      	 �� IsCancel	 .    MyButtonTheme#��[  5:      �� 5<      -   5        $	��✖��5<      $��50��5=      $��50��5>      
�������$��20(�5@      #��[  5B      5C      5D      �� 5F      $��1��6   .+�5G      	� -   5        
 	�Name$
 UsersRB��5H      $��Пользователи��5G      $��50��5I      
�������$��14(�5K        MenuButtonTheme#��[ 5L      ��5M      �� *UsersViewCommand+	� 5O      -   5        $
 DataRB��5P      $"��Доступ к данным��5O      $��50��5Q      
�������$��14(�5S      #��[ 5T      ��5U      �� *ChangeDataKeyViewCommand+	� 5W      $#��Изменить пароль��6   $��50��5X      
�������$��14(�5Z      #��[ 5[      ��5\      �� *ChangePasswordViewCommand+	� 5^      $��Справка��6   $��50��5_      
�������$��14(�5a       d� 	IsChecked$
 TrueY�5b      #��[ 5c      ��5d      �� *ReferenceViewCommand+5f      �� 5h      -   5         ��Name$ 	MyContent��5h      $��1��5i      $��1��5j      $��10q�5k      ��5l      �� *CurrentView+5n      5p      5r      