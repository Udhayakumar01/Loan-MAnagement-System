   M S B A M L   `   `   `  ����A  =LMS_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LMS_UILMS_UI  5   	   "    LMS_UI.View_Customer_Details   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:LMS_UI     5   	     � Title$  viewinfo��5   	   $	��450��6   $	��800��6'    � 	Resources 5	         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  ButtonStyle2��%K  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   $
 13��61   #��z��6C   #��z��6o   #��z��6�    . ._�5)      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted . . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver . . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � �� . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {� .  . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      �� 5A   
   " ��6%   .�5B      ��  �@�FocusVisualStyle8   61   �� 5C       � ��8  6+   �� 5D       � ��8  6,   �� 5E       � ��# � ��6+   �� 5F       � ��$ 1q�60   �� 5G       � ��$ Center=�6;   �� 5H       � ��$ Center=�69   �� 5I       � ��$ 1q�6(   �� 5J       � �� 5K      �� 5L      " ��6&   .R�5M      �� $	 border��6!   $
 13��61   #��z��6C   #��z��6o   #��z��6�    . ._�5N      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5O       5P      P� 5Q       �@��IsDefaulted . . �5R   "   �� $ border��6@   # � ��6T    � ��5S      P� 5T       �@J�IsMouseOver . . �5U   "   �� $ border��6?   8   � ��6S   �� 5V   "   $ border��6@   8   � ��6T   5W      P� 5X       � �� . . �5Y   "   �� $ border��6?   8   � ��6S   �� 5Z   "   $ border��6@   8   � ��6T   5[      P� 5\       � {� .  . �5]   "   �� $ border��6?   8   � ��6S   �� 5^   "   $ border��6@   8   � ��6T   �� 5_   "   $ contentPresenter��6K   8 	  � ��6i   5`      5b      5d      5e      5f      .��5g      � .+�5h   
   �� .@�5i      �� $��CUSTOMER INFORMATION��6   $��-2,-2,-185,0q�64   .��5j      � 
�������.+�5k      �� -   5         ��Name$ lbl_CustomerId��5k      $��Customer ID : ��64   $
��Left=�6M   $��	80,90,0,0q�6h   $	��Top=�6{    J� RenderTransformOrigin$ -0.744,3.705&�6�   �� 5l      -   5         ��Name$ txt_CustomerId��5l      ���	#FFF5E6B1$
��Left=�6{   $��25��6�   $��
270,90,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��116��6�   �� 5m      -   5         ��Name$ btn_View��5m      $
��View��6/   ���	#FFF7DDB7$
��Left=�6U   $��
463,93,0,0q�6p   $	��Top=�6�   $��89��6�   $��23��6�   #��� 
 6�   �� 5n      -   5        $ btn_Back��5n      $
��Back��6/   ���	#FFF7DDB7$
��Left=�6U   $��
616,95,0,0q�6p   $	��Top=�6�   $��95��6�   $ -0.693,1.242&�6�   $��23��6�   #���  6�   �� 5o      $��Customer  Details��6   $
��Left=�68   $��
264,18,0,0q�6S   $	��Top=�6g   $	��351��6   $
��Bold"�6�   $��36(�6�   ���	#FFF16363$��Italic$�6�   5p      5q      5r      &   System.Windows.Controls.DataGrid  5s   
   -   5          Name$ DataGrid��5s      ���	#FFF9EAB8$
��Left=�6<   $	��136��6W   $��
26,168,0,0q�6d   $	��Top=�6x   $	��738��6�   5u      5v      