CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY IDENTITY(1,1),
    ProjectName NVARCHAR(100) NOT NULL,
    StartDate DATE,
    Budget DECIMAL(18,2),
    IsCompleted BIT DEFAULT 0
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Expertise NVARCHAR(50) 
);

CREATE TABLE Tasks (
    TaskID INT PRIMARY KEY IDENTITY(1,1),
    ProjectID INT FOREIGN KEY REFERENCES Projects(ProjectID),
    EmployeeID INT FOREIGN KEY REFERENCES Employees(EmployeeID),
    TaskTitle NVARCHAR(150),
    HourlyRate DECIMAL(18,2), 
    WorkedHours DECIMAL(10,2), 
    TaskType NVARCHAR(20), 
    CreatedDate DATETIME DEFAULT GETDATE()
);

