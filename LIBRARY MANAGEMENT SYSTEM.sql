
/*CREATE DATABASE*/
CREATE Database db_LibraryMS2;

USE db_LibraryMS2;

/*CREATE TABLES*/

CREATE TABLE Publisher (
	Name VARCHAR (150) Primary Key NOT NULL,
	Address VARCHAR (150) NULL,
	Phone VARCHAR (50) NULL,
);

 INSERT INTO Publisher
 VALUES 
 ('Penguin', 'New York', '785-896-9856'),
 ('Random House', 'New York', '456-123-7898'),
 ('Simon and Schuster', 'New York', '785-456-9856'),
 ('HarperCollins', 'LA', '258-896-9856'),
 ('Hachette', 'Seattle', '206-896-9856');

SELECT * FROM Publisher;

CREATE TABLE Book (
	BookID INT IDENTITY(100,1) Primary Key NOT NULL,
	Title VARCHAR (100) NULL,
	PublisherName VARCHAR(150)
	FOREIGN KEY (PublisherName) REFERENCES Publisher(Name) 
	);

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
 ('The Lost Tribe','Random House'),
 ('Game of Thrones','Simon and Schuster');

SELECT * FROM Book;

CREATE TABLE Book_Authors (
	AuthorName VARCHAR (150) NULL,
	BookID INT
	FOREIGN KEY (BookID) REFERENCES Book(BookID) 
	);

 INSERT INTO Book_Authors
 VALUES 
 ('J.K Rowling','100'),
 ('Tech Academy','101'),
 ('Frank Baum','102'),
 ('J.K Rowling','103'), 
 ('J.K Rowling','104'), 
 ('J.K Rowling','105'), 
 ('J.K Rowling','106'), 
 ('J.K Rowling','107'),
 ('J.K Rowling','108'), 
 ('Ashley C','109'),  
 ('Walt Disney','110'),
 ('Stephen King','111'), 
 ('Stephen King','112'),
 ('Stephen King','113'),
 ('Fitzgerald','114'),
 ('Harper Lee','115'),
 ('Lewis Carroll','116'),
 ('Mark Lee','117'), 
 ('William Golding','118'),
 ('Tolkin','119');
 
SELECT * FROM Book_Authors;


CREATE TABLE Library_Branch (
	BranchID INT IDENTITY(10,1) Primary Key NOT NULL,
	BranchName VARCHAR (150) NULL,
	Address VARCHAR (500) NULL,
);

INSERT INTO Library_Branch
Values 
('Sharpstown','125 Sharp Street'), 
('Central','256 Central Plaza'), 
('King','1456 King Court N.'), 
('Madina','23 Madina Plaza South');

SELECT * FROM Library_Branch;

CREATE TABLE Book_Copies(
	BookID INT
	FOREIGN KEY (BookID) REFERENCES Book(BookID), 
	BranchID INT
	FOREIGN KEY (BranchID) REFERENCES Library_Branch(BranchID), 
	No_Of_Copies INT NULL
);

 INSERT INTO Book_Copies
 VALUES 
 ('100','10','14'),
 ('101','10','9'),
 ('102','10','25'),
 ('103','10','15'),
 ('104','10','10'),
 ('105','10','4'),
 ('106','10','15'),
 ('107','10','6'),
 ('108','10','30'),
 ('109','10','35'),
 ('118','10','35'),

 ('112','11','10'),
 ('113','11','10'),
 ('114','11','10'),
 ('115','11','10'),
 ('116','11','10'),
 ('117','11','30'),
 ('118','11','20'),
 ('119','11','10'),
 ('109','11','10'),
 ('108','11','10'),

 ('107','12','14'),
 ('106','12','9'),
 ('105','12','25'),
 ('104','12','15'),
 ('103','12','10'),
 ('102','12','4'),
 ('101','12','15'),
 ('100','12','6'),
 ('119','12','30'),
 ('118','12','35'),

 ('100','13','10'),
 ('101','13','10'),
 ('117','13','10'),
 ('116','13','10'),
 ('104','13','10'),
 ('105','13','30'),
 ('106','13','20'),
 ('107','13','10'),
 ('108','13','10'),
 ('109','13','10'),
 ('110','13','10'),
 ('111','13','10'),
 ('113','13','10');

SELECT * FROM Book_Copies;

CREATE TABLE Borrower (
	CardNo INT IDENTITY (23,1) PRIMARY KEY,
	Name VARCHAR (150) NOT NULL,
	Address VARCHAR (150) NULL,
	Phone VARCHAR (50) NULL,
);

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

INSERT INTO Book_Loans
VALUES
('100','10','25','3/10/18','3/30/18'),
('101','10','25','3/10/18','3/30/18'),
('102','10','25','3/10/18','3/30/18'),
('103','10','25','3/10/18','3/30/18'),
('104','10','25','3/10/18','3/30/18'),

('105','11','26','3/10/18','3/30/18'),
('106','11','26','3/10/18','3/30/18'),
('107','11','26','3/10/18','3/30/18'),
('108','11','26','3/10/18','3/30/18'),
('109','11','26','3/10/18','3/30/18'),

('110','11','23','3/10/18','3/30/18'),
('111','11','23','3/10/18','3/30/18'),
('112','11','23','3/10/18','3/30/18'),
('113','11','23','3/10/18','3/30/18'),
('114','11','23','3/10/18','3/30/18'),

('115','12','24','3/10/18','3/30/18'),
('116','12','24','3/10/18','3/30/18'),
('117','12','24','3/10/18','3/30/18'),
('118','12','24','3/10/18','3/30/18'),
('119','12','24','3/10/18','3/30/18'),

('100','12','27','1/8/18','1/18/18'),
('101','12','27','1/8/18','1/18/18'),
('102','12','27','1/8/18','1/18/18'),
('103','12','27','1/8/18','1/18/18'),
('104','12','27','1/8/18','1/18/18'),
('105','12','27','1/8/18','1/18/18'),

('106','13','28','3/8/18','3/18/18'),
('107','13','28','3/8/18','3/18/18'),
('108','13','28','3/8/18','3/18/18'),
('109','13','28','3/8/18','3/18/18'),
('110','13','28','3/8/18','3/18/18'),
('111','13','28','3/8/18','3/18/18'),
('113','13','28','3/8/18','3/18/18'),
('112','13','28','3/8/18','3/18/18'),
('114','13','28','3/8/18','3/18/18'),


('115','13','29','3/10/18','3/30/18'),
('116','13','29','3/10/18','3/30/18'),
('117','13','29','3/10/18','3/30/18'),
('118','13','29','3/10/18','3/30/18'),
('119','13','29','3/10/18','3/30/18'),
('100','10','29','3/10/18','3/30/18'),
('101','10','29','3/10/18','3/30/18'),
('102','10','29','3/10/18','3/30/18'),
('103','10','29','3/10/18','3/30/18'),
('104','10','29','3/10/18','3/30/18'),

('105','11','25','6/12/18','6/30/18'),
('106','11','25','6/12/18','6/30/18'),
('107','11','25','6/12/18','6/30/18'),
('108','11','25','6/12/18','6/30/18'),
('109','11','25','6/12/18','6/30/18');

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
