CREATE DATABASE People;

USE People;

CREATE TABLE People(
	id INT AUTO_INCREMENT,
    name VARCHAR(200) NOT NULL,
    picture BLOB,
    height DOUBLE(3,2),
    weight DOUBLE(5,2),
    gender ENUM('m', 'f') NOT NULL,
    birthdate DATE NOT NULL,
    biography TEXT,
    CONSTRAINT pk_id PRIMARY KEY (id)
);

INSERT INTO People(name, height, gender, birthdate, biography)
VALUES  ('Ivan', 1.75, 'm', '2008-7-04', 'Hi, I''m  Ivan'),
		('Maria', 1.62, 'f', '2003-11-10', NULL),
		('Maria Petrova', 1.55, 'f', '2013-1-10', NULL);
        
INSERT INTO People(name, picture, gender, birthdate, biography)   
VALUES  ('Ivan', 'some picture here %%%%', 'm', '2008-7-04', 'Hi, I''m  Ivan');

ALTER TABLE People
MODIFY COLUMN birthdate DATE;

INSERT INTO People(name, height, gender, biography)
VALUES  ('Ivan', 1.75, 'm', 'Hi, I''m  Ivan');