   M S B A M L   `   `   `  ����  ProWPF_C8    2ProWPF_C.Ch17_ControlTemplates.SimpleCustomButtons   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  SimpleCustomButtons��5   	   $	��300��6%   $	��458��62    � 	Resources 5         ButtonTemplate �� 
TargetType �� CornerRadius �� StrokeDashArray J� SnapsToDevicePixels �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value��%x  &	        �� 5   
   " ��61   .R�5      �� $��Border��5	   6   
��� ���$��3q�5   *   $ 2��6>   
���  ��
�������._�5
      � .+�5      �� $��FocusCue��6    $y�Hidden=�60   
���   �$��1��5      $	 1 2R�6     . 5   *   �� 5      ��. #��z��5      5      5      5       5      P� 5       �@J�IsMouseOver . . �5      �� $	 Border��6   
 � ��
 �  ��6G   5      P� 5       � �� . . �5      �� $	 Border��6   
 � ��
 �\\��6G   �� 5      $	 Border��6   
 � ��
 �k���6H   5      P� 5       �@J�IsKeyboardFocused . . �5      �� $	 FocusCue��6   
 � y�$ Visible=�6I   5      P� 5       � {� .  . �5      �� $	 Border��6   
 � ��
 �����6Q   �� 5       $	 Border��6   
 � ��
 �����6G   5!      5$      5%      .��5'      �� $��10q�6   .+�5(   
   �� -   5        $��cmdOne��5(   d   $��10q�6   $��5q�6   #��[  6)   .��6r   (&A simple Button with a Custom Template5*      �� 5,   
   -   5        $��cmdTwo��5,   d   $��10q�6   $��5q�6   #��[  6)   .��6r   .,Another simple Button with a Custom Template5.      �� 50   
   -   5        $��cmdThree��50   d   $��10q�6   $��5q�6   #��[  6)   .��6t   A Third Button52      �� 54   
   -   5        $��cmdFour��54   v   $��10q�6   $��5q�6   #��[  6)   {�.  .��6�   A Disabled Button56      57      58      