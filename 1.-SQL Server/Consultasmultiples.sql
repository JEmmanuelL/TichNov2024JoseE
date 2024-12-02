use InstitutoTich;
GO

SELECT * FROM CatCursos

SELECT nombre ,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno',rfc, cuotaHora AS 'Cuota por Hora', IIF(activo>0, 'Activo', 'Inactivo') as [Estatus]   FROM Instructores;

SELECT Catcur.Nombre as Curso, Horas as horas, Cur.fechaInicio,fechatermino
	FROM Cursos Cur INNER JOIN  CatCursos Catcur
	ON Cur.idCatCurso = Catcur.id


SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno',curp, Esta.nombre AS 'Estado', EstAlu.Nombre AS 'Estatus'
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN EstatusAlumnos EstAlu
        ON Alu.idEstatus = EstAlu.id;



SELECT Ins.nombre AS 'Instructor', Ins.cuotaHora, CatCurs.nombre ,Curs.fechaInicio, Curs.fechatermino
FROM Instructores Ins
		INNER JOIN CursosInstructores CursIns 
		ON Ins.id = CursIns.idInstructor
		INNER JOIN Cursos Curs
        ON CursIns.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id;


		SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', Esta.nombre AS 'Estado', CatCurs.nombre AS 'Curso', CursAlu.fechaInscripcion ,Curs.fechaInicio, Curs.fechatermino, CursAlu.calificacion
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		INNER JOIN Cursos Curs
        ON CursAlu.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id;


		SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', Esta.nombre AS 'Estado', CatCurs.nombre AS 'Curso', CursAlu.fechaInscripcion ,Curs.fechaInicio, Curs.fechatermino, CursAlu.calificacion
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		INNER JOIN Cursos Curs
        ON CursAlu.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id
		ORDER BY calificacion DESC;


		SELECT clave, nombre AS 'Curso', horas,
		CASE idPreRequisito
		WHEN  1 THEN 'Bases de Datos SQL Server'
		WHEN  2 THEN 'Introducción a  ASP .NET y C#'
		WHEN  3 THEN 'ASP .NET C#'
		WHEN  4 THEN 'ASP .NET MVC'
		ELSE 'Sin PreRequisito'
		END AS 'PreRequisito'
		FROM CatCursos

		SELECT Cat1.clave, Cat1.nombre AS 'Curso', Cat1.horas, ISNULL(Cat2.nombre, 'SinPrerequisito') AS 'PreRequisito'
		FROM CatCursos Cat1
		LEFT JOIN CatCursos Cat2
		ON Cat1.idPreRequisito = Cat2.id;

		select * from CatCursos


		SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', CatCurs.nombre AS 'Curso' ,Curs.fechaInicio, Curs.fechatermino, CursAlu.calificacion,
		CASE 
		WHEN CursAlu.calificacion BETWEEN 9 AND 10 THEN 'Excelente'
		WHEN CursAlu.calificacion BETWEEN 7 AND 8 THEN 'Bien'
		WHEN CursAlu.calificacion BETWEEN 6 AND 6 THEN  'Suficiente'
		ELSE 'N/A'
		END AS 'Nivel'
		FROM Alumnos Alu 
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		INNER JOIN Cursos Curs
        ON CursAlu.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id;


		-----upd
		SELECT Alu.nombre, Esta.nombre AS 'Estado', CursAlu.calificacion
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno