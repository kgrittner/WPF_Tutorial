   M S B A M L   `   `   `  ����  ProWPF_C:    4ProWPF_C.Ch17_ControlTemplates.ButtonsWithAnimations   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ButtonsWithAnimations��5   	   $	��300��6'   $	��300��64    � 	Resources 5         ButtonTemplate �� 
TargetType �� CornerRadius �� StrokeDashArray J� SnapsToDevicePixels �� Triggers :� RoutedEvent �� 
TargetName	 �� TargetProperty	
 �� To g� Duration g� AutoReverse g� RepeatBehavior P� Property P� Value �� 
TargetName �� Property �� Value��%O  &	        �� 5   
   " ��61   .R�5      �� $��Border��5   C   
��� ���$��3q�5   *   $ 2��6>   
���  ��
�������._�5	      � .+�5
      �� $��FocusCue��6    $y�Hidden=�60   
���   �$��1��5       $	 1 2R�64    . 5      �� 5      ��. #��z��5   '   5      5      5       5      :� 5      $ 
MouseEnter��6   .[�5      �� .��5      �� .��5      �� $ Border��6-   $	 Background.Color�6L   $

 BlueX�5   -   $ 0:0:1D�67    . $ Forever��6[   5      5      5      5      :� 5      $ 
MouseLeave��6   .[�5      �� .��5      �� .��5       �� $ Border��6-   $	 Background.Color�6L   $ 0:0:0.5D�6y   6�   5!      5"      5#      P� 5$       � �� . . �5%      �� $ Border��6    � ��
 �\\��6[   �� 5&      $ Border��6    � ��
 �k���6\   5'      P� 5(       �@J�IsKeyboardFocused . . �5)      �� $ Border��6    � ��
 �\\��6[   �� 5*      $ FocusCue��6    � y�$ Visible=�6I   6[   5+      5-      5.      .��51      �� $��10q�6   .+�52   
   �� -   5        $��cmdOne��52   U   $��10q�6   $��5q�6   #��[  6*   .��6c   (&A Simple Button with a Custom Template54      �� 55   
   -   5        $��cmdTwo��55   T   $��10q�6   $��5q�6   #��[  6)   .��6b   '%Another Button with a Custom Template57      58      59      