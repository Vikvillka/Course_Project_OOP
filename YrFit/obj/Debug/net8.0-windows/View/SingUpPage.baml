   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:YrFit.View
YrFit.View  5          YrFit.View.SingUpPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:YrFit.View     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
SingUpPage��5
      .��5      �  � RowDefinitions 5   
    � ColumnDefinitions 5   
   �� 5      $��500px �6   �� 5      $��4* �6   .+�5   
   � $��0��6    K� ZIndex$ 2��6    $	��Top=�63   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $
��0 40q�6O   .+�5      �� $��..\img\logo.png��6   $	��100��61   $��Center=�6=   6\   5      5      �� 5   
   $��0��6   ���#2E2E2E._�5      � $��Center=�6      
Page_Style#��[  6.    5      �� 5      $��* �6'   �� 5       $��* �6'    5"      �� 5#      $��4* �6$   62   �� 5$      $��2* �6$   .+�5&      �� $	��Top=�6   $��	20 0 10 0q�65   $ 2��6H   .+�5'      �� $��1��6   
�������$��14(�6A   $��
Логин��6O     MaterialDesignLabel#���  6_   �� 5(      $��1��6    
�������$��5 0 5 10q�5*       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5+      ��5,      �� *Login+�� 5.      $��1��6   
�������$��14(�6A   $��Имя��6O   #���  6]   �� 5/      $��1��6    
�������$��5 0 5 10q�6C   #��[ 6U   ��50       �� *Name+�� 52      $��1��6   
�������$��14(�6A   $��Телефон��6O   #���  6a   �� 53      $��1��6    
�������$��5 0 5 10q�6C   #��[ 6U   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ +375-29-111-22-33��56   !      HintOpacity$	 0.2Q�57   !      
IsFloating$ False��58   !   ��54   !   �� *PhoneNumber+58   !   �� 5;      $��1��6   
�������$��14(�6@   $��Дата рождения��6N   (  "System.Windows.Controls.DatePicker  5<      $��1��6"   ���#E2D6C7$��5 0 5 10q�5>         SelectedDate 5?      �� *	BirthDate+5D      �� 5E      $	��Top=�6   $��	10 0 20 0q�65   $��1��6H   $ 2��6X   .+�5F      �� $��1��6   
�������$��14(�6@   $��Пароль��6N   G� 5G      -   5        $��1��5G   $   $��5 0 5 10q�5H      ���#E2D6C7 2 .MaterialDesignOutlinedPasswordFieldPasswordBox#��[ 5K      �� 5N      $��1��6   
�������$��14(�6A   $��Фамилия��6O   #���  6a   �� 5O      $��1��6    
�������$��5 0 5 10q�6C   #��[ 6U   ��5P      �� *	Surname+�� 5R      $��1��6   
�������$��14(�6A   $��
Почта��6O   #���  6_   �� 5S      $��1��6    
�������$��5 0 5 10q�6C   #��[ 6U   $ yourMail@gmail.com��5U   !   $	 0.2Q�5V   !   $ False��5W   !   ��5T       �� *Email+5W   !   5Z      �� 5[      $��2��6   $��2��61   .+�5\      �� $	��220��6   $��5 10 5 0q�6+   $��Регистрация��6>   ��6T   �� *SignUpCommand+�� 5]      $��Center=�6    $��10q�6=   ��5^      �� 5_      	 �� 
TargetType"	 ��6$   
 �� Triggers
 5`   "   P� 5a   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5b   *   ��  �� Property � �� �� Value
 �����6G   5c   '   5e      �� 5g       �� TextDecorations$
 None{�6%    �� Command 6<   �� *HLinkAutoCommand+.�6a   .�5h      �� 
�������$��14(�6:   
Назад6O   5i      5j      5k      5l      5n      �� 5o   
   $��1��6   $	��320��6&   .+�5p      �� ���#C43939$	��Top=�6.   $��20 0 0 0q�6F   $
��Wrap=�6X   $
��Left=�6l   $��14(�6�   ��6�   �� *
ErrorBox+5q      �� 5u   
   $��0��6    J� IsHitTestVisible$ False��6"   $ 0��6;   $��2��6L   $��..\img\MaskLogin.png��6`   $
��Fill=�6   6�   5w      5x      