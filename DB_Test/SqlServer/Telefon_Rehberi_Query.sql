-- create database TelefonRehberi	(TelefonRehberi adýnda DB oluþturuldu.)

-- use TelefonRehberi			    (Oluþturulan DB üzerinde iþlem yapýlacaðý belirtildi.)
 
-- create table Kisiler(Ad varchar(20) NOT NULL, Soyad varchar(20) NOT NULL, Numara varchar(11) PRIMARY KEY NOT NULL) (Ad, Soyad, Numara sütunlarýna sahip tablo oluþturuldu. Numara her bir kiþi için unique olacaðý için PRIMARY KEY olarak atandý.)

-- insert into Kisiler values('Murat','Kadak','05412697030'),('Ayþe','Bircen','05433018567'),('Özge','Nam','05289521124')
--						,('Selim','Pýnar','05147365420'),('Cemil','Gedik','05223942852'),('Enes','Güngör','05324525846')   (Oluþturulan tabloya 6 farklý deðer eklendi.)

-- update Kisiler set Numara = '05347226410' where Ad = 'Cemil' and Soyad = 'Gedik'   (Adý 'Cemil' ve Soyadý 'Gedik' olan satýrdaki Numara deðeri güncellendi.)

-- delete from Kisiler where Soyad = 'Kadak'  (Soyadý 'Kadak' olan kayýt silindi.)

-- select * from Kisiler  (Tablonun tümü listelendi.)

-- select Ad from Kisiler where Soyad ='Pýnar' (Soyadý 'Pýnar' olanlarýn adlarýný listeler. Bu þekilde farklý select kombinasyonlarý mümkün.)
