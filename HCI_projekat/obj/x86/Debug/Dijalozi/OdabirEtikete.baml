   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCI_projekat.DijaloziHCI_projekat.Dijalozi  5   	   )    #HCI_projekat.Dijalozi.OdabirEtikete   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HCI_projekat.Dijalozi     5   	     � Title$  Odabir etikete��5   	   $	��300��6    $	��600��6-    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�6   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ OdaberiEtiketuDataGrid��5      $
��Left=�6}   $	��211��6�   $��	10,10,0,0q�6�   $	��Top=�6�   $	��564��6�      
IsReadOnly .    AutoGenerateColumns .  ��63   ��  �� Path$ Etikete� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Oznaka��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 4* 6u   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Oznaka+$ PropertyChanged=�6u     5      $
	 Opis��6%   $
 4* 6q    63   �� *Opis+$ PropertyChanged=�6q   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
	 Boja��6)   $
 4* 67      CellTemplate 5      �� 5      .R�5      �  � ColumnDefinitions 5   "   �� 5   &   $��4* �67   �� 5   &   $
��Auto �67   .+�5   "   �� $��0��6,   ��5   &   �� 5   *    �� Color 6:   �� *Boja+5   #   5      5      5      5!      �� 5"   
   -   5         ��Name$ OdustaniButton��5"      $��Odustani��6)   $
��Left=�6<   $��479,226,0,0q�6W   $	��Top=�6l   $��95��6�   $��25��6�   6�   �� 5#   
   -   5        $ OdaberiButton��5#      $��Odaberi��6(   $
��Left=�6:   $��379,226,0,0q�6U   $	��Top=�6j   $��95��6�   $��25��6�   6�   5%      5&      