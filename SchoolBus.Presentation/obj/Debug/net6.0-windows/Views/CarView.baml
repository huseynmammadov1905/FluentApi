   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5      U/clr-namespace:SchoolBus.Presentation.ViewModels!SchoolBus.Presentation.ViewModels  6G   *    $SchoolBus.Presentation.Views.CarView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:SchoolBus.Presentation.Views     5      F
viewmodels/clr-namespace:SchoolBus.Presentation.ViewModels     6G   .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��0.3* �6   �� 5      .+�5   
   �� $��50(�6   $��Elephant)�6   $��Center=�64   .��6Q   Cars6W   �� 5   
   $��Add Car��5      $��40q�5      $	��200��5      $��40��5      
��� ���
���   �$��Elephant)�5   U   ��6   �� *CarAddCommand+6U   �� 5   
   -   5         ��Name$ LV��5      $��1��6   $��Elephant)�6I   $��20(�6_   $
��Left=�6m   ��6,   �� *Cars+ �� SelectedValue 6�   �� *	SelectCar+ �� View 5      �� 5      P�5      �� 5      $��Id��6)    �� DisplayMemberBinding 66   �� *Id+�� 5      $��Vendor��6)    6:   �� *Name+�� 5      $��Number��6)    6:   �� *	CarNumber+�� 5      $��
Seat Count��6)    6>   �� *	SeatCount+�� 5        �� CellTemplate 5!      �� 5"   "   .R�5#   &   �� $��Edit Car��5%   %   $��40q�5&   %   $	��100��5'   %   
��� ���
���   �$��Elephant)�5(   �   ��6&   �� *DataContext.CarEditCommand+ �� ElementName$ LV��6�   5)   #   5+      51      ��54      �� 55       �� 
TargetType" ��6   .�56      ��  �� Property � ��	 �� Value$	 Center=�6C   �� 57       � ��$	 Center=�6C   58      5:      5;      5<      