   M S B A M L   `   `   `  ����G  CRLC_Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RLC_Analysis.WindowsRLC_Analysis.Windows  5   	   '    !RLC_Analysis.Windows.MathModeling   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:RLC_Analysis.Windows     5   	     � Title$  MathModeling��5   	   $	��450��6   $��924.024��6+    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$
 Open��5
      6(     5   
   -   5        $
 Save��5      6(   .��5      ]� .+�5   
   c� $	��Top=�6   .@�5      �� $
��Open��6   .��6$   Главное меню62   �� 5      $
��Save��6   .��6$   Рассчитать60   5      �� 5   
   ���	#FF199CD6$��1q�6)   ._�5      a� $
��Left=�6   $	��101��61   $��0,0.2q�6=   .+�5      �� ���	#FF199CD6���	#FF199CD6$��2q�6H   $
��Left=�6\   $��20��6w   $	��100��6�   $��0,0,0,0q�6�   ._�5      d� ���	#FF199CD6.��6:   
Elements6D   5      �� 5      -   5         ��Name$ resistor��5      $��60��6*   $��40��66   $��/images/resistor.png��6A   $��-30,0,-19.2,10q�6z   6�   �� 5      -   5        $ inductor��5      $��60��6*   $��40��66   $��/images/inductor.png��6A   $��25,0,35.8,10q�6z   �� 5      -   5        $ 	capacitor��5      $��60��6+   $��40��67   $��/images/capacitor.png��6B   $��25,0,35.8,0q�6|    J� RenderTransformOrigin$ 0.953,0.597&�6�   5      5      � 5   
   .+�5      �� 
�������$
��Left=�6%   $��262.173��6@   $��57.493,61.097,0,0q�6Q   
���   �$	��Top=�6{   $��701.739��6�   A� 5      ���	#FFF4F4F5$
��Left=�6'   $��64.396��6B   $��25.296,166.895,0,0q�6R   
���   �$	��Top=�6}   $��63.855��6�   $ 0.5,0.5&�6�   z�5      V� 5       .~�5!      �� �� 5"      �� 5#       �� Angle$ 179.799Q�6*   T� 5$      5%      5'      F� 5(      ���� u@(�р�@(�	���	#FFF4F4F5$
��Left=�6;   $��1��6V   $��
52,217,0,0q�6a    �� Stretch$
 Fill=�6u   
���   �$	��Top=�6�   $��11��6�   F� 5)      ���� u��
��M���
	���	#FFF4F4F5$
��Left=�6;   $��1��6V   $��
52,182,0,0q�6a   $
 Fill=�6u   
���   �$	��Top=�6�   $��12��6�   F� 5*      ����@�e@Ό
�@�e �4	���	#FFF4F4F5$
��Left=�6;   $��12��6V   $��
57,177,0,0q�6b   $
 Fill=�6v   
���   �$	��Top=�6�   $��1��6�   F� 5+      ����@�e@Ό
�@�e �4	���	#FFF4F4F5$
��Left=�6;   $��262.173��6V   $��286.537,61.097,0,0q�6g   $
 Fill=�6�   
���   �$	��Top=�6�   $��1��6�   F� 5,      ����@�e@Ό
�@�e �4	���	#FFF4F4F5$
��Left=�6;   $��262.173��6V   $��520.015,61.097,0,0q�6g   $
 Fill=�6�   
���   �$	��Top=�6�   $��1��6�   F� 5-      ����@�e@Ό
�@�e �4	���	#FFF4F4F5$
��Left=�6;   $��24.782��6V   $��519.882,323.27,0,0q�6f   $
 Fill=�6�   
���   �$	��Top=�6�   $��1.133��6�   $ 0.5,0.5&�6�   z�5.      V� 5/      .~�50      ��  �� ScaleX$ -1Q�6)   �� 51      �� 52      T� 53      54      56      F� 57      ����@�e@Ό
�@�e �4	���	#FFF4F4F5$
��Left=�6;   $��24.782��6V   $��520.03,335.191,0,0q�6f   $
 Fill=�6�   
���   �$	��Top=�6�   $��1��6�   $ 0.5,0.5&�6�   z�58      V� 59      .~�5:      �� �� 5;      �� 5<      $	 -90Q�6*   T� 5=      5>      5@      �� 5A      -   5        $ internal��5A      $
��Left=�6&   $��40��6A   $	��Top=�6M   $��60��6e   $��
132,47,0,0q�6p   $��/images/resistor.png��6�    J� 	AllowDrop .  6�   �� 5B      -   5        $ first��5B      $
��Left=�6#   $��40��6>   $	��Top=�6J   $��60��6b   $��
380,47,0,0q�6m   $/��)/RLC_Analysis;component/images/Empty2.png��6�    . 6�   �� 5C      -   5        $ second��5C      $
��Left=�6$   $��40��6?   $	��Top=�6K   $��60��6c   $��
617,47,0,0q�6n   $/��)/RLC_Analysis;component/images/Empty2.png��6�    . 6�   �� 5D      -	   5        $ third��5D      $
��Left=�6#   $��40��6>   $	��Top=�6J   $��60��6b   $��258,177,0,0q�6m   $/��)/RLC_Analysis;component/images/Empty2.png��6�    . 6�   �� 5E      -
   5        $ forth��5E      $
��Left=�6#   $��40��6>   $	��Top=�6J   $��60��6b   $��491,183,0,0q�6m   $/��)/RLC_Analysis;component/images/Empty2.png��6�    . 6�   �� 5F      -   5        $ fifth��5F      $
��Left=�6#   $��40��6>   $	��Top=�6J   $��60��6b   $��730,182,0,0q�6m   $/��)/RLC_Analysis;component/images/Empty2.png��6�    . 6�   �� 5G      $
��Left=�6   $��
152,74,0,0q�63   $
��Wrap=�6G   $	��Top=�6[   �� 5H      .�6   Y6    �� 5I      	 K� Variants$	 	Subscript=�6   .�66   вн6:   5J      �� 5K      -   5        
 ��Name$
 first_lb��5K      $�� ��6&   $
��Left=�61   $��
391,84,0,0q�6L   $	��Top=�6`   �� 5L      -   5        $
 	second_lb��5L      $�� ��6'   $
��Left=�62   $��
643,84,0,0q�6M   $	��Top=�6a   �� 5M      -   5        $
 fifth_lb��5M      $�� ��6&   $
��Left=�61   $��719,191,0,0q�6L   $	��Top=�6a   �� 5N      -   5        $
 forth_lb��5N      $�� ��6&   $
��Left=�61   $��475,191,0,0q�6L   $	��Top=�6a   �� 5O      -   5        $
 third_lb��5O      $�� ��6&   $
��Left=�61   $��242,191,0,0q�6L   $	��Top=�6a   �� 5P      $
��Left=�6   $��
93,191,0,0q�63   $
��Wrap=�6G   $	��Top=�6[   $��17��6s   $��11��6   �� 5Q      $�E��6   �� 6!   $� ��6%   5R      5S      5T      5U      