   M S B A M L   `   `   `  ����  ProWPF_C1    +ProWPF_C.ToKnow2000.Animation.Pulsing_Image   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Pulsing_Image��5   	   $	��300��6   $	��300��6,   .��5      �� $��15q�6   .+�5   
   �� $��Turn On��6   $��10q�6%    d� 	IsChecked$
 TrueY�61   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $��Tune In��6   $��10q�6)   $��Center=�65   �� 5	      -   5        $��
funkyArrow��5	      $��../Images/Capture.PNG��6&   $
��15,0q�6E    � Triggers 5
      :� 5       :� RoutedEvent$ Image.Loaded��6#   .[�5      �� .��5      �� .��5   "   W�  �� 
TargetName$ 
funkyArrow��62    �� TargetProperty$ Opacity�5   !    W� From$	 1.0X�5   !   	 W� To$	 0.1X�6,   	 g� Duration$	 0:0:0.5D�65   
 g� AutoReverse
 .  g� RepeatBehavior$ Forever��5   4   5      5      5      5      5      �� 5   
   $��Drop Out��6   $��10q�6&   5      5      