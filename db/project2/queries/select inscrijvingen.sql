select idevent,datumStart, datumEnd, img, ie.naam,idinschrijving,u.iduser,voornaam,
u.naam,u.vegan,veganistisch,u.username from user as u inner join (
select i.idevent,datumStart, datumEnd, img,naam,idinschrijving,iduser from event as e
inner join (select * from inschrijving)as i on i.idevent =e.idevent) as  ie on ie.iduser order by idevent
;