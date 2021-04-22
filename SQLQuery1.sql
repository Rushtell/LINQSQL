DELETE FROM Workers WHERE id > 0

INSERT INTO Workers VALUES (N'Петя', 1, 1, 1)
INSERT INTO Workers VALUES (N'Ваня', 1, 1, 1)
INSERT INTO Workers VALUES (N'Саня', 1, 1, 1)
INSERT INTO Workers VALUES (N'Влад', 1, 1, 1)
INSERT INTO Workers VALUES (N'Влад', 2, 2, 2)
INSERT INTO Workers VALUES (N'Саня', 2, 2, 2)
INSERT INTO Workers VALUES (N'Ваня', 2, 2, 2)
INSERT INTO Workers VALUES (N'Петя', 2, 2, 2)
INSERT INTO Workers VALUES (N'Петя', 3, 3, 3)
INSERT INTO Workers VALUES (N'Ваня', 3, 3, 3)
INSERT INTO Workers VALUES (N'Влад', 3, 3, 3)
INSERT INTO Workers VALUES (N'Саня', 3, 3, 3)

INSERT INTO Bosses VALUES (N'Семён')
INSERT INTO Bosses VALUES (N'Михалыч')
INSERT INTO Bosses VALUES (N'Валера')

INSERT INTO [Types] VALUES (N'Обычный')
INSERT INTO [Types] VALUES (N'Странный')
INSERT INTO [Types] VALUES (N'Глухой')

INSERT INTO Salaries VALUES (10000)
INSERT INTO Salaries VALUES (20000)
INSERT INTO Salaries VALUES (30000)

SELECT Workers.id, Workers.[name], Bosses.[name] as bossName, Salaries.salary, [Types].[type] 
FROM Workers, Bosses, Salaries, [Types]
WHERE Workers.idBoss = Bosses.id AND Workers.idSalary = Salaries.id AND Workers.idType = [Types].id

SELECT T1.id as ID, T1.[name] as WorkerName, T2.[name] as BossName, T3.salary as Salary, T4.[type] as [Type]
FROM Workers as T1
INNER JOIN Bosses as T2 ON T1.idBoss = T2.id
INNER JOIN Salaries as T3 ON T1.idSalary = T3.id
INNER JOIN [Types] as T4 ON T1.idType = T4.id
ORDER BY T1.[name], T1.id DESC