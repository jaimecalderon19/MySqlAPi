CREATE DATABASE IF NOT EXISTS backend;
USE backend;


CREATE TABLE Users (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL
);

INSERT INTO Users (Name, Email, Password) VALUES
    ('Administrador', 'admin@example.com', 'password123'),
    ('Usuario', 'user@example.com', 'password456');


CREATE TABLE Tasks (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Title VARCHAR(100) NOT NULL,
    Description VARCHAR(200) NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    StatusTask INT NOT NULL
);

CREATE TABLE TaskAssignments (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    TaskId INT NOT NULL,
    UserId INT NOT NULL,
    AssignedDate DATETIME NOT NULL,
    FOREIGN KEY (TaskId) REFERENCES Tasks(Id),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

CREATE TABLE Comments (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    TaskId INT NOT NULL,
    UserId INT NOT NULL,
    CommentText VARCHAR(200) NOT NULL,
    CreatedDate DATETIME NOT NULL,
    FOREIGN KEY (TaskId) REFERENCES Tasks(Id),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);