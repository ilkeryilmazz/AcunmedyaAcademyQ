Create Database LibraryManagementDb

Use LibraryManagementDb

Create Table Authors(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50)
);

Create Table Categories(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50)
);

Create Table Publishers(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50)
);

Create Table BookLanguages(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50)
);

Create Table Books(
	Id INT PRIMARY KEY IDENTITY(1,1),
	PublisherId INT FOREIGN KEY (PublisherId) REFERENCES Publishers(Id),
	LanguageId INT FOREIGN KEY (LanguageId) REFERENCES BookLanguages(Id),
	AuthorId INT FOREIGN KEY (AuthorId) REFERENCES Authors(Id),
	Title VARCHAR(100),
	Summary VARCHAR(550),
	PublishedYear INT,
	PageCount INT,
	CoverPath VARCHAR(100),
);


Create Table BookCategories(
	Id INT PRIMARY KEY IDENTITY(1,1),
	BookId INT FOREIGN KEY (BookId) REFERENCES Books(Id),
	CategoryId INT FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);


Create Table Stocks(
	Id INT PRIMARY KEY IDENTITY(1,1),
	BookId INT FOREIGN KEY (BookId) REFERENCES Books(Id),
	StockNumber INT,
	IsAvailable bit,
);


Create Table BorrowStatues(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50)
);

Create Table UserTypes(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50)
);

Create Table Users(
	Id INT PRIMARY KEY IDENTITY(1,1),
	TypeId INT FOREIGN KEY (TypeId) REFERENCES UserTypes(Id),
	Name VARCHAR(50),
	Email VARCHAR(150),
	Phone VARCHAR(11),
	PasswordHash BINARY,
	PasswordSalt BINARY,
);

Create Table Borrows(
	Id INT PRIMARY KEY IDENTITY(1,1),
	UserId INT FOREIGN KEY (UserId) REFERENCES Users(Id),
	StockId INT FOREIGN KEY (StockId) REFERENCES Stocks(Id),
	StatusId INT FOREIGN KEY (StatusId) REFERENCES BorrowStatues(Id),
	BorrowDate date,
	ReturnDate date,
	ActualReturnDate date
);

INSERT INTO [dbo].[Authors] ( Name) VALUES
( 'Dr. Binay Bilgin Þensoy'),
( 'Bayan Ayþenur Laika Türk'),
( 'Dr. Akise Demirel Ýhsanoðlu'),
( 'Yaþar Akar'),
( 'Rabih Hindal Mansýz'),
( 'Dr. Yadigar Veis Çamurcuoðlu'),
( 'Nazende Akçay'),
( 'Dr. Nurseda Çetin Karadeniz'),
( 'Doðannur Akçay'),
( 'Karaca Güçlüer Demir');


INSERT INTO [dbo].[Publishers] ( Name) VALUES
( 'Durmuþ Bilir A.Þ.'),
( 'Fýrat Alemdar Þti.'),
( 'EnerjiSA'),
('Demir Yorulmaz A.Þ.'),
('Opet'),
('Dumanlý Öcalan Þti.'),
( 'Sakarya Ltd.'),
( 'Türk Yýldýrým Þti.'),
( 'Þener Þti.'),
( 'Sezer Yaman A.Þ.');


INSERT INTO [dbo].[Categories] (Name) VALUES
('Bilim Kurgu'),
('Tarih'),
('Roman'),
('Polisiye'),
('Fantastik'),
('Kiþisel Geliþim'),
('Psikoloji'),
('Edebiyat'),
('Felsefe'),
('Bilgisayar Bilimleri'),
('Macera');



INSERT INTO [dbo].[UserTypes] (Name) VALUES
('Öðrenci'),
('Akademisyen'),
('Personel');


