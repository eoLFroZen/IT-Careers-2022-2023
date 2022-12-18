CREATE DATABASE online_store;

USE online_store;

CREATE TABLE item_types(
	item_type_id INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE items(
	item_id INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    item_type_id INT NOT NULL,
    CONSTRAINT fk_items_item_types FOREIGN KEY (item_type_id) REFERENCES item_types(item_type_id)
);

CREATE TABLE cities(
	city_id INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE customers(
	customer_id INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    birthday DATE,
    city_id INT NOT NULL,
    CONSTRAINT fk_customers_cities FOREIGN KEY (city_id) REFERENCES cities(city_id)
);

CREATE TABLE orders(
	order_id INT PRIMARY KEY,
    customer_id INT NOT NULL,
    CONSTRAINT fk_orders_customers FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE orders_items(
	order_id INT NOT NULL,
    item_id INT NOT NULL,
    CONSTRAINT pk_orders_items PRIMARY KEY (order_id, item_id),
    CONSTRAINT fk_orders FOREIGN KEY (order_id) REFERENCES orders(order_id),
    CONSTRAINT fk_items FOREIGN KEY (item_id) REFERENCES items(item_id)
);