   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ProWPF_C.Ch20_Databinding.Classes!ProWPF_C.Ch20_Databinding.Classes  5   	   4    .ProWPF_C.Ch20_Databinding.ComboBoxSelectionBox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:ProWPF_C.Ch20_Databinding.Classes     5   	     � Title$  ComboBoxSelectionBox��5   	   $	��376��6&   $	��521��63    � 	Resources 5      :   4ProWPF_C.Ch20_Databinding.Classes.ImagePathConverter   ImagePathConverter��%   &	          5   
   6@   5	      .��5      �� $��5q�6   .+�5   
   �� -   5        $��lstProducts��5   9   $��5q�6    J� SnapsToDevicePixels . $��Stretch=�6L    �� 
IsEditable 5      ��  �� ElementName$ chkIsEditable�� �� Path$ 	IsChecked� �� 
IsReadOnly 5      �� $ chkIsReadOnly��$ 	IsChecked� w� TextPath 5      �� $ txtTextSearchPath��$
 Text���5      �� 5      .�5      ��  �� Property � ��	 �� Value$	 0q�68   6D   
 �� Triggers
 5      P� 5       P� Property �@��
IsSelected P� Value . . �5      ��  � ��
	 �  ��6H   5      P� 5       �@��IsHighlighted . . �5      ��  � ��
	 �z���6H   5      5      ��5      �� 5      .R�5       � $��0q�6   
�������.+�5!      �� $��5q�6!   $��1q�6,   
�����F� �� CornerRadius$ 4��5)      ��5"      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ��$ 
Background�._�5*      � $��3q�6#    � RowDefinitions 5+   "   �� 5,   &   66   �� 5-   &   66    � ColumnDefinitions 5/   "   �� 50   &   69   �� 51   &   $
��Auto �67   6F   .+�53   "   �� $
��Bold"�6,   ��6>   �� $ ModelNumber�6b   �� 54   "   $��1��6,   ��69   �� $ 	ModelName�6[   �� 55   "   $��1��6(   $��2��68   $��50��6I   ��6U   �� $ ProductImagePath� �� 	Converter# [  6�   56      57      58      59      5;      �� 5=   
   -   5        $��chkIsEditable��5=      $��5q�6(   .��63   
IsEditable6?   �� 5>   
   -   5        $��chkIsReadOnly��5>      $��5q�6(   .��63   
IsReadOnly6?   �� 5?   
   $��5q�6   TextSearch.TextPath: �� 5A      -   5        $��txtTextSearchPath��5A      $	��150��6)   6c   5B      5D      5E      