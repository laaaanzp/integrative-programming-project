CREATE DATABASE FinalsCollabDB;
USE FinalsCollabDB;


/* Employee */
CREATE TABLE EmployeeInformation(
	id			SMALLINT		PRIMARY KEY		IDENTITY(1, 1),
	firstname	VARCHAR(50),
	middlename	VARCHAR(50),
	lastname	VARCHAR(50),
	position	VARCHAR(8)		CHECK (position in ('admin', 'doctor', 'nurse', 'bhw', 'resigned')),
);

CREATE TABLE EmployeeAccount(
	id			SMALLINT		FOREIGN KEY	REFERENCES EmployeeInformation(id)	ON DELETE CASCADE,
	username	VARCHAR(50),
	password	VARCHAR(50)
);

CREATE TABLE EmployeeContact(
	id			SMALLINT		FOREIGN KEY	REFERENCES EmployeeInformation(id)	ON DELETE CASCADE,
	email		VARCHAR(250),
	phone		VARCHAR(12)
);


/* Patient */
CREATE TABLE PatientInformation(
	id				INT				PRIMARY KEY		IDENTITY(1, 1),
	name			VARCHAR(100),
	gender			VARCHAR(6)		CHECK (gender in ('male', 'female', 'others')),
	birthday		DATETIME,
	address			VARCHAR(150),
	bloodtype		VARCHAR(3),
	marital_status	VARCHAR(7)		CHECK (marital_status in ('single', 'married')),
	number_of_kids	SMALLINT
);

CREATE TABLE PatientContact(
	id		INT				FOREIGN KEY	REFERENCES PatientInformation(id)	ON DELETE CASCADE,
	email	VARCHAR(250),
	phone	VARCHAR(12)
);


/* Queue */
CREATE TABLE Queue(
	id				INT				PRIMARY KEY IDENTITY(1, 1),
	patient_id		INT				FOREIGN KEY	REFERENCES PatientInformation(id)	ON DELETE CASCADE,
	blood_pressure	VARCHAR(20),
	weight_kg		INT,
	height_ft		DECIMAL(10, 2),
	reason			VARCHAR(7)		CHECK (reason in ('vaccine', 'checkup'))
);


/* Record */
CREATE TABLE Record(
	id					INT				PRIMARY KEY IDENTITY(1, 1),
	patient_id			INT				FOREIGN KEY	REFERENCES PatientInformation(id)	ON DELETE CASCADE,
	visit_datetime		DATETIME,
	blood_pressure		VARCHAR(20),
	weight_kg			INT,
	height_ft			DECIMAL(10, 2),
	reason				VARCHAR(7)		CHECK (reason in ('vaccine', 'checkup')),
	assigned_worker_id	SMALLINT		FOREIGN KEY	REFERENCES EmployeeInformation(id)	ON DELETE CASCADE,
	remarks				VARCHAR(500),
	notes				VARCHAR(500),
	deferred			BIT
);