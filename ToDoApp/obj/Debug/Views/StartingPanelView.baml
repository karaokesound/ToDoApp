   M S B A M L   `   `   `  ????B  >ToDoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ToDoApp.ViewsToDoApp.Views  5      %    ToDoApp.Views.StartingPanelView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:ToDoApp.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $??0.18* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??4??6    ?? CornerRadius$ 5??5      $??1q?5       J? Opacity$ 60Q?5      ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #000742??6#    ? Offset$	 0.0Q?63   ? 5      $ #4f003f??6#   $
 0.52Q?63   ? 5      $ #570006 ??6#   $	 1.1Q?64   5      ??5      ?? 5      $	 0,0&?6&   $	 1,1&?67   .??5      ? $ 
  #7f7f7f ??6#   $
 0.25Q?66   5       5"      ?? 5%   
   ???#050824$ 5??5&      $??1q?5'      $ 50Q?5(      ._?5)      ?? $??To-do Application??6   
???????$
??Left=?5+      $??Center=?5,      $??10,0,0,0q?5-      5.      ?? 51   
   $??2??6   $??Center=?52      $??Center=?53      .+?54      ?? 
?????? $??1,1,1,3q?55      $	??250??56      $??30??57      $??15(?58      $??0,0,0,4q?59      
?????????5;      ?? *
UserName+ ?? ValidatesOnDataErrors .  ?? UpdateSourceTrigger$ PropertyChanged=?	 ? ToolTip	 5<      ?? *ErrorCollection[UserName]+.??6D   5=      ?? 5>      $??username??6   
???????$??0,0,0,20q?5@      $??14(?5A      G? 5C      
?????? $??1,1,1,3q?5D      $??0,0,0,4q?5E      $??15(?5F      $??30??5G      
???????5H   /   ?? 5K      $??password??6   
???????$??0,0,0,10q?5M      $??14(?5N      5O      ?? 5R   
   $??3??6   $??Center=?5S      
 ?? Orientation$
 
Horizontal=?5T      $??0,0,0,50q?5U      .+?5V      ?? $??SIGN IN??6      StartingPanelButton#??[  5X      $??Right=?5Y      $??0,0,15,0q?5Z      ??5W      ?? * NavigateNavigationPanelCommand+5Z      ?? 5\      $??SIGN UP??6   #??[  5]      $??1??5^      $
??Left=?5_      $??15,0,0,0q?5`      5a      5b      5c      