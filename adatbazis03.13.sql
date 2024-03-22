\C latin2
CREATE DATABASE kezbesito DEFAULT CHARSET utf8 collate=utf8_hungarian_ci;

USE kezbesito;

SELECT lap.cim,lap.havi from lap where lap.havi != 0 order by lap.cim;

SELECT nev,utca,hazszam from elofizeto,elofizetes WHEre elofizeto.id=eloid group by eloid having count(lapid)>=4;

SELECT sum(lap.eves) as osszeg from lap,elofizetes,elofizeto where lap.id=lapid and eloid=elofizeto.id and utca="Bodor utca" and hazszam = 13;

SELECT cim, havi*12-eves as kedvezmeny from lap order by havi*12-eves desc limit 1;