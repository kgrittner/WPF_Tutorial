   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:ProWPF_C.WPFCookbook.Ch7CommandsAndMVVM.xClasses0ProWPF_C.WPFCookbook.Ch7CommandsAndMVVM.xClasses  5   	   <    6ProWPF_C.WPFCookbook.Ch7CommandsAndMVVM.RoutedCommands   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Plocal>clr-namespace:ProWPF_C.WPFCookbook.Ch7CommandsAndMVVM.xClasses     5   	     � Title$  Image Viewer��5   	   $	��350��6   $	��525��6+    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6(     5   
   -   5        $ IncreaseZoom��5      6D     5	   
   -   5        $ DecreaseZoom��5	      6E     5
   
   -   5        $&  local:Commands.ZoomNormalCommand��5
      6\   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   c� $��14(�6   .@�5      �� $��Open...��6   $
��Open��6'   $��6q�66   �� 5      $��Zoom In��6   $��IncreaseZoom��6'   $��6q�6>   �� 5      $��Zoom Out��6   $��DecreaseZoom��6(   $��6q�6?   �� 5      $��Normal��6   $&�� local:Commands.ZoomNormalCommand��6&   $��6q�6Q   5      �� 5   
   $��1��6   $
��Auto=�6$   $
��Auto=�6I   .��5      �� $
��None=�61   ��6   �� *	ImagePath+ � LayoutTransform 5      �� 5       �� ScaleX 6%   �� *Zoom+ �� ScaleY 6=   �� *Zoom+5      5      5      5      