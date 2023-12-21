use master;
go
drop database if exists webshop;
go
create database webshop collate Croatian_CI_AS;
go
use webshop;

create table proizvodi(

	sifra int not null primary key identity(1,1),
	naziv varchar(100),
	datumNabave datetime,
	cijena decimal(18,2),
	aktivan bit

);

create table kupci(

	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	ulica varchar(100) not null,
	mjesto varchar(100) not null

);

create table racuni(

	sifra int not null primary key identity(1,1),
	datum datetime not null,
	kupac int not null,
	_status bit
);

create table stavke(

	racun int not null,
	proizvod int not null,
	kolicina int not null,
	cijena decimal(18,2)

);


alter table stavke add foreign key (racun) references racuni(sifra);
alter table stavke add foreign key (proizvod) references proizvodi(sifra);

alter table racuni add foreign key (kupac) references kupci(sifra);