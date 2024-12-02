use InstitutoTich;
GO

select * from  Alumnos 
select * from Instructores

UPDATE Alu SET Alu.idEstatus = 3
	FROM Alumnos Alu 
	WHERE idEstatus = 2

	UPDATE Alu SET Alu.segundoApellido = upper(Alu.segundoApellido)
	FROM Alumnos Alu 

	UPDATE Alu SET Alu.segundoApellido =  CONCAT(UPPER(SUBSTRING(Alu.segundoApellido, 1,1)), LOWER(SUBSTRING(Alu.segundoApellido, 2, LEN(Alu.segundoApellido))))
	FROM Alumnos Alu 

	UPDATE Ins SET Ins.telefono = STUFF(Ins.telefono, 1, 2, '55')
	FROM Instructores Ins 
	WHERE SUBSTRING(Ins.curp, 12, 2) = 'DF'

	UPDATE CursAlu SET CursAlu.calificacion = IIF(CursAlu.calificacion <= '9', CursAlu.calificacion+1,'10' )
	FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno
		WHERE (Alu.idEstadoOrigen = '12' OR Alu.idEstadoOrigen = '19') AND (MONTH(CursAlu.fechaInscripcion) = 11  AND YEAR (CursAlu.fechaInscripcion) = 2024  )
		-----
		SELECT Alu.nombre, Esta.nombre AS 'Estado', CursAlu.calificacion, MONTH(CursAlu.fechaInscripcion) AS 'M', YEAR(CursAlu.fechaInscripcion) AS 'Y'
		FROM Alumnos Alu 
		INNER JOIN Estados Esta 
		ON Alu.idEstadoOrigen = Esta.id
		INNER JOIN CursosAlumnos CursAlu 
		ON Alu.id = CursAlu.idAlumno 
		WHERE (Alu.idEstadoOrigen = '12' OR Alu.idEstadoOrigen = '19') AND ( MONTH(CursAlu.fechaInscripcion) = 11  AND YEAR (CursAlu.fechaInscripcion) = 2024 ) 
		-----


			UPDATE Ins SET Ins.cuotaHora = (Ins.cuotaHora+Ins.cuotaHora*0.10)
			FROM Instructores Ins
			INNER JOIN CursosInstructores CursIns 
			ON Ins.id = CursIns.idInstructor
			INNER JOIN Cursos Curs
			ON CursIns.idCurso = Curs.id
			INNER JOIN CatCursos CatCurs
			ON Curs.idCatCurso = CatCurs.id
			WHERE CatCurs.nombre = 'ASP .NET MVC';

			-----
			SELECT Ins.nombre AS 'Instructor', Ins.cuotaHora, CatCurs.nombre, (Ins.cuotaHora+Ins.cuotaHora*0.10) AS 'cuota mas 10', Ins.cuotaHora*0.10 AS '%'
			FROM Instructores Ins
			INNER JOIN CursosInstructores CursIns 
			ON Ins.id = CursIns.idInstructor
			INNER JOIN Cursos Curs
			ON CursIns.idCurso = Curs.id
			INNER JOIN CatCursos CatCurs
			ON Curs.idCatCurso = CatCurs.id
			WHERE CatCurs.nombre = 'ASP .NET MVC';
			---

GO

Use Ejercicios

SELECT * INTO Ejercicios.dbo.AlumnosTodos FROM Alumnos;

SELECT * INTO Ejercicios.dbo.AlumnosHgo FROM Alumnos WHERE idEstadoOrigen = '12'

SELECT * from AlumnosTodos
SELECT * from AlumnosHgo

	UPDATE Ins SET Ins.telefono = STUFF(Ins.telefono, 1, 2, '77')
	FROM AlumnosHgo Ins 


	UPDATE AluT SET AluT.telefono = AluHg.telefono
	FROM AlumnosTodos AluT 
	INNER JOIN AlumnosHgo AluHg 
	ON AluHg.id = AluT.id


	select 'Tabla Hidalgo' AS TABLA, * from AlumnosHgo
	UNION
	select 'Tabla Todos' AS TABLA, * from AlumnosTodos where id=4
	ORDER BY TABLA

	