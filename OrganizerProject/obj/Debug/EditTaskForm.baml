   M S B A M L   `   `   `  ����K  GOrganizerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OrganizerProjectOrganizerProject  5   	   #    OrganizerProject.EditTaskForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OrganizerProject     5   	     � Title$  EditTaskForm��5   	   $	��550��6   $	��550��6+   .��5	      �� ��5
   
   �� 5       �� ImageSource$A ;C:\Users\megas\source\repos\OrganizerProject\img\space3.jpg��6   .+�5   
   �� -   5         ��Name$ cbFinish��5      $��Finish Task��6%   $��5q�6;   $��20(�6F   
�������$	��Rod)�6l   5      � 5   
   $��5q�6   .+�5      �� $��Title��6   $��5,5,10,5q�6$   $��20(�66   
�������$	��Rod)�6\   6o   �� 5      -   5         ��Name$ txtTitle��5      $	��200��6(   66   �� 5      -   5        $ txtId��5      $	��200��6%   $y�Hidden=�61   6G   5      � 5   
   $��5q�6   .+�5      �� $��Start:��6   $��5,5,10,5q�6%   $��20(�67   
�������$	��Rod)�6]   6p   (  "System.Windows.Controls.DatePicker  5      -   5        $��dpStart��5      6*   �� 5      $
��End:��6   $��	50,5,10,5q�6#   $��20(�66   
�������$	��Rod)�6\   6o     5      -   5        $��dpEnd��5      6(   5      � 5   
   $��5q�6   5      � 5   
   $��5q�6   .+�5      �� $��Description��6   $��5,5,10,5q�6*   $��20(�6<   
�������$	��Rod)�6b   6u   �� 5       -   5        $ txtDescription��5       $	��200��6.   6<   5!      � 5"   
   $��5q�6   .+�5#      �� $��Location��6   $��5,5,10,5q�6'   $��20(�69   
�������$	��Rod)�6_   6r   �� 5$      -   5        $ txtLocation��5$      $	��200��6+   69   5%      � 5&   
   .+�5'      �� -   5         ��Name$ btnEditTask��5'      $��Save Changes��6*   $	��160��6A   $
��Left=�6M   $��20,5,5,0q�6h   $��5q�5(      $��20(�6!   
�������$	��Rod)�6G   ��5)      �� 5*       �� 
StartPoint$ 0.5,0&�6*    �� EndPoint$ 0.5,1&�6=   .��5+      �  � Color$ Green��6'    � Offset$
 0.25Q�65   � 5,      $ White��6'   $ 0Q�65   5-      5/      �� 50      -	   5        $ btnDeleteTask��50      $��Delete Task��6,   $	��160��6B   $
��Left=�6N   $��20,5,5,0q�6i   $��5q�51      $��20(�6!   
�������$	��Rod)�6G   ��52      �� 53      $ 0.5,0&�6*   $ 0.5,1&�6=   .��54      � $	 Red��6'   $
 0.25Q�63   � 55      $ White��6'   $ 0Q�65   56      58      59      5;      5<      