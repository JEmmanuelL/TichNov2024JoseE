use InstitutoTich;
GO

SELECT nombre, primerApellido, segundoApellido from Alumnos where primerApellido LIKE 'Mendoza' OR segundoApellido LIKE 'Mendoza'; 

SELECT  Alu.nombre, primerApellido, segundoApellido, EstAlu.Nombre AS 'Estatus'
		FROM Alumnos Alu 
		INNER JOIN EstatusAlumnos EstAlu
        ON Alu.idEstatus = EstAlu.id
		where EstAlu.Nombre like 'En Capacitaci_n';

SELECT nombre, primerApellido, segundoApellido,  DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad' FROM Instructores WHERE  DATEDIFF(year, fechaNacimiento, GETDATE()) > 30;

SELECT nombre, primerApellido, segundoApellido,  DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad' FROM Alumnos WHERE  DATEDIFF(year, fechaNacimiento, GETDATE()) >= 20 AND DATEDIFF(year, fechaNacimiento, GETDATE()) <= 25;

SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', Esta.nombre AS 'Estado', EstAlu.Nombre AS 'Estatus'
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN EstatusAlumnos EstAlu
        ON Alu.idEstatus = EstAlu.id
		WHERE (Esta.nombre = 'Oaxaca' AND EstAlu.Nombre = 'En Capacitación') OR (Esta.nombre = 'Campeche' AND EstAlu.Nombre = 'Prospecto');

SELECT nombre, primerApellido, segundoApellido, correo from Alumnos where correo LIKE '%gmail%'; 


SELECT nombre, primerApellido, segundoApellido, fechaNacimiento from Alumnos where MONTH(fechaNacimiento) = 03; 

SELECT nombre, primerApellido, segundoApellido, fechaNacimiento, DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad Actual', DATEDIFF(year, fechaNacimiento, GETDATE()) +5 AS 'Edad en 5 años'  from Alumnos where (DATEDIFF(year, fechaNacimiento, GETDATE()) +5 ) > 30; 

SELECT nombre, primerApellido, segundoApellido from Alumnos where len(nombre) > 10; 

SELECT nombre, primerApellido, segundoApellido, curp from Alumnos where curp like '%[^A-Z]';

SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', CursAlu.calificacion
		FROM Alumnos Alu 
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		WHERE CursAlu.calificacion > 8;


		SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno',Alu.sueldo, EstAlu.Nombre AS 'Estatus'
		FROM Alumnos Alu 
		INNER JOIN EstatusAlumnos EstAlu
        ON Alu.idEstatus = EstAlu.id
		WHERE (EstAlu.Nombre = 'Laborando' OR EstAlu.Nombre = 'Liberado') AND Alu.sueldo > 15000;


		SELECT nombre, primerApellido, segundoApellido, fechaNacimiento from Alumnos where (YEAR(fechaNacimiento) >= 1990 AND YEAR(fechaNacimiento) <= 1995 ) AND (primerApellido LIKE 'B%' OR primerApellido LIKE 'C%' OR primerApellido LIKE 'Z%'); 

		SELECT id, nombre, primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', curp,fechaNacimiento, CONVERT(DATE, SUBSTRING(curp, 5, 6))  AS FechaCurp
		FROM Alumnos
		WHERE CONVERT(DATE, SUBSTRING(curp, 5, 6)) != fechaNacimiento;


		SELECT nombre, primerApellido, segundoApellido, fechaNacimiento, DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad Actual' from Alumnos where primerApellido LIKE 'A%' AND MONTH(fechaNacimiento) = 04 AND ( DATEDIFF(year, fechaNacimiento, GETDATE()) >= 21 AND DATEDIFF(year, fechaNacimiento, GETDATE()) <= 30 ); 


		SELECT nombre, primerApellido, segundoApellido from Alumnos where nombre LIKE '%LUIS%'; 

		SELECT CatCurs.nombre, fechaInicio, fechatermino, COUNT(CursAlu.idAlumno) AS 'Cantidad de Alumnos', AVG(CursAlu.calificacion) AS 'Promedio de calificaciones'
		FROM Alumnos Alu 
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		INNER JOIN Cursos Curs
        ON CursAlu.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id
		WHERE YEAR(fechaInicio) = 2024 AND YEAR(fechatermino) = 2024
		GROUP BY CatCurs.nombre, fechaInicio, fechatermino;

		SELECT Esta.nombre AS 'Estado', COUNT(Alu.idEstadoOrigen) AS 'Total Alumnos' , AVG(CursAlu.calificacion) AS 'Promedio del Estado' 
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		WHERE CursAlu.calificacion > 6
		GROUP BY Esta.nombre
		HAVING COUNT(Alu.idEstadoOrigen) > 1 AND AVG(CursAlu.calificacion) > 6;

		SELECT * FROM CursosAlumnos;