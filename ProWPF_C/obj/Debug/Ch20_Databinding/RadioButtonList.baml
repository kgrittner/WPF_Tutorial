   M S B A M L   `   `   `  ����  ProWPF_C/    )ProWPF_C.Ch20_Databinding.RadioButtonList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  RadioButtonList��5   	   $	��300��6!   $	��300��6.    � 	Resources 5         RadioButtonListStyle �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� Padding d� 	IsChecked	 �� Path
 �� RelativeSource �� Mode �� Triggers P� Property P� Value �� 
TargetName��%S  &	        �� 5   
   " ��6-   .�5      ��  � �� 5	      �� 5
      " ��6   .�5      ��  � ��
 �����67   �� 5       � �� 5      �� 5   "   " ��62   .R�5   &   �� $��Border��6-    . #��z��5   -   $��5q�5   -   $ 5q�5   -   ._�5   *   	� |�.   5      �� $	 
IsSelected�
 �� *TemplatedParent+$ TwoWay=�.��5   .   �� 6A   5   +   5   '    5   &   P� 5   *    �@��
IsSelected . . �5    .   �� $ Border��65    � ��
 ����6_   5!   +   5#   #   5%      5&      5(      5)      5*      .��5,      � $��8q�6    � RowDefinitions 5-   
   �� 5.      6   �� 5/      $
��Auto �6   6,   .+�52   
   �� -   5        $��lstProducts��52   @   #��[  6    �� DisplayMemberPath$ 	ModelName��53      
 � Tag$ UnitCost��6.   54      �� 56   
   -   5        $��1��56      $��0,5,0,0q�6   .��6J   Get Selected Item6]   57      58      