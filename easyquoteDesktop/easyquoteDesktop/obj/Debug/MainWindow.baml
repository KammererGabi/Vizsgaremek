   M S B A M L   `   `   `  ����K  GeasyquoteDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:easyquoteDesktopeasyquoteDesktop  5   	   !    easyquoteDesktop.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:easyquoteDesktop     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5	   	   $	��400��5
   	   $	��350��5   	    � Title$; 5easyQuote Adminisztrációs Felület - Bejelentkezés��5   	    � Icon$ images/favicon2.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��	easyQuote��5      $��0��5      $��42(�5      $
��Bold"�5      $��Center=�5      $��Center=�5      ��5      �� 5        �� 
TargetType" ��6"   .R�5!      ��  �� Padding$ 9 2 9 9q�5"      
���   � �� CornerRadius$ 4��5$      $��1q�5%      ._�5'      �� $��Center=�5(   !   $��Center=�5)   !   5+      5,      5.      �� 5/   
   $��E-mail cím:��50      $��1��51      $��18(�52      $	��Top=�53      $��Center=�54      �� 56   
   -   5         ��Name$ textbox_email��57      $	��300��58      $��50��59      $��0,20,0,0q�5:      $��1��5;      $��18(�5<      	 �� TextAlignment$	 Center=�5=      $��Center=�5>      $��Center=�5?      $��Center=�5@      �� 5B   
   $��Jelszó:��5C      $��2��5D      $��18(�5E      $	��Top=�5F      $��Center=�5G      G� 5I   
   -   5        
 G�Name$
 passwordbox_password��5J      $	��300��5K      $��50��5L      $��0,20,0,0q�5M      $��2��5N      $��18(�5O      $��Center=�5P      $��Center=�5Q      $��Center=�5R      $��Center=�5S      �� 5U   
   -   5         ��Name$ login_button��5V      $	��300��5X      $��50��5Y      $��Bejelentkezés��5Z      $��3��5[      $��20(�5\       �� 	IsDefault . $��Arial)�5^      $
��Bold"�5_      
����������#ff0000$��Center=�5b      $��Center=�5c      5e      5f      