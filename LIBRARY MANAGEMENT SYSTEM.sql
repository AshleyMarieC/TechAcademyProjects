
/*CREATE DATABASE*/
CREATE Database db_LibraryMS

USE db_LibraryMS;

/*CREATE TABLES*/

CREATE TABLE Book (
	BookID INT IDENTITY(100,1) Primary Key NOT NULL,
	Title VARCHAR (100) NULL,
	PublisherName VARCHAR(150)
	FOREIGN KEY (PublisherName) REFERENCES Publisher(Name) 
	);

SELECT * FROM Book;


CREATE TABLE Publisher (
	Name VARCHAR (150) Primary Key NOT NULL,
	Address VARCHAR (150) NULL,
	Phone VARCHAR (50) NULL,
);

SELECT * FROM Publisher;

CREATE TABLE Book_Authors (
	AuthorName VARCHAR (150) NULL,
	BookID INT
	FOREIGN KEY (BookID) REFERENCES Book(BookID) 
	);

SELECT * FROM Book_Authors;

CREATE TABLE Library_Branch (
	BranchID INT IDENTITY(10,1) Primary Key NOT NULL,
	BranchName VARCHAR (150) NULL,
	Address VARCHAR (500) NULL,
);

SELECT * FROM Library_Branch;

CREATE TABLE Book_Copies(
	BookID INT
	FOREIGN KEY (BookID) REFERENCES Book(BookID), 
	BranchID INT
	FOREIGN KEY (BranchID) REFERENCES Library_Branch(BranchID), 
	No_Of_Copies INT NULL
);

SELECT * FROM Book_Copies;

CREATE TABLE Borrower (
	CardNo INT IDENTITY (23,1) PRIMARY KEY,
	Name VARCHAR (150) NOT NULL,
	Address VARCHAR (150) NULL,
	Phone VARCHAR (50) NULL,
);

SELECT * FROM Borrower;

CREATE TABLE Book_Loans(
	BookID INT
	FOREIGN KEY (BookID) REFERENCES Book(BookID), 
	BranchID INT
	FOREIGN KEY (BranchID) REFERENCES Library_Branch(BranchID),
	CardNo INT 
	FOREIGN KEY (CardNo) REFERENCES Borrower(CardNo),
	DateOut DATE NULL,
	DueDate DATE NULL,
);

SELECT * FROM Book_Loans;


/*Add Info to Tables*/
INSERT INTO Book 
VALUES 
('Harry Potter Year 7','Penguin'),
 ('Hello World!','Random House'),
 ('The Wizzard of Oz','Penguin'),
 ('Harry Potter Year 1','Penguin'),
 ('Harry Potter Year 2','Penguin'),
 ('Harry Potter Year 3','Penguin'),
 ('Harry Potter Year 4','Penguin'),
 ('Harry Potter Year 5','Penguin'),
 ('Harry Potter Year 6','Penguin'),
 ('My Life','Penguin'),
 ('The Little Mermaid','Penguin'),
 ('Misery','Hachette'),
 ('The Shining','Simon and Schuster'),
 ('IT','Hachette'),
 ('The Great Gatsby','Random House'),
 ('To Kill A Mockingbird','Hachette'),
 ('Alice In Wonderland','HarperCollins'),
 ('Lord of the Flies','HarperCollins'),
 ('The Lord of The Rings','Random House'),
 ('Game of Thrones','Simon and Schuster');

UPDATE Book
SET Title = 'The Lost Tribe'
WHERE BookID = 164;

