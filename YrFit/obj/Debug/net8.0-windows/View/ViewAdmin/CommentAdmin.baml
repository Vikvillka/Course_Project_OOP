   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:YrFit.View.ViewAdminYrFit.View.ViewAdmin  5      '    !YrFit.View.ViewAdmin.CommentAdmin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:YrFit.View.ViewAdmin     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $	��130 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 10��6   ���#2E2E2E$��20 20 20 10q�69    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      	Direction$	 290Q�61      ShadowDepth$ 5Q�6A      Opacity$	 0.3Q�6Q   ._�5      ��  �� Orientation$ Vertical=�6   $��20 10q�60   .+�5      �� $��Поиск:��6   $
��Left=�6+   $��16(�6G   	 J� Opacity$		 0.8Q�6U   $
��Bold"�6c   ���#E2D6C7$��	0 0 10 10q�6�   �� 5       *  &MaterialDesignOutlinedTextFieldTextBox#��[  6\   $
��Left=�5      $��40��6)   ���#E2D6C7$	��300��6J   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$4
 .Введите поисковой запрос��5         HintOpacity$	 0.4Q�5         
IsFloating$ False��5      ��5      �� *
SearchTerm+ �� UpdateSourceTrigger$ PropertyChanged=�5      5       5!      � 5"   
   $��2��6   $��0��6     
Page_Style#��[ 6-    K� ZIndex$ 1��6Q   .+�5#      �� $��2��68   $��0��6E   $��	80 0 80 0q�5$      $ 1��5%      ��5#      �� *
Comments+ � 	Resources 5'       �� 
TargetType �� Property �� Value �� 
TargetType��%�   '��       �� 5(      " ��6   .�5)      ��  � �� 5*      �� 5+      " ��6.   .R�5,   "   �  5-   &   �� 5.   *   $��* �68   �� 5/   *   $
��Auto �68   .+�51   &   �� $��0��6=   52   #   53      55      56      57      ��58      �� 59      .R�5:      � .+�5;      �� $ 10��6!   ���#2E2E2E$��5q�6H    5<        5=   "   $ Black��63   $	 290Q�6A   $ 5Q�6Q   $	 0.3Q�6a   ._�5?      �   5@   "   �� 5A   &   $	��100 �67   �� 5B   &   $��* �67   �� 5C   &   $	��150 �67   .+�5E   "   �� $	��Top=�6)   $��80��6A   $��	0 10 0 10q�6L   $ 40��6_    J� Clip 5F   &   @� 5G   *    @� Center$ 40,40&�6:    @� RadiusX$ 40Q�6I    @� RadiusY$ 40Q�6V   ._�5I   &   �� $��2��6s   $��2��6�   $��80��6�   $
��Fill=�6�   $��80��6�   ��6,   �� *User.AvatarImg+$ PropertyChanged=�6�   5J   #   �� 5L   "   $��1��6-   .+�5M   &   ]� $
��0 10q�60   .+�5N   *   �� $
��10,0q�64   ���#E2D6C7$		 0.8Q�6W   �� 5O      $ �Пользователь: ��6"   $��14(�68    �� 5P      $��14(�6>   $
��Bold"�6L   �6"   �� *
User.Login+6L   5Q   +   �� 5R   *   $		 0.6Q�6m   ���#E2D6C7$
��10 0q�6�   $��Right=�6�   ��64   �� *
DateTime+ �� StringFormat$ dd.MM.yy hh:mm��6�   5S   '   �� 5T   &   ���#E2D6C7$		 0.8Q�6b   $
��Wrap=�6p   $
��Left=�6�   $��10q�6�   $	��460��6�   ��60   �� *CommentText+6�   5U   #   �� 5V   "   $��2��6)   $	��100��69   $��Center=�6E   $��Center=�6`   $��Удалить��5X      ��5V   }   �� *DataContext.DeleteCommand+ �� RelativeSource ��  �� AncestorType ListView��5W      �� 5X      5Y      5Z      5[      5\      5^      5_      �� 5`   
   $��2��6   $��0��6!    J� IsHitTestVisible$ False��63   $ 0��6L   $��2��6]   $��..\..\img\FonPage.png��6q   $
��Fill=�6�   6�   5a      5b      