INSERT INTO [dbo].[Users] (TypeId, Name, Email, Phone, PasswordHash, PasswordSalt) VALUES
(1, 'Esra Gülsoy', 'esragulsoy@example.com', '05301234567', 0x01, 0x02),
(1, 'Barýþ Altýn', 'baris.altin@example.com', '05312345678', 0x01, 0x02),
(1, 'Ayþegül Kara', 'aysegul.kara@example.com', '05323456789', 0x01, 0x02),

(2, 'Prof. Dr. Selim Kýlýç', 'selim.kilic@uni.edu.tr', '05334567890', 0x01, 0x02),
(2, 'Doç. Dr. Melike Arslan', 'melike.arslan@uni.edu.tr', '05345678901', 0x01, 0x02),
(2, 'Dr. Halit Öztürk', 'halit.ozturk@uni.edu.tr', '05356789012', 0x01, 0x02),

(3, 'Zeynep Yýlmaz', 'zeynep.yilmaz@kurum.com', '05367890123', 0x01, 0x02),
(3, 'Onur Güneþ', 'onur.gunes@kurum.com', '05378901234', 0x01, 0x02),
(3, 'Murat Demir', 'murat.demir@kurum.com', '05389012345', 0x01, 0x02),
(3, 'Fatma Koç', 'fatma.koc@kurum.com', '05390123456', 0x01, 0x02);


INSERT INTO [dbo].[BookLanguages] (Name) VALUES
('Türkçe'),
('Ýngilizce'),
('Fransýzca'),
('Almanca'),
('Ýspanyolca'),
('Arapça'),
('Rusça'),
('Çince'),
('Japonca'),
('Ýtalyanca');


INSERT INTO [dbo].[BorrowStatues] (Name) VALUES
('Beklemede'),
('Teslim Edildi'),
('Ýade Edildi'),
('Gecikti'),
('Kayýp');


INSERT INTO [dbo].[Books] (PublisherId, LanguageId, AuthorId, Title, Summary, PublishedYear, PageCount, CoverPath) VALUES
(1, 4, 3, 'Harry Potter ve Felsefe Taþý', 'Harry Potter, büyücü olduðunu öðrendikten sonra Hogwarts Cadýlýk ve Büyücülük Okulu''na baþlar.', 1997, 223, '/covers/book1.jpg'),
(9, 8, 3, 'Suç ve Ceza', 'Raskolnikov adlý genç, bir tefeci kadýný öldürür ve suçluluk duygusuyla yüzleþir.', 1866, 671, '/covers/book2.jpg'),
(8, 9, 9, 'Sefiller', 'Jean Valjean’ýn topluma yeniden kazandýrýlma mücadelesi anlatýlýr.', 1862, 1232, '/covers/book3.jpg'),
(8, 1, 6, 'Simyacý', 'Santiago adlý çobanýn, kiþisel menkýbesinin peþinden Mýsýr piramitlerine yolculuðu.', 1988, 190, '/covers/book4.jpg'),
(7, 6, 7, 'Hayvan Çiftliði', 'Hayvanlarýn insanlara karþý ayaklandýðý ve sonunda yine bir diktatörlük kurduðu alegorik roman.', 1945, 112, '/covers/book5.jpg'),
(6, 7, 2, 'Bülbülü Öldürmek', 'Irkçýlýk ve adalet temalarýnýn iþlendiði, küçük bir kýzýn gözünden anlatýlan Amerikan Güneyi.', 1960, 281, '/covers/book6.jpg'),
(8, 5, 7, 'Yüzüklerin Efendisi', 'Frodo’nun Tek Yüzük’ü yok etmek için çýktýðý destansý Orta Dünya yolculuðu.', 1954, 1178, '/covers/book7.jpg'),
(6, 10, 8, 'Kürk Mantolu Madonna', 'Raif Efendi''nin Maria Puder’e duyduðu derin ve içli aþk anlatýlýr.', 2024, 160, '/covers/book8.jpg'),
(8, 9, 7, 'Uçurtma Avcýsý', 'Amir ve Hasan’ýn dostluðu, ihanet ve kefaret temalarý eþliðinde anlatýlýr.', 2003, 371, '/covers/book9.jpg'),
(8, 5, 10, '1984', 'Totaliter bir rejim altýnda bireysel özgürlüklerin yok oluþunu anlatan distopya.', 1949, 328, '/covers/book10.jpg'),
(1, 4, 3, 'Bilgisayar Bilimi 101', 'Bilgisayar Biliminin Temelleri', 2020, 223, '/covers/book11.jpg'),
(1, 4, 3, 'Bilgisayar Bilimi 202', 'Bilgisayar Biliminin Detaylarý', 2021, 278, '/covers/book12.jpg');


