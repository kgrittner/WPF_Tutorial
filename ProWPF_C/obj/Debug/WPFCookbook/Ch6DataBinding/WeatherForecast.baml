   M S B A M L   `   `   `  ����C  ?ProWPF_C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses,ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses  5   	   9    3ProWPF_C.WPFCookbook.Ch6DataBinding.WeatherForecast   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Llocal:clr-namespace:ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses     5   	     � Title$  WeatherForecast��5   	   $	��300��6!   $	��300��6.    � 	Resources 5      R  LProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.GeneralForecastToBrushConverter   gf2brush��%   &	          5   
   60   5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $(��"Select number of days to forecast:��6   $��15(�6B   $��Center=�6P   $��4q�6k   �� 5      -   5         ��Name$ _days��5       �� SelectedIndex$ 0��6&   $��50��68   �� 5      -   5        $��4q�5      $��Get Forecast��6    $��16(�67   6E   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��4q�6;   $��15(�6F   .+�5      �� $��Select units:��6   $��4q�6-   	� 5      $��Celsius��6    d� 	IsChecked$
 TrueY�6,   $
��10,4q�6=   	� 5      $��
Fahrenheit��6   $
��20,4q�6/   5      �� 5   
   $��Stretch=�6*   $��2��6O   ��6   �� ��5      �� 5      .R�5      �� $��4q�6   
���   �$��2q�6<    �� Padding$ 4q�6P   ��5      �� *GeneralForecast+ �� 	Converter# [  ._�5      �� $ 
Horizontal=�6%   .+�5       �� $��20(�6(   $
��Bold"�66   ��6H   �� *GeneralForecast+�� 5!      $��16(�6(   $��10,0,0,0q�66   $��Bottom=�6H   ��6c   �� *TemperatureLow+	 �� StringFormat$	 Low: {0:N2}���� 5"      $��16(�6(   $��10,0,0,0q�66   $��Bottom=�6H   ��6c   �� *TemperatureHigh+$	 High: {0:N2}���� 5#      $��16(�6(   $��20,0,0,0q�66   $��Bottom=�6H   ��6c   �� *Percipitation+$	 Percip: {0:N2}��5$      5%      5&      5(      5)      5*      