   M S B A M L   `   `   `  ����C  ?Sort_TAM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Sort_TAM.windowsSort_TAM.windows  5   	       Sort_TAM.windows.About   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Sort_TAM.windows     5   	   -   5          �Name$  About_Window��5   	    � Title$ About��5   	   $	��500��6   $	��600��6$   ���	#FF2C2C2C � 
ResizeMode$ CanMinimize=�6G   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ About_Content��5      $
��Left=�6)   $	��415��6D   $��	25,25,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��535��6�   ���	#FF2C2C2C
�������$��16(�6�    �� 
IsReadOnly . $����
This application takes an input string of letter 'A', 'M' and 'T'.

Input string is stored in an array and sorted in such a way that all T's comes first, then A's and at last M's.

Sorting of this array has following constraints:

    1. Each letter ('A', 'M', or 'T') is evaluated only once.

    2. Swap of letters is used only when it is necessary.

    3. No extra space can be used by the algorithm. In other words, only the array TAMUK can be used to sort the 'A', 'M', or 'T'. 

    4. You cannot count the number of each letter 'A', 'M', or 'T'. 
��6�    �� TextAlignment$ Justify=�6�  5      5      