   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:YrFit.View
YrFit.View  5          YrFit.View.Comment   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:YrFit.View     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $	��180 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 10��6   $
��Left=�6#   ���#2E2E2E$��20 40 20 10q�6T   $	��710��6i    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      	Direction$	 290Q�61      ShadowDepth$ 5Q�6A      Opacity$	 0.3Q�6Q   ._�5      �� $��Center=�6   $	��100��64   .+�5      �� $���~Вы можете оставить тут свой комментарий о работе нашего фитнес-клуба��6   ���#E2D6C7$��30 10q�5       J� Opacity$	 0.6Q�6+   $	��Top=�5      $��14(�5      6,   ]� 5      $��0 0 0 0q�6   .+�5      �� ���#E2D6C7$	��500��6L   $��40��6Z    *  &MaterialDesignOutlinedTextFieldTextBox#��[  5      
������ $��30 10q�5       )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$-	 'Оставьте комментарий��5!      
   HintOpacity$	
 0.4Q�5"         
IsFloating$ False��5#      ��5      �� *CommentText+5#   L   �� 5$      $	��120��6;   $
��Left=�5%      $	��0 0q�5&      ��5$      �� *AddCommentCommand+.��5&   #   Добавить6-   5'      �� 5(      $��30 -10q�6   ���#E2D6C7$	 0.6Q�6C   ��6Q   �� *ErrorComment+6r   5)      5*      � 5+   
   $��2��6   $��0��6   $��
80 40 80 0q�6.    K� ZIndex$ 1��6B     
Page_Style#��[ 6T   .+�5,      �� ��6   �� *
Comments+��5-      �� 5.       �� 
TargetType" ��6   .�5/      ��  �� Property �@J�IsHitTestVisible �� Value$ False��6=   50       � 	Resources 52       �� 
TargetType��%�   '��       �� 53      " ��6   .�54      ��  � �� 55      �� 56   "   " ��62   .R�57   &   �  58   *   �� 59   .   $��* �6<   �� 5:   .   $
��Auto �6<   .+�5<   *   �� $��0��6A   5=   '   5>   #   5@      5A      5B      ��5C      �� 5D      .R�5E      � .+�5F      �� $ 10��6%   ���#2E2E2E J� IsHitTestVisible$ False��6N   $��5q�6g    5G   "     5H   &   $ Black��67   $	 290Q�6E   $ 5Q�6U   $	 0.3Q�6e   ._�5J   "   �   5K   &   �� 5L   *   $	��100 �6;   �� 5M   *   $��* �6;   .+�5O   &   �� $	��Top=�6-   $��80��6F   $��	0 10 0 10q�6Q   $ 40��6e    J� Clip 5P   *   @� 5Q   .    @� Center$ 40,40&�6>    @� RadiusX$ 40Q�6M    @� RadiusY$ 40Q�6Z   ._�5S   *   �� $��2��6w   $��2��6�   $��80��6�   $
��Fill=�6�   $��80��6�   ��60   �� *User.AvatarImg+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5T   '   �� 5V   &   $��1��61   .+�5W   *   ]� $
��0 10q�64   .+�5X   .   �� $
��10,0q�69   ���#E2D6C7$	 0.8Q�6\   �� 5Y   &   $ �Пользователь: ��6*   $��14(�6A    �� 5Z   &   $��14(�6F   $
��Bold"�6T   �6*   �� *
User.Login+6T   5[   /   �� 5\   .   $	 0.6Q�6q   ���#E2D6C7$
��10 0q�6�   $��Right=�6�   ��68   �� *
DateTime+ �� StringFormat$ dd.MM.yy hh:mm��6�   5]   +   �� 5^   *   ���#E2D6C7$	 0.8Q�6g   $
��Wrap=�6u   $
��Left=�6�   $��10q�6�   $	��460��6�   ��64   �� *CommentText+6�   5_   '   5c   #   5d      5e      5f      5h      5i      �� 5j   
   $��2��6   $��0��6!   $ False��63   $ 0��6L   $��2��6]   $��..\img\FonPage.png��6q   $
��Fill=�6�   6�   5l      5m      