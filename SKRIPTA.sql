DROP SCHEMA IF EXISTS ServisRacunara;
create schema ServisRacunara default character set utf8;
use ServisRacunara;

DROP PROCEDURE IF EXISTS OBRISI_PARTNERA;
CREATE PROCEDURE OBRISI_PARTNERA(IN pIdPartnera INT)
UPDATE  Partner
SET Obrisan=1
WHERE IdPartnera=pIdPartnera;

DROP TABLE IF EXISTS GRAD;
create table GRAD(
PostanskiBrojGrada INT,
NazivGrada VARCHAR(40) NOT NULL,
PRIMARY KEY(PostanskiBrojGrada)
);
DROP TABLE IF EXISTS ULICA;
create table ULICA(
IdUlice INT AUTO_INCREMENT,
PostanskiBrojGrada INT,
NazivUlice VARCHAR(50),
PRIMARY KEY(IdUlice,PostanskiBrojGrada),
CONSTRAINT ULICA_GRAD
FOREIGN KEY(PostanskiBrojGrada) references GRAD(PostanskiBrojGrada) ON UPDATE CASCADE);

DROP TABLE IF EXISTS ADRESA;
create table ADRESA(
PostanskiBrojGrada INT,
IdUlice INT NOT NULL,
KucniBroj INT NOT NULL,
PRIMARY KEY(PostanskiBrojGrada,IdUlice,KucniBroj),
CONSTRAINT ADRESA_ULICA
FOREIGN KEY(PostanskiBrojGrada,IdUlice) references ULICA(PostanskiBrojGrada,IdUlice)  ON UPDATE CASCADE
);

DROP TABLE IF EXISTS PARTNER;
create table PARTNER(
IdPartnera INT AUTO_INCREMENT,
Ime VARCHAR(50) NOT NULL,
email VARCHAR(50),
PostanskiBrojGrada INT,
IdUlice INT,
KucniBroj INT,
Obrisan TINYINT DEFAULT 0,
PRIMARY KEY(IdPartnera),
CONSTRAINT PARTNER_ADRESA
FOREIGN KEY(PostanskiBrojGrada,IdUlice,KucniBroj) references ADRESA(PostanskiBrojGrada,IdUlice,KucniBroj) ON UPDATE CASCADE
);


DROP TABLE IF EXISTS TELEFON;
create table TELEFON(
BrojTelefona VARCHAR(12) NOT NULL,
IdPartnera INT,
PRIMARY KEY(BrojTelefona,IdPartnera),
CONSTRAINT TELEFON_PARTNER
FOREIGN KEY(IdPartnera) references PARTNER(IdPartnera));

DROP TABLE IF EXISTS RADNIK;
create table RADNIK(
IdPartnera INT,
Uloga VARCHAR(50) NOT NULL,
Plata DECIMAL(10,2) NOT NULL,
VozackaDozvola varchar(2) NOT NULL,
PRIMARY KEY (IdPartnera),
CONSTRAINT RADNIK_PARTNER
FOREIGN KEY (IdPartnera) references PARTNER(IdPartnera));

DROP TABLE IF EXISTS KLIJENT;
create table KLIJENT(
IdPartnera INT,
JestePravnoLice TINYINT UNSIGNED DEFAULT 0 NOT NULL,
BrojLicneKarte CHAR(9),
JIB CHAR(13),
PRIMARY KEY(IdPartnera),
CONSTRAINT KLIJENT_PARTNER
FOREIGN KEY (IdPartnera) references PARTNER(IdPartnera));

DROP TABLE IF EXISTS RACUN;
create table RACUN(
BrojRacuna INT PRIMARY KEY,
VrijemeIzdavanja DATETIME NOT NULL,
ZbirniIznos DECIMAL(10,2));

