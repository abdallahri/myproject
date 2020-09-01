--create database okul_db
--use okul
--go
--create table sinav9
--(Id int primary key identity(1,1) not null,
--O_No nvarchar(10) not null,
--O_Ad nvarchar(25) not null,
--O_Soyad nvarchar(25) not null,
--O_babasi nvarchar(25) not null,
--O_Telefon nvarchar(11) not null,
--O_Adres nvarchar(50) not null
--)

--create table sinav10
--(Id int primary key identity(1,1) not null,
--O_No nvarchar(10) not null,
--O_Ad nvarchar(25) not null,
--O_Soyad nvarchar(25) not null,
--O_babasi nvarchar(25) not null,
--O_Telefon nvarchar(11) not null,
--O_Adres nvarchar(50) not null
--)

--create table sinav11
--(Id int primary key identity(1,1) not null,
--O_No nvarchar(10) not null,
--O_Ad nvarchar(25) not null,
--O_Soyad nvarchar(25) not null,
--O_babasi nvarchar(25) not null,
--O_Telefon nvarchar(11) not null,
--O_Adres nvarchar(50) not null
--)

--create table sinav12
--(Id int primary key identity(1,1) not null,
--O_No nvarchar(10) not null,
--O_Ad nvarchar(25) not null,
--O_Soyad nvarchar(25) not null,
--O_babasi nvarchar(25) not null,
--O_Telefon nvarchar(11) not null,
--O_Adres nvarchar(50) not null
--)
--ALTER TABLE sinav12
--ADD O_Resim  image ;
create table notlar
(
Ogrenci_no references sinif9(Id 

)

--EXEC sp_rename 'sinav12', 'sinif12';
--EXEC sp_rename 'sinav9', 'sinif9';
--EXEC sp_rename 'sinav10', 'sinif10';
--EXEC sp_rename 'sinav11', 'sinif11';

--create table ogretmenler
--(ID int primary key identity(1,1) not null,
--Adi nvarchar(25) not null,
--Ad nvarchar(25) not null,
--ders_Adi nvarchar(50) not null,
--ders_saati time)