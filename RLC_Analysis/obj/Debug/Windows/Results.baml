   M S B A M L   `   `   `  ����^  ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration  5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	   m iSystem.Windows.Forms.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�mclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization/System.Windows.Forms.DataVisualization.Charting 5   	    RLC_Analysis"   RLC_Analysis.Windows.Results   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _wfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   }dvcmclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization     5   	     � Title$  Результаты��5
   	   $	��450��6   $��601.341��6)    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6(   .��5      ]� .+�5   
   c� $	��Top=�6   .@�5      �� $
��Open��6   .��6$   Главное меню62   5      �� 5   
   $	��Top=�6   .@�5      �� -   5         ��Name$
 Main��5      ��5      �� 5      $��2q�6    $��14(�6+   $��Comic Sans MS)�69   $
��Bold"�6T   Характеристики6w   ��5      � 5      $��
0,0,4,-0.4q�6   .+�5      �� $��Токи в ветвях��6#   $
��Left=�6:   $	��129��6U   $��
10,182,0,0q�6b   $	��Top=�6v   $	��566��6�   $��Comic Sans MS)�6�   $
��Bold"�6�   $��14(�6�   .��5      �� .+�5   "   �� -   5         ��Name$ 
Amperage_1��5   ,   $
��Left=�6@   $��	10,10,0,0q�6[   $
��Wrap=�6n   $��I1 = ��6�   $	��Top=�6�   $	��519��6�   �� 5   "   -   5        $ 
Amperage_2��5   ,   $
��Left=�6@   $��	10,10,0,0q�6[   $
��Wrap=�6n   $��I2 = ��6�   $	��Top=�6�   $	��519��6�   �� 5   "   -   5        $ 
Amperage_3��5   ,   $
��Left=�6@   $��	10,10,0,0q�6[   $
��Wrap=�6n   $��I3 = ��6�   $	��Top=�6�   $	��519��6�   5       5!      �� 5"      $;��5Эквивалентные сопротивления��6#   $
��Left=�6H   $	��129��6c   $��	10,10,0,0q�6p   $	��Top=�6�   $	��566��6�   $��Comic Sans MS)�6�   $
��Bold"�6�   $��14(�6�   .��5#      �� .+�5$   "   �� -   5        $ Resistanse_1��5$   ,   $
��Left=�6B   $��	10,10,0,0q�6]   $
��Wrap=�6p   $��Z1 = ��6�   $	��Top=�6�   $	��519��6�   �� 5%   "   -   5        $ Resistanse_2��5%   ,   $
��Left=�6B   $��	10,10,0,0q�6]   $
��Wrap=�6p   $��Z2 = ��6�   $	��Top=�6�   $	��519��6�   �� 5&   "   -   5        $ Resistanse_3��5&   ,   $
��Left=�6B   $��	10,10,0,0q�6]   $
��Wrap=�6p   $��Z3 = ��6�   $	��Top=�6�   $	��519��6�   5'      5(      5*      5,      �� 5-      -	   5        $
 Plot��5-      ��5.      �� 5/      $��2q�6    $��14(�6+   $��Comic Sans MS)�69   $
��Bold"�6T   График6o   ��51      ]� 52      .+�53      �� $	��Top=�6#   $"��Характеристика��68   $��Comic Sans MS)�6P   $��70��6k   $	��300��6w   $
��Bold"�6�   .��54      �� .+�55   "   	� -
   5        $��I1_radio��55   .    	� 	GroupName$ Amperage��6>   $��I1��6k   	� 56   "   -   5        $��I2_radio��56   .   $ Amperage��6>   $��I2��6k   	� 57   "   -   5        $��I3_radio��57   .   $ Amperage��6>   $��I3��6k   58      59      7   1System.Windows.Forms.Integration.WindowsFormsHost  5:      $	��400��6+   $	��283��67   $��Bottom=�6D   $
��Left=�6_   $��
0,0,0,-0.4q�6u      Child. 5;      ;  5System.Windows.Forms.DataVisualization.Charting.Chart  -   5        	chart��5;   (   5<      �� 5=      $��Right=�6#   $	��190��6:   $	��170��6G   $/��)Параметры отображения��6S   $��Comic Sans MS)�6r   $
��Bold"�6�   .��5>      �� .+�5?   "   �� -   5         ��Name$ startTime_label��5?   (   $#��Начальное время��6A   �� 5@   "   -   5         ��Name$ 	startTime��5@   *   $��25��6=   �� 5A   "   -   5        $ endTime_label��5A   (   $!��Конечное время��6?   �� 5B   "   -   5        $ endTime��5B   *   $��25��6;   �� 5C   "   -   5        $ 
step_label��5C   (   $��Шаг��6<   �� 5D   "   -   5        $
 step��5D   *   $��25��68   5E      5F      5G      5I      5J      5L      5N      