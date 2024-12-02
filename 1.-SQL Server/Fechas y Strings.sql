use InstitutoTich;
GO

select * from Alumnos

SELECT id, nombre, primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', fechaNacimiento, GETDATE() AS 'Hoy', DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad', DATEDIFF(year, fechaNacimiento,DATEADD(MONTH, 5, GETDATE()) )  AS 'Edad en 5 Meses'
FROM Alumnos


SELECT id, UPPER(nombre), UPPER(primerApellido)  AS 'Apellido Paterno', UPPER(segundoApellido) AS 'Apellido Materno', fechaNacimiento, GETDATE() AS 'Hoy', DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad', DATEDIFF(year, fechaNacimiento,DATEADD(YEAR, 5, GETDATE()) )  AS 'Edad en 5 Meses'
FROM Alumnos

SELECT id, UPPER(nombre), UPPER(primerApellido)  AS 'Apellido Paterno', UPPER(segundoApellido) AS 'Apellido Materno', fechaNacimiento, curp, CONVERT(DATE, SUBSTRING(curp, 5, 6))  AS FechaCurp , GETDATE() AS 'Hoy', DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad', DATEDIFF(year, fechaNacimiento,DATEADD(MONTH, 5, GETDATE()) )  AS 'Edad en 5 Meses'
FROM Alumnos

SELECT id, UPPER(nombre), UPPER(primerApellido)  AS 'Apellido Paterno', UPPER(segundoApellido) AS 'Apellido Materno', fechaNacimiento, curp, CONVERT(DATE, SUBSTRING(curp, 5, 6))  AS FechaCurp , GETDATE() AS 'Hoy', DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad', DATEDIFF(year, fechaNacimiento,DATEADD(MONTH, 5, GETDATE()) )  AS 'Edad en 5 Meses', IIF(SUBSTRING(curp, 11, 1) = 'H', 'Hombre', IIF(SUBSTRING(curp, 11, 1) = 'M', 'Mujer','Error en Curp'))  AS Genero
FROM Alumnos


SELECT id, UPPER(nombre), UPPER(primerApellido)  AS 'Apellido Paterno', UPPER(segundoApellido) AS 'Apellido Materno', correo, REPLACE(correo, 'gmail', 'hotmail') AS hotmail
FROM Alumnos