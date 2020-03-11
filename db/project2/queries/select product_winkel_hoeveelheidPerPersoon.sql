
select gerechtid, naam as product, hoeveelheid, voluit as eenheidFull, eenheid as eenheidAfk, winkel from eenheden as e inner join (
select w.naam as winkel, gerechtid, idproduct, eenheid, w.idwinkel, hoeveelheid, s.naam from winkel as w inner join(
SELECT gerechtid, p.idproduct ,eenheid,idwinkel,pg.hoeveelheid,naam FROM kokenvoorgroepen.product as p
inner join (select * from produtgerecht)pg on p.idproduct = pg.productid) as s
on w.idwinkel = s.idwinkel) as a on a.eenheid = e.afkorting where gerechtid = '6'
;