use master;
go
drop database if exists tvrtka;
go

create database tvrtka collate Croatian_CI_AS;
go

use tvrtka;

create table zaposlenici(

	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	datumRodenja datetime,
	placa decimal(18,2),
	invalid bit,

);

create table slike(

	sifra int not null primary key identity(1,1),
	zaposlenik int not null,
	redniBroj varchar(40),
	putanja varchar(40)

);

alter table slike add foreign key (zaposlenik) references zaposlenici(sifra)


insert into zaposlenici(ime, prezime, datumRodenja, placa, invalid) values
('Marko', 'Markoviæ', '2002-12-22', 1234.34, 1),
('Ivan', 'Ivanociæ', '2002-2-23', 1245.34, 0),
('Josip', 'Jopiæ', '2001-3-4', 1224.34, 1);

insert into slike(zaposlenik, redniBroj, putanja) values
(1,'1.','lijevo'),
(1,'2.','desno');

insert into slike(zaposlenik, redniBroj, putanja) values
(2,'3.','lijevo gore'),
(2,'4.','desno dolje');

insert into slike(zaposlenik, redniBroj, putanja) values
(3,'5.','lijevo gore'),
(3,'6.','desno dolje');

select * from zaposlenici;
select * from slike;
