-- create database TelefonRehberi	(TelefonRehberi ad�nda DB olu�turuldu.)

-- use TelefonRehberi			    (Olu�turulan DB �zerinde i�lem yap�laca�� belirtildi.)
 
-- create table Kisiler(Ad varchar(20) NOT NULL, Soyad varchar(20) NOT NULL, Numara varchar(11) PRIMARY KEY NOT NULL) (Ad, Soyad, Numara s�tunlar�na sahip tablo olu�turuldu. Numara her bir ki�i i�in unique olaca�� i�in PRIMARY KEY olarak atand�.)

-- insert into Kisiler values('Murat','Kadak','05412697030'),('Ay�e','Bircen','05433018567'),('�zge','Nam','05289521124')
--						,('Selim','P�nar','05147365420'),('Cemil','Gedik','05223942852'),('Enes','G�ng�r','05324525846')   (Olu�turulan tabloya 6 farkl� de�er eklendi.)

-- update Kisiler set Numara = '05347226410' where Ad = 'Cemil' and Soyad = 'Gedik'   (Ad� 'Cemil' ve Soyad� 'Gedik' olan sat�rdaki Numara de�eri g�ncellendi.)

-- delete from Kisiler where Soyad = 'Kadak'  (Soyad� 'Kadak' olan kay�t silindi.)

-- select * from Kisiler  (Tablonun t�m� listelendi.)

-- select Ad from Kisiler where Soyad ='P�nar' (Soyad� 'P�nar' olanlar�n adlar�n� listeler. Bu �ekilde farkl� select kombinasyonlar� m�mk�n.)
