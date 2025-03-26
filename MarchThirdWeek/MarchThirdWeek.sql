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
( 'Dr. Binay Bilgin �ensoy'),
( 'Bayan Ay�enur Laika T�rk'),
( 'Dr. Akise Demirel �hsano�lu'),
( 'Ya�ar Akar'),
( 'Rabih Hindal Mans�z'),
( 'Dr. Yadigar Veis �amurcuo�lu'),
( 'Nazende Ak�ay'),
( 'Dr. Nurseda �etin Karadeniz'),
( 'Do�annur Ak�ay'),
( 'Karaca G��l�er Demir');


INSERT INTO [dbo].[Publishers] ( Name) VALUES
( 'Durmu� Bilir A.�.'),
( 'F�rat Alemdar �ti.'),
( 'EnerjiSA'),
('Demir Yorulmaz A.�.'),
('Opet'),
('Dumanl� �calan �ti.'),
( 'Sakarya Ltd.'),
( 'T�rk Y�ld�r�m �ti.'),
( '�ener �ti.'),
( 'Sezer Yaman A.�.');


INSERT INTO [dbo].[Categories] (Name) VALUES
('Bilim Kurgu'),
('Tarih'),
('Roman'),
('Polisiye'),
('Fantastik'),
('Ki�isel Geli�im'),
('Psikoloji'),
('Edebiyat'),
('Felsefe'),
('Bilgisayar Bilimleri'),
('Macera');



INSERT INTO [dbo].[UserTypes] (Name) VALUES
('��renci'),
('Akademisyen'),
('Personel');


INSERT INTO [dbo].[Users] (TypeId, Name, Email, Phone, PasswordHash, PasswordSalt) VALUES
(1, 'Esra G�lsoy', 'esragulsoy@example.com', '05301234567', 0x01, 0x02),
(1, 'Bar�� Alt�n', 'baris.altin@example.com', '05312345678', 0x01, 0x02),
(1, 'Ay�eg�l Kara', 'aysegul.kara@example.com', '05323456789', 0x01, 0x02),

(2, 'Prof. Dr. Selim K�l��', 'selim.kilic@uni.edu.tr', '05334567890', 0x01, 0x02),
(2, 'Do�. Dr. Melike Arslan', 'melike.arslan@uni.edu.tr', '05345678901', 0x01, 0x02),
(2, 'Dr. Halit �zt�rk', 'halit.ozturk@uni.edu.tr', '05356789012', 0x01, 0x02),

(3, 'Zeynep Y�lmaz', 'zeynep.yilmaz@kurum.com', '05367890123', 0x01, 0x02),
(3, 'Onur G�ne�', 'onur.gunes@kurum.com', '05378901234', 0x01, 0x02),
(3, 'Murat Demir', 'murat.demir@kurum.com', '05389012345', 0x01, 0x02),
(3, 'Fatma Ko�', 'fatma.koc@kurum.com', '05390123456', 0x01, 0x02);


INSERT INTO [dbo].[BookLanguages] (Name) VALUES
('T�rk�e'),
('�ngilizce'),
('Frans�zca'),
('Almanca'),
('�spanyolca'),
('Arap�a'),
('Rus�a'),
('�ince'),
('Japonca'),
('�talyanca');


INSERT INTO [dbo].[BorrowStatues] (Name) VALUES
('Beklemede'),
('Teslim Edildi'),
('�ade Edildi'),
('Gecikti'),
('Kay�p');


