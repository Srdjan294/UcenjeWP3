use master;
go
drop database if exists ERA_Autobusnikolodvor;
go
create database ERA_Autobusnikolodvor collate Croatian_CI_AS;
go
use ERA_Autobusnikolodvor;

create table mjesta(

	sifra int not null primary key identity(1,1),
	naziv varchar(255) not null

);

create table relacije(

	sifra int not null primary key identity(1,1),
	polaziste int not null,
	odrediste int not null,
	cijena decimal(18,2) not null

);

create table korisnici(

	sifra int not null primary key identity(1,1),
	ime varchar(255) not null,
	prezime varchar(255) not null,
	email varchar(255),
	brojMobitela varchar(255) not null

);

create table racuni(

	sifra int not null primary key identity(1,1),
	korisnik int not null,
	datumKupnje datetime 

);

create table stavke(

	racun int not null,
	relacija int not null,
	kolicina int,
	datumPutovanja datetime
);

alter table stavke add foreign key (racun) references racuni(sifra);
alter table stavke add foreign key (relacija) references relacije(sifra);

alter table racuni add foreign key (korisnik) references korisnici(sifra);

alter table relacije add foreign key (odrediste) references mjesta(sifra);
alter table relacije add foreign key (polaziste) references mjesta(sifra);