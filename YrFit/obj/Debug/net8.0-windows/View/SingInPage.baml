   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:YrFit.View
YrFit.View  5      E AFluentWPF, Version=0.10.2.0, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5          YrFit.View.SingInPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:YrFit.View     5      Efw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      )  #SourceChord.FluentWPF.AcrylicWindow    AcrylicWindowStyle$  Normal=�5	   	      Enabled$
 True��5
   	      TintOpacity$	 0.1Q�5   	      AcrylicAccentState$ 
BlurBehind=�5   	    N� Title$ 
SingInPage��5      .��5      �  � RowDefinitions 5   
    � ColumnDefinitions 5   
   �� 5      $��500px �6   �� 5      $��4* �6   .+�5   
   � $��0��6    K� ZIndex$ 2��6    $	��Top=�63   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $
��0 40q�6O   .+�5      �� $��..\img\logo.png��6   $	��100��61   $��Center=�6=   6\   5      5      �� 5    
   $��0��6   *  $SourceChord.FluentWPF.PointerTracker	   Enabled$
	 True��6!   ���#2E2E2E
 J� Effect
 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         Color$ Black��6#      	Direction$	 220Q�61      ShadowDepth$ 5Q�6A      Opacity$	 0.8Q�6Q   ._�5$      �    
Page_Style#��[  6   .+�5%      �� $��Center=�6   .+�5(      �� $��Center=�6!   $��100 50q�6<   $ 2��6L   .+�5)      �� $��1��6!   ���#C43939$��Center=�6F   $��20q�6c   $��14(�6o     MaterialDesignLabel#���  6�   ��6}   �� *
ErrorBox+6�   ]� 5*      $	��5 0q�6$   .+�5+      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Person=�66   $��12��6E   $��Center=�6Q   ���#E2D6C7$��0,0,0,0q�6�   �� 5,      $��1��6%   ���#E2D6C7$��14(�6K   $��
Логин��6Y   #���  6i   5-      �� 5/      $��1��6$   ���#E2D6C7$��5 0 5 10q�51       * &MaterialDesignOutlinedTextFieldTextBox#��[ 52      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$&  Введите ваш логин��54          HintOpacity$	 0.2Q�55   !      
IsFloating$ False��56   !   ��53      �� *Login+.��56   N   57      ]� 58      $	��5 0q�6%   .+�59        $
 Lock=�66   $��12��6C   $��Center=�6O   ���#E2D6C7$��0,0,0,0q�6�   �� 5:      $��1��6$   ���#E2D6C7$��14(�6J   $��Пароль��6X   5;      G� 5<      -   5        $��1��5<   (   $��5 0 5 10q�5=      ���#E2D6C7 2 .MaterialDesignOutlinedPasswordFieldPasswordBox#��[ 5@      $( "Введите ваш пароль��5A   !   $	 0.2Q�5B   !   $ False��5C   !   �� 5D      $��3��6"   $��1��60   $��5 10 5 0q�6A   $��
Войти��6T   ��6d   �� *SignInCommand+�� 5E      $��Center=�6    $��10q�6=   ��5F      �� 5G       �� 
TargetType" ��6$    �� Triggers 5H   "   P� 5I   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5J   *   ��  �� Property � �� �� Value
 �����6G   5K   '   5M      �� 5O       �� TextDecorations$
 None{�6!    �� Command 68   �� *HLinkRegistrationCommand+.�6e   .�5P      �� 
�������$��14(�66   ,*У меня еще нет аккаунта6]   5Q      5R      5S      5T      5U      5V      �� 5X   
   $��0��6    J� IsHitTestVisible$ False��6"   $ 0��6;   $��2��6L   $��..\img\MaskLogin.png��6`   $
��Fill=�6   6�   5Z      5[      