   M S B A M L   `   `   `  ����C  ?Sort_TAM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Sort_TAMSort_TAM  5   	       Sort_TAM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Sort_TAM     5   	   -   5          �Name$  Main_Window��5   	    � Title$ 
TAM Sorter��5   	   $	��500��6   $	��600��6)   $y�Visible=�65    � 
ResizeMode$ CanMinimize=�6J   ���	#FF2C2C2C&   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6z   4  .System.Windows.Automation.AutomationProperties   HelpText$ Hey this is Help!��6�   .��5	      � .+�5
   
   �� -   5         ��Name$ Tamuk��5
      $
��Left=�6   $	��200��6:   $��	35,30,0,0q�6G   $	��Top=�6Z   $	��350��6r   $��coe_full.png��6~   �� 5   
   -   5         ��Name$ Sorter��5      $��Sorter��6!   $
��Left=�62   $��30��6M   $��445,120,0,0q�6Y   $	��Top=�6n   $	��100��6�   ���	#FF288791
������� �� 	ClickMode$ Press=�6�   $��16(�6�    � Cursor$
 Hand��6�   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $ Close��5      $��Close��6    $
��Left=�60   $��30��6K   $��445,190,0,0q�6W   $	��Top=�6l   $	��100��6�   ���	#FF288791
�������$ Press=�6�   $��16(�6�   $
 Hand��6�   ��5      �� 5      $	 0.5,1&�6&   $
 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $ About��5      $��About��6    $
��Left=�60   $��30��6K   $��
445,50,0,0q�6W   $	��Top=�6k   $	��100��6�   ���	#FF288791
�������$ Press=�6�   $��16(�6�   $
 Hand��6�   ��5      �� 5      $	 0.5,1&�6&   $
 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   5       5"      �� 5#   
   -   5         ��Name$ Instructions��5#      $
��Left=�6(   $	��180��6C   $��
22,260,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $����
    Instructions:

        Click on 'About', to understand the functionality of the application.

        Click on 'Sorter', to sort a TAM string.

        Click on 'Close', to close the application.��6x   $	��Top=�6d  $	��540��6|  ���	#FF2C2C2C
�������
������� �� 
IsReadOnly . $��14(�64   �� TextDecorations 6�  Z�  �� SelectionBrush 6�  Z� 64  5$      5%      