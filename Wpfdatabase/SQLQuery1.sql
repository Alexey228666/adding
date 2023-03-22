Create table Department(
	ID int IDENTITY (1,1) PRIMARY KEY not NULL ,
	Title VARCHAR (50) not NULL
);
Create table Person(
	ID int IDENTITY (1,1) PRIMARY KEY not NULL,
	Person_Name VARCHAR (50) not NULL,
	Person_MiddleName VARCHAR (50) not null,
	Person_LastName VARCHAR (50) not null,
);
Create table PersonDepartment(
	ID int IDENTITY (1,1) PRIMARY KEY not NULL,
	ID_Person_Name int not NULL,
	ID_Department int not NULL,
	FOREIGN KEY(ID_Person_Name)
		REFERENCES Person (ID),
	FOREIGN KEY (ID_Department)
		REFERENCES Department (ID) 
);