function fvKikapcs() {
   lilaTeknos = function () { };
   kekTeknos = function () { };
   pirosTeknos = function () { };
   zoldTeknos = function () { };
}
//lapok
const teknosok = ["zoldteknosvagott.png", "lilateknosvagott.png", "pirosteknosvagott.png", "kekteknosvagott.png"];
const bogarak = ["zoldbogar.png", "kekbogar.png", "lilabogar.png", "pirosbogar.png"];
const gyemantok = ["zoldgyemant.png", "kekgyemant.png", "pirosgyemant.png", "lilagyemant.png"];
const zold_lapok = ["zoldbalra.png", "zoldbekaikon.png", "zoldelore.png", "zoldjobbra.png", "zoldlezer.png"];
const piros_lapok = ["pirosbalra.png", "pirosbekaikon.png", "piroselore.png", "pirosjobbra.png", "piroslezer.png"];
const kek_lapok = ["kekbalra.png", "kekbekaikon.png", "kekelore.png", "kekjobbra.png", "keklezer.png"];
const lila_lapok = ["lilabalra.png", "lilabekaikon.png", "lilaelore.png", "lilajobbra.png", "lilalezer.png"];
const tablaKozepek = ["tablaKozep1","tablaKozep2","tablaKozep3","tablaKozep4"]
const urlTeknos = ["url("+'"'+"kepek/kekteknosvagott.png"+'"'+")","url("+'"'+"kepek/zoldteknosvagott.png"+'"'+")","url("+'"'+"kepek/pirosteknosvagott.png"+'"'+")","url("+'"'+"kepek/lilateknosvagott.png"+'"'+")"]



//tabla sarkok
const tablaSarkok = ["tablaSarokBalFelso", "tablaSarokJobbFelso", "tablaSarokBalAlso", "tablaSarokJobbAlso"]
const randomSarok = Math.floor(Math.random() * tablaSarkok.length);

//a jatek kezdes gombja behozza a teknos valasztast
function jatek_kezdes() {
   let valasztas = document.getElementById("valasztas_div");
   console.log(valasztas)
   valasztas.style.display = "block";
   
    
   //console.log(tablaSarkok[randomSarok])

}


//valasztott teknos megjelenitese

function teknosValaszto(kepNeve) {
   if (kepNeve === "kep1") {
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundImage = "url('kepek/zoldteknosvagott.png')";
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundSize = "cover";
      alapPalyaRendezes()
   }
   else if (kepNeve === "kep2") {
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundImage = "url('kepek/lilateknosvagott.png')";
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundSize = "cover";
      alapPalyaRendezes()
   }
   else if (kepNeve === "kep3") {
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundImage = "url('kepek/pirosteknosvagott.png')";
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundSize = "cover";
      alapPalyaRendezes()
   }
   else if(kepNeve==="kep4"){
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundImage = "url('kepek/kekteknosvagott.png')";
      document.getElementById(tablaSarkok[randomSarok]).style.backgroundSize = "cover";
      alapPalyaRendezes()
   }
}
// teknos valasztas utan alap palyarendezes valamint gomb / valasztas menu eltuntetese
function alapPalyaRendezes(){
   
   let kartyaTarto = document.getElementById("kartyaTartoFo");
   let gombok = document.getElementById("szulo");
   for(let i = 0;i<tablaSarkok.length && urlTeknos.length;i++){
      if(document.getElementById(tablaSarkok[i]).style.backgroundImage!=""){
         
         //console.log("teknos: "+urlTeknos[i])
         //console.log("tablasarok: "+document.getElementById(tablaSarkok[i]).style.backgroundImage)
         valasztas.style.display="none";
         kartyaTarto.style.display="";
         gombok.style.display="none";

         
         // kozepre lerakja a gyemantokat
         for(let i = 0;i<tablaKozepek.length && gyemantok.length;i++){
            document.getElementById(tablaKozepek[i]).style.backgroundImage = "url("+'"'+"kepek/"+gyemantok[i]+'"'+")";
            document.getElementById(tablaKozepek[i]).style.backgroundSize = "cover";

            
          }     
         }
         //ha valasztottal teknost ki vesszuk azt az ulrt a urlTeknosbol valamint a hasznalt sarkot is és a tobbi szabad helyet feltoltjuk a maradek url-el

         /*
      function torlo(elem,i){
         if(document.getElementById(tablaSarkok[i]).style.backgroundImage.includes(elem)){
            urlTeknos.splice(i,1)
         }
      }
      const proba = urlTeknos.filter(torlo)
      urlTeknos=proba
      console.log(urlTeknos)
      */
   }
 }
 
  /*console.log("asdasd")
      document.getElementById(tablaKozepek[i]).style.backgroundImage = "url("+'"'+"kepek/"+urlTeknos[i]+'"'+")";
      document.getElementById(tablaKozepek[i]).style.backgroundSize = "cover";
      */