\C latin2
CREATE database nemzet DEFAULT charset utf8 collate=utf8_hungarian_ci;
use nemzet;

select * from szinesz where valasztas = "2000-08-22" order by nev;
select nev,szuletesinev from szinesz where  nev<>szuletesinev and szuletesinev<>"";

select nev,ev,megnevezes from szinesz join kapott on szinesz.id=szineszid join elismeres on elismeresid=elismeres.id order by nev,ev;