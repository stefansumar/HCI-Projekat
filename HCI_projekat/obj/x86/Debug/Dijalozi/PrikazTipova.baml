   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCI_projekat.DijaloziHCI_projekat.Dijalozi  5   	   (    "HCI_projekat.Dijalozi.PrikazTipova   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HCI_projekat.Dijalozi     5   	     � Title$  Prikaz tipova��5   	   $	��375��6   $	��600��6,    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   �� -   5         ��Name$ button��5       � Cursor$
 Hand��6!   $��Dodaj��6/   $
��Left=�6?   $��175,305,0,0q�6Z   $	��Top=�6o   $��95��6�   $��25��6�   �� 5   
   -   5        $ button1��5      $
 Hand��6"   $��Obrisi��60   $
��Left=�6A   $��375,305,0,0q�6\   $	��Top=�6q   $��95��6�   $��25��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
 Hand��6%   $
��Left=�63   $	��290��6N   $��	10,10,0,0q�6[   $	��Top=�6n   $	��560��6�      
IsReadOnly .    Columns 5         RowDetailsTemplate 5      �� 5      .R�5      ]� 
�������.+�5      �� $
��Left=�6    $��80��66   ��6C   ��  �� Path$ Slika�5      5      5      �� 5   
   -   5        $ ZatvoriButton��5      $
 Hand��6(   $��Zatvori��66   $
��Left=�6H   $��475,305,0,0q�6c   $	��Top=�6x   $��95��6�   $��25��6�   6�   �� 5   
   -   5        $ IzmeniButton��5      $
 Hand��6'   $��Izmeni��65   $
��Left=�6F   $��275,305,0,0q�6a   $	��Top=�6v   $��95��6�   $��25��6�   6�   5      5       