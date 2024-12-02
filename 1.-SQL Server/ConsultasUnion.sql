use InstitutoTich;
GO

	SELECT 'Alumno' as TipoPersona,nombre, primerApellido, segundoApellido, MONTH(fechaNacimiento) AS 'MesNacimiento', DAY(fechaNacimiento) AS 'DiaNacimiento'
	FROM Alumnos
	UNION 
	SELECT 'Profesor' as TipoPersona, nombre, primerApellido, segundoApellido, MONTH(fechaNacimiento) AS 'MesNacimiento', DAY(fechaNacimiento) AS 'DiaNacimiento'
	FROM Instructores
	ORDER BY TipoPersona, MONTH(fechaNacimiento), DAY(fechaNacimiento)