INSERT INTO [dbo].[BookCategories] (BookId, CategoryId) VALUES
( 1, 4),
( 1, 10),
( 2, 3),
( 3, 2),
( 3, 5),
( 4, 8),
( 5, 5),
( 5, 4),
( 6, 8),
( 6, 2),
( 7, 1),
( 8, 10),
( 9, 2),
( 9, 9),
( 10, 9),
( 11, 11),
( 12, 11),
( 10, 7);


INSERT INTO [dbo].[Stocks] (BookId, StockNumber, IsAvailable) VALUES
(1, 1001, 1),
(1, 1002, 1),
(2, 1003, 1),
(3, 1004, 1),
(4, 1005, 0),
(4, 1006, 1),
(4, 1007, 0),
(5, 1008, 0),
(5, 1009, 1),
(5, 1010, 0),
(6, 1011, 0),
(7, 1012, 1),
(7, 1013, 1),
(8, 1014, 1),
(8, 1015, 1),
(9, 1016, 0),
(9, 1017, 0),
(9, 1018, 1),
(10, 1019, 1),
(10, 1020, 1),
(11, 1022, 1),
(12, 1023, 1),
(10, 1021, 1);


INSERT INTO [dbo].[Borrows] (UserId, StockId, StatusId, BorrowDate, ReturnDate, ActualReturnDate) VALUES
(4, 1, 1, '2025-02-13', '2025-02-14', NULL),
(5, 2, 3, '2025-02-17', '2025-02-19', '2025-02-19'),
(5, 3, 4, '2025-02-23', '2025-03-20', NULL),
(10, 4, 5, '2025-02-20', '2025-03-05', NULL),
(6, 6, 3, '2025-01-27', '2025-02-17', '2025-02-17'),
(5, 9, 2, '2025-01-26', '2025-02-26', '2025-02-26'),
(8, 12, 3, '2025-02-01', '2025-02-19', '2025-02-19'),
(3, 13, 3, '2025-02-17', '2025-03-08', '2025-03-08'),
(7, 14, 3, '2025-02-05', '2025-03-03', '2025-03-03'),
(1, 15, 1, '2025-02-09', '2025-02-24', NULL);



--Books tablosundaki tüm kitaplarý listeleyen sorguyu yazýnýz.

SELECT * FROM Books

--Yalnýzca "Bilgisayar Bilimleri" kategorisindeki kitaplarý listeleyiniz.

SELECT *
FROM Books b
JOIN BookCategories bc ON b.Id = bc.BookId
WHERE bc.CategoryId = 11;

--2020 ve sonrasýnda yayýmlanan kitaplarý listeleyiniz.

SELECT *
FROM Books
WHERE PublishedYear >= 2020;

--Her kitabýn ismini ve ait olduðu kategoriyi listeleyen sorguyu yazýnýz.

SELECT 
    b.Title AS Name,
    STRING_AGG(c.Name, ', ') AS Categories
FROM Books b
JOIN BookCategories bc ON b.Id = bc.BookId
JOIN Categories c ON bc.CategoryId = c.Id
GROUP BY b.Title;

--Kitap alan öðrencilerin adýný, soyadýný ve kitap adýný listeleyiniz.

