CREATE DATABASE Bibliotheque_DB
USE Bibliotheque_DB


CREATE TABLE Adherent(
CodeAd int primary key identity not null,
NumRecuAd int not null,
NomAd varchar(50)not null,
PrenomAd varchar(50)not null,
AdresseAd varchar(300)not null,
TelephoneAd int not null
)

insert into Adherent(NumRecuAd,NomAd,PrenomAd,AdresseAd,TelephoneAd) values(111111,'Alami','Ali','Acharaf IMM B3',0623344556)
insert into Adherent(NumRecuAd,NomAd,PrenomAd,AdresseAd,TelephoneAd) values(222222,'Hassan','Marwa','AlWaha IMM 12',0694585763)
insert into Adherent(NumRecuAd,NomAd,PrenomAd,AdresseAd,TelephoneAd) values(333333,'JAAFAR','Youssef','Rida IMM 8',0636344636)
insert into Adherent(NumRecuAd,NomAd,PrenomAd,AdresseAd,TelephoneAd) values(444444,'Chadi','Ahmed','AlAmal IMM A11',0663894451)


CREATE TABLE Livre(
CodeLv varchar(50) primary key not null,
TitreLv varchar(150)not null,
NomAuteurLv varchar(100)not null,
EditeurLv varchar(300)not null,
NbrPagesLv int not null,
QtteLv int not null,
Categorie varchar(50)not null
)

insert into Livre values('CL_4_001','Critique Li','Sadiq Karim','ALCHOROQ 2008',122,3,'Critique Literraire')
insert into Livre values('H_1_012','HISTOIRE  du Maroc','Rima Asmaa','ALNOR 2004',543,1,'Historique')
insert into Livre values('Phis_2_009','Physique Exercices','Kilani Hassan','ALCHOROQ 2011',212,4,'Physique ')
insert into Livre values('Mth_6_016','Math Exercices','Chakor Oussama','ALCHOROQ 2008',198,2,'Mathematique')


CREATE TABLE Bibliothecaire(
CodeBibl int primary key identity not null,
NomBibl varchar(50)not null,
PrenomBibl varchar(50)not null,
AdresseBibl varchar(300)not null,
TelephoneBibl int not null,
Utilisateur varchar(50)not null,
MotDePass varchar(50)not null,
Permission varchar(50)not null
)

insert into Bibliothecaire(NomBibl,PrenomBibl,AdresseBibl,TelephoneBibl,Utilisateur,MotDePass,Permission) values('Jabbaj','Mohammed','ALManar IMM 5 E1',0683651857,'user','us1234','user')
insert into Bibliothecaire(NomBibl,PrenomBibl,AdresseBibl,TelephoneBibl,Utilisateur,MotDePass,Permission) values('Oudani','Khadija','AlRisala IMM 9 E1',0677751857,'admin','ad1234','admin')


CREATE TABLE Emprunt(
CodeEmpr int primary key identity not null,
CodeLv varchar(50) foreign key references Livre(CodeLv),
CodeBibl int foreign key references Bibliothecaire(CodeBibl),
CodeAd int foreign key references Adherent(CodeAd),
DateEmprunt DateTime not null,
DateReturn DateTime not null
)
