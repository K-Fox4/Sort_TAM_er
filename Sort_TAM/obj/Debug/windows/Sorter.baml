   M S B A M L   `   `   `  ����C  ?Sort_TAM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Sort_TAM.windowsSort_TAM.windows  5   	       Sort_TAM.windows.Sorter   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Sort_TAM.windows     5   	   -   5          �Name$  Sorter_Window��5   	    � Title$ Sorter��5   	   $	��350��6   $	��505��6%   ���	#FF2C2C2C
������� � 
ResizeMode$ CanMinimize=�6[   .��5	      � .+�5
   
   �� -   5         ��Name$ Input_String_Label��5
      $A��;Input the string of letters 'A', 'T' & 'M' with ending '#':��6,   $
��Left=�6v   $��35��6�   $��	30,60,0,0q�6�   $	��Top=�6�   $	��420��6�   
�������$��16(�6�   �� 5   
   -   5         ��Name$ Input_String_Textbox��5      $
��Left=�60   $��40��6K   $��
30,105,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��320��6�   ���	#FF2C2C2C
�������$��18(�6�   $
��Bold"�6�   $��Center=�6�   $��5,0,0,0q�6  6!  �� 5   
   -   5         ��Name$ Sort_Button��5      $
��Sort��6&   $
��Left=�65   $��30��6P   $��385,110,0,0q�6\   $	��Top=�6q   $��75��6�   ���	#FF288791���	#FFFFFFFC$��16(�6�    � Cursor$
 Hand��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   � 5      $
 White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $ Output_String_Label��5      $��Sorted string is:��6-   $
��Left=�6I   $��35��6d   $��
30,180,0,0q�6p   $	��Top=�6�   $	��420��6�   ���	#FFFFFFF9$��16(�6�   �� 5   
   -   5        $ Output_String_Textbox��5      $
��Left=�61   $��50��6L   $��
30,225,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��430��6�   ���	#FF2C2C2C$��24(�6�   $
��Bold"�6�    �� 
IsReadOnly . $��Center=�6  $��Center=�6A  �� 5   
   -   5        $ Refresh_Button��5      $
��Left=�6)   $��30��6D   $��
445,20,0,0q�6P   $	��Top=�6d   $��30��6|   ���	#FF007DFA.��5      �� -   5         ��Name$ Refresh_Image��5      $��20��6+   $��20��67   $��media_repeat_alt_inv.png��6B   5      5      5      