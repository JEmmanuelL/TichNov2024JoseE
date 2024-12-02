use InstitutoTich;

GO

CREATE TABLE TablaISR (
id int IDENTITY,
LimInf Decimal(19, 2),
LimSup Decimal(19, 2),
CuotaFija Decimal(19, 2),
ExedLimInf Decimal(19, 2),
Subsidio Decimal(19, 2),
primary key (id)
);


SELECT * FROM CursosInstructores;


INSERT INTO CatCursos ([clave], [nombre], [descripcion], [horas], [activo])
			   VALUES ('SQL', 'Bases de Datos SQL Server','Semana 1 donde aprendes SQL', 200, 1);


INSERT INTO CatCursos ([clave], [nombre], [descripcion], [horas], [idPreRequisito], [activo])
			   VALUES ('AspNet', 'Introducción a  ASP .NET y C#','Semana 2 introductorio', 100, 1, 0);


INSERT INTO CatCursos ([clave], [nombre], [descripcion], [horas], [idPreRequisito], [activo])
			   VALUES ('NetC', 'ASP .NET C#','Semana 3 ASP .NET con C# osea más caos', 105, 2, 0);

INSERT INTO CatCursos ([clave], [nombre], [descripcion], [horas], [idPreRequisito], [activo])
			   VALUES ('NetMVc', 'ASP .NET C#','Semana 4 ASP .NET con MVC la mera crema y nata', 50, 3, 0);


			   EXEC sp_helpconstraint CatCursos;


ALTER TABLE CatCursos DROP CONSTRAINT FK_Cursos_CatCursos;

ALTER TABLE Cursos DROP CONSTRAINT FK_Cursos_CatCursos;

ALTER TABLE Cursos ADD CONSTRAINT fK_CatCursos_Cursos_ID
FOREIGN KEY (idCatCurso) REFERENCES CatCursos(id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE CatCursos ADD CONSTRAINT fK_CatCursos_CatCursos_ID
FOREIGN KEY (idPreRequisito) REFERENCES CatCursos(id);

truncate table CatCursos;

SELECT * FROM Cursos;


INSERT INTO Cursos ([idCatCurso], [fechaInicio], [fechatermino], [activo])
			   VALUES (1, '2024-11-17','2024-11-24', 1);

INSERT INTO Cursos ([idCatCurso], [fechaInicio], [fechatermino], [activo])
			   VALUES (2, '2024-11-25','2024-12-02', 0);

INSERT INTO Cursos ([idCatCurso], [fechaInicio], [fechatermino], [activo])
			   VALUES (3, '2024-12-02','2024-12-08', 0);

INSERT INTO Cursos ([idCatCurso], [fechaInicio], [fechatermino], [activo])
			   VALUES (4, '2024-12-09','2024-12-15', 0);

INSERT INTO Cursos ([idCatCurso], [fechaInicio], [fechatermino], [activo])
			   VALUES (1, '2024-12-16','2024-12-22', 0);

INSERT INTO Cursos ([idCatCurso], [fechaInicio], [fechatermino], [activo])
			   VALUES (2, '2024-12-2','2024-12-29', 0);

INSERT INTO Cursos ([idCatCurso], [fechaInicio], [fechatermino], [activo])
			   VALUES (3, '2024-12-29','2025-01-05', 0);

GO

SELECT * FROM CursosAlumnos;

GO

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (1,1,'2024-11-17','2024-11-24', 10);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (1,2,'2024-11-18','2024-11-23', 8);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (1,3,'2024-11-19','2024-11-22', 7);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (2,4,'2024-11-25','2024-12-02', 5);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (2,5,'2024-11-26','2024-12-03', 7);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (2,6,'2024-11-27','2024-12-04', 6);
				   
INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (3,8,'2024-12-06','2024-12-12', 10);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (3,9,'2024-12-06','2024-12-09', 9);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (3,10,'2024-12-07','2024-12-08', 8);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (4,11,'2024-12-09','2024-12-15', 7);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (4,12,'2024-12-11','2024-12-13', 9);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (4,13,'2024-12-13','2024-12-14', 10);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (5,14,'2024-12-16','2024-12-22', 5);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (5,15,'2024-12-16','2024-12-22', 7);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (5,16,'2024-12-16','2024-12-22', 10);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (6,17,'2024-12-2','2024-12-29', 10);

INSERT INTO CursosAlumnos ([idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (6,18,'2024-12-2','2024-12-29', 10);

GO

SELECT * FROM CursosInstructores;

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (1,1,'2024-10-10');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (1,2,'2024-10-5');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (2,3,'2024-10-12');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (2,4,'2024-10-9');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (3,1,'2024-10-18');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (3,4,'2024-10-22');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (4,2,'2024-10-26');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (4,3,'2024-10-29');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (5,2,'2024-10-30');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (5,4,'2024-10-17');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (6,1,'2024-10-28');

INSERT INTO CursosInstructores ([idCurso], [idInstructor], [FechaContratación] )
						VALUES (6,3,'2024-10-31');

-- truncate table CursosInstructores;

GO

