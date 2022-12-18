USE geography;

-- Problem 3
SELECT 
	c1.capital AS 'Place', 
    c1.country_name AS 'Player 1',
    '' AS 'Host',
    '' AS 'Guest',
    c2.country_name AS 'Player 2'
FROM countries AS c1
CROSS JOIN countries AS c2
JOIN continents AS c
ON c.continent_name = 'Europe'
WHERE c1.country_code != c2.country_code AND c1.continent_code = c.continent_code AND c2.continent_code = c.continent_code
ORDER BY RAND();

-- Problem 5
SELECT co.continent_name, currencies.currency_code, c.country_name 
FROM (SELECT DISTINCT(currency_code) FROM countries WHERE currency_code IS NOT NULL) AS currencies
JOIN countries AS c
ON c.currency_code = currencies.currency_code
JOIN continents AS co
ON co.continent_code = c.continent_code
WHERE (SELECT COUNT(*) FROM countries AS c
	   WHERE c.currency_code = currencies.currency_code) = 1;

SELECT 
	continent_usage.continent_code,
    u.currency_code,
    continent_usage.currency_usage
FROM	(SELECT 
			c.continent_code, 
			MAX(u.currency_usage) AS 'currency_usage'
		FROM (SELECT DISTINCT(continent_code) FROM countries) AS c
		JOIN (SELECT currency_code, continent_code, COUNT(country_code) AS 'currency_usage' FROM countries
			  WHERE currency_code IS NOT NULL
			  GROUP BY currency_code, continent_code) as u
		ON c.continent_code = u.continent_code
		GROUP BY c.continent_code
        HAVING currency_usage > 1) AS continent_usage
JOIN (SELECT currency_code, continent_code, COUNT(country_code) AS 'currency_usage' FROM countries
	  WHERE currency_code IS NOT NULL
	  GROUP BY currency_code, continent_code) as u
ON continent_usage.continent_code = u.continent_code AND continent_usage.currency_usage = u.currency_usage
ORDER BY continent_usage.continent_code, u.currency_code;