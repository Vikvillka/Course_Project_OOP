   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:YrFit.View
YrFit.View  5      1clr-namespace:YrFit.UtilitiesYrFit.Utilities  5      e aMicrosoft.Web.WebView2.Wpf, Version=1.0.2478.35, Culture=neutral, PublicKeyToken=2a8ab48044d2601ekLclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.WpfMicrosoft.Web.WebView2.Wpf 5	      1clr-namespace:YrFit.UtilitiesYrFit.Utilities  5
          YrFit.View.MediaPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:YrFit.View     5      1convertclr-namespace:YrFit.Utilities     5      \wv2Lclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.Wpf     5	      +lclr-namespace:YrFit.Utilities     5
        � 	Resources  5      )   #YrFit.Utilities.VisibilityConverter   MediaContentConverter��%   &	          5   
   6&   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��37* �6   �� 5      $
��163* �6    � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $	��110 �6   �� 5      $��* �6   .+�5   
   �� $��2��6   ���#2E2E2E.+�5      �� ���#2E2E2E$��	10,10,0,0q�6.   $��20(�6A    J� Opacity$	 0.8Q�6O   ���#E2D6C7$��2��6s   �� 5      $,�&Выберите тренировку ��6   $
��Bold"�6#   67    �� 5      $c�]  (Загрузка метериала может занять некоторое время)��6   $��12(�6A   6R   5       5!      �� 5"   
   $��2��6   $��	10 35 0 0q�6   $	��150��6/   $
��Left=�6;   ���#EC823A6m   �� 5#   
   $��1��6   ���#2E2E2E$��2��69   .��5$      ��  �� CornerRadius$ 10��6   ���#2E2E2E$
��Left=�6<   $��
10 0 20 10q�6W   $	��900��6k   ._�5%      �� .+�5'      �� $ �� IsSynchronizedWithCurrentItem$
 TrueY�6m   ��6   �� *MediasTraining+ �� SelectedItem 6F   �� *SelectedTrain+��5(      �� 5)      .R�5*      ��  �� Orientation$ 
Horizontal=�6)   .+�5,   "   �� ���#E2D6C7$��0 0 0 0q�5.   -   �� 5/   .   $
��Bold"�6I   $��16(�6\   �62   �� *Title+6l    �� 50   .   $� ��62   6=    �� 51   .   $��13(�6Q   �62   �� *Description+6Q   53   #   54      55      57      58      59      5:      ]� 5;   
   $��2��6   $��2��6!   .+�5<      )  #Microsoft.Web.WebView2.Wpf.WebView2  -   5        $��webView��5<         Source 6*   �� *SelectedTrain.MediaContent+	 �� FallbackValue$4	 .https://www.youtube.com/@Nobadaddiction/videos��5=      5?      5A      