   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HCI_projekat.UnosHCI_projekat.Unos  5   	   A%clr-namespace:HCI_projekat.ValidacijaHCI_projekat.Validacija  5   	   %    HCI_projekat.Unos.UnosTipaVrste   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HCI_projekat.Unos     5   	   <
validacija%clr-namespace:HCI_projekat.Validacija     5   	     � Title$  Dodavanje novog tipa��5	   	   $	��260��6&   $	��400��63    � Icon$_ YC:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\HCI_projekat\Ikonice\panda.png��5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   � ��5      �� 5       �� Color# � ��6"   .+�5      �� $��Oznaka:��6   $
��Left=�6&   $��	10,13,0,0q�6A   $	��Top=�6T   $��90��6l   $��Calibri)�6w   $��14(�6�   �� 5      $��Naziv:��6   $
��Left=�6%   $��	10,39,0,0q�6@   $	��Top=�6S   $��99��6k   $��Calibri)�6v   $��14(�6�   �� 5      $��Opis:��6   $
��Left=�6$   $��	10,70,0,0q�6?   $	��Top=�6R   $��99��6j   $��Calibri)�6u   $��46��6�   $��14(�6�   �� 5      -   5         ��Name$ 	OznakaTxt��5       � ToolTip$ Obavezan unos oznake tipa��6)   $
��Left=�6M   $��23��6h   $��
125,13,0,0q�6t    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��227��6�   
�������.��6�   ��5      �� 5       �� Path$ Oznaka�6    �� UpdateSourceTrigger$ PropertyChanged=�6,   	 �� ValidationRules	 5      (  "HCI_projekat.Validacija.Validacija  5      ,  &System.Windows.Controls.ValidationRule
   ValidatesOnTargetUpdated
 . 64   5      .��5        =� ErrorTemplate 5      �� 5      .R�5      �  � RowDefinitions 5       �� 5!   "    � ColumnDefinitions 5#      �� 5$   "   �� 5%   "   $
��Auto �63   .+�5(      ��  ��Name$ textBox��6U   $��0��68   $��0��6H   6U   �� 5)      $��1��6(   $��0��68   
���  ��$��Center=�6x   $��22(�6�   $��Medium"�6�   ��6E   �� *[0].ErrorContent+6�   5*      5+      .��5,   ,   5-      �� 5.      -   5        $ NazivTxt��5.      $ Obavezan unos naziva tipa��6)   $
��Left=�6M   $��23��6h   $��
125,42,0,0q�6t   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   .��6�   ��5/      �� 50      $ Naziv�6   $ PropertyChanged=�6+   	 51        53      
 . 64   55      .��56        57      �� 58      .R�59      �  5:      �� 5;   "    5=      �� 5>   "   �� 5?   "   $
��Auto �63   .+�5B      �� $ textBox��6U   $��0��68   $��0��6H   6U   �� 5C      $��1��6(   $��0��68   
���  ��$��Center=�6x   $��22(�6�   $��Medium"�6�   ��6E   �� *[0].ErrorContent+6�   5D      5E      .��5F   ,   5G      �� 5H      -   5        $ OpisTxt��5H      $ Opcion unos opisa tipa��6)   $
��Left=�6K   $��46��6f   $��
125,70,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   �� 5I      $��Ikonica:��6   $
��Left=�6'   $��
10,121,0,0q�6B   $	��Top=�6V   $��99��6n   $��Calibri)�6y   $��50��6�   $��14(�6�   �� 5J      -   5         ��Name$ ikonica��5J      $
��Left=�6%   $��50��6@   $��125,125,0,0q�6L   $	��Top=�6a   $��50��6y    J� OpacityMask 5K      �� 5L       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5M      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5N      $ White��6'   $ 1Q�65   5O      5Q      �� 5R      -   5        $��Odaberi ikonicu��5R      $
��Left=�6/   $��200,123,0,0q�6J   $	��Top=�6_   $��96��6w   $��Calibri)�6�   $��23��6�   6�   �� 5S      -   5        $��Sačuvaj��5S      $
��Left=�6'   $��155,190,0,0q�6B   $	��Top=�6W   $��96��6o   $��Calibri)�6z   $��23��6�   6�   �� 5T      -   5        $��Odustani��5T      $
��Left=�6(   $��256,190,0,0q�6C   $	��Top=�6X   $��96��6p   $��Calibri)�6{   $��23��6�    �� IsCancel . 6�   �� 5U      
���   �$��1q�6)   $
��Left=�6=   $��52��6X   $��125,123,0,0q�6d   $	��Top=�6y   $��50��6�   5V      5X      5Y      