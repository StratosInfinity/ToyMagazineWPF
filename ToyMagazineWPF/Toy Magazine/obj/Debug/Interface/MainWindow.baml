   M S B A M L   `   `   `  ????G  CToy Magazine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Toy_MagazineToy_Magazine  5   	       Toy_Magazine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Toy_Magazine     5   	     ? Title$  
MainWindow??5   	   $	??250??6   $	??400??6)    ? 
ResizeMode$ NoResize=?5	   	   ???#faf0e6 ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   6,   ?? 5      $??3* ?6   6,   ?? 5      $??1* ?6   6,    ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   .+?5   
   ?? $??1??6   $??0,5,0,0q?6%   .+?5      ?? $??Введите логин??6   ?? 5      -   5        $??logbox??5      6&   ?? 5      $!??Введите пароль??6   ? 5      .+?5      G? -   5         G?Name$ passwordBox??5       G? PasswordChar$ *??6/   ?? 5      -   5         ??Name$ passwordTxtBox??5      $y?	Collapsed=?62   6K   5      5      ?? 5    
   -   5        $??showPassord??5    #   $??2??6   $
??Left=?6v   $??Center=?6?   $??5,60,0,0q?6?   ?? 5!   
   -   5         ??Name$ Enter??5!         BaseButtonStyle#??[  6!   $??1??6J   $??1??6W   $	??100??6g   $??25??6s   $
??Left=?6   $	??Top=?6?   $??
Войти??6?   $??69,5,0,0q?6?   ?? 5#   
   -   5        $ ExitApp??5#   V   $??2??6   $	??Top=?6!   $??Right=?69   $??26??6g   $??26??6r   .??5$      ?? $??/Resources/exit.png??6   5%      ?? 5&   
   $??1??6   $??1??6    $??Bottom=?6-   $??70??6H   $??70??6T   $??/Resources/logo.png??6_   5'      5)      