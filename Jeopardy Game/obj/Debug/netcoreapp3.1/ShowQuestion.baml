   M S B A M L   `   `   `  ????H  DJeopardy Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Jeopardy_GameJeopardy_Game  5   	        Jeopardy_Game.ShowQuestion   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Jeopardy_Game     5   	   -   5           
strAppName  ? Title#  [  5   	   $	??450??6-   $	??800??6:     	MainColor#??[ 5	   	   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6    ? RowDefinitions 5   
   ?? 5      $??2* ?6   ?? 5      $??2* ?6   ?? 5      $??1* ?6   ?? 5      $??2* ?6   ?? 5      $??1* ?6   .+?5   
   ??   Headers#??[ 6   $??0??65   $??1??6B   $??2??6R   $??Question??6f   $??30(?6v   $??Center=?6?   $??5q?6?   6?   ?? 5   
   -   5         ??Name$ txtQuestion??5      $??1??6)   $??0??66   $??4??6F   $??WrapWithOverflow=?6Z   $??theQuestion??6z   $??22(?6?   $??Center=?6?   $??Center=?6?   $??	20 0 20 0q?6?   6?   ? 5   
   $??2??6   $??0??6!   $??2??61   $??Center=?6E   $??Center=?6b   .+?5      ?? -   5        $ team1??5      $??Team1??6'   $??25(?64   $??Center=?6B   $??Center=?6_   6|   ?? 5       -   5        $ 
scoreTeam1??5       $	??100??6,   $??20(?67   $??20 0 0 0q?6E   $??Center=?6W   $??Center=?6t   6?   5"      ? 5#   
   $??2??6   $??2??6!   $??2??61   $??Center=?6E   $??Center=?6b   .+?5$      ?? -   5        $ team2??5$      $??Team2??6'   $??25(?64   $??Center=?6B   $??Center=?6_   6}   ?? 5%      -   5        $ 
scoreTeam2??5%      $	??100??6,   $??20(?67   $??20 0 0 0q?6E   $??Center=?6W   $??Center=?6t   6?   5&      ?? 5)   
   -   5         ??Name$ txtteam1Right??5)      $??Right??6(   $??15(?6R   $??0??6`   $??3??6p   $??50??6}   $??30??6?   $??Right=?6?   $	??Top=?6?   $??0 0 5 0q?6?   6?   ?? 5*   
   -   5        $ txtteam1Wrong??5*      $??Wrong??6(   $??15(?6R   $??1??6`   $??3??6p   $??50??6}   $??30??6?   $
??Left=?6?   $	??Top=?6?   $??5 0 0 0q?6?   6?   ?? 5+   
   -	   5        $ txtteam2Right??5+      $??Right??6(   $??15(?6R   $??2??6`   $??3??6p   $??50??6}   $??30??6?   $??Right=?6?   $	??Top=?6?   $??0 0 5 0q?6?   6?   ?? 5,   
   -
   5        $ txtteam2Wrong??5,      $??Wrong??6(   $??15(?6R   $??3??6`   $??3??6p   $??50??6}   $??30??6?   $
??Left=?6?   $	??Top=?6?   $??5 0 0 0q?6?   6?   ?? 5.   
   -   5        $ seeAnswerBtn??5.      $??
See Answer??6B   $??25(?6W   $??1??6e   $??4??6u   $	??150??6?   $??40??6?   $??Center=?6?   $??Center=?6?   ?? 5/   
   -   5        $ doneBtn??5/      $
??Done??68   $??25(?6G   $??2??6U   $??4??6e   $	??150??6r   $??40??6~   $??Center=?6?   $??Center=?6?   51      52      