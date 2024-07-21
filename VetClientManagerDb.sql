CREATE DATABASE VetClientManagerDb;
GO
USE VetClientManagerDb;
GO
CREATE TABLE Clients (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL CHECK (Role IN ('admin', 'user')),
    PasswordHash NVARCHAR(255) NOT NULL
);
GO
CREATE TABLE Pets (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Type NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    ClientId INT NOT NULL,
    FOREIGN KEY (ClientId) REFERENCES Clients(Id)
);
GO
CREATE TABLE Appointments (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Date DATETIME NOT NULL,
    Reason NVARCHAR(255) NOT NULL,
    PetId INT NOT NULL,
    FOREIGN KEY (PetId) REFERENCES Pets(Id)
);
GO
INSERT INTO Clients (Name, Email, Role, PasswordHash) 
VALUES ('Jan Kowalski', 'jankowalski@example.com', 'admin', '');