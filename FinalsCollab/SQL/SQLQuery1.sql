CREATE DATABASE DBHCMIS;
USE DBHCMIS;


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

CREATE PROCEDURE GetEmployees
AS
BEGIN
	SELECT 
		I.id,
		I.firstname,
		I.middlename,
		I.lastname,
		I.position,
		C.email,
		C.phone,
		A.username,
		A.password
	FROM
		EmployeeInformation I
	INNER JOIN EmployeeContact C
		ON I.id = C.id
	INNER JOIN EmployeeAccount A
		ON C.id = A.id;
END

CREATE PROCEDURE EmployeeLogin
	@username VARCHAR(50),
	@password VARCHAR(50)
AS
BEGIN
	SELECT 
		I.id,
		I.firstname,
		I.middlename,
		I.lastname,
		I.position,
		C.email,
		C.phone,
		A.username,
		A.password
	FROM
		EmployeeInformation I
	INNER JOIN EmployeeContact C
		ON I.id = C.id
	INNER JOIN EmployeeAccount A
		ON C.id = A.id
	WHERE
		A.username = @username COLLATE SQL_Latin1_General_CP1_CS_AS AND 
		A.password = @password COLLATE SQL_Latin1_General_CP1_CS_AS;
END

CREATE PROCEDURE EmployeeRegister
	@firstname	VARCHAR(50),
	@middlename	VARCHAR(50),
	@lastname	VARCHAR(50),
	@position	VARCHAR(8),
	@email		VARCHAR(250),
	@phone		VARCHAR(12),
	@username VARCHAR(50),
	@password VARCHAR(50)
AS
BEGIN
	INSERT INTO EmployeeInformation
	VALUES (@firstname, @middlename, @lastname, @position);

	DECLARE @ID AS SMALLINT = SCOPE_IDENTITY();

	INSERT INTO EmployeeContact
	VALUES (@ID, @email, @phone);

	INSERT INTO EmployeeAccount
	VALUES (@ID, @username, @password);
END

CREATE PROCEDURE EmployeeDelete
	@id SMALLINT
AS
BEGIN
	DELETE
	FROM EmployeeInformation
	WHERE id = @id;
END

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

CREATE PROCEDURE GetPatients
AS
BEGIN
	SELECT 
		I.id,
		I.name,
		I.gender,
		I.birthday,
		I.address,
		I.bloodtype,
		I.marital_status,
		I.number_of_kids,
		C.email,
		C.phone
	FROM
		PatientInformation I
	INNER JOIN PatientContact C
		ON I.id = C.id;
END

CREATE PROCEDURE GetPatientsByName
	@name VARCHAR(100)
AS
BEGIN
	SELECT 
		I.id,
		I.name,
		I.gender,
		I.birthday,
		I.address,
		I.bloodtype,
		I.marital_status,
		I.number_of_kids,
		C.email,
		C.phone
	FROM
		PatientInformation I
	INNER JOIN PatientContact C
		ON I.id = C.id
	WHERE
		I.name = @name;
END

CREATE PROCEDURE GetPatientByID
	@id INT
AS
BEGIN
	SELECT 
		I.id,
		I.name,
		I.gender,
		I.birthday,
		I.address,
		I.bloodtype,
		I.marital_status,
		I.number_of_kids,
		C.email,
		C.phone
	FROM
		PatientInformation I
	INNER JOIN PatientContact C
		ON I.id = C.id
	WHERE
		I.id = @id;
END

CREATE PROCEDURE PatientRegister
	@name			VARCHAR(100),
	@gender			VARCHAR(6),
	@birthday		DATETIME,
	@address		VARCHAR(150),
	@bloodtype		VARCHAR(3),
	@marital_status	VARCHAR(7),
	@number_of_kids	SMALLINT,
	@email	VARCHAR(250),
	@phone	VARCHAR(12)
AS
BEGIN
	INSERT INTO PatientInformation
	VALUES (@name, @gender, @birthday, @address, @bloodtype, @marital_status, @number_of_kids);

	DECLARE @ID AS SMALLINT = SCOPE_IDENTITY();

	INSERT INTO PatientContact
	VALUES (@ID, @email, @phone);
END

CREATE PROCEDURE PatientDelete
	@id INT
AS
BEGIN
	DELETE
	FROM PatientInformation
	WHERE id = @id;
END

/* Queue */
CREATE TABLE Queue(
	id				INT				PRIMARY KEY IDENTITY(1, 1),
	patient_id		INT				FOREIGN KEY	REFERENCES PatientInformation(id)	ON DELETE CASCADE,
	blood_pressure	VARCHAR(20),
	weight_kg		INT,
	height_ft		DECIMAL(10, 2),
	reason			VARCHAR(7)		CHECK (reason in ('vaccine', 'checkup'))
);

CREATE PROCEDURE QueueAdd
	@id				INT,
	@patient_id		INT,
	@blood_pressure	VARCHAR(20),
	@weight_kg		INT,
	@height_ft		DECIMAL(10, 2),
	@reason			VARCHAR(7)
AS
BEGIN
	INSERT INTO Queue
	VALUES (@patient_id, @blood_pressure, @weight_kg, @height_ft, @reason)
END

CREATE PROCEDURE GetQueues
AS
BEGIN
	SELECT
		id, patient_id, blood_pressure, weight_kg, height_ft, reason
	FROM
		Queue
END

CREATE PROCEDURE GetQueueByID
	@id	INT
AS
BEGIN
	SELECT
		id, patient_id, blood_pressure, weight_kg, height_ft, reason
	FROM
		Queue
	WHERE
		id=@id;
END

CREATE PROCEDURE QueueDelete
	@id INT
AS
BEGIN
	DELETE FROM Queue
	WHERE id=@id;
END

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

CREATE PROCEDURE RecordAdd
	@patient_id			INT,
	@visit_datetime		DATETIME,
	@blood_pressure		VARCHAR(20),
	@weight_kg			INT,
	@height_ft			DECIMAL(10, 2),
	@reason				VARCHAR(7),
	@assigned_worker_id	SMALLINT,
	@remarks			VARCHAR(500),
	@notes				VARCHAR(500),
	@deferred			BIT
AS
BEGIN
	INSERT INTO Record
	VALUES (@patient_id, @visit_datetime, @blood_pressure, @weight_kg, @height_ft, @reason, @assigned_worker_id, @remarks, @notes, @deferred);
END

CREATE PROCEDURE GetPatientRecords
	@patient_id	INT
AS
BEGIN
	SELECT
		id,
		patient_id,
		visit_datetime,
		blood_pressure,
		weight_kg,
		height_ft,
		reason,
		assigned_worker_id,
		remarks,
		notes,
		deferred
	FROM Record
	WHERE patient_id=@patient_id;
END

CREATE PROCEDURE GetPatientTotalRecords
	@patient_id INT
AS
BEGIN
	SELECT COUNT(*) AS 'Total'
	FROM Record
	WHERE patient_id=@patient_id;
END

CREATE PROCEDURE GetRecords
AS
BEGIN
	SELECT
		id,
		patient_id,
		visit_datetime,
		blood_pressure,
		weight_kg,
		height_ft,
		reason,
		assigned_worker_id,
		remarks,
		notes,
		deferred
	FROM Record;
END
