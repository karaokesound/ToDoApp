   M S B A M L   `   `   `  ????B  >ToDoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ToDoApp.ViewsToDoApp.Views  5      $    ToDoApp.Views.ProfilePanelView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:ToDoApp.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $??0.066* ?6   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??3??6    ?? CornerRadius$ 5??5      $??1q?5       J? Opacity$ 60Q?5      ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #000742??6#    ? Offset$	 0.0Q?63   ? 5      $ #4f003f??6#   $
 0.52Q?63   ? 5      $ #570006 ??6#   $	 1.1Q?64   5      ??5      ?? 5      $	 0,0&?6&   $	 1,1&?67   .??5      ? $ 
  #7f7f7f ??6#   $
 0.25Q?66   5      5!      ?? 5$   
   ???#050824$ 5??5%      $??1q?5&      ._?5'      ?? $??Profile??6   
???????$
??Left=?5)      $??Center=?5*      $??10,0,0,0q?5+      5,      ?? 5/   
   $??1??6   $??20q?50      .+?51      ?? $??Welcome karaokesound??6   
???????$??20(?53      $??Rubik)?54      $??0,0,0,40q?55      ?? 56      $??Your tasks today:??6   
???????$??0,0,0,7q?58      $??15(?59      $??Rubik)?5:      $??
UltraLight"?5;      ?? 5<      $??Finished tasks:??6   
???????$??15(?5>      $??Rubik)?5?      ?? 5@      $??Calendar??6   
???????$??18(?5B      $??0,30,0,0q?5C      $??Rubik)?5D      &   System.Windows.Controls.Calendar  5E      $
??Left=?6   $??10q?5F      
???????5G      5H      ?? 5K   
   $??3??6    ?? Orientation$ 
Horizontal=?5L      $??Center=?5M      $	??0,2q?5N      .+?5O      ?? $??	Main Menu??6      NavigationBarButton#??[  5Q      $	??200??5R      $??25??5S      ??5P      ?? * NavigateNavigationPanelCommand+5S      ?? 5T      $??My Tasks??6   #??[  5V      $	??148??5W      $??25??5X      ??5U      ?? *$"NavigateTaskOperationsPanelCommand+5X      ?? 5Y      $??Finished Tasks??6   #??[  5[      $	??148??5\      $??25??5]      ??5Z      ?? *#!NavigateFinishedTasksPanelCommand+5]      5^      5_      5`      