DROP TABLE IF EXISTS RADNI_NALOG;
create table RADNI_NALOG(
BrojRadnogNaloga INT PRIMARY KEY AUTO_INCREMENT,
OpisZahtjeva VARCHAR(10000),
Napomena VARCHAR(10000),
StatusNaloga VARCHAR(20) ,
DatumKreiranja DATETIME NOT NULL,
DatumZavrsetka DATETIME,
IdServiseraZ INT,
IdServiseraR INT,
IdKlijenta INT,
Obrisan TINYINT DEFAULT 0,
CONSTRAINT SERVISER_KOJI_JE_KREIRAO_NALOG
FOREIGN KEY(IdServiseraZ) references RADNIK(IdPartnera),
CONSTRAINT SERVISER_KOJI_RADI_NALOG
FOREIGN KEY(IdServiseraR) references RADNIK(IdPartnera),
CONSTRAINT RADNI_NALOG_KLIJENT
FOREIGN KEY (IdKlijenta) references KLIJENT(IdPartnera),
Proknjizeni TINYINT UNSIGNED DEFAULT 0,
BrojRacuna INT,
CONSTRAINT RADNI_NALOG_RACUN
FOREIGN KEY(BrojRacuna) references RACUN(BrojRacuna));


DROP TABLE IF EXISTS KOMPONENTA;
create table KOMPONENTA(
SifraKomponente INT,
NazivKomponente VARCHAR(50) NOT NULL,
CijenaKomponente DECIMAL(10,2) NOT NULL, 
DostupnaKolicina INT NOT NULL,
Obrisana TINYINT DEFAULT 0,
PRIMARY KEY(SifraKomponente));

DROP TABLE IF EXISTS KOMPONENTA_STAVKA;
create table KOMPONENTA_STAVKA(
SifraKomponente INT,
BrojRadnogNaloga INT,
PRIMARY KEY(SifraKomponente,BrojRadnogNaloga),
Kolicina INT NOT NULL,
Cijena DECIMAL(10,2) NOT NULL,
Rabat DECIMAL(5,2) NOT NULL,
Ukupno DECIMAL(5,2) NOT NULL,
Obrisana TINYINT DEFAULT 0,
CONSTRAINT KOMPONENTA_STAVKA_RADNI_NALOG
FOREIGN KEY (BrojRadnogNaloga) references RADNI_NALOG(BrojRadnogNaloga) ON UPDATE CASCADE,
CONSTRAINT KOMPONENTA_STAVKA_KOMPONENTA
FOREIGN KEY (SifraKomponente) references KOMPONENTA(SifraKomponente) ON UPDATE CASCADE);

DROP TABLE IF EXISTS USLUGA;
create table USLUGA(
SifraUsluge INT,
Naziv VARCHAR(70) NOT NULL,
CijenaPoH Decimal(10,2) NOT NULL,
Obrisana TINYINT DEFAULT 0,
PRIMARY KEY(SifraUsluge));

DROP TABLE IF EXISTS USLUGA_STAVKA;
create table USLUGA_STAVKA(
SifraUsluge INT,
BrojRadnogNaloga INT,
Kolicina INT NOT NULL,
CijenaPoH DECIMAL(10,2) NOT NULL,
Rabat DECIMAL(10,2) NOT NULL,
Ukupno DECIMAL(5,2) NOT NULL,
Obrisana TINYINT DEFAULT 0,
PRIMARY KEY(SifraUsluge,BrojRadnogNaloga),
CONSTRAINT USLUGA_STAVKA_USLUGA
FOREIGN KEY(SifraUsluge) references USLUGA(SifraUsluge),
CONSTRAINT USLUGA_STAVKA_RADNI_NALOG
FOREIGN KEY(BrojRadnogNaloga) references RADNI_NALOG(BrojRadnogNaloga));

CREATE PROCEDURE UnosUlice (IN pPostanskiBrojGrada INT, IN pNazivUlice varchar(50))
INSERT INTO ULICA(PostanskiBrojGrada,NazivUlice) VALUES (pPostanskiBrojGrada,pNazivUlice);

CREATE PROCEDURE UPDATE_USLUGA_STAVKA(IN pSifraUsluge INT,IN pBrojRadnogNaloga INT,IN pKolicina INT,IN pCijenaPoH DECIMAL,IN pRabat DECIMAL,IN pUkupno DECIMAL)
UPDATE USLUGA_STAVKA
SET Kolicina=pKolicina,Rabat=pRabat,Ukupno=pUkupno
WHERE SifraUsluge=pSifraUsluge and BrojRadnogNaloga=pBrojRadnogNaloga;

