   M S B A M L   `   `   `  ����F  BInfoManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InfoManagerInfoManager  5   	   7 clr-namespace:InfoManager.CommonInfoManager.Common  61   5clr-namespace:InfoManager.ModelInfoManager.Model  6a   ?$clr-namespace:InfoManager.View.pagesInfoManager.View.pages  5   	       InfoManager.View.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:InfoManager     5   	   3common clr-namespace:InfoManager.Common     61   1modelclr-namespace:InfoManager.Model     6a   2p$clr-namespace:InfoManager.View.pages     5   	     � Title$  Welcome Listen��5	   	   $	��600��6    $	��950��6-   $��Microsoft YaHei)�5
   	   $��
ExtraLight"�6&    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . ��66   Z�  � 	Resources 5       �� Source�� 5   
   $+ %../Assets/style/ButtonDictionary.xaml?�6   %    .��5      �� $��5q�6   
������� �� CornerRadius$ 10��6+    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$
 Gray��6   	   Opacity$		 0.4Q�6,   ._�5   
   � .+�5      �� 
�������$	��110��6(   $	��Top=�65   $ 	10,10,0,0��6M   �� 5      
 �� Orientation$
 
Horizontal=�6   $��Right=�62   $	��Top=�6N   .+�5      �� $��40��6   $��40��6%      
ForkButton#��[  60   $	����6W   
�������6j   �� 5      $��40��6   $��40��6%   #��[  60   $	����6W   
�������6j   �� 5      $��40��6   $��40��6%   #��[  60   $	����6W   
�������6j   5      � 5       � RowDefinitions 5      �� 5      $��8* �6$   �� 5      $��1* �6$   .+�5       �� $
 
Horizontal=�6   $��10q�66   $
��Left=�6B   $��Center=�6]   .+�5!      �� $��Welcome Listen��6    $��30(�66   $
��Bold"�6D   $��Italic$�6V   
�������6i   5"      �� 5#      $
 
Horizontal=�6   $��10q�66   $��Right=�6B   $	��Top=�6^   .+�5$      �� $	��vip��6    $
��Bold"�6+   
�������$��30q�6P   5%      � 5&      $��0��6    � ColumnDefinitions 5'      �� 5(      $��1* �6+   �� 5)      $��4* �6+   .+�5+      �� -   5        ���	#090000005+   4   �� 5,      ���	#09000000$��1��64   �� 5-      $��0��6!   .+�5.      �� $
��Left=�6%   .+�5/      �� $	��100��6%   $	��100��61   $ 40��6>   ��50   "   �� 51   &    �� ImageSource$" ../Assets/MusicLogo/logo.png��61    53   "     54   &   $
 Gray��67   6F   56      57      	� 58      $��首页��6&   
 � Tag$	 ��63     MenuButtonStyle#��[ 6B    d� 	IsChecked$
 TrueY�6k   	� 59      $��精品歌单��6&   $	 ��65   #��[ 6D   	� 5:      $��歌手推荐��6&   $	 ��65   #��[ 6D   �� 5;      $��音乐分类��6    $	 ��6/     MenuLabelStyle#��[ 6>   $��0,15,0,0q�6f   A� 5<       A� Columns$ 2��6&   $��	40,0,10,0q�62   .+�5=      	� $��流行��6*     ClassButtonStyle#��[ 67   $
 TrueY�6a   	� 5>      $��民谣��6*   #��[ 67   	� 5?      $��古典��6*   #��[ 67   	� 5@      $��恋爱��6*   #��[ 67   	� 5A      $��伤感��6*   #��[ 67   	� 5B      $��乐器��6*   #��[ 67   5C      �� 5D      $��我的音乐��6    $	 ��6/   #��[ 6>   
������ $��0,15,0,0q�6   �� 5E      $��	40,0,10,0q�6E   ��6'   �� *Slist+��5F      �� 5G   "   .R�5H   &   	�   SheetButtonStyle#��[ 6b   ��62   �� *Header+ 6M   �� *Icon+6b   5I   #   5K      5L      � 5M      $��1��6    5N      �� 5O      $��60 �6,   �� 5P      .+�5R      �� $��1��6'   $��Hidden=�64   .��5S      &    InfoManager.View.pages.FirstPage  $��1��6*   5T      5U      5V      5W      5X      5Y      5Z      