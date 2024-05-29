A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat: 
create database varosok default charset=utf8 collate=utf8_hungarian_ci;
3. feladat:
select  vnev from varos where vnev like "%vásár%";
4. feladat:
select vnev,nepesseg,terulet from varos where terulet>400 order by nepesseg desc;
5. feladat:
select vnev,nepesseg from varos inner join megye on megyeid=megye.id where mnev="Fejér" and nepesseg>15000;
6. feladat:
select vtip as "Város típusa",count(varos.id) as "Városok száma",sum(nepesseg) as "Népesség" from varostipus inner join varostipus on varostipus.id = vtipid;
7. feladat:

