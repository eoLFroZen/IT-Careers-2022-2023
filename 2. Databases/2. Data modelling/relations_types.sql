CREATE DATABASE DatabaseModellingLab;

USE DatabaseModellingLab;

# one-to-one
CREATE TABLE passports(
	passport_id INT PRIMARY KEY,
    passport_number CHAR(8) NOT NULL UNIQUE
);

CREATE TABLE people(
	person_id INT PRIMARY KEY,
    first_name VARCHAR(20),
    salary DECIMAL,
    passport_id INT,
    CONSTRAINT fk_people_passports FOREIGN KEY (passport_Id) REFERENCES passports(passport_id)
);

INSERT INTO passports
VALUES  (101, 'N34FG21B'),
		(102, 'K65LO4R7'),
        (103, 'ZE657QP2');
        
INSERT INTO people
VALUES  (1, 'Roberto', 43300, 102),
		(2, 'Tom', 56100, 103),
        (3, 'Yana', 60200, 101);
        
# one-to-many
CREATE TABLE manufacturers(
	manufacturer_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20),
    established_on DATE
);

CREATE TABLE models(
	model_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20),
    manufacturer_id INT,
    CONSTRAINT fk_models_manufacturers FOREIGN KEY (manufacturer_id) REFERENCES manufacturers(manufacturer_id)
);

INSERT INTO manufacturers(name, established_on)
VALUES  ('BMW', '1916-03-01'),
		('Tesla', '2003-01-01'),
        ('Lada', '1966-05-01');
        
INSERT INTO models(name, manufacturer_id)
VALUES  ('X1', 1),
		('i6', 1),
        ('Model S', 2),
        ('Model X', 2),
        ('Model 3', 2),
        ('Nova', 3);
        
# many-to-many
CREATE TABLE students(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20)
);

CREATE TABLE exams(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20)
);

CREATE TABLE students_exams(
	student_id INT NOT NULL,
    exam_id INT NOT NULL,
    CONSTRAINT fk_students FOREIGN KEY (student_id) REFERENCES students(id),
    CONSTRAINT fk_exams FOREIGN KEY (exam_id) REFERENCES exams(id)
);

ALTER TABLE students_exams
ADD CONSTRAINT pk_students_exams PRIMARY KEY(student_id, exam_id);

INSERT INTO students(name)
VALUES  ('Mila'),
		('Toni'),
        ('Ron');
        
INSERT INTO exams
VALUES  (101, 'Spring MVC'),
		(102, 'Neo4j'),
        (103, 'Oracle 11g');
        
INSERT INTO students_exams
VALUES  (1, 101),
		(1, 102),
        (2, 101),
        (3, 103),
        (2, 102),
        (2, 103);
        
# self-reference
CREATE TABLE teachers(
	teacher_id INT PRIMARY KEY,
    name VARCHAR(20),
    manager_id INT,
    CONSTRAINT fk_teachers_teachers FOREIGN KEY (manager_id) REFERENCES teachers(teacher_id)
);

INSERT INTO teachers
VALUES  (101, 'John', NULL),
		(102, 'Maya', 101),
		(103, 'Silvia', 101),
		(104, 'Ted', 103),
		(105, 'Mark', 102),
		(106, 'Greta', 102);