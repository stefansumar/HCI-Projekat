   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCI_projekat.DijaloziHCI_projekat.Dijalozi  5   	   (    "HCI_projekat.Dijalozi.PrikazTipova   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HCI_projekat.Dijalozi     5   	     � Title$  Prikaz tipova��5   	   $	��375��6   $	��600��6,    � Icon$_ YC:\Users\Stefan\Desktop\Faks\HCI\HCI-projekat\HCI_projekat\HCI_projekat\Ikonice\panda.png��5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   �� -   5         ��Name$ button��5      $��Dodaj��6!   $
��Left=�61   $��275,305,0,0q�6L   $	��Top=�6a   $��95��6y   $��25��6�   �� 5   
   -   5        $ button1��5      $��Obrisi��6"   $
��Left=�63   $��375,305,0,0q�6N   $	��Top=�6c   $��95��6{   $��25��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $	��290��6@   $��	10,10,0,0q�6M   $	��Top=�6`   $	��560��6x      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Oznaka��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 4* 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Oznaka+6P     5      $ Naziv��6%   $	 4* 6N   
 64   �� *Naziv+6N     5      $
 Opis��6%   $	 4* 6L   
 63   �� *Opis+6L     5      $ Ikonica��6%   $	 4* 6P   
 66   �� *Slika+6P      RowDetailsTemplate 5      �� 5      .R�5      ]� 
�������.+�5      �� $
��Left=�6    $��80��66   ��6C   ��  �� Path$ Slika�5      5      5      �� 5    
   -   5        $ ZatvoriButton��5       $��Zatvori��6(   $
��Left=�6:   $��475,305,0,0q�6U   $	��Top=�6j   $��95��6�   $��25��6�   6�   5"      5#      