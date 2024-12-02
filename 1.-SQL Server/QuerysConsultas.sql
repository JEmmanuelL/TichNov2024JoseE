use InstitutoTich;
GO

SELECT * FROM Alumnos;

SELECT primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', nombre,telefono, correo  FROM Alumnos;


SELECT nombre ,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno',rfc, cuotaHora AS 'Cuota por Hora'  FROM Instructores;

SELECT clave ,nombre, descripcion,horas FROM CatCursos;

SELECT TOP 5 2024-YEAR(fechaNacimiento) AS 'Edad', * FROM Alumnos ORDER BY 2024-YEAR(fechaNacimiento) ASC;

CREATE DATABASE Ejercicios;

SELECT * INTO Ejercicios.dbo.Alumnos FROM Alumnos;

SELECT * INTO Ejercicios.dbo.Instructores FROM Instructores;