CREATE PROCEDURE DELETE_USLUGA_STAVKA(IN pBrojRadnogNaloga INT,IN pSifraUsluge INT)
UPDATE USLUGA_STAVKA
SET Obrisana=1
WHERE BrojRadnogNaloga=pBrojRadnogNaloga AND SifraUsluge=pSifraUsluge;

DROP PROCEDURE IF EXISTS DELETE_KOMPONENTA_STAVKA;
DELIMITER $$
CREATE PROCEDURE DELETE_KOMPONENTA_STAVKA(IN pBrojRadnogNaloga INT,IN pSifraKomponente INT,IN pRazlika INT)
BEGIN
UPDATE KOMPONENTA
SET DostupnaKolicina=DostupnaKolicina+pRazlika
WHERE SifraKomponente=pSifraKomponente;
DELETE FROM KOMPONENTA_STAVKA WHERE BrojRadnogNaloga=pBrojRadnogNaloga and SifraKomponente=pSifraKomponente;
END $$
DELIMITER ;

DROP PROCEDURE IF EXISTS UPDATE_KOMPONENTA_STAVKA;
DELIMITER $$
CREATE PROCEDURE UPDATE_KOMPONENTA_STAVKA(IN pBrojRadnogNaloga INT,IN pSifraKomponente INT,IN pRazlika INT,IN pCijena DECIMAL,IN pRabat DECIMAL,IN pUkupno DECIMAL,IN pKolicina INT)
BEGIN
UPDATE KOMPONENTA_STAVKA
SET Kolicina=pKolicina,Cijena=pCijena,Rabat=pRabat,Ukupno=pUkupno
WHERE SifraKomponente=pSifraKomponente and BrojRadnogNaloga=pBrojRadnogNaloga;
UPDATE KOMPONENTA
SET DostupnaKolicina=DostupnaKolicina-pRazlika
WHERE SifraKomponente=pSifraKomponente;
END $$
DELIMITER ;
 
CREATE PROCEDURE UMANJI_DOSTUPNE_KOMPONENTE(IN pSifraKomponente INT,IN pZaKolicinu INT)
UPDATE KOMPONENTA
SET DostupnaKolicina=DostupnaKolicina-pZaKolicinu
WHERE SifraKomponente=pSifraKomponente;

CREATE PROCEDURE OBRISI_SVE_STAVKE_USLUGE_SA_NALOGA(IN pBrojRadnogNaloga INT)
DELETE FROM USLUGA_STAVKA WHERE BrojRadnogNaloga=pBrojRadnogNaloga;

DROP PROCEDURE  IF EXISTS OBRISI_RADNI_NALOG; 
CREATE PROCEDURE OBRISI_RADNI_NALOG(IN pBrojRadnogNaloga INT)
UPDATE RADNI_NALOG
SET Obrisan=1
WHERE BrojRadnogNaloga=pBrojRadnogNaloga;

DROP PROCEDURE  IF EXISTS UPDATE_RADNI_NALOG; 
CREATE PROCEDURE UPDATE_RADNI_NALOG(IN pBrojNaloga INT,IN pZahtjev VARCHAR(10000),IN pNapomena VARCHAR(10000),IN pDatumKreiranja DATETIME, IN pDatumZavrsetka DATETIME,IN pStatus VARCHAR(20),
IN pIdServiseraZ INT,IN pIdServiseraR INT)
UPDATE Radni_nalog
SET OpisZahtjeva=pZahtjev,Napomena=pNapomena,StatusNaloga=pStatus,DatumKreiranja=pDatumKreiranja,DatumZavrsetka=pDatumZavrsetka,IdServiseraZ=pIdServiseraZ,IdServiseraR=pIdServiseraR
WHERE BrojRadnogNaloga=pBrojNaloga;




