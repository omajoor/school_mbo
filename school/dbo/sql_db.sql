use bioscoop;
select * from klant;

select * from klant order by achternaam,voornaam;

select voornaam,tussenvoegsel,achternaam,email from klant where voornaam="Piet";

select * from klant where tussenvoegsel like '%van%';

select * from klant where voornaam='frits' or voornaam='kees';

select concat(voornaam, " ",tussenvoegsel, " ",achternaam)volledige_naam,email from klant where achternaam like 'jan%';

select * from genre;

select distinct(naam) from genre;

select naam from genre where naam not like '%a%';

select * from voorstelling;

select naam,plaatsen from zaal where naam="Kinderzaal" or naam="megazaal";

select naam,plaatsen from zaal where plaatsen between 50 and 300;

select * from film  order by duur desc;

select naam,releasedatum from film where duur <100 or duur > 150;

select naam,releasedatum from film where (duur <100 or duur > 150) and releasedatum like"2013-02%";

select id,aanvang,prijs from voorstelling order by prijs desc;

select id,aanvang,prijs,prijs*1.1 from voorstelling where prijs <=8;

select * from voorstelling where ondertitel_id is NULL;

select date_format(aanvang,'%d-%m-%Y')aanvangsdatum from voorstelling;

select sysdate();


select * from voorstelling;

select count(*) as klant_aantal from klant;

select avg(duur) from film where releasedatum like '2012%';

select sum(duur) from film;

select film_id,count(*) as aantal from voorstelling group by film_id;

select zaal_id,avg(prijs) as gem_prijs from voorstelling group by zaal_id having gem_prijs>=8;






