USE gringotts;

-- Problem 1
SELECT
	wd.deposit_group,
	wd1.magic_wand_creator,
    wd.min_deposit_charge
FROM (SELECT 
		 deposit_group,
		 MIN(deposit_charge) AS min_deposit_charge
	 FROM wizzard_deposits
	 GROUP BY deposit_group) AS wd
JOIN wizzard_deposits AS wd1
ON wd1.deposit_group = wd.deposit_group AND wd1.deposit_charge = wd.min_deposit_charge
ORDER BY magic_wand_creator, deposit_group;

-- Problem 2
SELECT *
FROM (SELECT 
		 CONCAT('[', IF(age <= 10, 0, (10 * FLOOR(age / 10) + 1)), '-', (10 * FLOOR(age / 10) + 10), ']') AS age_group,
		 COUNT(*) AS wizard_count
	  FROM wizzard_deposits
	  WHERE age <= 60
	  GROUP BY (CEILING(age / 10))
      UNION
      SELECT 
		 '[61+]', 
		 COUNT(*) 
      FROM wizzard_deposits
      WHERE age > 60) AS ages_0_60
ORDER BY wizard_count;

-- Problem 3
SELECT SUBSTR(first_name, 1, 1) AS first_letter FROM wizzard_deposits
WHERE deposit_group = 'Troll Chest'
GROUP BY first_letter
ORDER BY first_letter;

-- Problem 4
SELECT 
	deposit_group,
    is_deposit_expired,
    AVG(deposit_interest) AS average_interest
FROM wizzard_deposits
WHERE deposit_start_date > 01/01/1985
GROUP BY deposit_group, is_deposit_expired
ORDER BY deposit_group DESC, is_deposit_expired;