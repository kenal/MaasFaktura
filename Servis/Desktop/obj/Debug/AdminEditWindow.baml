   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	    Desktop   Desktop.AdminEditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   -   5          �Name$  Window��5   
    � Title$ AdminEditWindow��5   	   $
��1024��6!   $	��900��6.   $	��600��6=   $	��600��6M    � SizeToContent$ WidthAndHeight=�6Z    � WindowStartupLocation$ CenterScreen=�6y   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5	   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5
      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   ��  �� Path$" DataContext.PopuniEditWindow�	 �� ElementName$	 Window��5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      � -   5        $��grdNew��5      ���#C0C0C0$��0��6.    K� ZIndex$ 1��6>   $��2��6O   $��10q�6\   .+�5   
   �� $��Vorname:��6   $	��Top=�6#   $��Center=�6;   $��-10,10,200,0q�6X   $��14(�6n   �� 5      -   5         ��Name$ idName��5      $��Center=�6&   $��30��6H   $	��200��6T   $	��Top=�6`   $��Center=�6x   $��
100,10,0,0q�6�   ��6�   �� *
NameEdit+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError .  �� ValidatesOnExceptions .  �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��Name:��6   $	��Top=�6    $��Center=�68   $��-10,50,220,0q�6U   $��14(�6k   �� 5      -   5        $ 
idLastName��5      $��Center=�6*   $��30��6L   $	��200��6X   $	��Top=�6d   $��Center=�6|   $��
100,50,0,0q�6�   ��6�   �� *LastNameEdit+$ TwoWay=� .  .  . $ PropertyChanged=��� 5   
   $��E-mail:��6   $	��Top=�6"   $��Center=�6:   $��-10,90,220,0q�6W   $��14(�6m   �� 5      -   5        $ idEmail��5      $��Center=�6'   $��30��6I   $	��200��6U   $	��Top=�6a   $��Center=�6y   $��
100,90,0,0q�6�   ��6�   �� *	EmailEdit+$ TwoWay=� .  .  . $ PropertyChanged=��� 5   
   $��Telefon:��6   $	��Top=�6#   $��Center=�6;   $��-10,130,215,0q�6X   $��14(�6o   �� 5      -   5        $ 	idTelefon��5      $��Center=�6)   $��30��6K   $	��200��6W   $	��Top=�6c   $��Center=�6{   $��100,130,0,0q�6�   ��6�   �� *TelefonEdit+$ TwoWay=� .  .  . $ PropertyChanged=��� 5    
   $��	Benutzer:��6   $	��Top=�6$   $��Center=�6<   $��-10,170,210,0q�6Y   $��14(�6p   �� 5!      -   5        $ 
idUsername��5!      $��Center=�6*   $��30��6L   $	��200��6X   $	��Top=�6d   $��Center=�6|   $��100,170,0,0q�6�   ��6�   �� *UsernameEdit+$ TwoWay=� .  .  . $ PropertyChanged=��� 5"   
   $��	Passwort:��6   $	��Top=�6$   $��Center=�6<   $��-5,210,210,0q�6Y   $��14(�6o   �� 5#      -   5        $ 
idPassword��5#      $��Center=�6*   $��30��6L   $	��200��6X   $	��Top=�6d   $��Center=�6|   $��100,210,0,0q�6�   ��6�   �� *PasswordEdit+$ TwoWay=� .  .  . $ PropertyChanged=��� 5$   
   $��Benutzertype:��6   $	��Top=�6(   $��Center=�6@   $��20,250,210,0q�6]   $��14(�6s   	� 5%      $��Administrator��6    	� 	GroupName$ radType��62   $	��Top=�6F   $��Center=�6^   $��	0,259,0,0q�6�    � Cursor$
 Hand��6�    d� 	IsChecked 6{   �� *RadAdminEdit+6�   	� 5&      $��Mitarbeiter��6   $ radType��60   $	��Top=�6D   $��Center=�6\   $��180,259,0,0q�6�   $
 Hand��6�    6y   �� *
RadMitEdit+6�   	� 5'      $��
sekretarin��6   $ radType��6/   $	��Top=�6C   $��Center=�6[   $��340,259,0,0q�6�   $
 Hand��6�    6x   �� *
RadSekEdit+6�   	� 5(      $��	Techniker��6   $ radType��6.   $	��Top=�6B   $��Center=�6Z   $��-22,279,0,0q�6�   $
 Hand��6�    6w   �� *RadTechEdit+6�   	� 5)      $��Werkstattleiter��6   $ radType��64   $	��Top=�6H   $��Center=�6`   $��198,279,0,0q�6�   $
 Hand��6�    6}   �� *RadWerkEdit+6�   �� 5*      $��Lizenz:��6   $	��Top=�6&   $��Center=�6>   $��-20,300,210,0q�6[   $��14(�6r   $
 Hand��6�   (  "System.Windows.Controls.DatePicker  5+   
   -	   5          Name$ 	idLicence��5+      $��30��6(   $	��200��64   $	��Top=�6@   $��Center=�6X   $��100,300,0,0q�6u      DisplayDateStart$ 
1930-01-01X�6�      SelectedDate 6�   �� *LicenceEdit+6�   �� 5,      $��	Speichern��6   $��30��6)   $	��130��65   $��Center=�6A   $	��Top=�6^   $��-140,350,0,0q�6v   ���#5bb75b
�������$
��Bold"�6�   $��14(�6�   $
 Hand��6�   ��6�   �� *	UnesiEdit+6�   �� 5-      -
   5        $��	Abbrechen��5-      $��30��6)   $	��130��65   $��Center=�6A   $	��Top=�6^   $��165,350,0,0q�6v   ���#414141
�������$
��Bold"�6�   $��14(�6�   $
 Hand��6�   6�   5.      5/      50      