SELECT 
    u.Name AS Borrower,
    b.Title AS BookName
FROM Borrows br
JOIN Users u ON br.UserId = u.Id
JOIN Stocks s ON br.StockId = s.Id
JOIN Books b ON s.BookId = b.Id
WHERE u.TypeId = 1; 

--Her kitapla iliþkili yazarý ve yayýn yýlýný listeleyiniz.

SELECT 
    b.Title AS BookName,
    a.Name AS AuthorName,
    b.PublishedYear AS PublishedYear
FROM Books b
JOIN Authors a ON b.AuthorId = a.Id;

--Hangi kullanýcý hangi kitabý ne zaman almýþ? 

SELECT 
    u.Name AS Borrower,
    b.Title AS BookName,
    br.BorrowDate AS Date
FROM Borrows br
JOIN Users u ON br.UserId = u.Id
JOIN Stocks s ON br.StockId = s.Id
JOIN Books b ON s.BookId = b.Id;

--Geri dönüþ tarihi boþ olan kitaplarýn listesini ve kullanýcý bilgilerini getiriniz.

SELECT 
    u.Name AS Borrower,
    b.Title AS BookName,
    br.BorrowDate AS BorrowedDate,
    br.ReturnDate AS DueDate
FROM Borrows br
JOIN Users u ON br.UserId = u.Id
JOIN Stocks s ON br.StockId = s.Id
JOIN Books b ON s.BookId = b.Id
WHERE br.ActualReturnDate IS NULL;

--Her kategoriye ait kaç kitap olduðunu listeleyiniz.

SELECT 
    c.Name AS Name,
    COUNT(bc.BookId) AS BookCount
FROM Categories c
LEFT JOIN BookCategories bc ON c.Id = bc.CategoryId
GROUP BY c.Name;

--En çok kitap ödünç alan kullanýcýlarý en fazla borç alandan az borç alana göre sýralayýnýz

SELECT 
    u.Name AS Borrower,
    COUNT(br.Id) AS BorrowCount
FROM Borrows br
JOIN Users u ON br.UserId = u.Id
GROUP BY u.Name
ORDER BY BorrowCount DESC;

--A) ALTER TABLE kullanýmý Bir tabloya yeni sütun nasýl eklenir? Bir sütun nasýl deðiþtirilir?

-- Var olan tabloya yeni bir sütun ekleme

--ALTER TABLE table_name
--ADD new_column_data_type;

-- Var olan sütunu deðiþtirme

--ALTER TABLE table_name
--ALTER COLUMN new_column_data_type;



--B) UPDATE,DELETE kullanýmý Bu komutlarýn kullanýmý nasýldýr? Araþtýrýnýz.Örnekle açýklayýnýz.

--Tablo içerisindeki veriyi deðiþtirme

--UPDATE table_name SET column_name = new_value WHERE condition; Where koþulu bulunmaz ise tüm veriler deðiþtirilir o sütuna ait.

--DELETE FROM table_name WHERE condition; Where koþulu bulunmaz ise tüm tablo verileri silinir.

--C) INNER JOIN, LEFT JOIN, RIGHT JOIN, FULL JOIN farklarý Ayný veride JOIN türlerine göre farklýlýklarý araþtýrýnýz ve  örnekle açýklayýnýz.

--INNER JOIN her iki tablo için eþleþen kayýtlarý getirir.

SELECT u.Name, b.Title
FROM Users u
INNER JOIN Borrows br ON u.Id = br.UserId
INNER JOIN Stocks s ON br.StockId = s.Id
INNER JOIN Books b ON s.BookId = b.Id;

--LEFT JOIN Soldaki tablodan tüm verileri saðdakilerden ise eþleþenleri getirir, eþlemeþme olmazsa saðdan null veri gelir.

