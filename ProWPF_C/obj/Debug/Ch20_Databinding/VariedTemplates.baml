   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ProWPF_C.Ch20_Databinding.Classes!ProWPF_C.Ch20_Databinding.Classes  5   	   /    )ProWPF_C.Ch20_Databinding.VariedTemplates   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:ProWPF_C.Ch20_Databinding.Classes     5   	     � Title$  VariedTemplates��5   	   $	��475��6!   $	��824��6.    � 	Resources 5         DefaultTemplate �� Triggers �� Value �� Binding �� Path �� Property �� Value �� RelativeSource	 �� Mode
 �� AncestorType �� CornerRadius � RowDefinitions  HighlightTemplate��%�  &	        &	 .    �� 5   
    5	      �� 5
      $ Tools��6D    6   �� $ CategoryName�.a�5      ��  � ��
 �  ��6M   5      .R�5      � $��0q�6   ��6   ��  �� $	 FindAncestor=�"
 ��$ 
Background�.+�5      �� $��5q�6   $��1q�6$   
�����F�$ 4��5      
�������._�5      � $��3q�6    5      �� 5      6.   �� 5      6.   .+�5      �� ��5      �� $ ModelNumber�62   �� 5       $��1��6$   ��5!      �� $ 	ModelName�60   5"      5#      5$      5%      �� 5'   
   .R�5(      � $��0q�6   ��6   ��  �� $	 FindAncestor=�"
 ��$ 
Background�.+�50      �� $��5q�6   $��1q�6$   
�����F�
�������$ 4��51      ._�52      � $��3q�6    53      �� 54      6.   �� 55      6.   �� 56      6.   .+�58      �� $
��Bold"�6$   ��59      �� $ ModelNumber�62   �� 5:      $��1��6$   $
��Bold"�61   ��5;      �� $ 	ModelName�60   �� 5<      $��2��6$   $��Italic$�61   $��Right=�6D   *** Great for vacations ***6}   5=      5>      5?      5@      5A      .��5C      �  � ColumnDefinitions 5D   
   �� 5E      $��3* �6   6,   �� 5F      $��5* �6   6,   .+�5H   
   �  5I      �� 5J      $
��Auto �6    60   �� 5K      $��* �6    6-   �� 5L      $
��Auto �6    60   .+�5O      �� -   5        $��7,7,7,0q�5O      $��2q�6&   .��6O   Get Products6]   �� 5Q      -   5        $��lstProducts��5Q   5   $��1��6   $��7,3,7,10q�6#   $��Stretch=�6H    J� SnapsToDevicePixels . ��5S      O   IProWPF_C.Ch20_Databinding.Classes.SingleCriteriaHighlightTemplateSelector  5T         DefaultTemplate# [  5U         HighlightTemplate# [ 5V         PropertyToEvaluate$ CategoryName��5W         PropertyValueToHighlight$ Travel��5X      5Z      ��5\      �� 5]      .�5^      ��  � ��$ 0q�6<   6H    �� Triggers 5_      P� 5`       P� Property �@��
IsSelected P� Value . . �5a   "   ��  � ��
 ����6K   �� 5b   "    � ��
 �   �6K   5c      5e      5g      �� 5i      -   5        $��7,0,7,7q�5i      $��3��6&   $��2q�63   .��6\   Change One Item6m   5j      �� 5l   
   $��1��6   $
��Left=�6'   $��Stretch=�6B   $��5��6^   6j   �� 5n   
   $��1��6    �� Padding$ 7q�6!   $��7q�6-   
����İ�._�5o      �  � DataContext 6   ��  �� ElementName$ lstProducts��$ SelectedItem� 5p      �� 5q      $
��Auto �6'   66   �� 5r      6)    5t      �� 5u      $
��Auto �6$   64   �� 5v      $
��Auto �6$   64   �� 5w      $
��Auto �6$   64   �� 5x      $
��Auto �6$   64   �� 5y      $��* �6$   61   .+�5|      �� $��7q�6   Model Number:66   �� 5}      $��5q�6   $��1��6%   ��65   �� $ ModelNumber�6Y   �� 5~      $��7q�6   $��1��6'   Model Name:6A   �� 5      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName�6d   �� 5�      $��7q�6   $��2��6'   
Unit Cost:6@   �� 5�      $��5q�6   $��2��6%   $��1��62   ��6B   �� $ UnitCost�6c   �� 5�      $��7,7,7,0q�6   $��3��6-   Description:6H   �� 5�      $��7q�6   $��4��6%   $��0��62   $��2��6B    �� TextWrapping$
 Wrap=�5�      " �� VerticalScrollBarVisibility$ Visible=�6&   ��6L   �� $ Description�6p   5�      5�      5�      5�      