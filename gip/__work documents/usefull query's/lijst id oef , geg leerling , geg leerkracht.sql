
 select idoefeningen, tietel, naam, famielienaam, idleerlingen, idleerkrachten, oefeningid from oefeningen inner join ( 
select a.naam, a.famielienaam, a.idleerlingen, leerkrachten.idleerkrachten ,a.oefeningid from leerkrachten inner join (
  select leerlingen.oefeningid, leerlingen.idleerlingen , klas.idklas ,klas.idleerkracht , leerlingen.naam, leerlingen.famielienaam from 
 klas inner join
 leerlingen on klas.idklas = leerlingen.idklas 
 
 ) as a on leerkrachten.idleerkrachten = a.idleerkracht )
 as b on b.oefeningid = oefeningen.idoefeningen WHERE idleerkrachten = '89';