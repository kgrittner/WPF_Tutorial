   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses,ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses  5   	   =    7ProWPF_C.WPFCookbook.Ch6DataBinding.SortingAndFiltering   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Llocal:clr-namespace:ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses     5   	     � Title$  Sorting and Filtering��5   	   $	��350��6'   $	��525��64    � 	Resources 5      @  :ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.SortFieldList   
sortFields<  6ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.SortField   DisplayName   PropertyName��%�   &	          5   
     5      $ 
(Unsorted)��6     5	      $ Process Name��6   $ ProcessName��69     5
      $ 
Process ID��6   $ Id��67     5      $ 	# Threads��6   $ Threads.Count��66   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��Stretch=�6   ��67   �� ��5      �� 5      .R�5      �� $��2q�6    �� Padding$ 4q�6(   
���   �$��1q�6H   ._�5      ��  �� Orientation$ 
Horizontal=�6%   $��16(�6>   .+�5      �� 
���   �$
��Bold"�6;   ��6M   �� *ProcessName+�� 5      $��10,0,0,0q�6(   
����  ���6L   �� *Id+ �� StringFormat$ ({0})���� 5      $��20,0,0,0q�6(   
���  ����6K   �� *Threads.Count+$ Threads: {0}��5      5      5      5      �� 5    
   $��1��6   $ 
Horizontal=�6"   $��4q�6;   $��14(�6F   .+�5!      �� $��Sort by��6   $��Center=�6'   �� 5"      -   5         ��Name$ 
_sortField��5"   4   $	��150��6   $��6,0,0,0q�6#   	 �� SelectedIndex$	 0��6H   #��[  5#      
 �� DisplayMemberPath$
 DisplayName��6A    �� SelectedValuePath$ PropertyName��5$      5%      �� 5&      -   5         ��Name$ 
_ascending��5'   (   $��10,0,0,0q�5&      $��	Ascending��6)   $��Center=�6=    d� 	IsChecked$
 trueY�5'      6(   �� 5(      -   5        $��4,0,0,0q�5(      $
��Sort��6&   65   �� 5)      -   5         ��Name$ _filterText��5)   (   $��10,0,0,0q�6   $	��120��6=   �� 5*      -   5        $��4,0,0,0q�5*      $��Filter��6&   67   5+      5,      5-      