create table cities(
	city_id int auto_increment,
    name varchar(30) not null,
    constraint PK_city primary key(city_id)
);

CREATE TABLE users(
	user_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255),
    balance DECIMAL(15, 2) NOT NULL,
    city_id INT NOT NULL,
    register_date DATETIME NOT NULL,
    CONSTRAINT FK_users_cities FOREIGN KEY(city_id) REFERENCES cities(city_id)
);

CREATE TABLE scooters(
	scooter_id INT PRIMARY KEY AUTO_INCREMENT,
    model VARCHAR(255) NOT NULL,
    gps_position VARCHAR(255) NOT NULL,
    is_taken BOOL DEFAULT FALSE
);

CREATE TABLE rents(
	rent_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT NOT NULL,
    scooter_id INT,
    start_date DATETIME NOT NULL,
    end_date DATETIME,
	is_completed BOOL DEFAULT FALSE,
    CONSTRAINT FK_rents_users FOREIGN KEY(user_id) REFERENCES users(user_id),
    CONSTRAINT FK_rents_scooters FOREIGN KEY(scooter_id) REFERENCES scooters(scooter_id)
);