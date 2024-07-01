# ExchanceRateApp
Bu uygulama her biri birer para birimi olan **ABD Doları**, **Euro** ve **İngiliz Sterilin**'ine ait kur bilgilerini bir Web API üzerinden çekerek görüntülenmesini sağlayan bir kur görüntüleme uygulamasıdır.

#### İçerik
* Windows Forms App(.Net Framework)
* 2 x Class Library(.Net Framework)
* ExchangeRateApp.sln
* Newtonsoft.Json.13.0.3 *-NuGet Package*
* NLog.5.3.2 *-NuGet Package*
* NLog.Schema.5.3.2 *-NuGet Package*
* TSQL\TransactSQL.sql
* .gitignore
* README.md
* LICENSE

#### Kullanılan Uygulamalar
* Visual Studio
* SQL Server Management Studio
* Microsoft SQL Server
* Git

#### Kullanılan Web API
* https://finans.truncgil.com/devextreme-datasource.php

## Installation
Öncelikle projeyi klonlayın.
```
git clone https://github.com/vahdetsavci/ExchanceRateApp.git
```

## Usage
1. **SQL Server Management Studio** ile **SQL Server**'a bağlanın.
2. *ExchanceRateApp\TSQL\TransactSQL.sql* yolundaki **TransactSQL.sql** dosyasında bulunan **T-SQL** komutlarını çalıştırarak uygulama için Database'i hazır hale getirin.
3. Ardından **ExchangeRateApp.sln** **Visual Studio** uygulaması ile açın.
4. Projeyi başlatın.

## LICENSE
[MIT](LICENSE)