--USE [OKUL YONATIM]
--GO



create table Hocalar
(
HocaNo int primary key identity (1,1) not null,
Ad nvarchar(50) not null,
soyad nvarchar(50)not null,
unvan nvarchar(50) not null

)
create table Dersler_9
(
Derskodu int primary key,
DersAdı varchar(50),
Teorik int,
Uygulama int,
icerik varchar(100),
Hoca int references Hocalar(HocaNo)

)
create table Ogrenciler_9
(
OgrNo int Primary key,
Adı varchar(30),
Soyadı varchar(30),
Dtarihi date,
dyeri varchar(25) default ('Kahramanmaraş'),
Adres varchar(100)
)
create table Notlar_9
(
OgrNo int references Ogrenciler_9 (OgrNo),
Derskodu int references Dersler_9 (Derskodu),
Dersyılı date,
Vize int,
final int,
Butunleme int
)



create table Dersler_10
(
Derskodu int primary key,
DersAdı varchar(50),
Teorik int,
Uygulama int,
icerik varchar(100),
Hoca int references Hocalar(HocaNo)

)
create table Ogrenciler_10
(
OgrNo int Primary key,
Adı varchar(30),
Soyadı varchar(30),
Dtarihi date,
dyeri varchar(25) default ('Kahramanmaraş'),
Adres varchar(100)
)
create table Notlar_10
(
OgrNo int references Ogrenciler_10 (OgrNo),
Derskodu int references Dersler_10 (Derskodu),
Dersyılı date,
Vize int,
final int,
Butunleme int
)



create table Dersler_11
(
Derskodu int primary key,
DersAdı varchar(50),
Teorik int,
Uygulama int,
icerik varchar(100),
Hoca int references Hocalar(HocaNo)

)
create table Ogrenciler_11
(
OgrNo int Primary key,
Adı varchar(30),
Soyadı varchar(30),
Dtarihi date,
dyeri varchar(25) default ('Kahramanmaraş'),
Adres varchar(100)
)
create table Notlar_11
(
OgrNo int references Ogrenciler_11 (OgrNo),
Derskodu int references Dersler_11 (Derskodu),
Dersyılı date,
Vize int,
final int,
Butunleme int
)







create table Dersler_12
(
Derskodu int primary key,
DersAdı varchar(50),
Teorik int,
Uygulama int,
icerik varchar(100),
Hoca int references Hocalar(HocaNo)

)
create table Ogrenciler_12
(
OgrNo int Primary key,
Adı varchar(30),
Soyadı varchar(30),
Dtarihi date,
dyeri varchar(25) default ('Kahramanmaraş'),
Adres varchar(100)
)
create table Notlar_12
(
OgrNo int references Ogrenciler_12 (OgrNo),
Derskodu int references Dersler_12 (Derskodu),
Dersyılı date,
Vize int,
final int,
Butunleme int
)