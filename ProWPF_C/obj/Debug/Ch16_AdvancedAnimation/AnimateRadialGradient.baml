   M S B A M L   `   `   `  ����  ProWPF_C;    5ProWPF_C.Ch16_AdvancedAnimation.AnimateRadialGradient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��myWind��5   	     � Title$  AnimateRadialGradient��5   	   $	��316��6'   $	��299��64    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5	      .��5
      �� -   5         g�Name$ myStoryBoard��5
   !   .��5      *� -   5        $ myPoint��5   7    �� 
TargetName$ ellipse��6F    �� TargetProperty$ Fill.GradientOrigin�6f    g� RepeatBehavior$ Forever��5   +   .'�5      ��  $� Value$ 0.7,0.3&�62    $� KeyTime$ 0:0:0��6B   6T   �� 5      $ 0.3,0.7&�62   $ 0:0:5��6B   6T   �� 5      $ 0.5,0.9&�62   $ 0:0:8��6B   6T   �� 5      $ 0.9,0.6&�62   $ 0:0:10��6B   6U   �� 5      $ 0.8,0.2&�62   $ 0:0:12��6B   6U   �� 5      $ 0.7,0.3&�62   $ 0:0:14��6B   6U   g� 5      $ 0.7,0.3&�64   $ 0:0:20��6D   6W   g� 5      $ 0.3,0.7&�64   $ 0:0:25��6D   6W   g� 5      $ 0.5,0.9&�64   $ 0:0:28��6D   6W   5      �� 5      $ ellipse��5      $! Fill.GradientStops[1].Color�5      	 �� From$	 	AliceBlueX�5      	
 �� To$
 WhiteX�6.    g� Duration$ 0:0:10D�6:    g� AutoReverse . $ Forever��5!      68   �� 5"      $ ellipse��5#      $! Fill.GradientStops[2].Color�5$      $

 BlueX�5%      $ 0:0:15D�6(    . $ Forever��5'      68   5(      5)      5+      .��5-      � -   5        $��myGrid��5-      .+�5.   
   A� -   5        $��ellipse��5.      $��5q�6"    �� Stretch$ Uniform=�6-   ��5/      
� 50       
� RadiusX$ 1Q�6&    
� RadiusY$ 1Q�62    
� GradientOrigin$ 0.7,0.3&�6>   .��51      �  � Color$ White��6#    � Offset$ 0Q�61   6?   � 52      $
 Blue��6#   $	 0.2Q�60   6@   � 53      $ Yellow��6#   $	 0.6Q�62   6B   54      56      �� 57   
   .+�58      �� -   5        $��	txtPointA��58      $��Right=�6)   6G   �� 59      -   5        $��	txtPointB��59      $��Right=�6)   6G   5:      5<      5=      