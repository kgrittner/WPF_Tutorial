   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ProWPF_C.Ch19_Databinding.Classes!ProWPF_C.Ch19_Databinding.Classes  5   	   6    0ProWPF_C.Ch19_Databinding.BindingGroupValidation   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:ProWPF_C.Ch19_Databinding.Classes     5   	     � Title$  BindingGroupValidation��5   	   $	��515��6(   $	��467��65   .��5      �  � RowDefinitions 5   
   �� 5	      $��* �6   6)   �� 5
      $
��Auto �6   6,   �� 5      $��2* �6   6*   .+�5   
   �  5      �� 5      $��* �6    6-   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��lstProducts��5      $��5q�6)    �� DisplayMemberPath$ 	ModelName��64   5      �� 5      $��1��6   $��Right=�6&    �� Orientation$ 
Horizontal=�6B   $��5,2,5,10q�6[   .+�5      �� -   5        $��2,0,0,0q�5      $��2q�6+   .��5   ,   Get Products6:   5      5      �� 5   
   $��1��6   $��Stretch=�6$   $��Bottom=�6B    �� ResizeBehavior$ PreviousAndNext=�6]   $��5��5      6   �� 5   
   $��2��6    �� Padding$ 7q�6   $��7q�6*   
����İ�._�5       � -   5        $��gridProductDetails��5        � DataContext 6-   ��  �� ElementName$ lstProducts�� �� Path$ SelectedItem�	 � ColumnDefinitions	 5#      �� 5$      $
��Auto �6'   66   �� 5%      6)    5'      �� 5(      $
��Auto �6$   64   �� 5)      $
��Auto �6$   64   �� 5*      $
��Auto �6$   64   �� 5+      $
��Auto �6$   64   �� 5,      $��* �6$   61   �� 5-      $
��Auto �6$   64   
 � BindingGroup
 50      &   System.Windows.Data.BindingGroup  51      -   5        productBindingGroup��   ValidationRules 52      :   4ProWPF_C.Ch19_Databinding.Classes.NoBlankProductRule  53      69   55      .+�58      �� $��7q�6   Model Number:66   �� 59      $��5q�6   $��1��6%   ��65   �� $ ModelNumber�.��6W   5:      �� 5<      $��7q�6   $��1��6'   Model Name:6A   �� 5=      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName�.��6b   5>      �� 5@      $��7q�6   $��2��6'   
Unit Cost:6@   �� 5A      $��5q�6   $��2��6%   $��1��62   .��6B   ��5B      �� 5C      $ UnitCost�6"    �� NotifyOnValidationError .  �� StringFormat$ {0:C}��6Q    �� ValidationRules 5D      9   3ProWPF_C.Ch19_Databinding.Classes.PositivePriceRule  5E   "   
   Max$ 999.99~�6:   6I   5G      .��5H   $   5I      �� 5J      $��7,7,7,0q�6   $��3��6-   Description:6H   �� 5K      $��7q�6   $��4��6%   $��0��62   $��2��6B   " �� VerticalScrollBarVisibility$ Visible=�5L       �� TextWrapping$
 Wrap=�68   ��6L   �� $ Description�6p   �� 5N      $ 
Horizontal=�6   $��3q�66   $��5��6A   $��2��6N   $��Right=�6b   .+�5O      �� -   5         �� 	IsDefault . $��2q�5P      $��	10,2,10,2q�6   .��62   Update6:   5R      5S      5T      5U      5V      