   M S B A M L   `   `   `  ????J  FShutdownManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShutdownManagerShutdownManager  5   	        ShutdownManager.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ShutdownManager     5   	     ? Title$  Shutdown Manager??5   	   $	??260??6"   $	??360??6/   .??5
      ? $??10q?6    ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      $
??Auto ?6    ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??0??6"   $??5,0,0,0q?62   .+?5      ?? $0??*Show/hide 'Shut down' option in Start menu??6   $
??Left=?6I   $??0,5,0,0q?6d   $	??Top=?6u   ?? 5      -   5         ??Name$ btnEnableShutdown??5      $
??Left=?60   $??0,5,0,0q?6K   $??80??6   .??6?   Show6?   ?? 5      -   5        $ btnDisableShutdown??5      $
??Left=?61   $??0,5,0,0q?6L   $??80??6?   .??6?   Hide6?   5      ?? 5   
   $??1??6   $??0??6"   $??5,0,0,0q?62   .+?5      ?? $??Shut down this machine??6   $
??Left=?65   $??0,5,0,0q?6P   $	??Top=?6a   ?? 5      -   5        $ btnPerformShutdown??5      $
??Left=?61   $??0,5,0,0q?6L   $??80??6?   .??6?   	Shut down6?   5      5      5       