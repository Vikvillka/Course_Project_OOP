   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:YrFit.View.ViewAdminYrFit.View.ViewAdmin  5      1clr-namespace:YrFit.UtilitiesYrFit.Utilities  5      %    YrFit.View.ViewAdmin.EntryAdmin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:YrFit.View.ViewAdmin     5      .utilclr-namespace:YrFit.Utilities     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � 	Resources  5      +   %YrFit.Utilities.BoolToStatusConverter   BoolToStatusConverter-   'YrFit.Utilities.BoolToRowColorConverter  BoolToRowColorConverter��%:   &	        &	        5   
   6%     5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��140 �6   6+   �� 5      $��40 �6   6*   �� 5      $��* �6   6)   .+�5   
   � .+�5      ��  �� CornerRadius$ 10��6   ���#2E2E2E$��20 20 20 10q�6=    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6'      	Direction$	 290Q�65      ShadowDepth$ 5Q�6E      Opacity$	 0.3Q�6U   ._�5      ��  �� Orientation$ Vertical=�6   $��20 10q�64   .+�5      �� $��Поиск:��6    $
��Left=�6/   $��16(�6K   	 J� Opacity$		 0.8Q�6Y   $
��Bold"�6g   ���#E2D6C7$��	0 0 10 10q�6�   �� 5       * &MaterialDesignOutlinedTextFieldTextBox#��[ 6`   $
��Left=�5      $��40��6-   ���#E2D6C7$	��300��6N   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$+
 %Введите Id для поиска��5          HintOpacity$	 0.4Q�5!         
IsFloating$ False��5"      ��5      �� *
SearchTerm+ �� UpdateSourceTrigger$ PropertyChanged=�5"      5$      5%      5&      �� 5'   
   ���#2E2E2E$ 5��6&   $��1��67   $
��20 4q�6D   ._�5(      ]� .+�5)      �� $$��Вывод резултата:��6   $
��Left=�66   $
��20 4q�6R   $��16(�6`   $		 0.8Q�6n   $
��Bold"�6|   ���#E2D6C76�   ]� 5*      $	��100��6   $��Right=�6(   $	��0 0q�6D   .+�5+      �� -   5         ��Name$ Up��5+      $
��Left=�6)    " MaterialDesignFlatAccentButton#��[ 6L   
������ ���#E2D6C7$��50��5,   K   .��5-      �� $ 
Horizontal=�6%   .+�5.      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�66   $��0q�6G   5/      50      �� 51      -   5        $
 Back��51      $
��Left=�6,   #��[ 6O   
������ ���#E2D6C7$	��50 ��52   8   .��53      �� $ 
Horizontal=�6%   .+�54        $ 
ArrowRight=�66   $��0q�6H   55      56      57      58      59      &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ dataGrid��5:       K� ZIndex$ 1��63      AutoGenerateColumns$ False��6D      
IsReadOnly$
 True��6`   $��2��6r   $��
20 0 20 20q�6�   ��6   �� *	Entryes+   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ ID User��6@      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 100	 6Q      
IsReadOnly$
 True��6]   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6%   �� *UserId+5=        5>      $ 
Логин��6D      MinWidth$	 120Q�6S   $ False��6b    6%   �� *
User.Login+5?        5@      $ Id тренеровки��6D   $	 120	 6[    6%   �� *
TrainingId+6[     5A      $! Тип тренировки��6G   $	 120Q�6_   $ False��6n    6%   �� *Training.Type+5B        5C      $# Дата проведения��6K   $	 130	 6d    6%   �� *Training.DateTime+6d     5E      $ Статус��6r   $	 100	 6�    6%   �� *Status+ �� 	Converter# [  6�     5F      $! Номер телефона��6J   $	 180	 6b    6%   �� *User.PhoneNumber+6b     5G      $ Эл. почта��6D   $	 200	 6W    6%   �� *
User.Email+6W     5H      $ Дата записи��6g   $	 140	 6|    6%   �� *AttendanceDate+ �� StringFormat$ dd.MM.yy HH:mm��6|      RowStyle 5J      �� 5K       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5L      ��  �� Property � �� �� Value 63   �� *Status+# [ 5M      5O      �� 5P   
   $��3��6   $��0��6!     J� IsHitTestVisible$  False��63   $ 0��6L   $��2��6]   $��..\..\img\FonPage.png��6q   $
��Fill=�6�   6�   5Q      5R      