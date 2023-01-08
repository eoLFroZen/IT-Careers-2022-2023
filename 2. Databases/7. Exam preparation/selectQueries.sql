-- Query 2
SELECT name FROM cities
ORDER BY name
LIMIT 5;

-- Query 3
SELECT username, register_date FROM users
WHERE balance = 0
ORDER BY register_date DESC, username ASC;

-- Query 4
SELECT username, balance FROM users AS u
JOIN cities AS c
ON c.city_id = u.city_id
WHERE c.name = 'Varna'
ORDER BY balance DESC
LIMIT 1;

-- Query 5
SELECT username, balance FROM users AS u
LEFT JOIN rents AS r
ON u.user_id = r.user_id
WHERE r.rent_id IS NULL
ORDER BY balance DESC, username
LIMIT 5;


SELECT username, balance FROM users
WHERE user_id NOT IN (SELECT DISTINCT user_id FROM rents)
ORDER BY balance DESC, username
LIMIT 5;

-- Query 6
SELECT 
	COUNT(*) AS total_rents,
    c.name
FROM rents AS r
JOIN users AS u
ON u.user_id = r.user_id
JOIN cities AS c
ON c.city_id = u.city_id
GROUP BY c.name
ORDER BY total_rents DESC, r.rent_id
LIMIT 10;

-- Query 7
SELECT 
	COUNT(*) AS 'total_rents',
    u.username
FROM users AS u
JOIN rents AS r
ON r.user_id = u.user_id
GROUP BY u.username
ORDER BY total_rents DESC, u.username
LIMIT 5;

-- Query 8
SELECT COUNT(*) AS 'not_returned' FROM rents AS r
JOIN users AS u
ON u.user_id = r.user_id
JOIN cities AS c
ON c.city_id = u.city_id
WHERE c.name = 'Plovdiv' AND r.is_completed = FALSE;