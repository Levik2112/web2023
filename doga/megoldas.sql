\C latin2
//10.feladat
create database kockaverseny default charset=utf8 collate=utf8_hungarian_ci;

use kockaverseny;

//12.feladat
delete from orszag where nev = "Svájc";

//13.feladat
select count(nev) as versenyzoszam  from versenyzo;

//14.feladat
select kategoria,min(ido1)/100 as leggyorsabb from eredmeny group by kategoria;

//15.feladat
select nev,kategoria,fordulo from versenyzo inner join eredmeny on versenyzoid=versenyzo.id where ido4 is not null and ido5 is null order by nev;

//16.feladat
select distinct orszag.nev as orszag from orszag inner join eredmeny ON versenyzoid=versenyzo.id where kategoria="3x3";

//nem jou :(