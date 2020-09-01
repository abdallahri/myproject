
ALTER TABLE Notlar_9
DROP COLUMN [Yil Sonu Notu];


ALTER TABLE Notlar_9
ADD [Yil Sonu Notu] as [1.Dönem Notu] + [2.Dönem Notu] / 2 ;