INSERT INTO Library_Branch
Values 
('Sharpstown','125 Sharp Street'), 
('Central','256 Central Plaza'), 
('King','1456 King Court N.'), 
('Madina','23 Madina Plaza South');


 INSERT INTO Publisher
 VALUES 
 ('Penguin', 'New York', '785-896-9856'),
 ('Random House', 'New York', '456-123-7898'),
 ('Simon and Schuster', 'New York', '785-456-9856'),
 ('HarperCollins', 'LA', '258-896-9856'),
 ('Hachette', 'Seattle', '206-896-9856');

 INSERT INTO Book_Authors
 VALUES 
 ('Stephen King','157'), 
 ('Stephen King','158'),
 ('Stephen King','159'),
 ('J.K Rowling','149'),
 ('J.K Rowling','150'), 
 ('J.K Rowling','151'), 
 ('J.K Rowling','152'), 
 ('J.K Rowling','153'), 
 ('J.K Rowling','154'), 
 ('Ashley C','155'),  
 ('William Golding','163'), 
 ('Lewis Carroll','162'), 
 ('Tolkin','165'),
 ('Harper Lee','161'),
 ('Fitzgerald','160'),
 ('Tech Academy','147'),
 ('Mark Lee','164');

 INSERT INTO Book_Copies
 VALUES 
 ('147','22','14'),
 ('148','22','9'),
 ('149','22','25'),
 ('150','22','15'),
 ('151','22','10'),
 ('152','22','4'),
 ('153','22','15'),
 ('154','22','6'),
 ('155','22','30'),
 ('156','22','35'),
 ('157','23','10'),
 ('158','23','10'),
 ('159','23','10'),
 ('160','23','10'),
 ('161','23','10'),
 ('162','23','30'),
 ('163','23','20'),
 ('164','23','10'),
 ('165','23','10'),
 ('166','23','10'),
 ('147','24','14'),
 ('148','24','9'),
 ('149','24','25'),
 ('150','24','15'),
 ('151','24','10'),
 ('152','24','4'),
 ('153','24','15'),
 ('154','24','6'),
 ('155','24','30'),
 ('156','24','35'),
 ('157','25','10'),
 ('158','25','10'),
 ('159','25','10'),
 ('160','25','10'),
 ('161','25','10'),
 ('162','25','30'),
 ('163','25','20'),
 ('164','25','10'),
 ('165','25','10'),
 ('166','25','10');


INSERT INTO Borrower
VALUES
('Sam','123 Green St.','425-698-9586'),
('Suzie','123 Blue St.','586-957-8569'),
('Ashley','253 Apple St.','425-698-9586'),
('Jim','586 Cherry Tree St.','425-698-9586'),
('Pam','586 Cherry Tree St.','425-698-9586'),
('Dwight','23 Beet St.','425-698-9586'),
('Michael','45 Purple Lane','425-698-9586'),
('Angela','586 Office Circle','425-698-9586');

INSERT INTO Book_Loans
VALUES
('147','22','75','3/10/18','3/30/18'),
('148','22','75','3/10/18','3/30/18'),
('149','22','75','3/10/18','3/30/18'),
('150','22','75','3/10/18','3/30/18'),
('151','22','75','3/10/18','3/30/18'),

('161','25','76','3/10/18','3/30/18'),
('160','25','76','3/10/18','3/30/18'),
('159','25','76','3/10/18','3/30/18'),
('158','25','76','3/10/18','3/30/18'),
('157','23','76','3/10/18','3/30/18'),

('161','25','77','3/10/18','3/30/18'),
('160','25','77','3/10/18','3/30/18'),
('159','25','77','3/10/18','3/30/18'),
('158','25','77','3/10/18','3/30/18'),
('158','25','77','3/10/18','3/30/18'),

('147','22','77','3/10/18','3/30/18'),
('148','22','77','3/10/18','3/30/18'),
('149','22','77','3/10/18','3/30/18'),
('150','22','77','3/10/18','3/30/18'),
('151','22','77','3/10/18','3/30/18'),

('147','22','71','1/8/18','1/18/18'),
('148','22','71','1/8/18','1/18/18'),
('149','22','71','1/8/18','1/18/18'),
('150','22','71','1/8/18','1/18/18'),
('151','22','71','1/8/18','1/18/18'),
('152','22','71','1/8/18','1/18/18'),

('148','24','72','3/8/18','3/18/18'),
('149','24','72','3/8/18','3/18/18'),
('150','24','72','3/8/18','3/18/18'),
('151','24','72','3/8/18','3/18/18'),
('152','24','72','3/8/18','3/18/18'),
('153','24','72','3/8/18','3/18/18'),
('154','24','72','3/8/18','3/18/18'),
('155','24','72','3/8/18','3/18/18'),
('156','24','72','3/8/18','3/18/18'),


('166','25','74','3/10/18','3/30/18'),
('165','25','74','3/10/18','3/30/18'),
('164','25','74','3/10/18','3/30/18'),
('163','25','74','3/10/18','3/30/18'),
('162','25','74','3/10/18','3/30/18'),
('161','25','74','3/10/18','3/30/18'),
('160','25','74','3/10/18','3/30/18'),
('159','25','74','3/10/18','3/30/18'),
('158','25','74','3/10/18','3/30/18'),
('158','25','74','3/10/18','3/30/18'),

