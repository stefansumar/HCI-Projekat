   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HCI_projekat.UnosHCI_projekat.Unos  5   	   A%clr-namespace:HCI_projekat.ValidacijaHCI_projekat.Validacija  5   	   %    HCI_projekat.Unos.UnosTipaVrste   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HCI_projekat.Unos     5   	   <
validacija%clr-namespace:HCI_projekat.Validacija     5   	     � Title$  Dodavanje novog tipa��5	   	   $	��260��6&   $	��400��63    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   � ��5      �� 5       �� Color# � ��6"   .+�5      �� $��Oznaka:��6   $
��Left=�6&   $��	10,13,0,0q�6A   $	��Top=�6T   $��90��6l   $��Calibri)�6w   $��14(�6�   �� 5      $��Naziv:��6   $
��Left=�6%   $��	10,39,0,0q�6@   $	��Top=�6S   $��99��6k   $��Calibri)�6v   $��14(�6�   �� 5      $��Opis:��6   $
��Left=�6$   $��	10,70,0,0q�6?   $	��Top=�6R   $��99��6j   $��Calibri)�6u   $��46��6�   $��14(�6�   �� 5      -   5         ��Name$ 	OznakaTxt��5       � ToolTip$ Obavezan unos oznake tipa��6)   $
��Left=�6M   $��23��6h   $��
125,13,0,0q�6t    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��227��6�   
�������.��6�   ��5      �� 5       �� Path$ Oznaka�6    �� UpdateSourceTrigger$ PropertyChanged=�6,    �� ValidationRules 5      (  "HCI_projekat.Validacija.Validacija  5      ,  &System.Windows.Controls.ValidationRule	   ValidatesOnTargetUpdated	 . 64   5      .��5       
 =� ErrorTemplate
 5      �� 5      .R�5      �  � RowDefinitions 5      �� 5    "    � ColumnDefinitions 5"      �� 5#   "   �� 5$   "   $
��Auto �63   .+�5'      ��  ��Name$ textBox��6U   $��0��68   $��0��6H   6U   �� 5(      $��1��6(   $��0��68   
���  ��$��Center=�6x   $��22(�6�   $��Medium"�6�   ��6E   �� *[0].ErrorContent+6�   5)      5*      .��5+   ,   5,      �� 5-      -   5        $ NazivTxt��5-      $ Obavezan unos naziva tipa��6)   $
��Left=�6M   $��23��6h   $��
125,42,0,0q�6t   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   .��6�   ��5.      �� 5/      $ Naziv�6   $ PropertyChanged=�6+    50        52      	 . 64   54      .��55       
 56      �� 57      .R�58      �  59      �� 5:   "    5<      �� 5=   "   �� 5>   "   $
��Auto �63   .+�5A      �� $ textBox��6U   $��0��68   $��0��6H   6U   �� 5B      $��1��6(   $��0��68   
���  ��$��Center=�6x   $��22(�6�   $��Medium"�6�   ��6E   �� *[0].ErrorContent+6�   5C      5D      .��5E   ,   5F      �� 5G      -   5        $ OpisTxt��5G      $ Opcion unos opisa tipa��6)   $
��Left=�6K   $��46��6f   $��
125,70,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   ��6�   �� $
 Opis�$ PropertyChanged=��� 5H      $��Ikonica:��6   $
��Left=�6'   $��
10,121,0,0q�6B   $	��Top=�6V   $��99��6n   $��Calibri)�6y   $��50��6�   $��14(�6�   �� 5I      -   5         ��Name$ ikonica��5I      $ Ikonica tipa��6%   $
��Left=�6<   $��50��6W   $��125,125,0,0q�6c   $	��Top=�6x   $��50��6�    J� OpacityMask 5J      �� 5K       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5L      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5M      $ White��6'   $ 1Q�65   5N      5P      �� 5Q      -   5        $��Odaberi ikonicu��5Q       � Cursor$
 Hand��6/   $- 'Kliknite da biste odabrali ikonicu tipa��6=   $
��Left=�6o   $��200,123,0,0q�6�   $	��Top=�6�   $��96��6�   $��Calibri)�6�   $��23��6�   6�   �� 5R      -   5        $��Sačuvaj��5R      $
 Hand��6'   $1 +Kliknite ukoliko želite da dodate novi tip��65   $
��Left=�6j   $��155,190,0,0q�6�   $	��Top=�6�   $��96��6�   $��Calibri)�6�   $��23��6�   6�   �� 5S      -   5        $��Odustani��5S      $
 Hand��6(   $> 8Kliknite ukoliko želite da odustanete od dodavanja tipa��66   $
��Left=�6x   $��256,190,0,0q�6�   $	��Top=�6�   $��96��6�   $��Calibri)�6�   $��23��6�    �� IsCancel . 6�   �� 5T      
���   �$��1q�6)   $
��Left=�6=   $��52��6X   $��125,123,0,0q�6d   $	��Top=�6y   $��50��6�   5U      5W      5X      