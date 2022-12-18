USE geography;

-- Problem 1
SELECT c.country_name, r.river_name FROM countries AS c
JOIN continents AS ct
ON c.continent_code = ct.continent_code AND ct.continent_name = 'Africa'
LEFT JOIN countries_rivers AS cr
ON c.country_code = cr.country_code
LEFT JOIN rivers AS r
ON r.id = cr.river_id
ORDER BY c.country_name
LIMIT 5;

-- Problem 2
SELECT c.country_name FROM countries AS c
LEFT JOIN mountains_countries AS mc
ON c.country_code = mc.country_code
WHERE mc.mountain_id IS NULL;

-- Problem 3
SELECT m.mountain_range, p.peak_name, p.elevation FROM mountains AS m
LEFT JOIN peaks AS p
ON m.id = p.mountain_id
JOIN mountains_countries AS mc
ON m.id = mc.mountain_id
JOIN countries AS c
ON c.country_code = mc.country_code AND c.country_name = 'Bulgaria'
WHERE p.elevation IS NULL 
	  OR p.elevation = (SELECT MAX(p1.elevation) FROM peaks AS p1
						WHERE p1.mountain_id = m.id)
ORDER BY p.elevation DESC