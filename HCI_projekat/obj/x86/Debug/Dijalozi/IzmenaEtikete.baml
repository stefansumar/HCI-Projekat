   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCI_projekat.DijaloziHCI_projekat.Dijalozi  5   	   )    #HCI_projekat.Dijalozi.IzmenaEtikete   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HCI_projekat.Dijalozi     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Izmena etikete��5	   	   $	��220��6    $	��400��6-    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   � ��5      �� 5       �� Color# � ��6"   .+�5      �� $��Oznaka:��6   $
��Left=�6&   $��	10,13,0,0q�6A   $	��Top=�6T   $��99��6l   $��Calibri)�6w   $��14(�6�   �� 5      -   5         ��Name$ 	OznakaTxt��5      $
��Left=�6f   $��23��6�   $��
125,13,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��227��6�   
���������6)   �� *Oznaka+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��Opis:��6   $
��Left=�6$   $��	10,45,0,0q�6?   $	��Top=�6R   $��99��6j   $��Calibri)�6u   $��14(�6�   $��46��6�   �� 5      -   5        $ OpisTxt��5      $
��Left=�6b   $��46��6}   $��
125,45,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   ��6'   �� *Opis+$ PropertyChanged=�6�   �� 5      -   5         ��Name$ SacuvajButton��5      $��Sačuvaj��6,   $
��Left=�6>   $��155,144,0,0q�6Y   $	��Top=�6n   $��96��6�   $��Calibri)�6�   $��23��6�    � Cursor$
 Hand��6�   6�   �� 5      -   5        $ OdustaniButton��5      $��Odustani��6-   $
��Left=�6@   $��256,144,0,0q�6[   $	��Top=�6p   $��96��6�   $��23��6�   $��Calibri)�6�   $
 Hand��6�   6�   �� 5      $��Boja:��6   $��Calibri)�6$   $��14(�69   $
��Left=�6G   $��	10,96,0,0q�6b   $	��Top=�6u   $��99��6�   #  Xceed.Wpf.Toolkit.ColorPicker  5      -   5          Name$ ColorPicker��5      ��. $��125,96,42,0q�6�   $��26��6�   $	��Top=�6�   	   DisplayColorAndName	 . 
   SelectedColor
 64   �� *Boja+$ PropertyChanged=�6�   5      5      5      