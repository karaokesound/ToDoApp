   M S B A M L   `   `   `  ????B  >ToDoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ToDoApp.ViewsToDoApp.Views  5      7 clr-namespace:ToDoApp.ComponentsToDoApp.Components  5      *    $ToDoApp.Views.FinishedTasksPanelView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:ToDoApp.Views     5      7
components clr-namespace:ToDoApp.Components     5      .??5
      ?   ? RowDefinitions  5   
   ?? 5      $??0.066* ?6   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??3??6    ?? CornerRadius$ 5??5      $??1q?5       J? Opacity$ 60Q?5      ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #000742??6#    ? Offset$	 0.0Q?63   ? 5      $ #4f003f??6#   $
 0.52Q?63   ? 5      $ #570006 ??6#   $	 1.1Q?64   5      ??5      ?? 5      $	 0,0&?6&   $	 1,1&?67   .??5      ? $ 
  #7f7f7f ??6#   $
 0.25Q?66   5       5"      ?? 5%   
   ???#050824$ 5??5&      $??1q?5'      ._?5(      ?? $??Finished Tasks??6   
???????$
??Left=?5*      $??Center=?5+      $??10,0,0,0q?5,      5-      ?? 5/   
   $??NOTHING'S HERE??6   $??30(?50      $??Center=?51      $??Center=?52      
???????$??1??54      ?? 57   
   ??6   ?? *PassedTasksList+??58      ?? 59      .R?5:      )   #ToDoApp.Components.FinishedTaskList  5;      5=      ?? 5@   
   $??3??6    ?? Orientation$ 
Horizontal=?5A      $??Center=?5B      $	??0,2q?5C      .+?5D      ?? $??	Main Menu??6      NavigationBarButton#??[  5F      $	??200??5G      $??25??5H      ??5E      ?? * NavigateNavigationPanelCommand+5H      ?? 5I      $??Profile??6   #??[  5K      $	??148??5L      $??25??5M      ??5J      ?? *NavigateProfilePanelCommand+5M      ?? 5N      $??My Tasks??6   #??[  5P      $	??148??5Q      $??25??5R      ??5O      ?? *$"NavigateTaskOperationsPanelCommand+5R      5S      5T      5U      