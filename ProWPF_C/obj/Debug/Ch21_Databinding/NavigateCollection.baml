   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProWPF_C.Ch21_DatabindingProWPF_C.Ch21_Databinding  5   	   2    ,ProWPF_C.Ch21_Databinding.NavigateCollection   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9local'clr-namespace:ProWPF_C.Ch21_Databinding     5   	     � Title$  NavigateCollection��5   	   $	��433��6$   $	��515��61   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   6,   �� 5
      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5        $��lstProducts��5       �� DisplayMemberPath$ 	ModelName��6&   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5       �� Text 5   D   ��  �� Path$ 	ModelName�5   D   �� 5   
   $��1��6    �� Padding$ 5q�6   $��0,5,0,5q�6*   
����İ�._�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6'   66   �� 5      6)    5      �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $��* �6$   61   .+�5       �� $��7q�6   Model Number:66   �� 5!      $��5q�6   $��1��6%   ��65   �� $ ModelNumber�6Y   �� 5"      $��7q�6   $��1��6'   Model Name:6A   �� 5#      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName�6d   �� 5$      $��7q�6   $��2��6'   
Unit Cost:6@   �� 5%      $��5q�6   $��2��6%   $��1��62   ��6B   �� $ UnitCost� �� StringFormat$ {0:C}��6x   �� 5&      $��7,7,7,0q�6   $��3��6-   Description:6H   �� 5'      $��7q�6   $��4��6%   $��0��62   $��2��6B   	 �� TextWrapping$
	 Wrap=�5(      "
 �� VerticalScrollBarVisibility$
 Visible=�6(   ��6N   �� $ Description�6r   5)      5*      � 5,   
   $��2��6   .+�5-      ��  �� Orientation$ 
Horizontal=�6   .+�5.      �� -   5        $��cmdPrev��5.      .��6>   <6D   �� 5/      -   5        $��lblPosition��5/   -   $��5,0,5,0q�6   $��Center=�6@   6]   �� 50      -   5        $��cmdNext��50      .��6>   >6D   51      52      53      54      