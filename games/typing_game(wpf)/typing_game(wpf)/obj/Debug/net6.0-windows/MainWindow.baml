   M S B A M L   `   `   `  ����K  Gtyping_game(wpf), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:typing_game_wpf_typing_game_wpf_  5   	   !    typing_game_wpf_.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:typing_game_wpf_     5   	   -   5          � Title$  
MainWindow��5   	   $	��300��6   $	��500��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��117* �6   �� 5      $	��25* �6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5        $��TextBlockTextToType��5      $��20(�6/   
�������$��Center=�6O   $��Center=�6l   $��WrapWithOverflow=�6�   �� 5   
   -   5        $��TextBoxUserInput��5      $��1��6*   $��20��67   $	��300��6C   $��Center=�6O   6�   �� 5   
   -   5        $��ButtonStart��5      $��Start��6$   $��1��64   $��75��6A   $��20��6L   $��Right=�6X   $��10q�6t   6�   �� 5   
   -   5        $��TextBoxAmountOfWords��5      $��1��6.   $��75��6<   $��20��6G   $
��Left=�6S   $��10q�6n   5      5      