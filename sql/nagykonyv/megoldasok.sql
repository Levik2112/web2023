-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:

create database nagykonyv default charset=utf8 collate = utf8_hungarian_ci;
use nagykonyv;
-- 3. feladat:
select distinct nemzetiseg from szerzo where nemzetiseg<>"magyar";


-- 4. feladat:

select nev,2005-szulev as kor from szerzo where halEv IS NULL;
-- 5. feladat:
select nev,min(helyezes) as legjobb from szerzo inner join konyv on szerzo.id=szerzoid where nemzetiseg="magyar" group by nev order by legjobb;

-- 6. feladat:
select nev,Count(cim) as konyvek from szerzo inner join konyv on szerzoid=szerzo.id group by nev having konyvek>1 order by  konyvek desc,nev;
