   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   G CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HCI_projekat.UnosHCI_projekat.Unos 5   	   A%clr-namespace:HCI_projekat.ValidacijaHCI_projekat.Validacija 5   	   !   HCI_projekat.Unos.UnosVrste   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   1localclr-namespace:HCI_projekat.Unos     5   	   <
validacija%clr-namespace:HCI_projekat.Validacija     5   	     � Title$  Dodavanje nove vrste��5
   	   $	��610��6&   $	��400��63    � 
ResizeMode$ NoResize=�5   	    � ShowActivated .  J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<    � 	Resources 5       
  Color1��%+   &	        ��5   
   	#FF98A9C7��6*   5      .��5      � $��0,1,0,-1q�6   ��5   
   �� 5       �� Color# � ��6   .+�5   
   �� $��Oznaka:��6   $
��Left=�6"   $��	10,13,0,0q�6=   $	��Top=�6P   $��99��6h   $��Calibri)�6s   $��14(�6�   �� 5   
   -   5         ��Name$ 	OznakaTxt��5      $
��Left=�6&   $��23��6A   $��
125,13,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��227��6�   
�������	 � ToolTip$*	 $Obavezan unos oznake ugrožene vrste��6�   
 �� MaxLines$
 1��6�    �� 	MaxLength$ 20��6�   .��6�    5        5      -   5        $ ApplicationCommands.Help��5   !   6D   .��5   '   ��5      �� 5       �� Path$ Oznaka�6    �� UpdateSourceTrigger$ PropertyChanged=�6(    �� ValidationRules 5       ( "HCI_projekat.Validacija.Validacija  5"      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 60   5$      .��5%       =� ErrorTemplate 5&      �� 5'      .R�5(      �  � RowDefinitions 5)      �� 5*       � ColumnDefinitions 5,      �� 5-      �� 5.      $
��Auto �6/   .+�51      ��  ��Name$ textBox��6Q   $��0��64   $��0��6D   6Q   �� 52      $��1��6$   $��0��64   
���  ��$��Center=�6t   $��22(�6�   $��Medium"�6�   ��6A   �� *[0].ErrorContent+6�   53      54      .��55   (   56      �� 5:   
   $
��Ime:��6   $
��Left=�6   $��	10,39,0,0q�6:   $	��Top=�6M   $��99��6e   $��Calibri)�6p   $��14(�6�   �� 5;   
   -   5        $ ImeTxt��5;      $
��Left=�6"   $��23��6=   $��
125,42,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��227��6�   $)	 #Obavezan unos imena ugrožene vrste��6�   $
 1��6�   $ 20��6�   .��6�   ��5<      �� 5=      $	 Ime�6   $ PropertyChanged=�6%    5>        5@       . 60   5B      .��5C       5D      �� 5E      .R�5F      �  5G      �� 5H       5J      �� 5K      �� 5L      $
��Auto �6/   .+�5O      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5P      $��1��6$   $��0��64   
���  ��$��Center=�6t   $��22(�6�   $��Medium"�6�   ��6A   �� *[0].ErrorContent+6�   5Q      5R      .��5S   (   5T      �� 5V   
   $��Opis:��6   $
��Left=�6    $��	10,70,0,0q�6;   $	��Top=�6N   $��99��6f   $��Calibri)�6q   $��14(�6�   �� 5W   
   -   5        $ OpisTxt��5W      $
��Left=�6#   $��46��6>   $��
125,70,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��227��6�   $'	 !Opcion unos opisa ugrožene vrste��6�   $
 3��6�   $ 60��6�    �� AcceptsReturn . .��6�   ��5X      �� 5Y      $
 Opis�6   $ PropertyChanged=�6&   .��5Z      5[      �� 5]   
   $
��Tip:��6   $
��Left=�6   $��
10,121,0,0q�6:   $	��Top=�6N   $��Calibri)�6f   $��99��6{   $��14(�6�   �� 5^   
   -   5        $��Odaberi tip��5^       � Cursor$
 Hand��6'   $6	 0Kliknite kako biste odabrali tip ugrožene vrste��65   $
��Left=�6o   $��256,121,0,0q�6�   $	��Top=�6�   $��96��6�   $��23��6�   $��Calibri)�6�   6�   �� 5_   
   -   5        $ TipTxt��5_      $
��Left=�6"   $��23��6=   $��125,121,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��119��6�   {�.  $ Arrow��6�   $*	 $Obavezan odabir tipa ugrožene vrste��6�   .��6�   ��5`      �� 5a      $ 
OznakaTipa�6   $ PropertyChanged=�6,    5b        5d       . 60   5f      .��5g       5h      �� 5i      .R�5j      �  5k      �� 5l       5n      �� 5o      �� 5p      $
��Auto �6/   .+�5s      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5t      $��1��6$   $��0��64   
���  ��$��Center=�6t   $��22(�6�   $��Medium"�6�   ��6A   �� *[0].ErrorContent+6�   5u      5v      .��5w   (   5x      �� 5z   
   $��Status ugroženosti:��6   $
��Left=�6.   $��
10,150,0,0q�6I   $	��Top=�6]   $��Calibri)�6u   $��14(�6�   �� 5{   
   -   5         ��Name$ Ugrozenost_ComboBox��5{      $3	 -Odaberite status ugroženosti ugrožene vrste��60   $
��Left=�6f   $��125,152,0,0q�6�   $	��Top=�6�   $	��227��6�   $��Calibri)�6�   �� 5}   
   $��Ikonica:��6   $
��Left=�6#   $��
10,179,0,0q�6>   $	��Top=�6R   $��99��6j   $��Calibri)�6u   $��50��6�   $��14(�6�   �� 5~   
   
���   �$��1q�6%   $
��Left=�69   $��50��6T   $��128,179,0,0q�6`   $	��Top=�6u   $��64��6�   �� 5   
   -	   5         ��Name$ ikonica��5      $	 Ikonica ugrožene vrste��6!   $
��Left=�6B   $��50��6]   $��128,179,0,0q�6i   $	��Top=�6~   $��64��6�   ��6�   �� $ Slika��� 5�   
   -
   5        $��Odaberi ikonicu��5�      $
 Hand��6+   $:	 4Kliknite kako biste odabrali ikonicu ugrožene vrste��69   $
��Left=�6w   $��205,178,0,0q�6�   $	��Top=�6�   $	��147��6�   $��Calibri)�6�   $��23��6�   6�   �� 5�   
   $��Opasna po ljude:��6   $
��Left=�6+   $��
10,229,0,0q�6F   $	��Top=�6Z   $	��105��6r   $��Calibri)�6~   $��14(�6�   	� 5�   
   -   5         	�Name$ OpasnaDa��5�      $��Da��6(   $
��Left=�65   $��141,234,0,0q�6P   $	��Top=�6e    	� 	GroupName$ Opasna��6}   	� 5�   
   -   5        $ OpasnaNe��5�      $��Ne��6(   $
��Left=�65   $��205,234,0,0q�6P   $	��Top=�6e   $ Opasna��6}   �� 5�   
   $��IUCN crvena lista:��6   $
��Left=�6-   $��
10,258,0,0q�6H   $	��Top=�6\   $	��114��6t   $��Calibri)�6�   $��14(�6�   	� 5�   
   -   5        $ IUCNDa��5�      $��Da��6&   $
 IUCN��63   $
��Left=�6D   $��141,263,0,0q�6_   $	��Top=�6t   $��34��6�   	� 5�   
   -   5        $ IUCNNe��5�      $��Ne��6&   $
 IUCN��63   $
��Left=�6D   $��205,263,0,0q�6_   $	��Top=�6t   �� 5�   
   $"��Živi u naseljenom
regionu:��6   $
��Left=�6>   $��
10,287,0,0q�6Y   $	��Top=�6m   $	��108��6�   $��Calibri)�6�   $��14(�6�   	� 5�   
   -   5        $ NaseljenoDa��5�      $��Da��6+   $ 	Naseljeno��68   $
��Left=�6N   $��141,303,0,0q�6i   $	��Top=�6~   $��34��6�   	� 5�   
   -   5        $ NaseljenoNe��5�      $��Ne��6+   $ 	Naseljeno��68   $
��Left=�6N   $��205,303,0,0q�6i   $	��Top=�6~   �� 5�   
   $��Turistički status:��6   $
��Left=�6-   $��
10,331,0,0q�6H   $	��Top=�6\   $	��114��6t   $��Calibri)�6�   $��14(�6�   �� 5�   
   -   5        $ TuristickiStatus_ComboBox��5�      $2	 ,Odaberite turistički status ugrožene vrste��66   $
��Left=�6k   $��125,333,0,0q�6�   $	��Top=�6�   $	��227��6�   $��Calibri)�6�   �� 5�   
   $��Godišnji prihod:��6   $
��Left=�6+   $��
10,360,0,0q�6F   $	��Top=�6Z   $��99��6r   $��Calibri)�6}   $��14(�6�   �� 5�   
   -   5        $ 	PrihodTxt��5�      $4	 .Opcion unos gosišnjeg prihoda ugrožene vrste��6%   $
��Left=�6\   $��23��6w   $��125,360,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��64��6�   $
 1��6�   $ 8��6�   .��6�   ��5�      �� 5�      $ Prihod�6   $ PropertyChanged=�6(   .��5�      5�      �� 5�   
   $��$��6   $
��Left=�6   $��194,360,0,0q�67   $	��Top=�6L   $��23��6d   $��50��6p   $��Calibri)�6{   $��11(�6�   $
��Bold"�6�   �� 5�   
   $��Datum otkrivanja:��6   $
��Left=�6,   $��
10,389,0,0q�6G   $	��Top=�6[   $��Calibri)�6s   $��14(�6�   �� 5�   
   -   5        $��Sačuvaj��5�      $
 Hand��6#   $5	 /Kliknite kako biste dodali novu ugroženu vrstu��61   $
��Left=�6j   $��155,540,0,0q�6�   $	��Top=�6�   $��96��6�   $��Calibri)�6�   $��23��6�   6�   (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$ Datum_DataPicker��5�      $
 Hand��6/   $0	 *Odaberite datum otkrivanja ugrožene vrste��6=   $
��Left=�6q   $��128,389,0,0q�6�   $	��Top=�6�   $	��224��6�   $��24��6�   
 �� Now   SelectedDate# Z 6�   �� 5�   
   -   5        $��Odustani��5�      $
 Hand��6$   $N	 HKliknite ukoliko želite da odustanete od dodavanja nove ugrožene vrste��62   $
��Left=�6�   $��256,540,0,0q�6�   $	��Top=�6�   $��96��6�   $��Calibri)�6�   $��23��6�    �� IsCancel . 6   �� 5�   
   -   5         ��Name$ EtiketeListView��5�      $
��Left=�6{   $	��117��6�   $��128,418,0,0q�6�   $	��Top=�6�   $	��123��6�   ��6,   �� $ EtiketeVrste�$ PropertyChanged=� �� View 5�      �� 5�      .P�5�      �� $��Oznaka��6%     �� Width$  70��65   ! �� DisplayMemberBinding! 6@   �� $ Oznaka�$ PropertyChanged=��� 5�      $
��Boja��6%   $  50��63   " �� CellTemplate" 5�      �� 5�      .R�5�   "   �� $��50��6,   $��15��67   ��5�   &   �� 5�   *    6:   �� $
 Boja�$ PropertyChanged=�5�   #   5�      5�      5�      5�      �� 5�   
   $��Etikete:��6   $
��Left=�6#   $��
10,421,0,0q�6>   $	��Top=�6R   $	��113��6j   $��Calibri)�6v   $��14(�6�   �� 5�   
   -   5        # ��Name$# DodajEtiketuButton��5�      $��Dodaj etiketu��6-   $
 Hand��6E   $(	 "Kliknite kako biste dodali etiketu��6S   $
��Left=�6�   $��256,418,0,0q�6�   $	��Top=�6�   $��96��6�   $��Calibri)�6�   $��23��6�   6�   �� 5�   
   -   5        $# UkloniEtiketuButton��5�      $��Ukloni etiketu��6.   $
 Hand��6G   $*	 $Kliknite kako biste uklonili etiketu��6U   $
��Left=�6�   $��256,446,0,0q�6�   $	��Top=�6�   $��96��6�   $��Calibri)�6�   $��23��6�   6�   5�      5�      