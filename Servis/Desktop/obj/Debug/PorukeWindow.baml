   M S B A M L   `   `   `  ����B  >Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DesktopDesktop  5   	       Desktop.PorukeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   *controlsclr-namespace:Desktop     5   	   -   5          �Name$  PorukeGlavni��5   	    � Title$ PorukeWidnow��5   	   $��490.121��6   $��925.805��6/    � 
ResizeMode$ NoResize=�6?   .��5      �  � ColumnDefinitions 5   
   �� 5	      $
��Auto �6   $	��167��6,   �� 5
       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��2��6;   ���#E0E0E0$��0,0,0,10q�6d   .+�5      �� $"��images/icons/iconMessage.png��6   $��25��6:   $��25��6F   $��10,0,0,0q�6Q   �� 5      $��Message��6   $��Center=�6'   $��14(�6B   $
��Bold"�6P   $��5,0,0,0q�6b   5      �� 5   
   $��0��6   $��1��6"   ���#DFDFDF$��2q�6E    �� CornerRadius$ 10��6Y   $��10,10,0,104q�6k   $	��120��6�   $	��Top=�6�   ._�5      o� $	��140��6   ���#FFFFFF$��5q�65   ��5      �� 5      .R�5      $�  $� Orientation$ Vertical=�61   5      .@�5      m� -   5        $��25��5      ��5      �� 5      $
��Neue��6$   $��Center=�60    J� RenderTransformOrigin$ 1.217,0.519&�6K   $��10,0,0,0q�6o   	 m� Icon	 5!      �� 5"      $��ikone/IkonaNovaPor.png��6    $��25��6@   $��20��6L   $��Center=�6W   $
��Left=�6r   5%      m� 5'      -   5        ��5(      �� 5)      $��Posteingang��6$   $��Center=�67   $��10,0,0,0q�6R   	 5+      �� 5,      $��ikone/IkoneInbox.png��6    $��25��6>   $��20��6J   $��Center=�6U   $
��Left=�6p   5.      m� 5/      -   5        ��50      �� 51      $��Gesendet��6$   $��Center=�64   $��10,0,0,0q�6O   	 53      �� 54      $��ikone/IkonaPoslanaPor.png��6    $��25��6C   $��20��6O   $��Center=�6Z   $
��Left=�6u   56      m� 57      ��58      �� 59      $��Einstellungen��6$   $��Center=�69   $��10,0,0,0q�6T   	 5;      �� 5<      $��ikone/IkonaPostavke.png��6    $��25��6A   $��20��6M   $��Center=�6X   $
��Left=�6s   5>      5@      5A      �� 5C   
   -   5        
 ��Name$

 root��5C      $��1��6   $��1��6/   ���#DFDFDF$��2q�6R   $ 10��6f   $��10q�6x   5t      �� 5u   
   -   5        $
 visak��5u      $��1��6    $��2��60   ���#DFDFDF$��2q�6S   $ 10��6g   $��10,29,10,42q�6y   ._�5w      �� ��6   ��  �� Path$ DataContext.Message� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� ElementName$ PorukeGlavni��5y      5{      5}      