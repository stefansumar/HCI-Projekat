   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   G CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HCI_projekat.UnosHCI_projekat.Unos 5   	   A%clr-namespace:HCI_projekat.ValidacijaHCI_projekat.Validacija 5   	   !   HCI_projekat.Unos.UnosVrste   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   1localclr-namespace:HCI_projekat.Unos     5   	   <
validacija%clr-namespace:HCI_projekat.Validacija     5   	     � Title$  Dodavanje nove vrste��5
   	   $	��510��6&   $	��400��63    � Icon$_ YC:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\HCI_projekat\Ikonice\panda.png��5   	    � 
ResizeMode$ NoResize=�5   	    � ShowActivated .  � 	Resources 5       
  Color1��%+   &	        ��5   
   	#FF98A9C7��6*   5      .��5      � $��0,1,0,-1q�6   ��5   
   �� 5       �� Color# � ��6   .+�5   
   �� $��Oznaka:��6   $
��Left=�6"   $��	10,13,0,0q�6=   $	��Top=�6P   $��99��6h   $��Calibri)�6s   $��14(�6�   �� 5   
   -   5         ��Name$ 	OznakaTxt��5      $
��Left=�6&   $��23��6A   $��
125,13,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��227��6�   
������� � ToolTip$* $Obavezan unos oznake ugrožene vrste��6�   	 �� MaxLines$	 1��6�   
 �� 	MaxLength$
 20��6�   .��6�   ��5      �� 5       �� Path$ Oznaka�6    �� UpdateSourceTrigger$ PropertyChanged=�6(    �� ValidationRules 5      ( "HCI_projekat.Validacija.Validacija  5      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 60   5      .��5       =� ErrorTemplate 5       �� 5!      .R�5"      �  � RowDefinitions 5#      �� 5$       � ColumnDefinitions 5&      �� 5'      �� 5(      $
��Auto �6/   .+�5+      ��  ��Name$ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5,      $��1��6$   $��0��64   
���  ��$��Center=�6t   $��22(�6�   $��Medium"�6�   ��6A   �� *[0].ErrorContent+6�   5-      5.      .��5/   (   50      �� 54   
   $
��Ime:��6   $
��Left=�6   $��	10,39,0,0q�6:   $	��Top=�6M   $��99��6e   $��Calibri)�6p   $��14(�6�   �� 55   
   -   5        $ ImeTxt��55      $
��Left=�6"   $��23��6=   $��
125,42,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��227��6�   $) #Obavezan unos imena ugrožene vrste��6�   $	 1��6�   $
 20��6�   .��6�   ��56      �� 57      $	 Ime�6   $ PropertyChanged=�6%    58        5:       . 60   5<      .��5=       5>      �� 5?      .R�5@      �  5A      �� 5B       5D      �� 5E      �� 5F      $
��Auto �6/   .+�5I      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5J      $��1��6$   $��0��64   
���  ��$��Center=�6t   $��22(�6�   $��Medium"�6�   ��6A   �� *[0].ErrorContent+6�   5K      5L      .��5M   (   5N      �� 5P   
   $��Opis:��6   $
��Left=�6    $��	10,70,0,0q�6;   $	��Top=�6N   $��99��6f   $��Calibri)�6q   $��14(�6�   �� 5Q   
   -   5        $ OpisTxt��5Q      $
��Left=�6#   $��46��6>   $��
125,70,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��227��6�   $' !Opcion unos opisa ugrožene vrste��6�   $	 3��6�   $
 60��6�    �� AcceptsReturn . .��6�   ��5R      �� 5S      $
 Opis�6   $ PropertyChanged=�6&   .��5T      5U      �� 5W   
   $
��Tip:��6   $
��Left=�6   $��
10,121,0,0q�6:   $	��Top=�6N   $��Calibri)�6f   $��99��6{   $��14(�6�   �� 5X   
   -   5        $��Odaberi tip��5X      $
��Left=�6'   $��256,121,0,0q�6B   $	��Top=�6W   $��96��6o   $��23��6z   $��Calibri)�6�   6�   �� 5Y   
   -   5        $ TipTxt��5Y      $
��Left=�6"   $��23��6=   $��125,121,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��119��6�    ^� ShowOnDisabled . {�.   � Cursor$ Arrow��6�   .��6�   ��5Z      �� 5[      $ 
OznakaTipa�6   $ PropertyChanged=�6,    5\        5^       . 60   5`      .��5a       5b      �� 5c      .R�5d      �  5e      �� 5f       5h      �� 5i      �� 5j      $
��Auto �6/   .+�5m      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5n      $��1��6$   $��0��64   
���  ��$��Center=�6t   $��22(�6�   $��Medium"�6�   ��6A   �� *[0].ErrorContent+6�   5o      5p      .��5q   (   5r      �� 5t   
   $��Status ugroženosti:��6   $
��Left=�6.   $��
10,150,0,0q�6I   $	��Top=�6]   $��Calibri)�6u   $��14(�6�   �� 5u   
   -   5         ��Name$ Ugrozenost_ComboBox��5u      $
��Left=�60   $��125,152,0,0q�6K   $	��Top=�6`   $	��227��6x   $��Calibri)�6�   �� 5w   
   $��Ikonica:��6   $
��Left=�6#   $��
10,179,0,0q�6>   $	��Top=�6R   $��99��6j   $��Calibri)�6u   $��50��6�   $��14(�6�   �� 5x   
   
���   �$��1q�6%   $
��Left=�69   $��50��6T   $��128,179,0,0q�6`   $	��Top=�6u   $��64��6�   �� 5y   
   -   5         ��Name$ ikonica��5y      $
��Left=�6!   $��50��6<   $��128,179,0,0q�6H   $	��Top=�6]   $��64��6u   ��6�   �� $ Slika��� 5z   
   -   5        $��Odaberi ikonicu��5z      $
��Left=�6+   $��205,178,0,0q�6F   $	��Top=�6[   $	��147��6s   $��Calibri)�6   $��23��6�   6�   �� 5|   
   $��Opasna po ljude:��6   $
��Left=�6+   $��
10,229,0,0q�6F   $	��Top=�6Z   $	��105��6r   $��Calibri)�6~   $��14(�6�   	� 5}   
   -	   5         	�Name$ OpasnaDa��5}      $��Da��6(   $
��Left=�65   $��141,234,0,0q�6P   $	��Top=�6e    	� 	GroupName$ Opasna��6}   	� 5~   
   -
   5        $ OpasnaNe��5~      $��Ne��6(   $
��Left=�65   $��205,234,0,0q�6P   $	��Top=�6e   $ Opasna��6}   �� 5�   
   $��IUCN crvena lista:��6   $
��Left=�6-   $��
10,258,0,0q�6H   $	��Top=�6\   $	��114��6t   $��Calibri)�6�   $��14(�6�   	� 5�   
   -   5        $ IUCNDa��5�      $��Da��6&   $
 IUCN��63   $
��Left=�6D   $��141,263,0,0q�6_   $	��Top=�6t   $��34��6�   	� 5�   
   -   5        $ IUCNNe��5�      $��Ne��6&   $
 IUCN��63   $
��Left=�6D   $��205,263,0,0q�6_   $	��Top=�6t   �� 5�   
   $"��Živi u naseljenom
regionu:��6   $
��Left=�6>   $��
10,287,0,0q�6Y   $	��Top=�6m   $	��108��6�   $��Calibri)�6�   $��14(�6�   	� 5�   
   -   5        $ NaseljenoDa��5�      $��Da��6+   $ 	Naseljeno��68   $
��Left=�6N   $��141,303,0,0q�6i   $	��Top=�6~   $��34��6�   	� 5�   
   -   5        $ NaseljenoNe��5�      $��Ne��6+   $ 	Naseljeno��68   $
��Left=�6N   $��205,303,0,0q�6i   $	��Top=�6~   �� 5�   
   $��Turistički status:��6   $
��Left=�6-   $��
10,331,0,0q�6H   $	��Top=�6\   $	��114��6t   $��Calibri)�6�   $��14(�6�   �� 5�   
   -   5        $ TuristickiStatus_ComboBox��5�      $
��Left=�66   $��125,333,0,0q�6Q   $	��Top=�6f   $	��227��6~   $��Calibri)�6�   �� 5�   
   $��Godišnji prihod:��6   $
��Left=�6+   $��
10,360,0,0q�6F   $	��Top=�6Z   $��99��6r   $��Calibri)�6}   $��14(�6�   �� 5�   
   -   5        $ 	PrihodTxt��5�      $
��Left=�6%   $��23��6@   $��125,360,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $��64��6�   $	 1��6�   $
 8��6�   .��6�   ��5�      �� 5�      $ Prihod�6   $ PropertyChanged=�6(   .��5�      5�      �� 5�   
   $��$��6   $
��Left=�6   $��194,360,0,0q�67   $	��Top=�6L   $��23��6d   $��50��6p   $��Calibri)�6{   $��11(�6�   $
��Bold"�6�   �� 5�   
   $��Datum otkrivanja:��6   $
��Left=�6,   $��
10,389,0,0q�6G   $	��Top=�6[   $��Calibri)�6s   $��14(�6�   �� 5�   
   -   5        $��Sačuvaj��5�      $
��Left=�6#   $��155,430,0,0q�6>   $	��Top=�6S   $��96��6k   $��Calibri)�6v   $��23��6�   6�   (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$ Datum_DataPicker��5�      $
��Left=�6/   $��128,389,0,0q�6J   $	��Top=�6_   $	��224��6w   $��24��6�   
 �� Now   SelectedDate# Z 6�   �� 5�   
   -   5        $��Odustani��5�      $
��Left=�6$   $��256,430,0,0q�6?   $	��Top=�6T   $��96��6l   $��Calibri)�6w   $��23��6�    �� IsCancel . 6�   5�      5�      