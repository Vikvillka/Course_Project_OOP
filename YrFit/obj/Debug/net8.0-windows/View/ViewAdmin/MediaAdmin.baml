   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:YrFit.View.ViewAdminYrFit.View.ViewAdmin  5      %    YrFit.View.ViewAdmin.MediaAdmin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:YrFit.View.ViewAdmin     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � RowDefinitions  5      �� 5      $	��170 �6    6/   �� 5      $��40 �6    6.   �� 5      $��* �6    6-   .+�5      � .+�5      ��  �� CornerRadius$ 10��6   ���#2E2E2E$��20 20 20 10q�6A    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6+      	Direction$	 290Q�69      ShadowDepth$ 5Q�6I      Opacity$	 0.3Q�6Y   ._�5      ��  �� Orientation$ 
Horizontal=�6!   $��20 10q�6:   .+�5      �� $	��280��6!   .+�5      �� $��Добавление:��6$   $
��Left=�68   $��16(�6T    J� Opacity$	 0.8Q�6b   $
��Bold"�6p   ���#E2D6C7$��	0 0 10 10q�6�   �� 5      $��Center=�6!   $ 
Horizontal=�6<   $
��Left=�6V   $	��300��6q   .+�5      �� $��Название: ��6$   $��0 0 0 10q�66   $��14(�6H   $	 0.6Q�6V   $
��Bold"�6d   ���#E2D6C76�   �� 5      ���#E2D6C7$
��Left=�68   $��14(�6S   $	��0 0q�6b   $	��195��6o   ��5      �� *Title+	 �� UpdateSourceTrigger$	 PropertyChanged=�5      5      �� 5      $��Center=�6%   $ 
Horizontal=�6@   $
��Left=�6Z   $	��300��6u   .+�5       �� $��Ссылка: ��6(   $��	0 20 0 10q�68   $��14(�6K   $	 0.6Q�6Y   $
��Bold"�6g   ���#E2D6C76�   �� 5!      ���#E2D6C7$
��Left=�6<   $��14(�6W   $
��0 20q�6f   $	��210��6t   ��5"   %   �� *MediaContent+$	 PropertyChanged=�5#       5$      5%      �� 5&      $��Center=�6!   $	��300��6>   .+�5'      �� $��Описание: ��6$   $��	10 45 0 0q�66   $��14(�6I   $	 0.6Q�6W   $
��Bold"�6e   ���#E2D6C76�   �� 5(      $
��Auto=�6'   $��Disabled=�6J   $
��Left=�6s   $	��5 0q�6�   $	��260��6�   $	��140��6�   .��5)      �� ���#E2D6C7$
��Left=�6;   $	��Top=�6V   $��14(�6n   $
��8 10q�6|   $	��236��6�   
 �� TextWrapping$

 Wrap=�5*   !   $��80��65    �� 	MaxLength$	 200��6_    *  &MaterialDesignOutlinedTextFieldTextBox#��[  5+   !   ��5*   A   �� *Description+5+   !   5,      5-      �� 5.      $��Добавить��6   $	��120��60   $
��Left=�6<   $��
-15 70 0 0q�6W   ��6k   �� *
AddCommand+5/      50      51      �� 52      ���#2E2E2E$ 5��6*   $��1��6;   $
��20 4q�6H   ._�53      ]� .+�54      �� $$��Вывод резултата:��6!   $
��Left=�6:   $
��20 4q�6V   $��16(�6d   $	 0.8Q�6r   $
��Bold"�6�   ���#E2D6C76�   ]� 55      $	��100��6    $��Right=�6,   $	��0 0q�6H   .+�56      �� -   5         ��Name$ Up��56   !   $
��Left=�6-    " MaterialDesignFlatAccentButton#��[ 6P   
������ ���#E2D6C7$��50��57   8   .��58      �� $ 
Horizontal=�6)   .+�59   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6:   $��0q�6K   5:      5;      �� 5<      -   5        $
 Back��5<   "   $
��Left=�60   #��[ 6S   
������ ���#E2D6C7$	��50 ��5=   <   .��5>      �� $ 
Horizontal=�6)   .+�5?   "     $ 
ArrowRight=�6:   $��0q�6L   5@      5A      5B      5C      5D      &   System.Windows.Controls.DataGrid  5E   
   -   5          Name$ dataGrid��5E   �    K� ZIndex$ 1��6:      AutoGenerateColumns$ False��6K      
IsReadOnly$
 True��6g   $��2��6y   $��
20 0 20 20q�6�   ��6   �� *MediasTraining+   Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L      
IsReadOnly$
 True��6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Id+5H        5I      $ Название��6?      MinWidth$	 150Q�6Q   $ False��6`    6%   �� *Title+5K        5L      $	 URL��6%   $	 200Q�6S    62   �� *MediaContent+   ElementStyle 5M      �� 5N       �� 
TargetType" ��6    .�5O      ��  �� Property �@�Cursor �� Value$
 Hand��67   -   5        5Q      5S        5T      $ Описание��6I   $	 200 6[    6)   �� *Description+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5U      $
 Auto 6)      CellTemplate 5V      �� 5W      .R�5X      �� $��2��6%   $	��100��65   $��Center=�6A   $��Center=�6\   $��Удалить��5Z   %   ��5X   y   �� *DataContext.DeleteCommand+ �� RelativeSource ��  �� AncestorType DataGrid��5Y   %   �� 5Z   %   5[      5]      5_      �� 5`      $��3��6   $��0��6%    J� IsHitTestVisible$ False��67   $ 0��6P   $��2��6a   $��..\..\img\FonPage.png��6u   $
��Fill=�6�   6�   5a      5b      