use InstitutoTich;
GO


	SELECT  Esta.nombre AS 'Estado', COUNT(Esta.nombre) AS 'Total'
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		WHERE Alu.idEstadoOrigen = Esta.id
		group by Esta.nombre;


		SELECT EstAlu.Nombre AS 'Estatus', COUNT(EstAlu.Nombre) AS 'Total'
		FROM Alumnos Alu 
		INNER JOIN EstatusAlumnos EstAlu
        ON Alu.idEstatus = EstAlu.id
		group by EstAlu.Nombre;

		select 'Calificaciones de Alumnos' AS 'Resumen de calificaciones', COUNT(idAlumno) AS 'Total', MAX(calificacion) AS 'Maxima', MIN(calificacion) 'Minima', AVG(calificacion) 'Promedio' from CursosAlumnos

		
		
		SELECT CatCurs.nombre, fechaInicio, fechatermino, COUNT(CursAlu.idAlumno) AS 'Total', MAX(CursAlu.calificacion) AS 'Maximo', MIN(CursAlu.calificacion) AS 'Minimo', AVG(CursAlu.calificacion) AS 'Promedio'
		FROM Alumnos Alu 
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		INNER JOIN Cursos Curs
        ON CursAlu.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id
		GROUP BY CatCurs.nombre, fechaInicio, fechatermino;


		


		select * from CursosAlumnos

		-- UPDATE CatCursos SET nombre = 'ASP .NET MVC' where clave = 'NetMVc';