INSERT INTO `servisracunara`.`USLUGA`(`SifraUsluge`,`Naziv`,`CijenaPoH`) VALUES (771,'Servis Racunara',20);
INSERT INTO `servisracunara`.`USLUGA`(`SifraUsluge`,`Naziv`,`CijenaPoH`) VALUES (772,'Servis Laptopa',30);
INSERT INTO `servisracunara`.`USLUGA`(`SifraUsluge`,`Naziv`,`CijenaPoH`) VALUES (773,'Servis Uredjaja',40);

INSERT INTO `servisracunara`.`komponenta` (`SifraKomponente`, `NazivKomponente`, `CijenaKomponente`, `DostupnaKolicina`) VALUES ('1111', 'HDD', '95', '11');
INSERT INTO `servisracunara`.`komponenta` (`SifraKomponente`, `NazivKomponente`, `CijenaKomponente`, `DostupnaKolicina`) VALUES ('1112', 'SSD', '55', '3');
INSERT INTO `servisracunara`.`komponenta` (`SifraKomponente`, `NazivKomponente`, `CijenaKomponente`, `DostupnaKolicina`) VALUES ('1113', 'Graficka karta', '350', '2');
INSERT INTO `servisracunara`.`komponenta` (`SifraKomponente`, `NazivKomponente`, `CijenaKomponente`, `DostupnaKolicina`) VALUES ('1114', 'MaticnaPloca', '110', '5');

INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78255','Aleksandrovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89245','Avtovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72286','Babanovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75290','Banovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78000','Banja Luka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78103','Banja Luka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78108','Banja Luka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78114','Banja Luka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70267','Bara??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76312','Batkovi??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72233','Begov Han');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88363','Berkovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77000','Biha??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76204','Bijela');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73263','Bijelo Brdo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76300','Bijeljina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76321','Suho Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72256','Bila');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88268','Bileti?? Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71253','Bilalovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89230','Bile??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72248','Bilje??evo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88407','Bjelimi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88201','Blagaj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74275','Blatnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88263','Blatnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71215','Bla??uj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76210','Bo??e');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76277','Bok');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74322','Boljani??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88405','Bora??ko Jezero');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88365','Borojevi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73225','Borike');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77240','Bosanska Krupa');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77250','Bosanski Petrovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80270','Bosansko Grahovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75420','Bratunac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76100','Br??ko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76120','Br??ko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76101','Br??ko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77205','Brekovica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74210','Brestovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71255','Brestovsko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71370','Breza');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79208','Brezi??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76216','Brezovo Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74206','Brijesnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76206','Brka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72243','Brnjic');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88243','Bro??anac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73309','Brod');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74450','Brod');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76313','Brodac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78204','Bronzani Majdan');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70230','Bugojno');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75203','Bukinje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74277','Buleti??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72293','Bu??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88202','Buna');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72260','Busova??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88366','Burmazi');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88409','Buturovi?? Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77245','Bu??im');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75405','Caparde');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71347','Careva ??uprija');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77220','Cazin');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76239','Crkvina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88367','Crni??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76328','Crnjelovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73280','??ajni??e');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88300','??apljina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88302','??apljina-Euroherc');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72224','??ardak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72246','??ati??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74274','??e??ava');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73307','??elebi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88404','??elebi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75246','??eli??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78240','??elinac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88265','??erin');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88260','??itluk');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88261','??itluk-Euroherc');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71223','Delija??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79243','Demirovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74400','Derventa');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75444','Derventa');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70204','Divi??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89233','Divin');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74101','Doboj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75328','Doborovci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70210','Dobreti??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79223','Dobrljin');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73247','Dobrun');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72278','Dolac na La??vi');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88446','Doljani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76233','Domaljevac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76231','Domaljevac-Grani??ni');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88305','Domanovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76274','Donja Mahala');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76257','Donja Me??i??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76237','Donja Slatina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71305','Donje Mo??tre');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79228','Donji Agi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79266','Donji Kamengrad');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88343','Donji Mami??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76297','Donji Svilaj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70220','Donji Vakuf');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78432','Donji Vija??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79289','Donji Vrbljani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76273','Donji ??abar');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74209','Dragalovci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76323','Dragaljevac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78215','Drago??aj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88215','Dre??nica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79290','Drini??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88344','Drinovci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75410','Drinja??a (Zvornik)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80260','Drvar');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70237','Drvetine');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75358','Duboki Potok');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75308','Dubo??tica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79227','Dubovik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78411','Dubrave');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75274','Dubrave Donje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75273','Dubrave Gornje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74483','Dugo Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88342','Du??ice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76311','Dvorovi');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79264','Fajtovci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75423','Fakovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73302','Fo??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71270','Fojnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89247','Fojnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88306','Gabela');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89240','Gacko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74484','Garevac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80230','Glamo??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88406','Glavati??evo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76318','Glavi??ice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74258','Globarica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88422','Glogo??nica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88392','Gradac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71275','Gojevi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78203','Gole??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73101','Gora??de');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76296','Gornja Dubica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77222','Gornja Koprivna');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76238','Gornja Slatina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75208','Gornja Tuzla');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78405','Gornji Podgradci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76207','Gornji Rahi??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79288','Gornji Ribnik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78438','Gornji Smrti??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78439','Gornji ??trpci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74272','Gornji Tesli??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70240','Gornji Vakuf');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89201','Grab');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74219','Grabovica (RS 74219)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78227','Grabovica (RS 78227)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88443','Gra??ac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75320','Gra??anica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70233','Gra??anica kod Bugojna');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75276','Gra??anica Selo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76250','Grada??ac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78400','Gradi??ka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76234','Grebnice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88340','Grude');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88341','Grude-MUP');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80205','Guber');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72277','Gu??a Gora');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75404','Gu??teri');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71240','Had??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72225','Hajderovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72245','Haljini??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72281','Han Bila');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71360','Han Pijesak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88368','Hodovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88395','Hrasno');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71144','Hre??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78436','Hrva??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75216','Husino');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88394','Hutovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71210','Ilid??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71380','Ilija??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73208','Ilova??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78234','Imljani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71123','Isto??no Sarajevo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77208','Iza??i??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88420','Jablanica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70101','Jajce');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76316','Janja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72215','Janji??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88224','Jare');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78233','Javorani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74264','Jelah');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70206','Jezero');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77241','Jezerski');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79244','Johova');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78244','Jo??avka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72264','Ka??uni');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72240','Kakanj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74413','Kalenderovci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75260','Kalesija');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71230','Kalinovik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71355','Kaljina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77204','Kamenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72265','Kaonik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70235','Karad??e');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72284','Karaula');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71213','Kasindo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80246','Kazaginac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88283','Kifino Selo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71250','Kiseljak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75211','Kiseljak kod Tuzle');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75280','Kladanj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88324','Klobuk (Ljubu??ki)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74207','Klokotnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79280','Klju??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78230','Kne??evo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79246','Kne??ica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71356','Kne??ina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78423','Koba??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88226','Ko??erin');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80244','Kongora');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76276','Kostr??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78207','Kola');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88400','Konjic');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77249','Konjodor');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74489','Koprivna');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75247','Koraj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76236','Kornica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74253','Kosova');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74222','Kostajnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79224','Kostajnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78220','Kotor Varo??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74215','Kotorsko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72226','Kova??i (Zavidovi??i)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79202','Kozarac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79240','Kozarska Dubica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75413','Kozluk');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72244','Kraljeva Sutjeska');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79284','Krasulje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76212','Krep??i??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71260','Kre??evo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78256','Kri??kovci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77253','Krnjeu??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78206','Krupa na Vrbasu');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88203','Kru??evo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78424','Kukulje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78443','Kula??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77206','Kulen Vakuf');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78212','Kuljani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80320','Kupres');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78250','Lakta??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78407','Laminci Sre??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79204','Lamovita');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89208','Lastva');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71254','Lepenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75213','Lipnica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80101','Livno');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80204','Li??tani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76278','Lon??ari');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75240','Lopare');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75300','Lukavac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75327','Lukavica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80203','Lusni??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79267','Lu??ci Palanka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75214','Ljuba??e');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79206','Ljubija');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88380','Ljubinje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89209','Ljubomir');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88320','Ljubu??ki');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88321','Ljubu??ki-Euroherc');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88322','Ljubu??ki-Op??ina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88223','Ljuti Dolac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74250','Maglaj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74216','Majevac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77235','Mala Kladu??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74418','Mala So??anica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75326','Male??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76208','Mao??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78223','Maslovare');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78410','Ma??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76271','Mati??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74203','Matuzi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88266','Me??ugorje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88267','Me??ugorje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88264','Me??ugorje-kiosk');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79247','Me??uvo??e');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72282','Mehuri??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80243','Mesihovina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75446','Mili??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74485','Milo??evac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73283','Miljeno');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73313','Miljevina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75329','Miri??ina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74480','Modri??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71428','Mokro');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89204','Mosko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88000','Mostar');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88101','Mostar');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88104','Mostar');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88105','Mostar-Avenija');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88107','Mostar-Balinovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88109','Mostar-Cim');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88123','Mostar-CIPS');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88122','Mostar-Euroherc');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88005','Mostar-Glavni telegraf');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88106','Mostar-Rodo??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88121','Mostar-MUP');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75212','Mramor');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73206','Mravinjac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70260','Mrkonji?? Grad');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78434','Naseobina Li??nja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72212','Nemila');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88390','Neum');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88280','Nevesinje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71383','Ni??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72276','Nova Bila');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75445','Nova Kasaba');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78418','Nova Topola');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79220','Novi Grad (Bosanski Novi)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74254','Novi ??eher');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72290','Novi Travnik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73110','Novo Gora??de');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78428','No??i??ko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70225','Oborci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76235','Obudovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76290','Od??ak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88285','Od??ak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71340','Olovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79203','Omarska');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79293','Opara');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78406','Orahova');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75323','Orahovica Donja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76270','Ora??je');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76281','Ora??je-Grani??ni');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80206','Orguz');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74412','Osinja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74225','Osje??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75406','Osmaci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88423','Ostro??ac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77228','Ostro??ac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76279','O??tra Luka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79263','O??tra Luka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77244','Otoka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72238','Ozimica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70243','Paji?? Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74255','Paklenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71420','Pale');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75453','Papra??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76315','Patkova??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71243','Pazari??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77227','Pe??igrad');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76256','Pelagi??evo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74317','Petrovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75412','Pilica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75248','Piperi');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78217','Piskavica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70275','Pljeva');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72252','Po??ulica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71425','Podgrab');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80209','Podhum');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71387','Podlugovi');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74217','Podnovlje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88403','Podora??ac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75355','Podora??je');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70266','Podra??nica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88206','Podvele??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77232','Podzvizd');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77209','Pokoj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75303','Poljice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88240','Posu??je');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88241','Posu??je-In??ilovi??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88242','Posu??je-Lager');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78216','Potkozarje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88208','Potoci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78435','Poto??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76298','Poto??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75433','Poto??ari');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73290','Pra??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73245','Prelovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79287','Previja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74276','Pribini??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75249','Priboj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79102','Prijedor');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80202','Priluka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80245','Prisoje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78430','Prnjavor');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74214','Prnjavor Mali');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88327','Prolog');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88440','Prozor');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76292','Prud');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70223','Prusac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71335','Pr??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72207','Puhovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75305','Pura??i??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88325','Radi??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75268','Rainci Gornji');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88245','Rakitno');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71217','Rakovica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88370','Ravno');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78249','Razboj Lijev??e Po??te Srpske');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76218','Ra??ljevo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79283','Ribnik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77215','Ripa??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73220','Rogatica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80247','Ro??ko Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79226','Rudice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73260','Rudo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88347','Ru??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79285','Sanica Gornja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79260','Sanski Most');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75411','Sapna');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78202','Sara??ica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71000','Sarajevo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71321','Semizovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76205','Seonjaci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75207','Simin Han');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78422','Sitne??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74212','Sjenina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75436','Skelani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74261','Skugri??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75353','Sladna');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78253','Slatina Ilid??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74323','So??kovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71350','Sokolac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71357','Sokolovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88345','Sovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78420','Srbac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75430','Srebrenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75350','Srebrenik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71385','Srednje (F BiH)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79249','Sreflije');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74208','Stanari');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78243','Stara Dubrava');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79268','Stari Majdan');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72251','Stari Vitez');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77224','Stijena');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73223','Stjenice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75324','Stjepan Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88360','Stolac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72209','Stranjani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78208','Stri??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70273','Strojice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88323','Studenci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75283','Stupari');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74221','Suho Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79229','Svodna');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76230','??amac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76209','??atorovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75450','??ekovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75275','??eri??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75245','??ibo??nica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78433','??ibovska');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70270','??ipovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78224','??iprage');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88220','??iroki Brijeg');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88221','??iroki Brijeg-ALTRA');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88222','??iroki Brijeg-Cips');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74279','??njegotina Gornja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75356','??pionica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77223','??turli??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80249','??ujica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77234','??umatac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71244','Tar??in');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75414','Teo??ak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74270','Tesli??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74260','Te??anj');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74266','Te??anjka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88348','Tihaljina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75357','Tinja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75455','Ti????a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73311','Tjenti??te');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77233','Todorovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75265','Toj??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76272','Tolisa');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80240','Tomislavgrad');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80241','Tomislavgrad-Op??ina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72213','Top??i?? Polje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70224','Torlakovac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72270','Travnik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88375','Trebinja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('89101','Trebinje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78252','Trn');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76335','Trnova Donja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71220','Trnovo');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76310','Trnjaci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77225','Tr??a??ka Ra??tela');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72283','Turbe');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75306','Turija');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78404','Turjak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75000','Tuzla');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76330','Ugljevik');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74278','Ugodnovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70280','Uskoplje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74321','Usora-Siv??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74230','Usora-??abljak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73250','Ustikolina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73265','Uvac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88444','Uzdol');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73249','Vardi??te');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71330','Vare??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71333','Vare?? Majdan');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77243','Varo??ka Rijeka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74213','Velika Bukovica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77207','Velika Gata');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77230','Velika Kladu??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76329','Velika Obarska');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70234','Vesela');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('80208','Vido??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76275','Vidovice');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('70202','Vinac');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74455','Vinska');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88247','Vir');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71300','Visoko');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73240','Vi??egrad');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88307','Vi??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72250','Vitez');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88326','Vitina');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74265','Vitkovci Donji');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73205','Vitkovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('75440','Vlasenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('71320','Vogo????a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88301','Vojarna Grabovine');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72227','Vozu??a');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74487','Vranjak 7');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74488','Vranjak 8');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88113','Vrap??i??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78211','Vrbanja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78225','Vrbanjci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78408','Vrba??ka');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('79262','Vrhpolje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77231','Vrnogra??');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77203','Vrsta');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76325','Vr??ani (Bijeljina)');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76254','Vu??kovci');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74470','Vukosavlje');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73287','Zaborak');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76333','Zabr??e');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('78214','Zalu??ani');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('73305','Zavajt');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72220','Zavidovi??i');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('74451','Zbori??te');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('77236','Zbori??te');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76259','Zelinja');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72101','Zenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72102','Zenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('72112','Zenica');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('88286','Zovi Do');
INSERT INTO `servisracunara`.`GRAD` (`PostanskiBrojGrada`,`NazivGrada`) VALUES ('76214','Zovik Gornji');

