   M S B A M L   `   `   `  ����  ProWPF_C&     ProWPF_C.ToKnow2000.Basics.Combo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$
  Test��5   	   $	��887��6   $��543.985��6#    � 	Resources 5         
hoverStyle �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect��%�   &	        �� 5   
   " ��6#    5      P� 5       �@J�IsMouseOver . . �5	      ��  �@J�Effect 5
        5      5      5      5      5      .��5      � .+�5   
   �� $��0��6   .+�5      �� .+�5      �� -   5        $F��@#127 – Reacting to a Dependency Property Change Using Triggers��5   0   �� 5      $��Check Me��6   $��Center=�6.   ��5      �� 5      " ��6     5      P� 5   "    �@d�	IsChecked$
 trueY�6?   . �5   &   ��  � ��
 ��+��6C   5   #   5!      5#      �� 5$      5%      �� 5(      .+�5)      �� $E��?#129 – Properties Changed by Triggers Are Automatically Reset��6   �� 5*      $��Hover Over the buttons��6   � 5+      .+�5,      �� $
��10,0q�6   $	��Run��6+   $	��100��69   #��[  6E   �� 5-      $
��10,0q�6   $
��SKip��6+   $	��100��6:   #��[  6F   �� 5.      $
��10,0q�6   $
��Jump��6+   $	��100��6:   #��[  6F   5/      �� 50      $
��0,10q�6   51      �� 54      .+�55      �� $%��#176 – Two Kinds of Templates��6   �� 56      $��Italic$�6   $K��ECreate Person Object for sample 2 to work... Uncertain how this works��6+   � 57      .+�58      �� -   5        $��btnWithTemplate��58      $��Recreate Me��64   
����  ���59      �� 5:       �� 
TargetType" ��6.   .R�5;   "   �� 	 �� Orientation$	 
Horizontal=�6-   .+�5<   &   �� $��**��6,   #��z��69   �� 5=   &   #��z��6-   #��z��6Q   �� 5>   &   $��**��6,   #��z��69   5?   #   5@      5B      �� 5C      -   5        $��	lblPerson��5C      ��6-   �� ��5D      �� 5E      .R�5F   "   �� $��2q�6)   
����  �._�5G   &   �� $	 Vertical=�61   .+�5H   *   �� $	 
Horizontal=�65   .+�5I   .   �� ��64   �� 
 �� Path$
 	FirstName��� 5J   .   $
��Bold"�6V   ��64   �� $
 LastName�6V   5K   +   �� 5L   *   $��Italic$�6S   ��60   �� $
 	BirthYear�6S   5M   '   5N   #   5O      5Q      5R      �� 5S      $
��0,10q�6   5T      �� 5W      .+�5X      �� $I��C#199 – An Application's Windows Property Lists All of Its Windows��6   � 5Y      .+�5Z      �� -   5        $
��25,0q�5Z      $��Create New Window��6+   6G   �� 5[      -   5        $
��25,0q�5[      $��Where Are the Windows?��6,   6M   5\      �� 5]      $
��0,10q�6   5^      �� 5a      .+�5b      �� $9��3#200 – Parent/Child Relationships Between Windows��6   �� 5c      $��Italic$�6   .��6+   ;9When Test Main is closed or min all child windows respond6f   � 5d      .+�5e      �� -   5        .��5e   4   Creat New Child Window6L   5f      �� 5g      $
��0,10q�6   5h      �� 5k      .+�5l      �� $6��0#201 – Showing a Modal Dialog Using ShowDialog��6   �� 5m      $��Italic$�6   .��6+   86Modal: Cannot interact with other windows until closed6c   �� 5n      $��Italic$�6   .��6+   LJModaless: Is fully independant. When main is closed all window still opend6w   � 5o      .+�5p      �� -   5        .��5p   4   Model6;   �� 5q      -   5        .��5q   4   
Modeless6>   5r      �� 5s      $
��0,10q�6   5t      �� 5w      .+�5x      �� $4��.#204 – Detecting Key Presses in a WPF Window��6   �� 5y      $��Italic$�6   .��6+   1/Will display any vowel keyed into a label below6\   � 5z      .+�5{      �� -	   5        $��	lblVowels��5{      6/   5|      �� 5}      $
��0,10q�6   5~      �� 5�      .+�5�      �� $�� ��6   �� 5�      $��Italic$�6   6-   � 5�      5�      �� 5�      $
��0,10q�6   5�      �� 5�      .+�5�      �� $�� ��6   �� 5�      $��Italic$�6   6-   � 5�      5�      �� 5�      $
��0,10q�6   5�      5�      �� 5�   
   $��1��6   5�      �� 5�   
   $��2��6   5�      �� 5�   
   $��3��6   5�      5�      5�      