('157','23','73','3/10/18','3/30/18'),
('158','23','73','3/10/18','3/30/18'),
('159','23','73','3/10/18','3/30/18'),
('160','23','73','3/10/18','3/30/18'),
('161','23','73','3/10/18','3/30/18');

SELECT * FROM Book_Loans;


/*PROCEDURE DRILL 1*/
CREATE PROCEDURE dbo.LostTribe @Title VARCHAR (100), @BranchName VARCHAR (150)
AS
SELECT a1. No_Of_Copies, a2. Title, a3.BranchName
	from Book_Copies a1
	INNER JOIN dbo.Book a2 ON a2.BookID = a1.BookID
	INNER JOIN dbo.Library_Branch a3 ON a3.BranchID = a1.BranchID
	WHERE Title = @Title
	AND BranchName = @BranchName
	GO

	EXEC dbo.LostTribe @Title = 'The Lost Tribe', @BranchName='Sharpstown'

/*PROCEDURE DRILL 2*/
CREATE PROCEDURE dbo.LostTribeBranch @Title VARCHAR (100)
AS
SELECT a1. No_Of_Copies, a2. Title, a3.BranchName
	from Book_Copies a1
	INNER JOIN dbo.Book a2 ON a2.BookID = a1.BookID
	INNER JOIN dbo.Library_Branch a3 ON a3.BranchID = a1.BranchID
	WHERE Title = @Title
	GO

EXEC dbo.LostTribeBranch @Title = 'The Lost Tribe'

/*PROCEDURE DRILL 3
Retrieve the names of all borrowers who do not have any books checked out.*/

CREATE PROCEDURE dbo.NoBorrowers
AS
SELECT Name
FROM BORROWER B
WHERE CardNo NOT IN (SELECT CardNo FROM BOOK_LOANS );
GO

EXEC dbo.NoBorrowers;


/*PROCEDURE DRILL 4*/
CREATE PROCEDURE dbo.DueDate @DueDate DATE, @BranchName VARCHAR (150)
AS
SELECT a1.DueDate, a2.Name, a2.Address, a3.BranchID
	from Book_Loans a1
	INNER JOIN dbo.Borrower a2 ON a2. CardNo = a1.CardNo AND a2.CardNo = a1.CardNo
	INNER JOIN dbo.Library_Branch a3 ON a3.BranchID = a1.BranchID
	WHERE DueDate = @DueDate
	AND BranchName = @BranchName
	GO

	EXEC dbo.DueDate @BranchName='Sharpstown', @DueDate = '3/30/18'


/*PROCEDURE DRILL 5*/
CREATE PROCEDURE dbo.uspBranchBooksOut
AS 
SELECT L.BranchName, COUNT(*)
FROM BOOK_COPIES B, LIBRARY_BRANCH L
WHERE B.BranchId = L.BranchId
GROUP BY L.BranchName
GO

EXEC dbo.uspBranchBooksOut;



/*PROCEDURE DRILL 6*/

CREATE PROCEDURE dbo.FiveBooks
AS 
SELECT B.Name, B.Address, COUNT(*) 
FROM BORROWER B, BOOK_LOANS L
WHERE B.CardNo = L.CardNo
GROUP BY B.CardNo, B.Name, B.Address
HAVING COUNT(*) > 5
GO

EXEC dbo.FiveBooks;

/*PROCEDURE DRILL 7*/
CREATE PROCEDURE dbo.StephenK @AuthorName VARCHAR (100), @BranchName VARCHAR(150)
AS
SELECT a1. No_Of_Copies, a2.AuthorName, a3.BranchName, a4. Title 
	from Book_Copies a1
	INNER JOIN dbo.Book_Authors a2 ON a2.BookID = a1.BookID
	INNER JOIN dbo.Library_Branch a3 ON a3.BranchID = a1.BranchID
	INNER JOIN dbo.Book a4 ON a4. BookID= a1.BookID
	WHERE AuthorName = @AuthorName
	AND BranchName = @BranchName
	GO

EXEC dbo.StephenK @AuthorName = 'Stephen King', @BranchName = 'Central'