   M S B A M L   `   `   `  ����  ProWPF_CE    ?ProWPF_C.WPFCookbook.Ch6DataBinding.WeatherForecastWithTriggers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$!  WeatherForecastWithTriggers��5   	   $	��350��6-   $	��525��6:   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $(��"Select number of days to forecast:��6   $��15(�6B   $��Center=�6P   $��4q�6k   �� 5      -   5         ��Name$ _days��5       �� SelectedIndex$ 0��6&   $��50��68   �� 5      -   5        $��4q�5      $��Get Forecast��6    $��16(�67   6E   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��4q�6;   $��15(�6F   .+�5      �� $��Select units:��6   $��4q�6-   	� 5      $��Celsius��6    d� 	IsChecked$
 TrueY�6,   $
��10,4q�6=   	� 5      $��
Fahrenheit��6   $
��20,4q�6/   5      �� 5   
   $��Stretch=�6*   $��2��6O   ��6   �� ��5      �� 5      .R�5      ��  ��Name$ _border��6   $��4q�6.   
���   �$��2q�6M    �� Padding$ 4q�6a   
�������._�5      �� $ 
Horizontal=�6%   .+�5      �� $��20(�6(   $
��Bold"�66   ��6H   �� *GeneralForecast+�� 5      $��16(�6(   $��10,0,0,0q�66   $��Bottom=�6H   ��6c   �� *TemperatureLow+ �� StringFormat$ Low: {0:N2}���� 5      $��16(�6(   $��10,0,0,0q�66   $��Bottom=�6H   ��6c   �� *TemperatureHigh+$ High: {0:N2}���� 5      $��16(�6(   $��20,0,0,0q�66   $��Bottom=�6H   ��6c   �� *Percipitation+$ Percip: {0:N2}��5      5      	 �� Triggers	 5       �� 5!      
 �� Value$
 Sunny��6J    �� Binding 6&   �� *GeneralForecast+.a�5"      ��  �� 
TargetName$ _border��6J    �� Property � �� �� Value
 � ���5#      �� 5$      $
 Snowy��6J    6&   �� *GeneralForecast+.a�5%      �� $ _border��6M    � ��
 ��ح�5&      �� 5'      $
 Rainy��6J    6&   �� *GeneralForecast+.a�5(      �� $ _border��6N    � ��
 ����5)      �� 5*      $	
 Dry��6J    6&   �� *GeneralForecast+.a�5+      �� $ _border��6O    � ��
 �����5,      5.      50      51      52      