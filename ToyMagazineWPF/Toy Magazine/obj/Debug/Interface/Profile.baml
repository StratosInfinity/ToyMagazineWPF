   M S B A M L   `   `   `  ????G  CToy Magazine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Toy_MagazineToy_Magazine  5   	       Toy_Magazine.Profile   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Toy_Magazine     5   	   -   5          ? Title$  Profile??5   	   $	??350??6   $	??800??6&    ? 
ResizeMode$ NoResize=?5	   	   ???#faf0e6 ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      $??2* ?6    ? RowDefinitions 5   
   ?? 5      $??3* ?6   ?? 5      .+?5   
   ?? $??20,5,0,0q?6   $??0??6'   .+?5      ?? $%??Имя пользователя??6   ?? 5      $??Баланс (Руб)??6   ?? 5      $.??(Пополнить баланс (Руб)??6   5      ?? 5   
   $??1??6   .+?5      ?? -   5         ??Name$ 	userlogin??5      $??0,5,0,10q?6*    ?? 
IsReadOnly . 6N   ?? 5      -   5        $ 
BalanceBox??5      $??0,0,0,10q?6*   $??0??6<    . 6W   ?? 5       -   5        $ uppBalanceBox??5       $??0,0,0,10q?6-   $??0??6?   ?? 5!      -   5         ??Name$ 	UpBalance??5!         BaseButtonStyle#??[  6(   $%??Пополнить баланс??6S   6n   5"      ?? 5#   
   $??2??6   $	??200??6    $	??200??6,   $??Center=?69   $??Center=?6V   $??/Resources/User.jpg??6q   ?? 5%   
   $??3??6    ?? Orientation$ 
Horizontal=?6)   $??1??6B   .+?5&      ?? -   5        $ 
GoCataloge??5&   >   #??[  6   $??
30,0,90,30q?6R   $??Bottom=?6f   $??Каталог??6?   6?   ?? 5'      -   5        $ GoBusket??5'   >   #??[  6   $??
30,0,90,30q?6P   $??Bottom=?6d   $??Корзина??6   6?   ?? 5(      -   5        $
 Exit??5(   >   #??[  6   $??
30,0,50,30q?6M   $??Bottom=?6a   $??
Выход??6|   6?   5)      5*      5,      