   M S B A M L   `   `   `  ����  ProWPF_C:    4ProWPF_C.WPFCookbook.Ch4StandardControls.TabAndFocus   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  TabAndFocus��5   	   $	��300��6   $	��400��6*   .��5      � $��4q�5       +� FocusedElement 5      ��  �� ElementName$ _name�� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��10 �6   �� 5
      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      .+�5   
   �� $��5��6   $��16(�6   $��Send Comment��6,   $��3��5      $��Center=�6%   $��0,20,0,0q�5      $��4q�6#   �� 5   
   $��Name:��6   $��Center=�6!   �� 5   
   -   5         ��Name$ _name��5   "   $��2��6   6"   �� 5   
   $��	Birthday:��6   $��2��6%   $��Center=�62   (  "System.Windows.Controls.DatePicker  5   
   $��2��6   $��2��6"   �� 5   
   $��	Comments:��6   $��4��6%   �� 5   
    �� AcceptsReturn . $��4��6'   $��2��5      $	��100��6"   5      5      