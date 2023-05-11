CREATE DATABASE HCMISDB;
USE HCMISDB;

CREATE TABLE EmployeeInformation(
    ID          SMALLINT        PRIMARY KEY     IDENTITY(1, 1),
    FirstName   VARCHAR(50)     NOT NULL,
    MiddleName  VARCHAR(50),
    LastName    VARCHAR(50)     NOT NULL,
    Position    VARCHAR(10)
);

CREATE TABLE EmployeeContact(
    ID          SMALLINT        FOREIGN KEY     REFERENCES EmployeeInformation(ID) ON DELETE CASCADE,
    Email       VARCHAR(250),
    PhoneNumber VARCHAR(12)
);

CREATE TABLE EmployeeAccount(
    ID          SMALLINT        FOREIGN KEY     REFERENCES EmployeeInformation(ID) ON DELETE CASCADE,
    Username    VARCHAR(50)     NOT NULL,
    Password    VARCHAR(50)     NOT NULL
);


CREATE TABLE PatientInformation(
    ID              INT             PRIMARY KEY     IDENTITY(1, 1),
    Fullname        VARCHAR(100)    NOT NULL,
    Gender          VARCHAR(6)      NOT NULL,
    Birthday        DATETIME        NOT NULL,
    Address         VARCHAR(150)    NOT NULL,
    Bloodtype       VARCHAR(4)      NOT NULL,
    MartialStatus   VARCHAR(20)     NOT NULL 
);

CREATE TABLE PatientContact(
    ID          INT             FOREIGN KEY     REFERENCES PatientInformation(ID) ON DELETE CASCADE,
    Email       VARCHAR(250),
    PhoneNumber VARCHAR(12)
);


CREATE TABLE Queue(
    ID              INT             PRIMARY KEY     IDENTITY(1, 1),
    PatientID       INT             FOREIGN KEY     REFERENCES PatientInformation(ID) ON DELETE CASCADE,
    BloodPressure   INT             NOT NULL,
    WeightKG        DECIMAL(10, 2)  NOT NULL,
    HeightFT        DECIMAL(10, 2)  NOT NULL,
    Reason          VARCHAR(10)     NOT NULL
);


CREATE TABLE Record(
    ID              INT             PRIMARY KEY     IDENTITY(1, 1),
    PatientID       INT             FOREIGN KEY     REFERENCES PatientInformation(ID) ON DELETE CASCADE,
    VisitDateTime   DATETIME        NOT NULL,
    BloodPressure   INT             NOT NULL,
    WeightKG        DECIMAL(10, 2)  NOT NULL,
    HeightFT        DECIMAL(10, 2)  NOT NULL,
    Reason          VARCHAR(10)     NOT NULL,
    AssignedWorker  VARCHAR(100)    NOT NULL
);