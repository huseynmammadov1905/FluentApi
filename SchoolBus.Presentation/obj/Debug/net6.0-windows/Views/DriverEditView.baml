   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5   	   U/clr-namespace:SchoolBus.Presentation.ViewModels!SchoolBus.Presentation.ViewModels  6B   1    +SchoolBus.Presentation.Views.DriverEditView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SchoolBus.Presentation.Views     5   	   F
viewmodels/clr-namespace:SchoolBus.Presentation.ViewModels     6B     � Title$  DriverEditView��5   	   $	��450��6    $	��800��6-   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Edit Driver��6   $��Elephant)�6&   $��50(�6<   $��Center=�6J   �� 5   
   $��1��6   $��20(�6   $��Center=�6+   $��Elephant)�6H   .��6^   	FirstName6i   �� 5   
   $��1��6D   $��Center=�6Q   $��Bottom=�6n   $	��400��6�   ��6   �� *EditDriver.FirstName+ �� Mode$ TwoWay=�6�   �� 5   
   $��2��6   $��20(�6   $��Center=�6+   $��Elephant)�6H   .��6^   
LastName6h   �� 5   
   $��2��6D   $��Center=�6Q   $��Bottom=�6n   $	��400��6�   ��6   �� *EditDriver.LastName+$ TwoWay=�6�   �� 5   
   $��3��6   $��20(�6   $��Center=�6+   $��Elephant)�6H   .��6^   Adress6f   �� 5   
   $��3��6A   $��Center=�6N   $��Bottom=�6k   $	��400��6�   ��6   �� *EditDriver.Adress+$ TwoWay=�6�   �� 5   
   $��4��6   $��20(�6   $��Center=�6+   $��Elephant)�6H   .��6^   Phone Number6l   �� 5    
   $��4��6F   $��Center=�6S   $��Bottom=�6p   $	��400��6�   ��6   �� *EditDriver.PhoneNumber+$ TwoWay=�6�   �� 5$   
   $��5��6   $��20(�6   $��Center=�6+   $��Elephant)�6H   .��6^   
Car Name6h   �� 5%   
   $��5��6   $��Center=�6a   $	��400��6|   ��6    �� *Cars+ �� SelectedItem 6=   �� *
_SelectCar+6�   �� 5'   
   $��6��6   $��Edit Driver��5(      $	��200��5)   	   
��� ���
���   �$	��2,0q�5,      {�5-      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window��6z   �� *CarEditCommand+5.      5/      