   M S B A M L   `   `   `  ????J  FShutdownManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShutdownManagerShutdownManager  5      %    ShutdownManager.ConfirmShutdown   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ShutdownManager     5      -   5        $	??260??5      $	??360??6     ? Title$  ConfirmShutdown??5	      .??5      ? $??10q?6    ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      $
??Auto ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??6"   $??5,0,0,0q?62   .+?5      ?? $??WrapWithOverflow=?6   $
??Left=?68   $??0,5,0,0q?6S   ~|To confirm shutdown, type the following code into the input below. This PC will shut down 3 seconds after entering the code.5      ?? 5      -   5        $??lblValidationCode??5      $?? ??6-   $
??Left=?68   $??0,5,0,0q?6S   $
??Bold"?6d   5      ?? 5   
   $??1??6   $??0??6"   $??5,0,0,0q?62   .+?5      ?? $??Enter code:??6   $
??Left=?6*   $??0,5,0,0q?6E   ?? 5       -   5        $??txtBoxConfirmShutdown??5       $
??Left=?63   $	??280??6N   $??0,5,0,0q?6Z    ?? TextWrapping$
 Wrap=?6k   $?? ??6   6?   ?? 5#      -   5        $??lblShuttingDown??5#      $??WrapWithOverflow=?6/   $
??Left=?6O   $??0,5,0,0q?6j   $y?Hidden=?6{   Shutting down...5%      5&      5(      5)      