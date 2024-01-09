CREATE DATABASE  tanulok DEFAULT CHARACTER SET = utf8 COLLATE=utf8_hungarian_ci;
USE tanulok;
CREATE TABLE tanulok_tabla (nev VARCHAR(10),datum DATE,magassag INT(3),suly FLOAT(5));
INSERT INTO tanulok_tabla(nev,datum,magassag,suly);
VALUES
("Bela","2011.08.02","162","44,5"),
("Pisti","2012.04.24","154","73,7"),
("Julcsi","2011.07.13","159","69,6"),
("Karcsi","2011.11.22","189","58,4"),
("Marcsi","2012.04.28","166","87,4"),
("Alehandró","2011.09.01","145","40,6"),
("Hürrem","2012.01.17","172","93,9"),
("Alex","2012.04.25","148","44,9"),
("Sanyi","2011.10.05","170","76,8");

DROP DATABASE tanulok;

Aelx a legalacsonyabb.