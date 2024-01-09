using oop2;

ember e1 = new ember("Szakács","Árpád");

Console.WriteLine(e1.teljesNev);

ember e2 = new ember("Nagy","Árpi");
Console.WriteLine(e2.teljesNev);

udvariasEmber ue1 = new udvariasEmber("Horváth", "Hugó");
Console.WriteLine(ue1.teljesNev);

ue1.koszon();
ue1.koszonNevvel();
ue1.koszon(e1);
ue1.koszonNevvel(e2);

diak d1 = new diak("Tálas", "Miklós", 12);
diak d2 = new diak("Verbulecc", "Bálint", 19);
diak d3 = new diak("Mibajodvan", "Alehandró", 26);


d1.koszonNevvel(ue1);

d1.koszon(d2);
//hf 3 fele random koszones