SELECT u.Name, b.Title
FROM Users u
LEFT JOIN Borrows br ON u.Id = br.UserId
LEFT JOIN Stocks s ON br.StockId = s.Id
LEFT JOIN Books b ON s.BookId = b.Id;

--RIGHT JOIN Saðdaki tablodan tüm verileri getirir soldakilerden ise eþleþenleri getirir.

SELECT u.Name, b.Title
FROM Books b
RIGHT JOIN Stocks s ON b.Id = s.BookId
RIGHT JOIN Borrows br ON s.Id = br.StockId
RIGHT JOIN Users u ON br.UserId = u.Id;


--JOIN her tablolunun tüm verilerini getirir eþleþenler yoksa null veri gelir.

SELECT u.Name, b.Title
FROM Users u
FULL JOIN Borrows br ON u.Id = br.UserId
FULL JOIN Stocks s ON br.StockId = s.Id
FULL JOIN Books b ON s.BookId = b.Id;


--D) HAVING ve GROUP BY birlikte nasýl kullanýlýr?

SELECT 
    u.Name AS Borrower,
    COUNT(br.Id) AS BorrowCount
FROM Users u
JOIN Borrows br ON u.Id = br.UserId
GROUP BY u.Name
HAVING COUNT(br.Id) >= 2;


--E) TOP, OFFSET-FETCH kullanarak sýralý veri çekme (ilk 5 kitap gibi)

SELECT Title
FROM Books
ORDER BY Id
OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY;


SELECT TOP 5 Title
FROM Books;

SELECT Title
FROM Books
ORDER BY Title
OFFSET 0 ROWS
FETCH NEXT 5 ROWS ONLY;


--F) SUBQUERY örnekleri – alt sorgu kullanarak kitap veya kullanýcý bilgisi getirme


SELECT Title
FROM Books
WHERE Id IN (
    SELECT BookId
    FROM BookCategories
    WHERE CategoryId = (
        SELECT Id
        FROM Categories
        WHERE Name = 'Bilgisayar Bilimleri'
    )
);

SELECT Name
FROM Users
WHERE Id IN (
    SELECT DISTINCT UserId
    FROM Borrows
);

--G) AND / OR mantýksal operatörleri ne iþe yarar? Koþullu sorgularda nasýl kullanýlýr?

-- AND ile birlikte tüm koþullar doðruysa sonuç döner or ile birlikte tüm koþullarýn doðruluðuna gerek olmaz.

SELECT * FROM Books
WHERE PublishedYear > 2010 AND PageCount > 300;

SELECT * FROM Books
WHERE Title = 'Simyacý' OR Title = '1984';

--H) BETWEEN ile aralýk filtrelemesi nasýl yapýlýr? Örnek: 2020 ile 2023 arasý kitaplar.

SELECT Title, PublishedYear
FROM Books
WHERE PublishedYear BETWEEN 1980 AND 2023;

-- I) IN ifadesiyle çoklu deðer karþýlaþtýrmasý nasýl yapýlýr? Örnek: Belirli kategorilerdeki kitaplar

SELECT Title
FROM Books
WHERE Id IN (
    SELECT BookId
    FROM BookCategories
    WHERE CategoryId IN (1, 3, 5)
);

-- J) LIKE operatörü nedir? '%' ve '_' karakterleriyle nasýl kullanýlýr? Örneklerle açýklayýnýz.

-- LIKE operatörü metinsel veriler içerisinde belli bir pattern düzen'e göre iþlem yapmak içni kullanýlýr.

--A ile baþlayan kullanýcýlarý getirir.
SELECT * FROM Users
WHERE Name LIKE 'A%';

--Ýçerisinde bilgisayar kelimesi geçen kitaplarý getirir.

SELECT * FROM Books
WHERE Title LIKE '%Bilgisayar%';

--Dört karakter uzunluðunda kitap adýna sahip kitaplarý getirir.
SELECT * FROM Books
WHERE Title LIKE '____';
