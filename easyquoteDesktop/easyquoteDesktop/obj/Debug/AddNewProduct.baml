   M S B A M L   `   `   `  ����K  GeasyquoteDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:easyquoteDesktopeasyquoteDesktop  5   	   $    easyquoteDesktop.AddNewProduct   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:easyquoteDesktop     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5	   	   $	��750��5
   	   $	��350��5   	    � Title$ Új termék��5   	    � Icon$ images/favicon2.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��150 �6   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Terméknév:��5      $��0��5      $��18(�5      $	��Top=�5      $��Center=�5      �� 5    
   -   5         ��Name$ textbox_productName��5!      $	��300��5"      $��50��5#      $��0��5$      $��18(�5%      $��0,20,0,0q�5&       �� TextAlignment$ Center=�5'      $��Center=�5(      $��Center=�5)      $��Center=�5*      �� 5,   
   $��	Leírás:��5-      $��1��5.      $��18(�5/      $	��Top=�50      $��Center=�51      �� 53   
   -   5        $ textbox_description��54      $	��300��55      $��80��56      $��1��57      $��18(�58      $��0,10,0,0q�59       �� TextWrapping$
 Wrap=�5:      $ Center=�5;      $��Center=�5<      $��Center=�5=      $��Center=�5>      �� 5@   
   $
��Ár:��5A      $��2��5B      $��18(�5C      $	��Top=�5D      $��Center=�5E      �� 5G   
   -   5        $ textbox_price��5H      $	��300��5I      $��50��5J      $��2��5K      $��18(�5L      $��0,20,0,0q�5M      $ Center=�5N      $��Center=�5O      $��Center=�5P      $��Center=�5Q      �� 5S   
   $��Kategória:��5T      $��3��5U      $��18(�5V      $	��Top=�5W      $��Center=�5X      �� 5Z   
   -   5         ��Name$ combobox_category��5[      $	��300��5\      $��50��5]      $��20(�5^      $��3��5_      $��0,20,0,0q�5`      $��Center=�5a      $��Stretch=�5b      $��Center=�5c      $��Center=�5d      �� 5f   
   $��Alkategória:��5g      $��4��5h      $��18(�5i      $	��Top=�5j      $��Center=�5k      �� 5m   
   -   5        $ combobox_subCategory��5n      $��20(�5o      $��4��5p      $	��300��5q      $��50��5r      $��0,20,0,0q�5s      $��Center=�5t      $��Stretch=�5u      $��Center=�5v      $��Center=�5w      �� 5y   
   $��Aktív termék:��5z      $��5��5{      $��18(�5|      $	��Top=�5}      $��Center=�5~      �� 5�   
   -   5        $ combobox_active��5�      $��20(�5�      $��5��5�      $	��300��5�      $��50��5�      $��0,20,0,0q�5�      $��Center=�5�      $��Stretch=�5�      $��Center=�5�      $��Center=�5�      �� 5�   
   -   5        	 ��Name$	 saveNewProduct_button��5�      $	��300��5�      $��50��5�      $��Mentés��5�      $��6��5�      $��20(�5�      $��Arial)�5�      $
��Bold"�5�      
 �� 	IsDefault
 . $��Center=�5�      $��Center=�5�      5�      5�      