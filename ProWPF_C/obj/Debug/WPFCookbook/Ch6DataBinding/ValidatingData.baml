   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Iclr-namespace:ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.ValidatingData;ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.ValidatingData  5   	   8    2ProWPF_C.WPFCookbook.Ch6DataBinding.ValidatingData   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   [localIclr-namespace:ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.ValidatingData     5   	     � Title$  Data Validation��5   	   $	��350��6!   $	��525��6.    � 	Resources 5         errorTemplate ��Name��%  &	        �� 5   
   .R�5      �� 
���  ��$��2q�6'   ._�5	      � .+�5
      �� $	 _el��60   �� 5      
���  ��$��Right=�5       $��Center=�6<   $��0,0,6,0q�6W   ��5       �� *[0].ErrorContent+5   W   5      5      5      5      .��5      � $��16(�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Name:��6   $��6q�6!   �� 5   
   $��1��6   $��6q�6"    =� ErrorTemplate# [  6-   .��6g   ��5      �� 5       �� Path$
 Name�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6C   	 �� ValidationRules	 5       N  HProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.ValidatingData.MinCharsRule  5!      
   MinimumChars$
 3��6-   5#      .��5$      5%      �� 5&   
   $
��Age:��6   $��1��6    $��6q�6-   �� 5'   
   $��1��5(      $��1��6"   $��6q�6/   ��5'      �� *Age+ �� ValidatesOnExceptions . $ PropertyChanged=�5(   /   5)      5*      