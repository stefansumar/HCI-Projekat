   M S B A M L   `   `   `  ����G  CHCI_projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCI_projekat.DijaloziHCI_projekat.Dijalozi  5   	   '    !HCI_projekat.Dijalozi.PrikazVrsta   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HCI_projekat.Dijalozi     5   	   -   5          � Title$  Prikaz vrsta��5   	   $	��440��6   $	��900��6+    � 
ResizeMode$ NoResize=�5	   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $
��Left=�6%   $	��256��6@   $��	10,74,0,0q�6M   $	��Top=�6`   $	��864��6x   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�      
IsReadOnly .    Columns 5      5      �� 5   
   -   5         ��Name$ button_Obrisi��5       � Cursor$
 Hand��6(   $��Obriši��66   $
��Left=�6G   $��679,354,0,0q�6b   $	��Top=�6w   $��95��6�   $��25��6�   $��Calibri)�6�   $��14(�6�   6�   �� 5   
   -   5        $ button_Dodaj��5      $
 Hand��6'   $��Dodaj��65   $
��Left=�6E   $��479,354,0,0q�6`   $	��Top=�6u   $��95��6�   $��25��6�   $��Calibri)�6�   $��14(�6�   6�   �� 5   
   -   5        $ OdustaniButton��5      $
 Hand��6)   $��Zatvori��67   $
��Left=�6I   $��779,354,0,0q�6d   $	��Top=�6y   $��95��6�   $��25��6�   $��Calibri)�6�   $��14(�6�   6�   �� 5   
   -   5        $ IzmeniButton��5      $
 Hand��6'   $��Izmeni��65   $
��Left=�6F   $��579,354,0,0q�6a   $	��Top=�6v   $��95��6�   $��25��6�   6�   �� 5   
   -   5         ��Name$ groupBox��5      $��Pretraga��6%   $
��Left=�67   $��59��6R   $��	10,10,0,0q�6^   $	��Top=�6q   $	��864��6�   $��13(�6�   .��5      �� -   5        	 ��Name$	 label��5      $��Pretraži po tipovima: ��6#   $
��Left=�6D   $��	10,10,0,0q�6_   $	��Top=�6r   $��25��6�   5      �� 5   
   -	   5        
 ��Name$
 textBox��5      $
��Left=�6#   $��25��6>   $��
169,35,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��200��6�   ��6�   �� *	UidFilter+�� 5   
   -
   5        $ OcistiPretraguButton��5      $��Očisti pretragu��6/   $
��Left=�6I   $��
374,35,0,0q�6d   $	��Top=�6x   $��95��6�   $��25��6�   $��14(�6�   $��Calibri)�6�   6�   5      5       