INSERT INTO [dbo].[Books] (PublisherId, LanguageId, AuthorId, Title, Summary, PublishedYear, PageCount, CoverPath) VALUES
(1, 4, 3, 'Harry Potter ve Felsefe Ta��', 'Harry Potter, b�y�c� oldu�unu ��rendikten sonra Hogwarts Cad�l�k ve B�y�c�l�k Okulu''na ba�lar.', 1997, 223, '/covers/book1.jpg'),
(9, 8, 3, 'Su� ve Ceza', 'Raskolnikov adl� gen�, bir tefeci kad�n� �ld�r�r ve su�luluk duygusuyla y�zle�ir.', 1866, 671, '/covers/book2.jpg'),
(8, 9, 9, 'Sefiller', 'Jean Valjean��n topluma yeniden kazand�r�lma m�cadelesi anlat�l�r.', 1862, 1232, '/covers/book3.jpg'),
(8, 1, 6, 'Simyac�', 'Santiago adl� �oban�n, ki�isel menk�besinin pe�inden M�s�r piramitlerine yolculu�u.', 1988, 190, '/covers/book4.jpg'),
(7, 6, 7, 'Hayvan �iftli�i', 'Hayvanlar�n insanlara kar�� ayakland��� ve sonunda yine bir diktat�rl�k kurdu�u alegorik roman.', 1945, 112, '/covers/book5.jpg'),
(6, 7, 2, 'B�lb�l� �ld�rmek', 'Irk��l�k ve adalet temalar�n�n i�lendi�i, k���k bir k�z�n g�z�nden anlat�lan Amerikan G�neyi.', 1960, 281, '/covers/book6.jpg'),
(8, 5, 7, 'Y�z�klerin Efendisi', 'Frodo�nun Tek Y�z�k�� yok etmek i�in ��kt��� destans� Orta D�nya yolculu�u.', 1954, 1178, '/covers/book7.jpg'),
(6, 10, 8, 'K�rk Mantolu Madonna', 'Raif Efendi''nin Maria Puder�e duydu�u derin ve i�li a�k anlat�l�r.', 2024, 160, '/covers/book8.jpg'),
(8, 9, 7, 'U�urtma Avc�s�', 'Amir ve Hasan��n dostlu�u, ihanet ve kefaret temalar� e�li�inde anlat�l�r.', 2003, 371, '/covers/book9.jpg'),
(8, 5, 10, '1984', 'Totaliter bir rejim alt�nda bireysel �zg�rl�klerin yok olu�unu anlatan distopya.', 1949, 328, '/covers/book10.jpg'),
(1, 4, 3, 'Bilgisayar Bilimi 101', 'Bilgisayar Biliminin Temelleri', 2020, 223, '/covers/book11.jpg'),
(1, 4, 3, 'Bilgisayar Bilimi 202', 'Bilgisayar Biliminin Detaylar�', 2021, 278, '/covers/book12.jpg');


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



--Books tablosundaki t�m kitaplar� listeleyen sorguyu yaz�n�z.

SELECT * FROM Books

--Yaln�zca "Bilgisayar Bilimleri" kategorisindeki kitaplar� listeleyiniz.

SELECT *
FROM Books b
JOIN BookCategories bc ON b.Id = bc.BookId
WHERE bc.CategoryId = 11;

--2020 ve sonras�nda yay�mlanan kitaplar� listeleyiniz.

SELECT *
FROM Books
WHERE PublishedYear >= 2020;

--Her kitab�n ismini ve ait oldu�u kategoriyi listeleyen sorguyu yaz�n�z.

SELECT 
    b.Title AS Name,
    STRING_AGG(c.Name, ', ') AS Categories
FROM Books b
JOIN BookCategories bc ON b.Id = bc.BookId
JOIN Categories c ON bc.CategoryId = c.Id
GROUP BY b.Title;

--Kitap alan ��rencilerin ad�n�, soyad�n� ve kitap ad�n� listeleyiniz.

SELECT 
    u.Name AS Borrower,
    b.Title AS BookName
FROM Borrows br
JOIN Users u ON br.UserId = u.Id
JOIN Stocks s ON br.StockId = s.Id
JOIN Books b ON s.BookId = b.Id
WHERE u.TypeId = 1; 

--Her kitapla ili�kili yazar� ve yay�n y�l�n� listeleyiniz.

SELECT 
    b.Title AS BookName,
    a.Name AS AuthorName,
    b.PublishedYear AS PublishedYear
FROM Books b
JOIN Authors a ON b.AuthorId = a.Id;

--Hangi kullan�c� hangi kitab� ne zaman alm��? 

SELECT 
    u.Name AS Borrower,
    b.Title AS BookName,
    br.BorrowDate AS Date
FROM Borrows br
JOIN Users u ON br.UserId = u.Id
JOIN Stocks s ON br.StockId = s.Id
JOIN Books b ON s.BookId = b.Id;

--Geri d�n�� tarihi bo� olan kitaplar�n listesini ve kullan�c� bilgilerini getiriniz.

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

--Her kategoriye ait ka� kitap oldu�unu listeleyiniz.

SELECT 
    c.Name AS Name,
    COUNT(bc.BookId) AS BookCount
FROM Categories c
LEFT JOIN BookCategories bc ON c.Id = bc.CategoryId
GROUP BY c.Name;

--En �ok kitap �d�n� alan kullan�c�lar� en fazla bor� alandan az bor� alana g�re s�ralay�n�z

SELECT 
    u.Name AS Borrower,
    COUNT(br.Id) AS BorrowCount
FROM Borrows br
JOIN Users u ON br.UserId = u.Id
GROUP BY u.Name
ORDER BY BorrowCount DESC;

--A) ALTER TABLE kullan�m� Bir tabloya yeni s�tun nas�l eklenir? Bir s�tun nas�l de�i�tirilir?

-- Var olan tabloya yeni bir s�tun ekleme

--ALTER TABLE table_name
--ADD new_column_data_type;

-- Var olan s�tunu de�i�tirme

