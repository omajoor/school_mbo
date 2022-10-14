create database school;
use school;
create table school(
		studentid int,
        achternaam varchar(45),
        voornaam varchar (45),
        primary key (studentid)
);

show tables;
describe school;
insert into school values(323666, "majoor", "olaf");
