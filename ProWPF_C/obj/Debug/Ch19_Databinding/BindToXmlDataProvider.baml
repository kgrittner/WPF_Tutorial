   M S B A M L   `   `   `  ����  ProWPF_C5    /ProWPF_C.Ch19_Databinding.BindToXmlDataProvider   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  BindToXmlDataProvider��5   	   $	��590��6'   $	��459��64    � 	Resources 5         products � Source � XPath��%F   &	        � 5   
   $ 	store.xml?�6+   $ Products��6>   6Q   5      .��5      �  � RowDefinitions 5	   
   �� 5
      $��* �6   6)   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��lstProducts��5      $��5q�6%    �� DisplayMemberPath$ 	ModelName��60   ��5      ��  �� Source# [   �� XPath$ Product��6[   �� 5   
   $��1��6   $��Stretch=�6$   $��Bottom=�6B    �� ResizeBehavior$ PreviousAndNext=�6]   $��5��5      5      �� 5   
   $��2��6   	 �� Padding$	 7q�6   $��7q�6*   
����İ�._�5      � 
 � DataContext
 6   ��  �� ElementName$ lstProducts�� �� Path$ SelectedItem� � ColumnDefinitions 5      �� 5      $
��Auto �6'   66   �� 5      6)    5      �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5       $
��Auto �6$   64   �� 5!      $��* �6$   61   .+�5$      �� $��7q�6   Model Number:66   �� 5%      $��5q�6   $��1��6%   ��65   �� $ ModelNumber��6Z   �� 5&      $��7q�6   $��1��6'   Model Name:6A   �� 5'      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName��6e   �� 5(      $��7q�6   $��2��6'   
Unit Cost:6@   �� 5)      $��5q�6   $��2��6%   $��1��62   ��6B   �� $ UnitCost��6d   �� 5*      $��7,7,7,0q�6   $��3��6-   Description:6H   �� 5+      $��7q�6   $��4��6%   $��0��62   $��2��6B    �� TextWrapping$
 Wrap=�5,      " �� VerticalScrollBarVisibility$ Visible=�6&   ��6L   �� $ Description��6q   5/      50      51      52      