--ALTER TABLE table_name
--ALTER COLUMN new_column_data_type;



--B) UPDATE,DELETE kullan�m� Bu komutlar�n kullan�m� nas�ld�r? Ara�t�r�n�z.�rnekle a��klay�n�z.

--Tablo i�erisindeki veriyi de�i�tirme

--UPDATE table_name SET column_name = new_value WHERE condition; Where ko�ulu bulunmaz ise t�m veriler de�i�tirilir o s�tuna ait.

--DELETE FROM table_name WHERE condition; Where ko�ulu bulunmaz ise t�m tablo verileri silinir.

--C) INNER JOIN, LEFT JOIN, RIGHT JOIN, FULL JOIN farklar� Ayn� veride JOIN t�rlerine g�re farkl�l�klar� ara�t�r�n�z ve  �rnekle a��klay�n�z.

--INNER JOIN her iki tablo i�in e�le�en kay�tlar� getirir.

SELECT u.Name, b.Title
FROM Users u
INNER JOIN Borrows br ON u.Id = br.UserId
INNER JOIN Stocks s ON br.StockId = s.Id
INNER JOIN Books b ON s.BookId = b.Id;

--LEFT JOIN Soldaki tablodan t�m verileri sa�dakilerden ise e�le�enleri getirir, e�leme�me olmazsa sa�dan null veri gelir.

SELECT u.Name, b.Title
FROM Users u
LEFT JOIN Borrows br ON u.Id = br.UserId
LEFT JOIN Stocks s ON br.StockId = s.Id
LEFT JOIN Books b ON s.BookId = b.Id;

--RIGHT JOIN Sa�daki tablodan t�m verileri getirir soldakilerden ise e�le�enleri getirir.

SELECT u.Name, b.Title
FROM Books b
RIGHT JOIN Stocks s ON b.Id = s.BookId
RIGHT JOIN Borrows br ON s.Id = br.StockId
RIGHT JOIN Users u ON br.UserId = u.Id;


--JOIN her tablolunun t�m verilerini getirir e�le�enler yoksa null veri gelir.

SELECT u.Name, b.Title
FROM Users u
FULL JOIN Borrows br ON u.Id = br.UserId
FULL JOIN Stocks s ON br.StockId = s.Id
FULL JOIN Books b ON s.BookId = b.Id;


--D) HAVING ve GROUP BY birlikte nas�l kullan�l�r?

SELECT 
    u.Name AS Borrower,
    COUNT(br.Id) AS BorrowCount
FROM Users u
JOIN Borrows br ON u.Id = br.UserId
GROUP BY u.Name
HAVING COUNT(br.Id) >= 2;


--E) TOP, OFFSET-FETCH kullanarak s�ral� veri �ekme (ilk 5 kitap gibi)

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


--F) SUBQUERY �rnekleri � alt sorgu kullanarak kitap veya kullan�c� bilgisi getirme


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

--G) AND / OR mant�ksal operat�rleri ne i�e yarar? Ko�ullu sorgularda nas�l kullan�l�r?

-- AND ile birlikte t�m ko�ullar do�ruysa sonu� d�ner or ile birlikte t�m ko�ullar�n do�rulu�una gerek olmaz.

SELECT * FROM Books
WHERE PublishedYear > 2010 AND PageCount > 300;

SELECT * FROM Books
WHERE Title = 'Simyac�' OR Title = '1984';

--H) BETWEEN ile aral�k filtrelemesi nas�l yap�l�r? �rnek: 2020 ile 2023 aras� kitaplar.

SELECT Title, PublishedYear
FROM Books
WHERE PublishedYear BETWEEN 1980 AND 2023;

-- I) IN ifadesiyle �oklu de�er kar��la�t�rmas� nas�l yap�l�r? �rnek: Belirli kategorilerdeki kitaplar

SELECT Title
FROM Books
WHERE Id IN (
    SELECT BookId
    FROM BookCategories
    WHERE CategoryId IN (1, 3, 5)
);

-- J) LIKE operat�r� nedir? '%' ve '_' karakterleriyle nas�l kullan�l�r? �rneklerle a��klay�n�z.

-- LIKE operat�r� metinsel veriler i�erisinde belli bir pattern d�zen'e g�re i�lem yapmak i�ni kullan�l�r.

--A ile ba�layan kullan�c�lar� getirir.
SELECT * FROM Users
WHERE Name LIKE 'A%';

--��erisinde bilgisayar kelimesi ge�en kitaplar� getirir.

SELECT * FROM Books
WHERE Title LIKE '%Bilgisayar%';

--D�rt karakter uzunlu�unda kitap ad�na sahip kitaplar� getirir.
SELECT * FROM Books
WHERE Title LIKE '____';
