   M S B A M L   `   `   `  ����B  >Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DesktopDesktop  5   	   9!clr-namespace:Desktop.HelperClassDesktop.HelperClass  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   
       Desktop.AddBugWindows   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   'viewsclr-namespace:Desktop     5   	   3local!clr-namespace:Desktop.HelperClass     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   
     � Title$  AddBugWindows��5   	   $	��600��6   $	��450��6.   $	��500��6>    � SizeToContent$ WidthAndHeight=�6K    � WindowStartupLocation$ CenterScreen=�6j   .��5	   
   �  � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � ���#E0E0E0$��0��6$   $��2��64   $��0��6H   .+�5      �� $"��images/icons/iconAngebot.png��6   $��30��6:   $
��Left=�6F   �� 5      $	��BUG��6   $
��Bold"�6"   $��16(�64   $��	30,-3,0,0q�6B   5      � 5   
   $��0��6   $��2��6   $��1��63   .+�5      �� -   5        $��txtBox01��5      $��Center=�6&    �� TextWrapping$
 Wrap=�6C   $	��Top=�5       �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�6?   $	��310��6�   $
��auto��6�   $	��900��6�   $	��550��6�   $��15q�6�   $��16(�6�   ��6b   �� *SendBugValue+6�   5      � 5   
   $��0��6   $��2��6   $��2��63   .+�5      �� $��	Speichern��6   $��30��6)   $	��130��65   $��Center=�6A   $	��Top=�6^   $��	150,0,0,0q�6v   ���#5bb75b
�������$
��Bold"�6�   $��14(�6�    � Cursor$
 Hand��6�   ��6�   �� *
PosaljiBug+6�   �� 5       $��	Abbrechen��6   $��30��6)   $	��130��65   $��Center=�6A   $	��Top=�6^   $��	0,0,150,0q�6v   ���#414141
�������$
��Bold"�6�   $��14(�6�   $
 Hand��6�   5"      5#      5$      