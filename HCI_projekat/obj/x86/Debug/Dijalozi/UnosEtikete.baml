   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HCI_projekat.UnosHCI_projekat.Unos  5   	   A%clr-namespace:HCI_projekat.ValidacijaHCI_projekat.Validacija  5	   	   #    HCI_projekat.Unos.UnosEtikete   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :xctk)http://schemas/xceed.com/wpf/xaml/toolkit     5   	   1localclr-namespace:HCI_projekat.Unos     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f45xctk1)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   6
validacija%clr-namespace:HCI_projekat.Validacija  5	   	     � Title$  Dodavanje nove etikete��5   	   $	��220��6(   $	��400��65    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   � ��5      �� 5       �� Color# � ��6"   .+�5      �� $��Oznaka:��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   $��99��6l   $��Calibri)�6w   $��14(�6�   �� 5      $��Opis:��6   $
��Left=�6$   $��	10,45,0,0q�6?   $	��Top=�6R   $��99��6j   $��Calibri)�6u   $��14(�6�   $��46��6�   �� 5      -   5         ��Name$ 	OznakaTxt��5       � ToolTip$" Obavezan unos oznake etikete��6)   $
��Left=�6P   $��27��6k   $��
125,13,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��227��6�   
�������.��6�   ��5      �� 5       �� Path$ Oznaka�6    �� UpdateSourceTrigger$ PropertyChanged=�6,    �� ValidationRules 5      (  "HCI_projekat.Validacija.Validacija  5      ,  &System.Windows.Controls.ValidationRule	   ValidatesOnTargetUpdated	 . 64   5      .��5       
 =� ErrorTemplate
 5      �� 5      .R�5      �  � RowDefinitions 5       �� 5!   "    � ColumnDefinitions 5#      �� 5$   "   �� 5%   "   $
��Auto �63   .+�5(      ��  ��Name$ textBox��6U   $��0��68   $��0��6H   6U   �� 5)      $��1��6(   $��0��68   
���  ��$��Center=�6x   $��22(�6�   $��Medium"�6�   ��6E   �� *[0].ErrorContent+6�   5*      5+      .��5,   ,   5-      �� 5.      -   5        $ OpisTxt��5.      $ Opcion unos opisa etikete��6'   $
��Left=�6K   $��46��6f   $��
125,45,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   .��6�   ��5/      �� 50      $
 Opis�6   $ PropertyChanged=�6*   .��51       52      �� 54      -   5         ��Name$ label��54      $��Boja:��6#   $
��Left=�63   $��	10,96,0,0q�6N   $	��Top=�6a   $��99��6y   $��27��6�   $��Calibri)�6�   $��14(�6�   #  Xceed.Wpf.Toolkit.ColorPicker  55      -   5        $��ColorPicker��55       ��. $��125,97,42,0q�6�   $��26��6�   $	��Top=�6�      DisplayColorAndName .    SelectedColor 63   �� $
 Boja�$ PropertyChanged=�6�   �� 56      -   5         ��Name$ SacuvajButton��56       � Cursor$
 Hand��6,   $��Sačuvaj��6:   $
��Left=�6L   $��155,144,0,0q�6g   $	��Top=�6|   $��96��6�   $��Calibri)�6�   $��23��6�   6�   �� 57      -   5        $ OdustaniButton��57      $
 Hand��6-   $��Odustani��6;   $
��Left=�6N   $��256,144,0,0q�6i   $	��Top=�6~   $��96��6�   $��23��6�   $��Calibri)�6�    �� IsCancel . 6�   59      5;      5<      