   M S B A M L   `   `   `  ����  Desktop#    MassProject.MaterialienWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          �Name$  Window��5       � Title$ MaterialienWindow��5      $
��1179��5      $	��702��6    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�6\   .��5	      � -   5         �Name$ MaterialienGrid��5	       � RowDefinitions 5
      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��6(   $��0��65   ���#E0E0E0$��30��6Z   .+�5      �� $$��ikone\IkonaListaMaterijala.png��6   �� 5      $��Material Liste��6   $��14(�6#   $
��Bold"�61   $��Center=�6C   5      �� 5      $ 
Horizontal=�6   $��0��6(   $��1��68   $��Right=�6E   $��	0,10,10,5q�6a   .+�5      �� $��Suche:��6   $��14(�6   �� 5      -   5        $��txtSucheMaterialListe��5      $	��130��6*   $��25��66   5      &   System.Windows.Controls.DataGrid  5      -   5        $��	datagrid1��5      $��0��6   $��2��6.   $
��Left=�6;   $	��Top=�6V      SelectionMode$ Single=�6p   	   AutoGenerateColumns	 .  $��14(�5   #   
   CanUserAddRows
 .     
IsReadOnly .    CanUserResizeColumns . $��
10,0,10,10q�6v   $��Center=�6�   ��5   �   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Geschn.��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 66   -   5        
col1_1��5   @     5      $ BN��6%   $ * 61   -   5        
col1_2��5   ;     5       $ Lager��6   $ * 6(   -   5        
col1_3��5    2     5!      $ 
Mat ID Nr.��6)   $ * 6=   -   5        
col1_4��5!   G     5"      $ Mat T.��6)   $ * 69   -	   5        
col1_5��5"   C     5#      $
 Mat.��6)   $ * 67   -
   5        
col1_6��5#   A     5$      $	 Stk��6)   $ * 66   -   5        
col1_7��5$   @     5%      $ Fläche��6)   $ * 69   -   5        
col1_8��5%   C     5&      $ Oberfläche��6)   $ * 6=   -   5        
col1_9��5&   G     5'      $ Gnt für��6)   $ * 6:   -   5        col1_10��5'   D     5(      $ 	Lieferant��6)   $ * 6<   -   5        col1_11��5(   F     5)      $ Bsch.��6)   $ * 68   -   5        col1_12��5)   B     5*      $
 Foto��6)   $ * 67   -   5        col1_13��5*   A     5+      $ Sektor��6)   $ * 69   -   5        col1_14��5+   C     5,      $ R��6)   $ * 64   -   5        col1_15��5,   >   4  .System.Windows.Controls.DataGridTemplateColumn  5-      $ Aktionen��6-   $ * 6?   -   5        col1_16��5-   I   5/      51      52      