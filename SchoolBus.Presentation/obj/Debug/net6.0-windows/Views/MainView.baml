   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5   	   U/clr-namespace:SchoolBus.Presentation.ViewModels!SchoolBus.Presentation.ViewModels  6B   +    %SchoolBus.Presentation.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SchoolBus.Presentation.Views     5   	   F
viewmodels/clr-namespace:SchoolBus.Presentation.ViewModels     6B     � Title$  MainView��5   	   $	��450��6   $	��800��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $��6* �6   6,   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6"   .+�5      �� $��Create Ride��5      $��40q�5      
��� ���
���   �$��Elephant)�5   ]   ��6   �� *CreateRideViewCommand+6]   �� 5      $��Rides��5      $��40q�5      
��� ���
���   �$��Elephant)�5   X   ��6   �� *RideViewCommand+6X   �� 5      $��Class��5"      $��40q�5#      
��� ���
���   �$��Elephant)�5$   X   ��6   �� *ClassViewCommand+6X   �� 5'      $��Student��5)      $��40q�5*      
���2͚�
���   �$��Elephant)�5+   a   ��6   �� *StudentViewCommand+6a   �� 5.      $��Parent��51      $��40q�52      
�������
���   �$��Elephant)�53   g   ��6   �� *ParentViewCommand+6g   �� 55      $��Driver��56      $��40q�57      
�������
���   �$��Elephant)�58   _   ��6   �� *DriverViewCommand+6_   �� 5:      $	��Car��5=      $��40q�5>      
�������
���   �$��Elephant)�5?   e   ��6   �� *CarViewCommand+6e   5@      �� 5B   
   $��1��6   ��6)   �� *CurrentViewModel+6P   5C      5D      