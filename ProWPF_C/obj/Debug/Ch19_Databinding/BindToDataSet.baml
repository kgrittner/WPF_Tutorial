   M S B A M L   `   `   `  ����  ProWPF_C-    'ProWPF_C.Ch19_Databinding.BindToDataSet   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  BindToDataSet��5   	   $	��575��6   $	��521��6,   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   �� 5	      $��* �6   6)   .+�5   
   �  5      �� 5      $��* �6    6-   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��lstProducts��5      $��5q�6)    �� DisplayMemberPath$ 	ModelName��64   6T   �� 5      $��1��6   $��Right=�6&    �� Orientation$ 
Horizontal=�6B   .+�5      �� -   5        $��2,0,2,10q�5      $��2q�6,   .��5   6   Get Products6D   �� 5      -   5        $��2,0,2,10q�5      $��2q�6,   .��5   8   Delete Selected6I   5      5      �� 5   
   $��1��6   $��Stretch=�6$   $��Bottom=�5       �� ResizeBehavior$ PreviousAndNext=�62   $��5��5      6$   �� 5   
   $��2��6    �� Padding$ 7q�6   $��7q�6*   
����İ�._�5       �  � DataContext 6   ��  �� ElementName$ lstProducts�� �� Path$ SelectedItem�	 � ColumnDefinitions	 5!      �� 5"      $
��Auto �6'   66   �� 5#      6)    5%      �� 5&      $
��Auto �6$   64   �� 5'      $
��Auto �6$   64   �� 5(      $
��Auto �6$   64   �� 5)      $
��Auto �6$   64   �� 5*      $��* �6$   61   .+�5-      �� $��7q�6   Model Number:66   �� 5.      $��5q�6   $��1��6%   ��65   �� $ ModelNumber�6Y   �� 5/      $��7q�6   $��1��6'   Model Name:6A   �� 50      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName�6d   �� 51      $��7q�6   $��2��6'   
Unit Cost:6@   �� 52      $��5q�6   $��2��6%   $��1��62   ��6B   �� $ UnitCost�6c   �� 53      $��7,7,7,0q�6   $��3��6-   Description:6H   �� 54      $��7q�6   $��4��6%   $��0��62   $��2��6B   
 �� TextWrapping$

 Wrap=�55      " �� VerticalScrollBarVisibility$ Visible=�6&   ��6L   �� $ Description�6p   58      59      5:      5;      