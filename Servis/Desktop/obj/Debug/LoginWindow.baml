   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	    Desktop   Desktop.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   -   5          �Name$  Window��5   '    � Title$ LoginWindow��5   	   $	��320��6   $	��446��6*    � SizeToContent$ WidthAndHeight=�66    � WindowStartupLocation$ CenterScreen=�6�   y�6U   �� *
Vidljivost+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Closed��6   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      6   0System.Windows.Interactivity.InvokeCommandAction  	   Command	 6$   �� 
 �� Path$
 DataContext.Closed� �� ElementName$ Window��5
      .��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $��0��6)   ���#5A5A5A.+�5      �� $��ikone/header.png��6   $��50��62   $��40��6=   $
��Left=�6I   $��5,0,10,0q�6d   5      � 5      $��0��6   $��1��6#   $��40,40,40,10q�60    5      �� 5      $��* �6'    5      �� 5      $
��Auto �6$   �� 5       $
��Auto �6$   �� 5!      $
��Auto �6$   �� 5"      $
��Auto �6$   �� 5#      $
��Auto �6$   .+�5%      ��  �� Orientation$ 
Horizontal=�6   $��0��66   $��0��6F   $��Center=�6S   .+�5&      �� ���#FFFFFF$	��350��6s    �� TextAlignment$ Center=�6   ��6    �� *Validacija1+��6S   �� *
Pozadina+6   5'      �� 5(      $��1��6   $��0��6*   $��	68,7,85,0q�6:   $ 
Horizontal=�6M   $��Center=�6f   .+�5)      �� $��ikone/IkonaProfila.png��6   $��25��6<   $��25��6H   $
��Left=�6S   �� 5*      $	��180��6   $��25��6*    � ToolTip$ Benutzername��6U   ��66   �� *KorisnickoIme+6U   5+      �� 5,      $��2��6   $��0��6*   $��	68,7,85,0q�6:   $ 
Horizontal=�6M   $��Center=�6f   .+�5-      �� $'��!ikone/IkonaMaterialBestellung.png��6   $��25��6G   $��25��6S   $
��Left=�6^   G� 5.      -   5        $��txtPassword��5.   "   $	��180��65   $��25��6A   $ Passwort��6M    J� InputBindings 5/      �� 50      
 �� Key$ Enter��6)    �� Command 65   �� *
LoginClick+ �� CommandParameter 6T   �� $ txtPassword��52      53      �� 54      $��Mich erinnern��6   $��0��63   $��3��6C   $��Center=�6P   $��0,5,0,0q�6m   $y�Hidden=�6~   �� 55      $��Anmelden��6   $��4��6,   $��0��69   $	��120��6I   ���#FFFFFF���#3B3B3B$��0,5,0,0q�6    � Cursor$
 Hand��6�   ��6�   �� *
LoginClick+��6�   �� $ txtPassword��6�   56      �� 58      $��0��6   $��2��6)   ���#5A5A5A$ 
Horizontal=�6L   .+�59      �� .+�5:      �� $��ikone/header.png��6   $��50��66   $��40��6A   $
��Left=�6M   $��5,0,10,0q�6h   5;      �� 5<      .+�5=      �� $��ikone/footer1.png��6   $��50��67   $��40��6B   $
��Left=�6N   $��5,0,10,0q�6i   5>      �� 5?      .+�5@      �� �� 5A      $!��http://www.maag-projekt.com?�6(   .�6R   .�5B   "   �� $��ikone/footer2.png��6(   $��50��6C   $��40��6N   $
��Left=�6Z   $��5,0,10,0q�6u   5C      5D      5F      5G      5H      5I      5J      