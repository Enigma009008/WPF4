   M S B A M L   `   `   `  ����J  FAcademy_Fitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Academy_FitnessAcademy_Fitness  5   	   .    (Academy_Fitness.WindowCourseRegistration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Academy_Fitness     5   	     � Title$,  &Регистрация на курсы��5      $	��450��6$   $	��800��61    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Right=�64   6D   �� 5       � ��$ Center=�62   6C   5      5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $��70 �6   6*   .+�5   
   A�  A� Columns$ 2��6   .+�5      �� 	Trainer6!   �� 5      -   5        $��
CmbTrainer��5       �� DisplayMemberPath$
 Name��6J    �� SelectedItem 6)   �� *	Trainer+6e   �� 5      Course6    �� 5      -   5        $��	CmbCourse��5      $ Title��6H    6(   �� *Course+6d   �� 5      Create Date6%   (  "System.Windows.Controls.DatePicker  5      	   SelectedDate	 6   �� *CreatedDate+6@   �� 5      $�� ��6   	Is Done6)   �� 5      
 d� 	IsChecked
 6   �� *IsDoneString+.��6:   Done6@   �� 5       Total Points6&   �� 5!      -   5        $��TxtTotalPoint��5!   2   ��6   �� *
TotalPoint+6I   �� 5"      	Comment6!   �� 5#       �� 	MaxLength$	 100��6/   ��6   �� *	Comment+6A   5$      �� 5'   
   -   5         ��Name$ BtnSave��5'      $��1��6"   $
��Save��6/   6>   5)      5*      