   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.SamochodWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  Samochod��5   	   $	��450��6   $	��400��6'   .��5	      � ���	#FFC0E6F0.+�5
   
   �� -   5         ��Name$ label_szczegoly��5
      $��	Samochód��6)   $
��Left=�6<   $��37��6W   $��
150,40,0,0q�6c   $	��Top=�6w   $	��100��6�   $��Book Antiqua)�6�   $��20(�6�   �� 5   
   -   5        $ label_marka��5      $��Marka			��6%   $
��Left=�6D   $��
57,100,0,0q�6_   $	��Top=�6s   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ label_model��5      $��Model��6%   $
��Left=�65   $��
57,130,0,0q�6P   $	��Top=�6d   $��Book Antiqua)�6|   $��12(�6�   �� 5   
   -   5        $ label_rejestracyjny��5      $��Numer rejestracyjny��6-   $
��Left=�6K   $��
57,160,0,0q�6f   $	��Top=�6z   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ label_pojemnosc��5      $��Pojemność��6)   $
��Left=�6=   $��
57,190,0,0q�6X   $	��Top=�6l   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ 	label_vin��5      $	��VIN��6#   $
��Left=�61   $��
57,220,0,0q�6L   $	��Top=�6`   $��Book Antiqua)�6x   $��12(�6�   �� 5   
   -   5        $ label_rodzajsilnika��5      $��Rodzaj silnika��6-   $
��Left=�6F   $��
57,250,0,0q�6a   $	��Top=�6u   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ label_automat��5      $��Automat��6'   $
��Left=�69   $��
57,280,0,0q�6T   $	��Top=�6h   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -	   5        $ 
label_cena��5      $
��Cena��6$   $
��Left=�63   $��
57,310,0,0q�6N   $	��Top=�6b   $��Book Antiqua)�6z   $��12(�6�   �� 5   
   -
   5         ��Name$ 	txt_marka��5      $
��Left=�6%   $��193,105,0,0q�6@   $��TextBox��6U    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��140��6�   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ 	txt_model��5      $
��Left=�6%   $��193,135,0,0q�6@   $��TextBox��6U   $
 Wrap=�6d   $	��Top=�6x   $	��140��6�   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ txt_rejestracyjny��5      $
��Left=�6-   $��193,165,0,0q�6H   $��TextBox��6]   $
 Wrap=�6l   $	��Top=�6�   $	��140��6�   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ txt_pojemnosc��5      $
��Left=�6)   $��193,195,0,0q�6D   $��TextBox��6Y   $
 Wrap=�6h   $	��Top=�6|   $	��140��6�   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ txt_vin��5      $
��Left=�6#   $��193,225,0,0q�6>   $��TextBox��6S   $
 Wrap=�6b   $	��Top=�6v   $	��140��6�   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ txt_automat��5      $
��Left=�6'   $��193,285,0,0q�6B   $��TextBox��6W   $
 Wrap=�6f   $	��Top=�6z   $	��140��6�   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5        $ txt_cena��5      $
��Left=�6$   $��193,315,0,0q�6?   $��TextBox��6T   $
 Wrap=�6c   $	��Top=�6w   $	��140��6�   $��Book Antiqua)�6�   $��12(�6�   �� 5   
   -   5         ��Name$ cmb_rodzajsilnika��5      $
��Left=�6.   $��193,255,0,0q�6I   $	��Top=�6^   $	��140��6v   $��Book Antiqua)�6�   $��12(�6�   .@�5      �� -   5         ��Name$ beznyna��5      .��6,   	benzyna65   �� 5      -   5        $ diesel��5      .��6+   diesel63   �� 5      -   5        $	 gaz��5      .��6(   gaz6-   �� 5      -   5        $ hybryda��5      .��6,   	hybryda65   �� 5      -   5        $ hybryda_plug_in��5      .��64   hybryda_plug_in6E   5       �� 5!   
   -   5         ��Name$ button_zamknij��5!      $��Zamknij��6)   $
��Left=�6;   $��26��6V   $��245,361,0,0q�6b   $	��Top=�6w   $��65��6�   ���	#FF121314���	#FF5BC9F1$��Book Antiqua)�6�   $��12(�6�   �� 5"   
   -   5        $ button_zatwierdz��5"      $��
Zatwierdź��6+   $
��Left=�6?   $��160,361,0,0q�6Z   $	��Top=�6o   $��26��6�   $��65��6�   ���	#FF121314���	#FF5BC9F1$��Book Antiqua)�6�   $��12(�6  �� 5#   
   $��l��6   $
��Left=�6   $��335,192,0,0q�67   $	��Top=�6L   $��Book Antiqua)�6d   $��12(�6~   �� 5$   
   $��zł/h��6   $
��Left=�6   $��335,312,0,0q�6:   $	��Top=�6O   $��Book Antiqua)�6g   $��12(�6�   5&      5'      