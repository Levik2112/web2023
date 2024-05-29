\C latin
CREATE DATABASE operett DEFAULT CHARSET utf8 COLLATE utf8_hungarian_ci;

SELECT cim FROM mu WHERE ev=1916 order by cim;

SELECT nev,tipus from mu join kapcsolat on mu.id=muid join alkoto on alkotoid=alkoto.id where cim = "Bob herceg";

SELECT ev from mu order by ev desc limit 1;

SELECT max(ev) from mu;

SELECT nev,count(muid) from alkoto join kapcsolat on alkotoid=alkoto.id group by alkotoid order by 2 desc limit 3;