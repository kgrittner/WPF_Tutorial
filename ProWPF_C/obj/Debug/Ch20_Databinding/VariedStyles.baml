   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ProWPF_C.Ch20_Databinding.Classes!ProWPF_C.Ch20_Databinding.Classes  5   	   ,    &ProWPF_C.Ch20_Databinding.VariedStyles   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:ProWPF_C.Ch20_Databinding.Classes     5   	     � Title$  VariedStyles��5   	   $	��300��6   $	��300��6+    � 	Resources 5         DefaultStyle �� 
TargetType �� Property �� Value  HighlightStyle��%  &	        &	 m     �� 5	   
   " ��6%   .�5
      ��  � ��
 �����6+   �� 5       � ��$ 2q�6(   5      �� 5   
   " ��6'   .�5      ��  � ��
 ��İ�6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 2q�6(   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   6,   �� 5      $��5* �6   6,   .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $��* �6    6-   �� 5      $
��Auto �6    60   .+�5"      �� -   5        $��7,7,7,0q�5"      $��2q�6&   .��6O   Get Products6]   �� 5$      -   5        $��lstProducts��5$   5   $��1��6   $��7,3,7,10q�6#   $��Stretch=�6H    J� SnapsToDevicePixels .  �� DisplayMemberPath$ 	ModelName��5%   +   ��5&      L   FProWPF_C.Ch20_Databinding.Classes.SingleCriteriaHighlightStyleSelector  5'      	   DefaultStyle#	 [  5(      
   HighlightStyle#
 [ 5)         PropertyToEvaluate$ CategoryName��5*         PropertyValueToHighlight$ Travel��5+      5-      5/      �� 51      -   5        $��7,0,7,7q�51      $��3��6&   $��2q�63   .��6\   Change One Item6m   52      �� 54   
   $��1��6   $
��Left=�6'   $��Stretch=�6B   $��5��6^   6j   �� 56   
   $��1��6    �� Padding$ 7q�6!   $��7q�6-   
����İ�._�57      �  � DataContext 6   ��  �� ElementName$ lstProducts�� �� Path$ SelectedItem� 58      �� 59      $
��Auto �6'   66   �� 5:      6)    5<      �� 5=      $
��Auto �6$   64   �� 5>      $
��Auto �6$   64   �� 5?      $
��Auto �6$   64   �� 5@      $
��Auto �6$   64   �� 5A      $
��Auto �6$   64   �� 5B      $��* �6$   61   .+�5E      �� $��7q�6   Model Number:66   �� 5F      $��5q�6   $��1��6%   ��65   �� $ ModelNumber�6Y   �� 5H      $��7q�6   $��1��6'   Model Name:6A   �� 5I      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName�6d   �� 5K      $��7q�6   $��2��6'   
Unit Cost:6@   �� 5L      $��5q�6   $��2��6%   $��1��62   ��6B   �� $ UnitCost�6c   �� 5N      $��7q�6   $��3��6'   	Category:6?   �� 5O      $��5q�6   $��3��6%   $��1��62   ��6B   �� $ CategoryName�6g   �� 5Q      $��7,7,7,0q�6   $��4��6-   Description:6H   �� 5R      $��7q�6   $��5��6%   $��0��62   $��2��6B    �� TextWrapping$
 Wrap=�5S      " �� VerticalScrollBarVisibility$ Visible=�6)   ��5T      �� $ Description�69   5V      5W      5Y      5Z      