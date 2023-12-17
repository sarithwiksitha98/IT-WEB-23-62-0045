SELECT * FROM student_info;

SELECT student_id, name, city FROM student_info
WHERE city='Kandy';

UPDATE student_info
SET city='Galle'
WHERE student_id='4';

SELECT student_info.student_id, student_info.name, student_info.city, student_info.course_id,
course_info.name, course_info.lecturer_name
FROM course_info
INNER JOIN student_info ON student_info.course_id = course_info.course_Id;