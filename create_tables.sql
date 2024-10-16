CREATE DATABASE HealthInsuranceDB;

USE HealthInsuranceDB;

CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DateOfBirth DATE,
    Address NVARCHAR(200),
    PhoneNumber NVARCHAR(12),
    Email NVARCHAR(100)
);

CREATE TABLE InsurancePlans (
    PlanID INT PRIMARY KEY IDENTITY(1,1),
    PlanName NVARCHAR(100),
    CoverageType NVARCHAR(50),
    PremiumAmount DECIMAL(10, 2),
    CoverageAmount DECIMAL(10, 2)
);

CREATE TABLE Providers (
    ProviderID INT PRIMARY KEY IDENTITY(1,1),
    ProviderName NVARCHAR(100),
    Specialty NVARCHAR(100),
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE Claims (
    ClaimID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT,
    ProviderID INT,
    PlanID INT,
    ClaimDate DATE,
    AmountClaimed DECIMAL(10, 2),
    Status NVARCHAR(20),
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID),
    FOREIGN KEY (PlanID) REFERENCES InsurancePlans(PlanID)
);

CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    ClaimID INT,
    TransactionDate DATE,
    AmountPaid DECIMAL(10, 2),
    PaymentMethod NVARCHAR(50),
    FOREIGN KEY (ClaimID) REFERENCES Claims(ClaimID)
);
