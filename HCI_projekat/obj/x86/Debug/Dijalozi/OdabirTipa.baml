   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCI_projekat.DijaloziHCI_projekat.Dijalozi  5   	   &     HCI_projekat.Dijalozi.OdabirTipa   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HCI_projekat.Dijalozi     5   	     � Title$  Odabir tipa��5   	   $	��400��6   $	��600��6*    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5       � Cursor$
 Hand��6I   $
��Left=�6W   $	��290��6r   $��	10,10,0,0q�6   $	��Top=�6�   $	��560��6�      AutoGenerateColumns .     
IsReadOnly . ��6%   ��  �� Path$ Tipovi�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Oznaka��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 4* 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Oznaka+6P     5      $ Naziv��6%   $	 4* 6N   
 64   �� *Naziv+6N     5      $
 Opis��6%   $	 4* 6L   
 63   �� *Opis+6L     5      $ Ikonica��6%   $	 4* 6R   
 66   �� *	Ikonica+6R   5      �� 5   
   -   5         ��Name$ OdaberiButton��5      $
 Hand��6(   $��Odaberi��66   $
��Left=�6H   $��375,312,0,0q�6c   $	��Top=�6x   $��95��6�   $��25��6�   $��Calibri)�6�   $��14(�6�   6�   �� 5   
   -   5        $ OdustaniButton��5      $
 Hand��6)   $��Odustani��67   $
��Left=�6J   $��475,312,0,0q�6e   $	��Top=�6z   $��95��6�   $��25��6�   $��Calibri)�6�   $��14(�6�   6�   5      5      