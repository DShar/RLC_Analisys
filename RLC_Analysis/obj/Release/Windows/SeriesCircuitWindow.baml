   M S B A M L   `   `   `  ���� G  CRLC_Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RLC_Analysis.WindowsRLC_Analysis.Windows  .    (RLC_Analysis.Windows.SeriesCircuitWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:RLC_Analysis.Windows       � Title$  ParallelCircuitWindow��$	��450��$	��800��$	��450��$	��800��$	��450��$	��800�� � 
ResizeMode$ NoResize=� J� CommandBindings )  #System.Windows.Input.CommandBinding     Command$
 Open��  $
 Save��.��]� .+�c� $	��Top=�.@��� $
��Open��.��Open�� -   $��
SaveButton��$
��Save��.��Save�� ���	#FF199CD6$��1q�._�a� $
��Left=�$	��101��$��0,0.2q�.+��� ���	#FF199CD6���	#FF199CD6$��2q�$
��Left=�$��20��$	��100��$��0,0,0,0q�._�d� ���	#FF199CD6.��
Elements�� -    ��Name$ resistor��$��60��$��40��$��/images/resistor2.png��$��-30,0,-19.2,10q��� -   $ inductor��$��60��$��40��$��/images/inductor2.png��$��25,0,35.8,10q��� -   $ 	capacitor��$��60��$��40��$��/images/capacitor2.png��$��25,0,35.8,0q� J� RenderTransformOrigin$ 0.953,0.597&�� .+�F� ����@t*@
�@t*�S)	���	#FFF4F4F5$
��Left=�$	��116��$��137,53.04,0,0q� �� Stretch$
 Fill=�
���   �$	��Top=�$��1��F� ����@t*�S)���}�S)	���	#FFF4F4F5$
��Left=�$��1��$��137,53.04,0,0q�$
 Fill=�
���   �$	��Top=�$��227.467��F� ����@���S)�@� ��8	���	#FFF4F4F5$
��Left=�$��2��$��358,53.04,0,0q�$
 Fill=�
���   �$	��Top=�$	��180��F� ���Ѐ: ��8р: �X
	���	#FFF4F4F5$
��Left=�$	��116��$��538,54.04,0,0q�$
 Fill=�
���   �$	��Top=�$��1��F� ���Ѐ: ���р: ��
	���	#FFF4F4F5$
��Left=�$��98.04��$��538,230,0,0q�$
 Fill=�
���   �$	��Top=�$��1��F� ����@t*���р�9@~�	���	#FFF4F4F5$
��Left=�$	��103��$��137,228.04,0,0q�$
 Fill=�
���   �$	��Top=�$��2��F� �����|  @~��@����	���	#FFF4F4F5$
��Left=�$��3��$��137,328.04,0,0q�$
 Fill=�
���   �$	��Top=�$	��403��A� -    A�Name$ voltage�����	#FFF4F4F5$
��Left=�$��59��$��107,169.04,0,0q�
���   �$	��Top=�$��60��F� ���� )� ��
р�v ��
	���	#FFF4F4F5$
��Left=�$��1��$��132,183.04,0,0q�$
 Fill=�
���   �$	��Top=�$��11��F� ����@t*���
�@t*@C5	���	#FFF4F4F5$
��Left=�$��11��$��137,178.04,0,0q�$
 Fill=�
���   �$	��Top=�$��1��F� ���� )���р�v��	���	#FFF4F4F5$
��Left=�$��1��$��132,218.04,0,0q�$
 Fill=�
���   �$	��Top=�$��11���� -   $ first��$
��Left=�$��60��$��
369,37,0,0q�$	��Top=�$��40��$��/images/Empty.png�� J� 	AllowDrop . �� -   $ third��$
��Left=�$��60��$��358,314,0,0q�$	��Top=�$��40��$��/images/Empty.png�� . �� -   $ second��$
��Left=�$��60��$��523,170,0,0q�$	��Top=�$��40��$��/images/Empty.png�� . �� -	   	 ��Name$	 
firstLabel��$�� ��$
��Left=�$��
322,81,0,0q�$	��Top=��� -
   $	 secondLabel��$�� ��$
��Left=�$��563,183,0,0q�$	��Top=��� -   $	 
thirdLabel��$�� ��$
��Left=�$��304,277,0,0q�$	��Top=