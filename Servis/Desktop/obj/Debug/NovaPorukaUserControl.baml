   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5       Desktop#   Desktop.NovaPorukaUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  
NovaPoruka��5      $	��739��5      $	��393��6+   .   (System.Windows.Interactivity.Interaction   Triggers 5	      /   )System.Windows.Interactivity.EventTrigger  5
   
      	EventName$ Loaded��6   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      6   0System.Windows.Interactivity.InvokeCommandAction     Command 6$   ��  �� Path$ DataContext.PopuniCombo� �� ElementName$ 
NovaPoruka��5      .��5      � ���#C0C0C0$��10,10,23,10q�6     � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $	��An:��6   $��0��6   $��0��6.   $��14(�6;   $��30��6I   $��5q�6U   �� 5   
   $��1��6   $��0��6#   $	��180��60   $
��Left=�6<   $
��5,26q�6W   	 �� SelectedIndex$	 0��6�   ��6e   �� *ListaKorisnika+
 �� SelectedItem
 5      �� *SelektovaniKorisnik+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      �� �� 5      �6   �� *ime+ �� 5       �6   �� *	prezime+5!      5"      5$      �� 5%   
   $��Betreff:��6   $��0��6#   $��1��63   $��14(�6@   $��30��6N   $��5q�6Z   �� 5'   
   $	��180��6   $��1��6   $��1��6.   $
��Left=�6;   $
��5,26q�6V   $��25��6d   ��6p   �� *	Betreff+�� 5(   
   $��
Nachricht:��6   $��0��6%   $��2��65   $��30��6B   $	��Top=�6N   $��5q�6f   $��14(�6q   �� 5)   
   $��2��6   $��1��6   $	��150��6/   $��10q�6<   $	��600��6H   ��6T   �� *Poruka+�� 5*   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��3��6B   $��Right=�6O   .+�5+      �� $��0,5,5,5q�6   ���#51A351$��80��6=   $��30��6H   ��6T   �� *	Sending+.��5,      �� $ 
Horizontal=�6   $��0,0,5,0q�66   $��Center=�6G   $��Center=�6b   .+�5-      �� $��ikone/IkonaButtonOk.png��6   $��20��6=   $��20��6H   �� 5.      $��Sende��6    
�������6-   5/      50      �� 51      $��0,5,10,5q�6   ���#222222$��80��6=   $��30��6H   .��52      �� $ 
Horizontal=�6   .+�53      �� $#��ikone/IkonaButtonOdustani.png��6   $��20��6C   $��20��6O   $��Center=�6Z   $��Center=�6u   �� 54      $��Zurück��6    
�������6.   55      56      58      �� 59   
   $��0��6   $��0��6$   $��Bottom=�61   
�������6L   �� 5:   
   $��1��6   $��0��6$   $��Bottom=�61   
�������6L   �� 5;   
   $��0��6   $��1��6$   $��Bottom=�61   
�������6L   �� 5<   
   $��1��6   $��1��6$   $��Bottom=�61   
�������6L   �� 5=   
   $��0��6   $��2��6$   $��Bottom=�61   
�������6L   �� 5>   
   $��1��6   $��2��6$   $��Bottom=�61   
�������6L   5A      5B      