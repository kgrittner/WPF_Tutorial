   M S B A M L   `   `   `  ����  ProWPF_C9    3ProWPF_C.WPFCookbook.Ch6DataBinding.TreeViewBinding   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Processes / Modules Tree��5   	   $	��350��6*   $	��525��67   .��5      � .+�5   
   R� ��6   �� ��5      �� 5       �� ItemsSource 6+   �� *	Modules+.R�5	      ��  �� Orientation$ 
Horizontal=�6!   $��2q�6:   .+�5
      �� $
��Bold"�6A   $��16(�6S   ��6$   �� *ProcessName+6S   �� 5      $��5,0,0,0q�6$   $��16(�6_   ��65   �� *Id+ �� StringFormat$ ({0})��6_   5       �� ItemTemplate 5      �� 5      .R�5      �� $ 
Horizontal=�6)   $��2q�6B   .+�5   "   �� $��14(�6H   $
��Bold"�6V   ��6,   �� *
ModuleName+6V   �� 5   "   $��5,0,0,0q�6,   $��12(�5      $��Center=�6'   ��5   =   �� *
FileName+$ ({0})��5   '   5      5      5      5      5      5      