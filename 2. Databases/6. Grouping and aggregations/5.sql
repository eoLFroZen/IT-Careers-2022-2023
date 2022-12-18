USE gringotts;

-- Problem 3
SELECT deposit_group, MAX(magic_wand_size) AS 'longest_magic_wand' FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY longest_magic_wand, deposit_group DESC;

-- Problem 6
SELECT deposit_group, SUM(deposit_amount) AS 'total_sum' FROM wizzard_deposits
WHERE magic_wand_creator = 'Ollivander family'
GROUP BY deposit_group
ORDER BY deposit_group;

-- Problem 7
SELECT deposit_group, SUM(deposit_amount) AS 'total_sum' FROM wizzard_deposits
WHERE magic_wand_creator = 'Ollivander family'
GROUP BY deposit_group
HAVING total_sum < 150000
ORDER BY total_sum desc;

-- Problem 12
SELECT 
    SUM(w1.deposit_amount - w2.deposit_amount) AS sum_difference
FROM wizzard_deposits AS w1
JOIN wizzard_deposits AS w2
ON w2.id = w1.id + 1;

USE soft_uni;

-- Problem 13
SELECT 
	department_id, 
    MIN(salary) AS minimum_salary 
FROM employees
WHERE department_id IN (2, 5, 7) AND
	  hire_date > 01/01/2000
GROUP BY department_id
ORDER BY department_id;

-- Problem 14
(SELECT 
	department_id,
    AVG(salary + 5000) AS avg_salary
FROM employees 
WHERE department_id = 1 AND salary > 30000 AND manager_id != 42)
UNION
(SELECT 
	department_id,
    AVG(salary) AS avg_salary
FROM employees 
WHERE department_id != 1 AND salary > 30000 AND manager_id != 42
GROUP BY department_id)
ORDER BY department_id;

SELECT 
	department_id,
    AVG(IF(department_id = 1, salary + 5000, salary)) AS avg_salary
FROM employees 
WHERE salary > 30000 AND manager_id != 42
GROUP BY department_id
ORDER BY department_id;

-- Problem 16
SELECT COUNT(*) AS count FROM employees
WHERE manager_id IS NULL;

-- Problem 17
SELECT 
	department_id,
    (SELECT salary FROM employees
    WHERE department_id = departmants.department_id
    ORDER BY salary DESC
    LIMIT 2, 1) AS third_highest_salary
FROM (SELECT DISTINCT department_id FROM employees) AS departmants;

-- Problem 18
SELECT first_name, last_name, department_id FROM employees AS e
WHERE salary > (SELECT AVG(e1.salary) FROM employees AS e1
				WHERE e1.department_id = e.department_id)
ORDER BY department_id
LIMIT 10;

-- Problem 19
SELECT department_id, SUM(salary) AS total_salary FROM employees
GROUP BY department_id
ORDER BY department_id;