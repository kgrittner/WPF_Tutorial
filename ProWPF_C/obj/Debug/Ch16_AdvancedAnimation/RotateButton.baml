   M S B A M L   `   `   `  ����  ProWPF_C2    ,ProWPF_C.Ch16_AdvancedAnimation.RotateButton   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  RotateButton��5   	   $	��300��6   $	��300��6+    � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers :� RoutedEvent ��Name �� TargetProperty		 W� To
 g� Duration g� RepeatBehavior��%  '��       �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   6E   �� 5	       �@J�RenderTransformOrigin$ 0.5,0.5&�66   6H   �� 5
       � ��$ 20,15q�6(   68   �� 5       � ��$ 2q�6'   63   �� 5       � z� 5      �� 5      6(   5       5      :� 5      $ Button.MouseEnter��6   [�5      �� 5      $ rotateStoryboardBegin��6*   .��5      �� .��5   "   W� $ RenderTransform.Angle�62   $		 360X�5      $
 0:0:0.8D�6   $ Forever��6.   6I   5      5      5      :� 5      $ Button.MouseLeave��6   [�5      �� 5      .��5      �� .��5    "   W� $ RenderTransform.Angle�62   $
 0:0:0.2D�5!      6)   5"      5#      5%      5'      5)      .��5*      �� $��5q�6   .+�5+   
   �� .��6   One6   �� 5,   
   .��6   Two6   �� 5-   
   .��6   Three6   �� 5.   
   .��6   Four6   �� 5/   
   -   5        $	��lbl��5/      $��5q�6   6,   50      51      