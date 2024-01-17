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

insert into mjesta(naziv) values
('Beli Manastir'),('Beli��e'),('Benkovac'),('Biograd na moru'),('Bjelovar'),('Buzet'),('Cernik'),('Cres'),('Crikvenica'),('�akovec'),('�azma'),
('Daruvar'),('Delnice'),('Donji Miholjac'),('Drni�'),('Dubrovnik'),('Dugo Selo'),('�akovo'),('�ur�evac'),('Gare�nica'),('Glina'),('Gospi�'),
('Grubi�no Polje'),('Imotski'),('Ivanec'),('Ivani�-Grad'),('Karlovac'),('Knin'),('Koprivnica'),('Kor�ula'),('Krapina'),('Kri�evci'),('Krk'),
('Kutina'),('Labin'),('Ludbreg'),('Makarska'),('Mali Lo�inj'),('Metkovi�'),('Mursko Sredi��e'),('Na�ice'),('Nova Gradi�ka'),('Novalja'),
('Novi Marof'),('Novi Vinodolski'),('Novigrad'),('Novska'),('Ogulin'),('Omi�'),('Opatija'),('Orahovica'),('Osijek'),('Oto�ac'),('Pag'),
('Pakrac'),('Pazin'),('Petrinja'),('Plitvi�ka Jezera'),('Plo�e'),('Pore�'),('Po�ega'),('Pregrada'),('Pula'),('Rab'),('Rijeka'),
('Rovinj'),('Samobor'),('Senj'),('Sinj'),('Sisak'),('Slatina'),('Slavonski Brod'),('Split'),('Stari Grad'),('Stubi�ke Toplice'),('Suko�an'),
('Sveti Ivan Zelina'),('�ibenik'),('Trogir'),('Umag'),('Valpovo'),('Vara�din'),('Vara�dinske Toplice'),('Velika Gorica'),('Vinkovci'),
('Vir'),('Virovitica'),('Vodice'),('Vojni�'),('Vrbovec'),('Vrbovsko'),('Vukovar'),('Zabok'),('Zadar'),('Zagreb'),('Zlatar'),('�upanja');


--select * from mjesta;


insert into relacije(polaziste, odrediste, cijena) values
(1, 95, 23.40), (1, 52, 4.70), (1, 72, 11.30);

select * from relacije;

select a.naziv as polaziste, c.naziv as odrediste
from mjesta a
inner join relacije b on a.sifra = b.polaziste
inner join mjesta c on c.sifra = b.odrediste;