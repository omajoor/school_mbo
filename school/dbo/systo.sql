create database Garage;
use Garage;

create table Auto(
kenteken varchar(10),
type varchar(50) not null,
primary key(kenteken)
);

describe eigenaar;

create table Eigenaar(
bsn int,
naam varchar(50) not null,
tel varchar(12) not null,
primary key(bsn)
);

create table AutoEigenaar(
auto varchar(10),
eigenaar int,
primary key(auto,eigenaar),
foreign key(auto) references Auto(kenteken),
foreign key(eigenaar) references Eigenaar(bsn)

);

describe AutoEigenaar;

insert into Auto values("APZ-34-23","farari");

select * from AutoEigenaar;

insert into Eigenaar values(123456,"olaf","0622314416");
insert into Eigenaar values(09876, "mac","061234567");
insert into Eigenaar values(123456789,"noah","06123456789");

insert into AutoEigenaar(auto,eigenaar) values("92-PK-392",123456);
insert into AutoEigenaar(auto,eigenaar) values("APZ-34-23",09876);
insert into AutoEigenaar(auto,eigenaar) values("APZ-34-23",123456789);