INSERT INTO `servisracunara`.`ULICA`(`PostanskiBrojGrada`,`NazivUlice`) VALUES('78000','Dusana Subotica');
INSERT INTO `servisracunara`.`ADRESA`(`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('78000','1','12');
INSERT INTO `servisracunara`.`PARTNER`(`Ime`,`email`,`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('Filip Adamovic','fadamovic@gmail.com','78000','1','12');
INSERT INTO `servisracunara`.`Telefon`(`BrojTelefona`,`IdPartnera`)VALUES('065/820-393','1');
INSERT INTO `servisracunara`.`Klijent`(`IdPartnera`,`BrojLicneKarte`,`JIB`)VALUES('1','756842319','');

INSERT INTO `servisracunara`.`ULICA`(`PostanskiBrojGrada`,`NazivUlice`) VALUES('78000','Josifa Pancica');
INSERT INTO `servisracunara`.`ADRESA`(`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('78000','2','4');
INSERT INTO `servisracunara`.`PARTNER`(`Ime`,`email`,`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('Ivan Kukavica','ivankukavica@gmail.com','78000','2','4');
INSERT INTO `servisracunara`.`Telefon`(`BrojTelefona`,`IdPartnera`)VALUES('065/165-759','2');
INSERT INTO `servisracunara`.`Klijent`(`IdPartnera`,`BrojLicneKarte`,`JIB`,`JestePravnoLice`)VALUES('2','','1568745936219','1');

INSERT INTO `servisracunara`.`ULICA`(`PostanskiBrojGrada`,`NazivUlice`) VALUES('78211','Hercegovacka');
INSERT INTO `servisracunara`.`ADRESA`(`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('78211','3','55');
INSERT INTO `servisracunara`.`PARTNER`(`Ime`,`email`,`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('Stanislav Panic','stanislav@gmail.com','78211','3','55');
INSERT INTO `servisracunara`.`Telefon`(`BrojTelefona`,`IdPartnera`)VALUES('065/811-141','3');
INSERT INTO `servisracunara`.`Radnik`(`IdPartnera`,`Uloga`,`Plata`,`VozackaDozvola`)VALUES('3','Serviser','900','C');

INSERT INTO `servisracunara`.`ULICA`(`PostanskiBrojGrada`,`NazivUlice`) VALUES('79102','Kozarska');
INSERT INTO `servisracunara`.`ADRESA`(`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('79102','4','19');
INSERT INTO `servisracunara`.`PARTNER`(`Ime`,`email`,`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('Danijel Basic','danijelb@gmail.com','79102','4','19');
INSERT INTO `servisracunara`.`Telefon`(`BrojTelefona`,`IdPartnera`)VALUES('065/129-734','4');
INSERT INTO `servisracunara`.`Radnik`(`IdPartnera`,`Uloga`,`Plata`,`VozackaDozvola`)VALUES('4','Sef Servisa','1100','B');

INSERT INTO `servisracunara`.`ULICA`(`PostanskiBrojGrada`,`NazivUlice`) VALUES('78000','Kuljanska');
INSERT INTO `servisracunara`.`ADRESA`(`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('78000','5','22');
INSERT INTO `servisracunara`.`PARTNER`(`Ime`,`email`,`PostanskiBrojGrada`,`IdUlice`,`KucniBroj`)VALUES('UNIS','UNIS@gmail.com','78000','5','22');
INSERT INTO `servisracunara`.`Telefon`(`BrojTelefona`,`IdPartnera`)VALUES('051/768-334','5');
INSERT INTO `servisracunara`.`Klijent`(`IdPartnera`,`BrojLicneKarte`,`JIB`,`JestePravnoLice`)VALUES('5','','4397645936219','1');

DROP VIEW IF EXISTS RADNIK_INFO;
CREATE VIEW RADNIK_INFO AS
SELECT P.IdPartnera,Ime,email,P.PostanskiBrojGrada,P.IdUlice,KucniBroj,Obrisan,Uloga,Plata,VozackaDozvola,NazivUlice,BrojTelefona
FROM ((Partner P inner join Radnik R on R.IdPartnera=P.IdPartnera) inner join Ulica U on P.IdUlice=U.IdUlice) inner join Telefon T on P.IdPartnera=T.IdPartnera;

DROP VIEW IF EXISTS KLIJENT_INFO;
CREATE VIEW KLIJENT_INFO AS
SELECT P.IdPartnera,Ime,email,P.PostanskiBrojGrada,P.IdUlice,KucniBroj,Obrisan,JIB,BrojLicneKarte,NazivUlice,BrojTelefona
FROM ((Partner P inner join Klijent K on K.IdPartnera=P.IdPartnera) inner join Ulica U on P.IdUlice=U.IdUlice) inner join Telefon T on P.IdPartnera=T.IdPartnera


