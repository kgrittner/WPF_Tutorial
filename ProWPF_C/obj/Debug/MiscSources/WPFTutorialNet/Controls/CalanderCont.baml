   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    ProWPF_C?   9ProWPF_C.MiscSources.WPFTutorialNet.Controls.CalanderCont   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  CalanderCont��5   	   $	��342��6   $	��509��6+    � 	Resources 5         calendarSelectionMode S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName  displayModes��%�   &	        &	 q     S� 5   
   $ GetNames��6;   "  6Q    5      M� 5	      $ CalendarSelectionMode��6   5      S� 5   
   $ GetNames��62   "  6H    5      M� 5      $ CalendarMode��6   5      5      .��5      � .+�5   
   ��  �� TabStripPlacement$
 Left=�6   $��Center=�6.   .@�5      �� $��Selection Modes��6   .��5      ]� .+�5      �� $	��Top=�6!    �� Orientation$ 
Horizontal=�66   $��10q�6P   .+�5      �� .��6    Selection Mode60   �� 5      -   5         ��Name$ selectionmode��5   #   	 �� SelectedIndex$	 0��6�   ��6:   �� 
 �� Source#
 [  6�   5      �� 5      $��10q�6!   .+�5      � .+�5      �� .��6$   Calander Size:65   �� 5      -   5        $ sizeCal��5   O   $
��Auto��6`   $	 0��6m   ��6'   �� *VolumeLevelList+.@�5   "   �� .��6/   20064   �� 5    "   .��6/   22064   �� 5!   "   .��6/   24064   �� 5"   "   .��6/   26064   �� 5#   "   .��6/   28064   �� 5$   "   .��6/   30064   5%      5&      (� 5'      $
��Auto��6w   ��6"   ��  �� Path$ SelectedValue.Content� �� ElementName$ sizeCal�� �� FallbackValue$	 200��.��5(      &   System.Windows.Controls.Calendar     SelectionMode 6'   �� *SelectedItem+$ selectionmode��6l   5)      5*      5+      5,      �� 5-      $��Blackout Dates��6   .��5.      �� .+�5/      �� $��20��6    $��46��6+   69     50       6   �� *SelectedItem+$ selectionmode��   BlackoutDates 51      /  )System.Windows.Controls.CalendarDateRange  52         Start$ 
12/01/2013��60   
   End$ 
12/11/2013��6C     53      $ 
12/24/2013��60   $ 
12/27/2013��6C   55      56      57      �� 58      $ ��Limit Displayed Date Range��6   .��59      ]� .+�5:      �� $	��Top=�6!   $ 
Horizontal=�66   .+�5;      �� $��20��6$   $��46��6/   6=   5<        5=         DisplayDateStart$ 
01/01/2010X�6      DisplayDateEnd$ 
01/15/2010X�6=   5>      5@      �� 5A      $��Display Mode��6   .��5B      ]� .+�5C      �� $	��Top=�6!   $ 
Horizontal=�66   $��10q�6O   .+�5D      �� .��6$   Selection Mode:66   �� 5E      -   5        $ displayModes��5E   '   $	 0��6z   ��6=   �� #
 [ 6�   5F        5G         DisplayMode 6   �� *SelectedItem+$ displayModes��6`   5H      5I      5J      5N      5O      