   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:YrFitYrFit  5   	   1clr-namespace:YrFit.ViewModelYrFit.ViewModel  5   	   1clr-namespace:YrFit.UtilitiesYrFit.Utilities  5      E AFluentWPF, Version=0.10.2.0, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5   
       YrFit.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:YrFit     5   	   ,vmclr-namespace:YrFit.ViewModel     5   	   .Menuclr-namespace:YrFit.Utilities     5      Efw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF     5   
   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Icon$  .\Img\AppLogo.png��5	   
   )  #SourceChord.FluentWPF.AcrylicWindow   Enabled$
 True��5   	      TintOpacity$	 0.4Q�5   	      AcrylicAccentState$ 
BlurBehind=�5   	   $��15(�5   
   $	��690��6   $	��690��6%   $
��1220��65   $
��1220��6E      ExtendViewIntoTitleBar$
 True��5   	      FallbackColor$ #2E2E2E��5       � WindowStyle$
 None=�5   
    � DataContext 5      "  YrFit.ViewModel.NavigationVM  5   
   .��5      � *  $SourceChord.FluentWPF.PointerTracker   Enabled$
 True��6   ���	#af161616.+�5   
   � .+�5       � -   5        	  �Name$	 	MainFrame��5      
  � NavigationUIVisibility$
 Hidden=�6'   5      5       5!      5"      