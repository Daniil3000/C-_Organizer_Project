   M S B A M L   `   `   `  ����K  GOrganizerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OrganizerProjectOrganizerProject  5   	   !    OrganizerProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OrganizerProject     5   	     � Title$  SuperOrganizer��5   	   $	��750��6    $	��550��6-   .��5	      �� ��5
   
   �� 5       �� ImageSource$@ :C:\Users\megas\source\repos\OrganizerProject\img\space.jpg��6   .+�5   
   �� $��Center=�6   $��26(�61    �� Padding$ 	10,0,10,0q�6?   $��0,10,0,0q�6S   
�������$	��Rod)�5   ,   $!��Select a date to add a task��6=   ��5      �� 5       �� 
StartPoint$ 0.5,0&�6&    �� EndPoint$ 0.5,1&�69   .��5      �  � Color$ Black��6+    � Offset$
 0.25Q�69   � 5      $ White��6#   $ 0Q�61   5      5      (� 5   
    (� Stretch$
 Fill=�6    (� StretchDirection$
 Both=�6!   $��
50,10,50,0q�69   .��5      &   System.Windows.Controls.Calendar  -   5        	  Name$	 
myCalendar��5      
   SelectionMode$
 MultipleRange=�6+   5      5      �� 5   
   -   5         ��Name$ tbDate��5      $y�Hidden=�5   3   $��Center=�6G   $��20(�6d   
�������$	��Rod)�5   ,   $ 10q�6=   ��5   $   ��  �� ElementName$ 
myCalendar�� �� Path$ SelectedDate� �� StringFormat$ d�� �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      $ 0.5,0&�6&   $ 0.5,1&�69   .��5       � $ Black��6#   $
 0.25Q�61   � 5!      $ White��6#   $ 0Q�61   5"      5$      �� 5%   
   -   5         ��Name$ btnCreateTask��5%      $��
Add a task��6(   $y�Hidden=�6=   $��50,10q�5&      $��30��6    $��5q�6,   $��20(�68   
�������$	��Rod)�6^   ��5'      �� 5(      $ 0.5,0&�6&   $ 0.5,1&�69   .��5)      � $ Coral��6#   $
 0.25Q�61   � 5*      $ White��6#   $ 0Q�61   5+      5-      � 5.   
   -   5         �Name$ existingTasks��5.      $y�Hidden=�6&    � RowDefinitions 5/      �� 50      6"   �� 51      6"   .+�53      �� $��0��6   $��Center=�6%   $��20(�6B   
�������$	��Rod)�6h   Existing tasks55      &   System.Windows.Controls.DataGrid  56      -   5          Name$ dgTasks��56         AutoGenerateColumns .   � ToolTip$% Doubleclick the task to edit it��57      $��1��6A      
IsReadOnly . $��50,10q�58   U   $��15(�59      
���   �$	��Rod)�68   ��56   (   ��    Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$
 Task��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Title+6S     5=      $ Details��6)    6:   �� *Description+6\     5>      $ Address��6)    6:   �� *
Location+6Y   4  .System.Windows.Controls.DataGridCheckBoxColumn  5?      $ Status��6-    6=   �� *
IsFinished+6^   5A      5B      5C      5D      