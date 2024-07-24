--שאילתא שמקבלת שם קורס ומחזירה את המרצים שמלמדים את זה
DECLARE @course VARCHAR(25) = 'אינפי1'
SELECT t.TeacherName
FROM dbo.Teacher t INNER JOIN Unit u on t.TeacherID = u.TeacherID
WHERE u.CourseName = @course
--הרשמת תלמיד לאניברסיטה
DECLARE @student VARCHAR(25) = 'ניקול'
INSERT INTO Student(NameStudent) VALUES (@student); 

----מחיר קורס
DECLARE @coursename VARCHAR(25) = 'אינפי1'
DECLARE @semestername VARCHAR(25) = 'אביב'
SELECT c.Price
FROM Courses c
WHERE C.CourseName = @coursename and c.SemesterName = @semestername
--הרשמה לקורס
DECLARE @name VARCHAR(25) = 'ניקול'
DECLARE @id INT = (SELECT MAX(s.ID)
				FROM Student s
				WHERE s.NameStudent = @name)
DECLARE @courseid INT = (SELECT MAX(c.ID)
						FROM Courses c
						WHERE c.CourseName = @coursename AND c.SemesterName = @semestername)
DECLARE @price INT = (
			SELECT c.Price
			FROM Courses c
			WHERE C.ID = @courseid)
INSERT INTO Registration(StudentID,CoursesID) 
VALUES(@id,@courseid)

UPDATE Student
SET Balance = Balance + @price
WHERE ID = @id
--יתרת חוב לסטודנט
DECLARE @id INT = (SELECT MAX(s.ID)
				FROM Student s
				WHERE s.NameStudent = @name)
SELECT s.Balance FROM Student s Where s.ID = @id
--הכנסת כסף לחשבון
DECLARE @mony INT = 100
DECLARE @id INT = (SELECT MAX(s.ID)
				FROM Student s
				WHERE s.NameStudent = @name)
DECLARE @courseid INT = (SELECT MAX(c.ID)
						FROM Courses c
						WHERE c.CourseName = @coursename AND c.SemesterName = @semestername)
UPDATE Student
SET Balance = Balance - @mony
WHERE ID = @id
UPDATE Pay
SET SumOfPay = SumOfPay + @mony
Where CoursesID = @courseid
--הצג את כל הקורסים
SELECT c.CourseName, C.SemesterName
FROM Courses c


