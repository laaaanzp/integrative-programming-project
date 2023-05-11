CREATE TABLE Records(
	ID					INT			PRIMARY KEY,
	Queue				INT			FOREIGN KEY		REFERENCES Queue(ID),
	Date				DATE		NOT NULL,
	Time				TIME		NOT NULL,
	AssignedWorkedID	SMALLINT	FOREIGN KEY		REFERENCES EmployeeInformation(ID),
);