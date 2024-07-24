CREATE TABLE Courses(
	ID INT IDENTITY PRIMARY KEY,
	SemesterName VARCHAR(25),
	CourseName VARCHAR(25),
	DataStart TIMESTAMP NULL,
	Price INT
);
CREATE TABLE Teacher(
	TeacherID INT IDENTITY PRIMARY KEY,
	TeacherName VARCHAR(25),
	Price INT
);
CREATE TABLE Unit(
	CourseName VARCHAR(25),
	UnitName VARCHAR(25),
	SumOfHours INT,
	TeacherID INT FOREIGN KEY REFERENCES Teacher(TeacherID)
);
CREATE TABLE Student(
	ID INT IDENTITY PRIMARY KEY,
	NameStudent VARCHAR(25),
	Balance INT
);
CREATE TABLE Registration(
	StudentID INT FOREIGN KEY REFERENCES Student(ID),
	CoursesID INT FOREIGN KEY REFERENCES Courses(ID)
);
CREATE TABLE Pay(
	CoursesID INT FOREIGN KEY REFERENCES Courses(ID),
	SumOfPay INT NULL
);
CREATE TABLE Days(
	CoursesID INT FOREIGN KEY REFERENCES Courses(ID),
	SundayStart INT NULL,
	MondayStart INT NULL,
	TuesdayStart INT NULL,
	WednesdayStart INT NULL,
	ThursdayStart INT NULL,
	FridayStart INT NULL,
	SuterdayStart INT NULL,
	SundayEnd INT NULL,
	MondayEnd INT NULL,
	Tuesday INT NULL,
	Wednesday INT NULL,
	Thursday INT NULL,
	Friday INT NULL,
	Suterday INT NULL
);