use InstitutoTich;
GO

SELECT nombre
FROM Alumnos
WHERE len(nombre) >= ALL (SELECT TOP 1 LEN(nombre) FROM Alumnos ORDER BY LEN(nombre) DESC);


SELECT nombre, primerApellido, segundoApellido,  DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad' 
FROM Alumnos 
WHERE  DATEDIFF(year, fechaNacimiento, GETDATE()) >= ALL (SELECT top 1 DATEDIFF(year, fechaNacimiento, GETDATE()) FROM Alumnos ORDER BY DATEDIFF(year, fechaNacimiento, GETDATE()) DESC);;



SELECT Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', CatCurs.nombre AS 'Curso', Curs.fechaInicio, Curs.fechatermino, CursAlu.calificacion
FROM Alumnos Alu 
INNER JOIN Estados Esta 
ON Alu.idEstadoOrigen = Esta.id
INNER JOIN CursosAlumnos CursAlu 
ON Alu.id = CursAlu.idAlumno
INNER JOIN Cursos Curs
ON CursAlu.idCurso = Curs.id
INNER JOIN CatCursos CatCurs
ON Curs.idCatCurso = CatCurs.id
WHERE CursAlu.calificacion >= 10;




SELECT Alu.nombre, primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno',  Cat.nombre AS 'Curso', Cu.fechaInicio,Cu.fechatermino, CurAlu.calificacion
FROM Alumnos Alu
INNER JOIN ( 
			SELECT idAlumno, idCurso, MAX(calificacion) AS Calificacion
			FROM CursosAlumnos
			group by idAlumno, idCurso, calificacion
			) AS CurAlu
ON Alu.id = CurAlu.idAlumno
INNER JOIN ( 
			SELECT id, idCatCurso, fechaInicio, fechatermino
			FROM Cursos
			) AS Cu
ON CurAlu.idCurso = Cu.id
INNER JOIN ( 
			SELECT id, nombre
			FROM CatCursos
			) AS Cat
ON Cu.idCatCurso = Cat.id
WHERE CurAlu.Calificacion >= ALL (SELECT Calificacion from CursosAlumnos)


----------

SELECT Cat.nombre AS  'Curso', fechaInicio, fechatermino, CurAlu.Total, CurAlu.Maximo AS 'CalMax', CurAlu.Minimo 'CalMin', CurAlu.Promedio 'CalProm'
FROM Cursos Cu
INNER JOIN ( 
			SELECT id, nombre
			FROM CatCursos
			) AS Cat
ON Cu.idCatCurso = Cat.id
INNER JOIN ( 
			SELECT idCurso ,COUNT(idAlumno) AS 'Total', MAX(calificacion) AS 'Maximo', MIN(calificacion) AS 'Minimo', AVG(calificacion) AS 'Promedio'
			FROM CursosAlumnos
			group by idCurso
			) AS CurAlu
ON Cu.id = CurAlu.idCurso

----------------

select * from CursosAlumnos

SELECT Alu.nombre, primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno',  Cat.nombre AS 'Curso', Cu.fechaInicio,Cu.fechatermino, CurAlu.calificacion
FROM Alumnos Alu
INNER JOIN ( 
			SELECT idAlumno, idCurso, AVG(calificacion) AS Calificacion
			FROM CursosAlumnos
			group by idAlumno, idCurso, calificacion
			) AS CurAlu
ON Alu.id = CurAlu.idAlumno
INNER JOIN ( 
			SELECT id, idCatCurso, fechaInicio, fechatermino
			FROM Cursos
			) AS Cu
ON CurAlu.idCurso = Cu.id
INNER JOIN ( 
			SELECT id, nombre
			FROM CatCursos
			) AS Cat
ON Cu.idCatCurso = Cat.id
WHERE CurAlu.Calificacion <= ALL (SELECT AVG(calificacion) from CursosAlumnos)

------------------

SELECT Alu.nombre, primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno',  Cat.nombre AS 'Curso', Cu.fechaInicio,Cu.fechatermino, CurAlu.calificacion
FROM Alumnos Alu
INNER JOIN ( 
			SELECT idAlumno, idCurso, MAX(calificacion) AS Calificacion
			FROM CursosAlumnos
			group by idAlumno, idCurso, calificacion
			) AS CurAlu
ON Alu.id = CurAlu.idAlumno
INNER JOIN ( 
			SELECT id, idCatCurso, fechaInicio, fechatermino
			FROM Cursos
			) AS Cu
ON CurAlu.idCurso = Cu.id
INNER JOIN ( 
			SELECT id, nombre
			FROM CatCursos
			) AS Cat
ON Cu.idCatCurso = Cat.id
WHERE CurAlu.Calificacion >= ALL (SELECT MAX(calificacion) from CursosAlumnos WHERE idCurso = CurAlu.idCurso)