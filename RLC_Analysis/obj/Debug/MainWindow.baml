   M S B A M L   `   `   `  ����G  CRLC_Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RLC_AnalysisRLC_Analysis  5   	       RLC_Analysis.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:RLC_Analysis     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ RLC-analysis��5	   	   $��357.6��6   $	��634��6-    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6(     5   
   -   5        $
 Save��5      6(   .��5      ]� .+�5   
   c� $	��Top=�6   .@�5      �� $
��Open��6   .��6$   Open6*   �� 5      -   5        $��
SaveButton��5      $
��Save��6'   .��66   About6=   5      � 5   
   .+�5      �� -   5        $g��a                                 Параллельное соединение элементов��5      $
��Left=�6b   $��
115,33,0,0q�6}   $	��Top=�6�   $	��382��6�   6�   �� 5       -   5        $k��e                             Последовательное соединение элементов��5       $
��Left=�6b   $��
115,73,0,0q�6}   $	��Top=�6�   $	��382��6�   6�   �� 5!      -   5        $^��X                                          Задачи по электротехнике��5!      $
��Left=�6b   $��115,113,0,0q�6}   $	��Top=�6�   $	��382��6�   6�   �� 5"      -   5        $a��[                                      Задачи с логическими схемами��5"      $
��Left=�6b   $��115,153,0,0q�6}   $	��Top=�6�   $	��382��6�   6�   �� 5#      -   5        $g��a                                 Моделирование электрической схемы��5#      $
��Left=�6b   $��115,193,0,0q�6}   $	��Top=�6�   $	��382��6�   6�   �� 5$      -	   5        $m��g                          Математические модели электрических схем��5$      $
��Left=�6b   $��115,233,0,0q�6}   $	��Top=�6�   $	��382��6�   6�   5%      5&      5'      