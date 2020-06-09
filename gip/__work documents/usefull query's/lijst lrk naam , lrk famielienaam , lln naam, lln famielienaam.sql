select  lln.naam  as leerlingNaam , lln.famielienaam as leerlingFamielienaam, sub1.naam as naamLeerkracht, sub1.famielienaam as famielnienaamLeerkracht from
(select lkr.idleerkrachten, lkr.naam, lkr.famielienaam, k.idklas
from dbarduinoeducatief.leerkrachten as lkr inner join dbarduinoeducatief.klas as k
on lkr.idleerkrachten = k.idleerkracht) as sub1 inner join dbarduinoeducatief.leerlingen as lln on lln.idklas = sub1.idklas ;