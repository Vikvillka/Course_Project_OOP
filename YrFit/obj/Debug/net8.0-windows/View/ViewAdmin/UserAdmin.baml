   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:YrFit.View.ViewAdminYrFit.View.ViewAdmin  5      $    YrFit.View.ViewAdmin.UserAdmin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:YrFit.View.ViewAdmin     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � RowDefinitions  5   
   �� 5      $	��140 �6   6+   �� 5      $��40 �6   6*   �� 5      $��* �6   6)   .+�5   
   � .+�5      �� $��Right=�6    K� ZIndex$ 3��64   $��10 20 20 20q�6E   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5   "   ��  �� Property � �� �� Value
 �   �6?   5      5      �� 5       �� TextDecorations$
 None{�6   	 �� Command	 6&   �� *ExitCommand+.�6G   .�5      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 	ExitToApp=�6#   $��12��65   $��Center=�6A   
���   �$��0,20,0,0q�6p    �� 5      
���   �$��14(�6(   $��0 0 10 0q�66   
Выйти6O   5      5      �� 5        �� CornerRadius$ 10��6   ���#2E2E2E$��20 20 20 10q�6=    J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         Color$ Black��6#      	Direction$	 290Q�61      ShadowDepth$ 5Q�6A      Opacity$	 0.3Q�6Q   ._�5$      ��  �� Orientation$ Vertical=�6   $��20 10q�60   .+�5&      �� $��Поиск:��6    $
��Left=�6/   $��16(�6K    J� Opacity$	 0.8Q�6Y   $
��Bold"�6g   ���#E2D6C7$��	0 0 10 10q�6�   �� 5'       *  &MaterialDesignOutlinedTextFieldTextBox#��[  6X   $
��Left=�5(      $��40��61   ���#E2D6C7$	��300��6R   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$D >Введите логин, Id или Email для поиска��5)         HintOpacity$	 0.4Q�5*         
IsFloating$ False��5+      ��5'      �� *
SearchTerm+ �� UpdateSourceTrigger$ PropertyChanged=�5+      5-      5.      5/      �� 50   
   ���#2E2E2E$ 5��6&   $��1��67   $
��20 4q�6D   ._�51      ]� .+�52      �� $$��Вывод резултата:��6   $
��Left=�66   $
��20 4q�6R   $��16(�6`   $	 0.8Q�6n   $
��Bold"�6|   ���#E2D6C76�   ]� 53      $	��100��6   $��Right=�6(   $	��0 0q�6D   .+�54      �� -   5         ��Name$ Up��54      $
��Left=�6%    " MaterialDesignFlatAccentButton#��[ 6H   
������ ���#E2D6C7$��50��55   8   .��56      �� $ 
Horizontal=�6!   .+�57        $
 	ArrowBack=�62   $��0q�6C   58      59      �� 5:      -   5        $
 Back��5:      $
��Left=�6(   #��[ 6K   
������ ���#E2D6C7$	��50 ��5;   <   .��5<      �� $ 
Horizontal=�6!   .+�5=        $
 
ArrowRight=�62   $��0q�6D   5>      5?      5@      5A      5B      &   System.Windows.Controls.DataGrid  5C   
   -   5          Name$ dataGrid��5C   }   $ 1��61      AutoGenerateColumns$ False��6B      
IsReadOnly$
 True��6^   $��2��6p   $��
20 0 20 20q�6�   ��6   �� *Users+   Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H      
IsReadOnly$
 True��6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+5F      4	  .System.Windows.Controls.DataGridTemplateColumn	  5G      -   5        DescriptionColumn��$ Аватарка��5G   D   $
 True��6V       MinWidth$	  100Q�6h   ! 	  CellTemplate! 5H      �� 5I      .R�5J      �� $ 
Horizontal=�6)   .+�5K   "   �� $ 2��6)   ._�5M   &   �� $��50��6,   $��50��67   $
��Fill=�6C     	ImageAnim#���  6o   ��6R   �� *	AvatarImg+6o   5N   #   5P      5Q      5S        5T      $ 
Логин��6?   $	  120Q�6N   $ False��6]    6%   �� *Login+5U        5V      $ Имя��6>   $	 120 6K    6%   �� *Name+6K     5W      $ Фамилия��6A   $	 140 6R    6%   �� *	Surname+6R     5X      $! Номер телефона��6E   $	 180 6]    6%   �� *PhoneNumber+6]     5Y      $ Эл. почта��6?   $	 200 6R    6%   �� *Email+6R     5Z      $ Дата рождения��6]   $	 140 6t    6%   �� *	BirthDate+" �� StringFormat$" 	dd.MM.yy ��6t   5\      �� 5]   
   $��3��6   $��0��6!   # J� IsHitTestVisible$# False��63   $ 0��6L   $��2��6]   $��..\..\img\FonPage.png��6q   $
��Fill=�6�   6�   5^      5_      