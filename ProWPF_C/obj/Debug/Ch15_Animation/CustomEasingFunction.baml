   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ProWPF_C.Ch15_AnimationProWPF_C.Ch15_Animation  5   	   2    ,ProWPF_C.Ch15_Animation.CustomEasingFunction   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7local%clr-namespace:ProWPF_C.Ch15_Animation     5   	     � Title$  CustomEasingFunction��5   	   $	��341��6&   $	��692��63    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5	      �� 5
      .��5      �� .��5      W�  �� 
TargetName$ ellipse1��5       �� TargetProperty$ (Canvas.Left)�6.   	 W� To$	 500X�5       g� Duration$ 0:0:10D�6   5      W� 5      $ ellipse2��5      $ (Canvas.Left)�6.   $	 500X�5      $ 0:0:10D�6    W� EasingFunction 5      .   (ProWPF_C.Ch15_Animation.RandomJitterEase  5   "   7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ EaseIn=�69   	   Bitter$
	 1000��6N   6^   5      5      5      5      .��5      �� $��10q�6   .+�5   
   A� -   5        $��ellipse1��5      
 �� Left$
 0��6"   
���  ��$��20��6=   $��20��6H   6V   A� 5   
   -   5        $��ellipse2��5      
 �� Top$	 100��6"   $
 0��63   
���  ��$��20��6N   $��20��6Y   6g   5       5!      