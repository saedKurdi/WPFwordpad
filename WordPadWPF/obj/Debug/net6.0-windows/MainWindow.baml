   M S B A M L   `   `   `  ����E  AWordPadWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WordPadWPF
WordPadWPF  5   	       WordPadWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WordPadWPF     5   	     � Title$  WPF WordPad��5   	   $	��450��6   $	��900��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��20* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      $��* �6#   .+�5      � $��0��6    5      �� 5      $	��10* �6'   �� 5      $��* �6'   .+�5      �� -   5        $��path_txtbox��5      $��
Enter Path��6n   $��0��6�   �� 5      -   5        $��open_button��5      $��1��6F   
������ .��5      �� $��\images\folder.png��6   5      5      � 5!      $��1��6    5"      �� 5#      $
��0.5* �6'   �� 5$      $��* �6'   �� 5%      $
��0.5* �6'   �� 5&      $
��0.5* �6'   �� 5'      $
��0.5* �6'   �� 5(      $��* �6'   .+�5+      �� -   5        $��save_button��5+      $��0��6,   $
��Save��6<   
������ 6d   �� 5,      -   5        $��	check_box��5,      $��1��6,   $��Center=�6<   $��	Auto Save��6W   �� 5-      -   5        $��
cut_button��5-      $��2��6+   $	��Cut��6;   
������ 6b   �� 5.      -   5        $��copy_button��5.      $��3��6,   $
��Copy��6<   
������ $��21��6d   $	��Top=�6p   6�   �� 5/      -   5        $��paste_button��5/      $��4��6-   $��Paste��6=   
������ $��21��6f   $��Bottom=�6r   6�   �� 50      -   5        $��select_all_button��50      $��5��62   $��
Select All��6B   
������ 6p   51      53      �� 55   
   -	   5        $��rich_textbox��55      $��1��6P   6_   57      58      