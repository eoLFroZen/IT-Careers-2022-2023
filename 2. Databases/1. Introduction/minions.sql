# Problem 1
CREATE DATABASE Minions;

# Problem 2
USE Minions;

CREATE TABLE minions (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50),
    age INT
); 

CREATE TABLE towns(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20)
);

# Problem 3 
ALTER TABLE minions
ADD town_id INT;

# Problem 4
INSERT INTO minions(name, age, town_id)
VALUES  ('Kevin', 22, 1),
		('Bob', 15, 3),
        ('Steward', NULL, 2);
        
INSERT INTO towns(name)
VALUES  ('Sofia'),
		('Plovdiv'),
        ('Varna');
        
# Problem 5
TRUNCATE minions;

# Problem 6
DROP TABLE minions;

DROP TABLE towns;

DROP DATABASE Minions;