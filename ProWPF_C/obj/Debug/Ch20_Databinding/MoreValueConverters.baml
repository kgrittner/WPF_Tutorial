   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ProWPF_C.Ch20_Databinding.Classes!ProWPF_C.Ch20_Databinding.Classes  5   	   3    -ProWPF_C.Ch20_Databinding.MoreValueConverters   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:ProWPF_C.Ch20_Databinding.Classes     5   	     � Title$  MoreValueConverters��5   	   $	��414��6%   $	��432��62    � 	Resources 5      :   4ProWPF_C.Ch20_Databinding.Classes.ImagePathConverter   ImagePathConverterB   <ProWPF_C.Ch20_Databinding.Classes.PriceToBackgroundConverter  PriceToBackgroundConverter   HighlightBrush   MinimumPriceToHighlight   DefaultBrush��%i   &	        &	        5   
   6@     5	   
   
 � ���$ 10~�5
   7    6   Z� 5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   �  5      �� 5      $��* �6    6-   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��lstProducts��5      $��5q�6)    �� DisplayMemberPath$ 	ModelName��64   6T   �� 5      $��1��6   $��Right=�6&    �� Orientation$ 
Horizontal=�6B   $��5,2,5,10q�6[   .+�5      �� -   5        $��2,0,0,0q�5      $��2q�6+   .��5   ,   Get Products6:   5      5       �� 5"   
   $��1��6   $��Stretch=�6$   $��Bottom=�6B    �� ResizeBehavior$ PreviousAndNext=�6]   $��5��6~   6�   �� 5%   
   
����İ�$��2��6-   $��7q�6:   ._�5'      �� 	 �� Padding$	 7q�5)      
 � DataContext
 5'      ��  �� ElementName$ lstProducts�� �� Path$ SelectedItem���5(      �� $ UnitCost� �� 	Converter# [ ._�5+      �  � ColumnDefinitions 5,      �� 5-      $
��Auto �6+   6:   �� 5.      6-    50      �� 51      $
��Auto �6(   68   �� 52      $
��Auto �6(   68   �� 53      $
��Auto �6(   68   �� 54      $
��Auto �6(   68   �� 55      $
��Auto �6(   68   .+�58      �� $��7q�6    Model Number:6:   �� 59      $��5q�6   $��1��6)   ��69   �� $ ModelNumber�6]   �� 5;      $��7q�6    $��1��6+   Model Name:6E   �� 5<      $��5q�6   $��1��6)   $��1��66   ��6F   �� $ 	ModelName�6h   �� 5>      $��7q�6    $��2��6+   
Unit Cost:6D   �� 5?      $��5q�6   $��2��6)   $��1��66   ��6F   �� $ UnitCost�6g   �� 5A      $��7q�6    $��3��6+   $��2��68   $��SemiBold"�6L   $��14(�6b   -+IF Cost >= 10 ( Display Orange Background )5C      �� 5E      $��5q�6   $��4��6'   $��1��64   $
��None=�6D   $
��Left=�6S   ��5F      �� $ ProductImagePath�# [  5G      5I      5J      5K      5L      5M      