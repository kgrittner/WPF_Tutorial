   M S B A M L   `   `   `  ����  ProWPF_C6    0ProWPF_C.WPFCookbook.Ch6DataBinding.MasterDetail   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  MasterDetail��5   	   $	��350��6   $	��525��6+   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5
   
   �� -   5         ��Name$ _master��5
   X   $��16(�6*    �� DisplayMemberPath$ ProcessName��68   ��6   �� 6X   � 5   
   $��1��6   $��16(�6    � DataContext 67   �� *SelectedItem+ �� ElementName$ _master�� � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��6q�6   ��6#   �� *ProcessName+ �� StringFormat$ 	Name: {0}���� 5      $��1��6   $��6q�6%   ��60   �� *Id+$ ID: 0���� 5      $��2��6   $��6q�6%   ��60   �� *PriorityClass+$ Priority Class: {0}���� 5      $��3��6   $��6q�6%   ��60   �� *Threads.Count+$ 
Threads: 0���� 5      $��4��6   $��6q�6%   ��60   �� *TotalProcessorTime+$ Processor Time: {0:G}��5      �� 5   
   
����  �$��2��6)   $��Right=�63   $��Stretch=�6O   5      5      