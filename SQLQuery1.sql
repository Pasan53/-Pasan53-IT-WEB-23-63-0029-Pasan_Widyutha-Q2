SELECT * FROM Student;
SELECT StudentId, Name, City FROM Student WHERE City = 'Kandy';

SELECT * FROM Student WHERE StudentId = 4;

SELECT Student.*, Course.Name AS CourseName
FROM Student
INNER JOIN Course ON Student.CourseId = Course.CourseId;