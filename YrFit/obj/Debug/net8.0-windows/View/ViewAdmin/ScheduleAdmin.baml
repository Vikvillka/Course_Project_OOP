   M S B A M L   `   `   `  ����@  <YrFit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:YrFit.View.ViewAdminYrFit.View.ViewAdmin  5      (    "YrFit.View.ViewAdmin.ScheduleAdmin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:YrFit.View.ViewAdmin     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	 cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah
 dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai  eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj! fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag" cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af# bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj$ fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak% gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah& dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!    	 
                        ! " # $ % & 5      b' ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes ' 5      ]( YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit ( 5
      .��5      � .+�5   
   �   � RowDefinitions  5      �� 5      $	��120 �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      $	��380 �6#   .+�5      ��  �� CornerRadius$ 10��6   ���#2E2E2E K� ZIndex$ 1��6<   $��	5 10 5 10q�6M   $��2��6`   $��1��6t    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6'      	Direction$	 290Q�65      ShadowDepth$ 5Q�6E      Opacity$	 0.3Q�6U   5      ]� 5      $��	20 10 0 0q�6   $
��Left=�6,   $��0��6G   $��0��6T   $��2��6e   $ 2��6y   .+�5       �� 	 �� Orientation$	 Vertical=�6   $��0 0 20 0q�64   $
��Left=�6G   .+�5"      �� $��Поиск:��6    $
��Left=�6/   $��20��6J   $��Center=�6V   $��16(�6r   
 J� Opacity$	
 0.8Q�6�   $
��Bold"�6�   ���#E2D6C7$��	0 10 10 5q�6�   �� 5#       *  &MaterialDesignOutlinedTextFieldTextBox#��[  6`   $
��Left=�5$      $��40��64   ���#E2D6C7$	��300��6U   ) ' #MaterialDesignThemes.Wpf.HintAssist   Hint$Q KВведите ID, тип тренировки или имя тренера��5%         HintOpacity$	 0.4Q�5&         
IsFloating$ False��5'      ��5#      �� *
SearchTerm+ �� UpdateSourceTrigger$ PropertyChanged=�5'      5)      �� 5*      $	��0 5q�6   .+�5+      �� $	 
Horizontal=�6!   .+�5,      �� $��	Дата:��6$   $
��Left=�61   $��20��6L   $��Center=�6X   $��14(�6s   $	
 0.8Q�6�   $
��Bold"�6�   ���#E2D6C7$��10 0 5 0q�6�   (  "System.Windows.Controls.DatePicker  5-      $
��Left=�6}   $	��120��6�   $��30��6�   ���#E2D6C7   SelectedDate 6%   �� *SelectedDate+ �� Mode$ TwoWay=�$ PropertyChanged=�6�   5.      �� 5/      $
��Left=�6    $��
10 10 30 5q�6;   $	��Top=�6O   �� 50       �� TextDecorations$
 None{�6)    �� Command 6@   �� *FilterTrainingsCommand+.�6k   .�51   *   ' ' !MaterialDesignThemes.Wpf.PackIcon     Kind$ ProgressClose=�6B   $��16��6X   $��Center=�6d   
�������$��0,0,0,0q�6�    �� 52   *   
�������$��14(�6F   $��0 -3 0 0q�6T   &$Вывод всех закрытых6{   53       54      �� 55      $
��Left=�6    $��	10 5 10 0q�6;   $��Bottom=�6O   �� 56      $
 None{�6    6-   �� *DeleteClosedTrainingCommand+.�6]   .�57        $ DeleteCircle=�6/   $��16��6D   $��Center=�6P   
�������$��0,0,0,0q�6~    �� 58      
�������$��14(�63   $��0 -3 0 0q�6A   ,*Удаление всех закрытых6k   59      5:      5<      �� 5=      $��56��6   $��20 0 5 0q�6C   ��6$   �� *
AllCommand+.��6U   Все6Z   �� 5>      $��50��6   $	��5 0q�6F   
������ ���#EC823A��6$   �� *MondayCommand+.��6�   пн6�   �� 5?      $��50��6   $	��5 0q�6G   
������ ���#EC823A��6$   �� *TuesdayCommand+.��6�   вт6�   �� 5@      $��50��6   $	��5 0q�6I   
������ ���#EC823A��6$   �� *WednesdayCommand+.��6�   ср6�   �� 5A      $��50��6   $	��5 0q�6H   
������ ���#EC823A��6$   �� *ThursdayCommand+.��6�   чт6�   �� 5B      $��50��6   $	��5 0q�6F   
������ ���#EC823A��6$   �� *FridayCommand+.��6�   пт6�   �� 5C      $��50��6   $	��5 0q�6H   
������ ���#EC823A��6$   �� *SaturdayCommand+.��6�   сб6�   �� 5D      $��50��6   $	��5 0q�6F   $
��Left=�6S   
������ ���#EC823A��6$   �� *SundayCommand+.��6�   вс6�   5E      �� 5G      $��0��6   $��2��6$   $
��Fill=�61   $��..\..\img\NotFound.png��6@   y�5H      �� 5I       �� Path$ IsEmptyImageVisible�6      BooleanToVisibilityConverter �� 	Converter# [ 69   5K      �� 5L      $��2��6   $ 1��6(   .��5N      �� $ �� IsSynchronizedWithCurrentItem$
 TrueY�6t   ��6   �� *	Trainings+ �� SelectedItem 6=   �� *SelectedTraining+$ TwoWay=���5O      �� 5P      .R�5Q      �  � Orientation$ 
Horizontal=�6(   5R      ��5T      �� 5U      .R�5V      �   
Page_Style#��[ 6$   .+�5W   "   �� $ 10��6)   ���#2E2E2E$��2 2 2 2q�6Q   $	��180��6b    5X   &     5Y   *   $ Black��6;   $	 290Q�6I   $ 5Q�6Y   $	 0.3Q�6i   ._�5[   &   �� .+�5\   *   � .+�5]   .   �� $	��150��65   $
��0 6 q�6B   $��4��6P   $
��Left=�6Z   $ 1��6u   ���#EC823A6�   �� 5_   .   $��15 10 10 10q�69   .+�5`   2   ]� $	��0 5q�6<   .+�5a   6   �� $
��Left=�6V   $��16(�5b   A   ���#E2D6C7$
 1Q�5d   A   $
��Bold"�5e   A   $
��Wrap=�5f   A   $	��0 0q�5g   A   $��Center=�5h   A   ��5a   @   �� *Type+5h   A   �� 5i   6   $��Right=�6C   ���#E2D6C7$	
 0.8Q�5k   3   $	��0 5q�5m   3   �� 5n   .   �62   �� *
Duration+6N    �� 5o   ,   $�мин.��60   6>   5p   7   5q   3   �� 5r   2   $	 
Horizontal=�6=   .+�5s   6   & (  Xceed.Wpf.Toolkit.DateTimePicker  ���#2E2E2E���#E2D6C7& (  Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�6�      FormatString$ dd-MM-yyyy HH:mm��6�   � ( �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Value 6t   �� *
DateTime+6�   5t   3   �� 5v   2   $
��Left=�6<   $
��Wrap=�5w   7   $��0 0 0 0q�5x   7   ���#E2D6C7$	
 0.8Q�5z   7   $��Center=�5{   7   �� 5|   0   $�Зал:��64   6B    �� 5}   0   �64   �� *
Location+6P   5~   3   �� 5   2   $
��Left=�6<   $
��Wrap=�5�   /   $��0 5 0 0q�5�   0   $��Тренер:��5�   /   ���#E2D6C7$	
 0.8Q�5�   /   $��Center=�5�   /   5�   3   �� 5�   2   $
��Left=�6>   $
��Wrap=�5�   /   $��0 0 0 5q�5�   /   ���#E2D6C7$	
 0.8Q�5�   /   $��Center=�5�   /   �� 5�   2   �67   �� *NameTrainer+6V   6\   ]� 5�   2   .+�5�   6   �� $
��Left=�6A   $
��Wrap=�5�   =   $��0 5 10 0q�5�   =   ���#E2D6C7$
 1Q�5�   =   $
��Bold"�5�   =   $��Center=�5�   =   �� 5�   >   $	�ID:��6C   6Q    �� 5�   2   $
��Bold"�6}   �68   �� *ID+$ TwoWay=�$ PropertyChanged=�6�   5�   7   �� 5�   6   $
��Left=�6A   $
��Wrap=�5�   =   $��0 5 0 0q�5�   =   ���#E2D6C7$	
 0.8Q�5�   =   $��Center=�5�   =   �� 5�   6   $�	Мест:��6;   6J    �� 5�   6   $
��Bold"�6�   �6<   �� *	MaxPeople+$ TwoWay=�$ PropertyChanged=�6�   5�   3   5�   3   ]� 5�   2   $��
10 -10 0 0q�6<   $��Right=�6P   .+�5�   6   �� $	 
Horizontal=�6A   $��60��6Z   .+�5�   :   ��   gridEditButton#��[ 5�   A   ��5�   A   �� *DataContext.SaveCommand+ �� RelativeSource ��  �� AncestorType ListBox��6�   �� .��5�   >   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Check=�6T     gridButtonIcon#��[ 6a   5�   ;   �� 5�   :   $��5 0 0 0q�5�   =     gridRemoveButton#��[ 6N   ��5�   =   �� *DataContext.DeleteCommand+ ��  ListBox��6�   �� .��5�   >     $ DeleteOutline=�6T   #��[ 6i   5�   ;   5�   7   5�   3   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      �� 5�      $��2��6   $ 1��6(   $��1��69   .��5�      �� $ 10��6   ���#2E2E2E$��
10 10 0 10q�6@    5�        5�      $ Black��6+   $	 290Q�69   $ 5Q�6I   $	 0.3Q�6Y   ._�5�      �� .+�5�      � #��[ 6    .+�5�      �� $��20 20q�6)   .+�5�   "   �� $��Добавление:��6,   $
��Left=�6@   $��16(�6\   $	
 0.8Q�6j   $
��Bold"�6x   ���#E2D6C7$��0 0 10 0q�6�   �� 5�   "   $��2��6)   $��0 10 0 0q�64   ���#EC823A6]   ]� 5�   "   .+�5�   &   �� $��Направление: ��60   $��16(�6E   ���#E2D6C7$	
 0.8Q�6h   $
��Wrap=�6w   $��0 10 0 0q�6�   $��Center=�5�   &   6C   �� 5�   &   $
��Left=�6/   $	��210��6J   $��16(�6V   ���#E2D6C7$
 1Q�6y    �� TextWrapping$
 Wrap=�6�   $��	10 10 0 0q�6�   $��Center=�5�   &   ��6B   �� *Type+$ PropertyChanged=�.��6   5�   '   5�   #   ]� 5�   "   $
��0 10q�6,   .+�5�   &   �� $%��Дата проведения: ��60   $��16(�6I   ���#E2D6C7$	
 0.8Q�6l   $
��Wrap=�6{   $��0 0 0 0q�6�   $��Center=�5�   2   6O   �� 5�   &   $	 
Horizontal=�61   $��Right=�6K   .+�5�   *     ���#2E2E2E$	��160��6S   ���#E2D6C7$ Custom=�6�   $ dd-MM-yyyy HH:mm��6�    6t   �� *
DateTime+6�   5�   '   5�   #   ]� 5�   "   .+�5�   &   �� $4��.Продолжительность (мин.): ��60   $��16(�6R   ���#E2D6C7$	
 0.8Q�6u   $
��Wrap=�6�   $��0 0 0 0q�6�   $��Center=�5�   1   6N   �� 5�   &   $
��Left=�6/   $��16(�6J   $	��120��6X   ���#E2D6C7$
 1Q�6y   $
 Wrap=�6�   $��0 0 0 0q�6�   $��Center=�5�   -   ��6I   �� *
Duration+$ PropertyChanged=�.��6�   5�   '   5�   #   ]� 5�   "   .+�5�   &   �� $��Номер зала: ��60   $��16(�6D   ���#E2D6C7$	
 0.8Q�6g   $
��Wrap=�6v   $��0 0 0 0q�6�   $��Center=�5�   -   6J   �� 5�   &   $
��Left=�6/   $��16(�6J   $��80��6X   ���#E2D6C7$
 1Q�6x   $
 Wrap=�6�   $��10 0 0 0q�6�   $��Center=�5�   .   ��6J   �� *
Location+$ PropertyChanged=�.��6�   5�   '   5�   #   ]� 5�   "   .+�5�   &   �� $ ��Стоимость (BYN): ��60   $��16(�6I   ���#E2D6C7$	
 0.8Q�6l   $
��Wrap=�6{   $��0 0 0 0q�6�   $��Center=�5�   1   6N   �� 5�   &   $
��Left=�6/   $��16(�6J   $��80��6X   ���#E2D6C7$
 1Q�6x   $
 Wrap=�6�   $��10 0 0 0q�6�   $��Center=�5�   1   ��6M   �� *Prise+$ PropertyChanged=�.��6�   5�   '   5�   #   ]� 5�   "   .+�5�   &   �� $��Тренер: ��60   $��16(�6@   ���#E2D6C7$	
 0.8Q�6c   $
��Wrap=�6r   $��0 0 0 0q�6�   $��Center=�5�   1   6N   �� 5�   &   $
��Left=�6/   $��16(�6J   $	��260��6X   ���#E2D6C7$
 1Q�6z   $
 Wrap=�6�   $��0 0 0 0q�6�   $��Center=�5�   -   ��6I   �� *NameTrainer+$ PropertyChanged=�.��6�   5�   '   5�   #   �� 5�   "   $��16(�6,   $-��'Описание тренировке: ��6:   $	
 0.8Q�6W   $��	0 10 0 10q�6e   ���#E2D6C7$
��Bold"�5�   *   �� 5�   "   $
��Auto=�6/   $��Disabled=�6R   $��-10 0q�6{   $	��320��6�   $	��140��6�   .��5�   &   �� ���#E2D6C7$��Center=�6C   $��Center=�6`   $��14(�6{   $	��0 0q�6�   $	��316��6�   $
 Wrap=�5�   -   $	��138��6A     �� 	MaxLength$	  700��6�   #��[  5�   -   ��5�   N   �� *Description+$ PropertyChanged=�5�   -   5�   #   ]� 5  "   .+�5  &   �� $+��%Количество человек: ��60   $��16(�6L   ���#E2D6C7$	
 0.8Q�6o   $
��Wrap=�6~   $��0 10 0 0q�6�   $��Center=�5  1   6N   �� 5  &   $
��Left=�6/   $��16(�6J   $	��160��6X   ���#E2D6C7$
 1Q�6z   $
 Wrap=�6�   $��0 10 0 0q�6�   $��Center=�5  0   ��6L   �� *	MaxPeople+$ PropertyChanged=�.��6�   5  '   5  #   �� 5  "   $��-20 0 -20 10q�6)   $��20��6?   5
  #   �� 5  "   $��Добавить��6)   $	��160��6<   $��Center=�6H   ��6f   �� *
AddCommand+5     5     5     5     5     �� 5     $��2��6   $��0��6%   ! J� IsHitTestVisible$! False��67   $ 0��6P   $��2��6a   $��..\..\img\FonPage.png��6u   $
��Fill=�6�   6�   5     5     5     