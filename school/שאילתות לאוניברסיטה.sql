--������ ������ �� ���� ������� �� ������ ������� �� ��
DECLARE @course VARCHAR(25) = '�����1'
SELECT t.TeacherName
FROM dbo.Teacher t INNER JOIN Unit u on t.TeacherID = u.TeacherID
WHERE u.CourseName = @course
--����� ����� ����������
DECLARE @student VARCHAR(25) = '�����'
INSERT INTO Student(NameStudent) VALUES (@student); 

----���� ����
DECLARE @coursename VARCHAR(25) = '�����1'
DECLARE @semestername VARCHAR(25) = '����'
SELECT c.Price
FROM Courses c
WHERE C.CourseName = @coursename and c.SemesterName = @semestername
--����� �����
DECLARE @name VARCHAR(25) = '�����'
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
--���� ��� �������
DECLARE @id INT = (SELECT MAX(s.ID)
				FROM Student s
				WHERE s.NameStudent = @name)
SELECT s.Balance FROM Student s Where s.ID = @id
--����� ��� ������
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
--��� �� �� �������
SELECT c.CourseName, C.SemesterName
FROM Courses c


