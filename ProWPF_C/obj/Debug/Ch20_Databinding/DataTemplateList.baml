   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ProWPF_C.Ch20_Databinding.Classes!ProWPF_C.Ch20_Databinding.Classes  5   	   0    *ProWPF_C.Ch20_Databinding.DataTemplateList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:ProWPF_C.Ch20_Databinding.Classes     5   	     � Title$  DataTemplateList��5   	   $	��409��6"   $	��853��6/    � 	Resources 5      :   4ProWPF_C.Ch20_Databinding.Classes.ImagePathConverter   ImagePathConverter��%   &	          5	   
   6@   5
      .��5   
   �  � ColumnDefinitions 5   
   �� 5      $��3* �6   6,   �� 5      $��5* �6   6,   .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $��* �6    6-   .+�5      �� -   5        $��7,7,7,0q�5      $��2q�6&   .��6O   Get Products6]   �� 5      -   5        $��lstProducts��5   5   $��1��6   $��7,3,7,10q�6#   $��Stretch=�5       J� SnapsToDevicePixels . ��5      �� 5      .�5      ��  �� Property � �� �� Value$ 0q�6<   6H    �� Triggers 5      P� 5        P� Property �@��
IsSelected	 P� Value	 . . �5!   "   ��  � ��
 ����6K   �� 5"   "    � ��
 �   �6K   5#      5%      ��5'      �� 5(      .R�5)      � $��0q�6   
�������.+�5*      �� $��5q�6%   $��1q�5+   %   
�����F�
 �� CornerRadius$
 4��54   ,   ��5-   %   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �� �� Path$ 
Background�._�55   "   � $��3q�6'    56   &   �� 57   *   6:   �� 58   *   6:    5:   &   �� 5;   *   $
��Auto �6;   6J   �� 5<   *   $
��Auto �6;   6J   .+�5>   &   �� $
��Bold"�60   $��1��6B   ��6R   �� $ ModelNumber�6v   �� 5?   &   $��1��60   $��1��6=   ��6M   �� $ 	ModelName�6o   �� 5@   &   $��5q�6,   $��0��67   $��2��6D   $
��Left=�6V   $��40��6q   ��5A   ,   �� $ ProductImagePath� �� 	Converter# [  5C   '   5D   #   5E      5F      5G      5I      5L      �� 5N   
   $��1��6   $
��Left=�6'   $��Stretch=�6B   $��5��6^   6j   �� 5P   
   $��1��6    �� Padding$ 7q�6!   $��7q�6-   
����İ�._�5Q      �  � DataContext 6   ��  �� ElementName$ lstProducts��$ SelectedItem� 5R      �� 5S      $
��Auto �6'   66   �� 5T      6)    5V      �� 5W      $
��Auto �6$   64   �� 5X      $
��Auto �6$   64   �� 5Y      $
��Auto �6$   64   �� 5Z      $
��Auto �6$   64   �� 5[      $��* �6$   61   .+�5^      �� $��7q�6   Model Number:66   �� 5_      $��5q�6   $��1��6%   ��65   �� $ ModelNumber�6Y   �� 5`      $��7q�6   $��1��6'   Model Name:6A   �� 5a      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName�6d   �� 5b      $��7q�6   $��2��6'   
Unit Cost:6@   �� 5c      $��5q�6   $��2��6%   $��1��62   ��6B   �� $ UnitCost�6c   �� 5d      $��7,7,7,0q�6   $��3��6-   Description:6H   �� 5e      $��7q�6   $��4��6%   $��0��62   $��2��6B    �� TextWrapping$
 Wrap=�5f      " �� VerticalScrollBarVisibility$ Visible=�6&   ��6L   �� $ Description�6p   5h      5i      5k      5l      