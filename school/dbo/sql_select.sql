show databases;

use selma;
show tables;

select * from werknemer;

describe werknemer;

select achternaam,tel,sal,sal*1.01 as verhoging from werknemer;

select concat(voorletters,achternaam)naam from werknemer;

select date_format(datum_in_dienst , '%D of %M %Y') from werknemer;

select * from werknemer;

select * from werknemer where wnr = 99  or achternaam = "Buck";

select * from werknemer where woonplaats ="amsterdam" or woonplaats="utrecht";
select * from werknemer where woonplaats in("amsterdam","utrecht","eindhoven");

select sysdate(); 

select distinct woonplaats,postcode from werknemer where woonplaats like '%dam' order by woonplaats desc, postcode asc;

select achternaam,wnr from werknemer where wnr between 10 and 16;







