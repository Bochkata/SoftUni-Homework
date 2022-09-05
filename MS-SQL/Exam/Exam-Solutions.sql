--1
CREATE TABLE Owners
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL,
	[Address] VARCHAR(50)
)
CREATE TABLE AnimalTypes
(
	Id INT PRIMARY KEY IDENTITY,
	AnimalType VARCHAR(30) NOT NULL
)
CREATE TABLE Cages
(
	Id INT PRIMARY KEY IDENTITY,
	AnimalTypeId INT FOREIGN KEY REFERENCES AnimalTypes(Id) NOT NULL
)
CREATE TABLE Animals
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL,
	BirthDate DATE NOT NULL,
	OwnerId INT FOREIGN KEY REFERENCES Owners(Id),
	AnimalTypeId INT FOREIGN KEY REFERENCES AnimalTypes(Id) NOT NULL
)
CREATE TABLE AnimalsCages
(
	CageId INT FOREIGN KEY REFERENCES Cages(Id) NOT NULL UNIQUE,
	AnimalId INT FOREIGN KEY REFERENCES Animals(Id) NOT NULL UNIQUE,
	PRIMARY KEY(CageId,AnimalId)
)
CREATE TABLE VolunteersDepartments
(
	Id INT PRIMARY KEY IDENTITY,
	DepartmentName VARCHAR(30) NOT NULL
)
CREATE TABLE Volunteers
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL,
	[Address] VARCHAR(50),
	AnimalId INT FOREIGN KEY REFERENCES Animals(Id),
	DepartmentId INT FOREIGN KEY REFERENCES VolunteersDepartments(Id) NOT NULL
)
GO


--2
INSERT INTO Animals (Name, BirthDate, OwnerId, AnimalTypeId)
VALUES ('Giraffe' ,  '2018-09-21', 21, 1),
	   ('Harpy Eagle',  '2015-04-17', 15, 3),	 
	   ('Hamadryas Baboon',  '2017-11-02', NULL, 1),	  
	   ('Tuatara',  '2021-06-30', 2, 4)

INSERT INTO Volunteers (Name, PhoneNumber, Address, AnimalId, DepartmentId)
VALUES ('Anita Kostova',  '0896365412',  'Sofia, 5 Rosa str.',  15, 1),
	   ('Dimitur Stoev',  '0877564223',  NULL,  42, 4),
	   ('Kalina Evtimova',  '0896321112',  'Silistra, 21 Breza str.', 9, 7),
	   ('Stoyan Tomov',  '0898564100',  'Montana, 1 Bor str.',  18,  8),
	   ('Boryana Mileva', '0888112233', NULL, 31, 5)
GO


--3
UPDATE Animals
SET OwnerId = 4
where OwnerId is null
GO


--4
DELETE FROM Volunteers
WHERE DepartmentId= (SELECT Id FROM VolunteersDepartments
WHERE Id=2)

DELETE FROM VolunteersDepartments
WHERE Id = 2
GO


--5
SELECT [Name],PhoneNumber,Address,AnimalId,DepartmentId FROM Volunteers
ORDER BY [Name], Id,DepartmentId desc
GO


--6
SELECT [Name],AnimalType,FORMAT(BirthDate,'dd.MM.yyyy') AS [BirthDate] FROM Animals AS A
JOIN AnimalTypes as AT on AT.Id = a.AnimalTypeId
ORDER BY [Name]
GO


--7
SELECT TOP(5)
o.[Name] AS [Owner],
COUNT(*) AS [CountOfAnimals]
FROM Owners AS O
JOIN Animals AS A ON A.OwnerId = O.Id
GROUP BY o.[Name]
ORDER BY CountOfAnimals desc,[Owner]
GO


--8
SELECT 
o.[Name]+ '-' + a.[Name] AS [OwnersAnimals],
o.PhoneNumber, 
ac.CageId 
FROM Animals AS a
JOIN Owners AS o ON o.Id = a.OwnerId
JOIN AnimalsCages AS ac ON ac.AnimalId = a.Id
JOIN AnimalTypes AS at ON at.Id = a.AnimalTypeId
WHERE at.AnimalType = 'Mammals'
ORDER BY o.[Name], a.[Name] DESC
GO


--9
SELECT 
[Name], 
PhoneNumber,
TRIM(SUBSTRING(TRIM(Address), 8, len(TRIM(Address)))) AS 'Address' 
FROM Volunteers
WHERE DepartmentId = 2 AND Address LIKE '%Sofia%'
ORDER BY [Name] 
GO


--10
SELECT 
a.[Name],
YEAR(BirthDate) as [BirthYear],
AnimalType
FROM Animals AS A
JOIN AnimalTypes AS AT ON A.AnimalTypeId= AT.Id
WHERE OwnerId IS NULL AND AnimalType != 'BIRDS' AND BirthDate>'01/01/2018'
ORDER BY a.[Name]
GO


--11
CREATE FUNCTION udf_GetVolunteersCountFromADepartment(@VolunteersDepartment VARCHAR(30)) 
RETURNS INT
AS
BEGIN
RETURN (SELECT COUNT(*) FROM VolunteersDepartments AS VD
JOIN Volunteers as V ON V.DepartmentId = VD.Id
WHERE DepartmentName= @VolunteersDepartment
)
END
GO


--12	
CREATE PROC usp_AnimalsWithOwnersOrNot(@AnimalName VARCHAR(30))
AS
BEGIN
DECLARE @Result VARCHAR(30) = 
(
	SELECT 
	O.[Name] 
	FROM Animals AS A
	JOIN Owners AS O ON A.OwnerId = O.Id
	WHERE A.Name = @AnimalName
)
IF(@Result IS NULL)
SELECT 
[Name],
'For adoption' AS [OwnersName] 
FROM Animals
WHERE Name = @AnimalName
ELSE
SELECT 
A.[Name],
O.[Name] AS [OwnersName] 
FROM Animals AS A
JOIN Owners AS O ON A.OwnerId = O.Id
WHERE A.Name = @AnimalName
END


