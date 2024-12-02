use InstitutoTich;
GO

CREATE OR ALTER VIEW VAlumnos
AS
SELECT Alu.id,Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', correo, telefono, curp,Esta.nombre AS 'Estado', EstaAlu.Nombre AS 'Estatus'
FROM Alumnos Alu 
INNER JOIN Estados Esta 
ON Alu.idEstadoOrigen = Esta.id
INNER JOIN EstatusAlumnos EstaAlu 
ON Alu.idEstatus = EstaAlu.id
WHERE EstaAlu.Nombre = 'Prospecto' OR EstaAlu.Nombre = 'Laborando' OR EstaAlu.Nombre = 'En capacitación';


--Ejecutar una vista:
SELECT *
FROM VAlumnos
WHERE Nombre LIKE '%Oscar%'

 create or alter procedure consultarEstados
  @id int
 as
  select id, nombre from estados where id=@id or @id=-1

  exec consultarEstados @id=-1;

  create or alter procedure consultarEstatusAlumnos
  @id int
 as
  select id, nombre from EstatusAlumnos where id=@id or @id=-1

  exec consultarEstatusAlumnos @id=-1;

  
  create or alter procedure consultarAlumnos
  @id int
 as
	SELECT Alu.id,Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', correo, fechaNacimiento, telefono, curp,Esta.nombre AS 'Estado', EstaAlu.Nombre AS 'Estatus'
	FROM Alumnos Alu 
	INNER JOIN Estados Esta 
	ON Alu.idEstadoOrigen = Esta.id
	INNER JOIN EstatusAlumnos EstaAlu 
	ON Alu.idEstatus = EstaAlu.id
	where Alu.id=@id or @id=-1

  exec consultarAlumnos @id=-1;

 create or alter procedure consultarEAlumnos
  @id int
 as
	SELECT Alu.id,Alu.nombre,primerApellido AS 'Apellido Paterno', segundoApellido AS 'Apellido Materno', correo, fechaNacimiento, telefono, curp,Alu.idEstadoOrigen AS 'Estado', Alu.idEstatus AS 'Estatus'
	FROM Alumnos Alu 
	where Alu.id=@id or @id=-1

	  exec consultarEAlumnos @id=-1;

 create or alter procedure actualizarEstatusAlumnos
  @id int,
  @IdEstatus int
 as
	declare @Cambios TABLE
	(
		nombre Varchar(50),
       Estatus_Anterior  Varchar(50),
       Estatus_Nuevo  Varchar(50)	
	   );	
	INSERT INTO @Cambios 
	SELECT Alu.nombre, EstaAlu.Nombre AS 'Estatus Anterior' ,(select nombre from EstatusAlumnos where id = @IdEstatus) AS 'Estatus Actual'
	FROM Alumnos Alu 
	INNER JOIN EstatusAlumnos EstaAlu 
	ON Alu.idEstatus = EstaAlu.id
	where Alu.id=@id

	UPDATE Alumnos SET idEstatus = @IdEstatus WHERE id = @Id;

	select * from @Cambios;

	
		  exec actualizarEstatusAlumnos 1,1;

		  select * from Alumnos

 create or alter procedure agregarAlumnos
  @nombre varchar(60),
  @primerApellido varchar(50),
  @segundoApellido varchar(50),
  @correo varchar(80),
  @telefono nchar(10),
  @fechaNacimiento date,
  @curp char(18),
  @sueldo decimal(9,2),
  @idEstadoOrigen int,
  @idEstatus smallint
 as
 DECLARE @id INT
INSERT INTO Alumnos VALUES ( @nombre, @primerApellido, @segundoApellido, @correo, @telefono, @fechaNacimiento, @curp, @sueldo, @idEstadoOrigen, @idEstatus)
 SET @id = SCOPE_IDENTITY()
select @id AS 'ID CREADA', * FROM Alumnos;

		  exec agregarAlumnos 'Jose','Lopez','Jimenez', 'Emma@gmail.com', '9211405292','2000-09-17',LOJE000917HVZPMMA1, 20000, 29,3;

 create or alter procedure actualizarAlumnos
  @id INT,
  @nombre varchar(60),
  @primerApellido varchar(50),
  @segundoApellido varchar(50),
  @correo varchar(80),
  @telefono nchar(10),
  @fechaNacimiento date,
  @curp char(18),
  @sueldo decimal(9,2),
  @idEstadoOrigen int,
  @idEstatus smallint
 as 
UPDATE [dbo].[Alumnos]
   SET [nombre] = @nombre
      ,[primerApellido] = @primerApellido
      ,[segundoApellido] = @segundoApellido
      ,[correo] = @correo
      ,[telefono] = @telefono
      ,[fechaNacimiento] = @fechaNacimiento
      ,[curp] = @curp
      ,[sueldo] = @sueldo
      ,[idEstadoOrigen] = @idEstadoOrigen
      ,[idEstatus] = @idEstatus
 WHERE id = @Id;

 SELECT * from alumnos;

 		  exec actualizarAlumnos 19,'Jose Emmanuel','Lopez','Jimenez', 'Emma@gmail.com', '9211405292','2000-09-17',LOJE000917HVZPMMA1, 20000, 29,3;


create or alter procedure eliminarAlumnos
  @id int
 as
     BEGIN TRY
        BEGIN TRANSACTION;
				declare @enc int = (select count(id) from Alumnos where id = @id);
					if(@enc != 0)
						BEGIN
							DELETE FROM CursosAlumnos WHERE idAlumno = @id;
							DELETE FROM Alumnos WHERE id = @id;
							COMMIT;

							/*SELECT Alu.id AS 'ID Alumno', Alu.nombre, primerApellido, segundoApellido, CuAlu.id AS 'ID CursoAlumno', CuAlu.idAlumno AS 'ID Alumno',CuAlu.idCurso AS 'ID Curso'
							FROM Alumnos Alu
							FULL JOIN CursosAlumnos CuAlu
							ON ALU.id = CuAlu.idAlumno;*/

						END
					ELSE
						BEGIN
						     ROLLBACK;
							PRINT concat('Error al eliminar al alumno con el id: ',@id);
						END         
    END TRY
    BEGIN CATCH
        ROLLBACK;
        PRINT concat('Error al eliminar al alumno con el id.',@id);
    END CATCH;


-------------------------------
	exec eliminarAlumnos 500;

/*	SET IDENTITY_INSERT [dbo].CursosAlumnos ON 
		INSERT [dbo].[Alumnos] ([id], [nombre], [primerApellido], [segundoApellido], [correo], [telefono], [fechaNacimiento], [curp], [sueldo], [idEstadoOrigen], [idEstatus]) VALUES (1, N'Marcelo Isai a', N'García', N'Mirón', N'marcelo@outlook.com', N'9911362600', CAST(N'1997-12-12' AS Date), N'MADA971212HVZRMN04', CAST(22000.00 AS Decimal(9, 2)), 29, 6);
	INSERT INTO CursosAlumnos (id,[idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (1,1,1,'2024-11-17','2024-11-24', 10);
	INSERT INTO CursosAlumnos (id,[idCurso], [idAlumno], [fechaInscripcion], [fechaBaja], [calificacion] )
				   VALUES (18,6,18,'2024-12-2','2024-12-29', 10);
	SET IDENTITY_INSERT [dbo].CursosAlumnos OFF */

	CREATE OR Alter TRIGGER Trigger_EliminarAlumnos
	ON alumnos
	AFTER DELETE
	AS
	BEGIN
		INSERT INTO AlumnosBaja (nombre,primerApellido,segundoApellido, FechaBaja)
		SELECT nombre,primerApellido, segundoApellido, GETDATE() FROM deleted;
	END

	BACKUP DATABASE InstitutoTich 
	TO DISK = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\Backup\\InstitutoTich.bak' 
	WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'RespaldoInstitutoTich'; 
	GO

	use PruebaTich

	GO

create or alter procedure spEliminaAlumnosCurso
  @NomCurso varchar(100)
 as
     BEGIN TRY
        BEGIN TRANSACTION;
		declare @idCatCurs int = (select id from CatCursos where nombre = @NomCurso);
		declare @CantAlumn int = (select count(Alu.id) from CatCursos Cat INNER JOIN Cursos Cu ON Cat.id = Cu.idCatCurso INNER JOIN CursosAlumnos CuAlu ON Cu.id = CuAlu.idCurso INNER JOIN Alumnos Alu ON CuAlu.idAlumno = Alu.id where Cat.id = @idCatCurs);
		declare @i int = 1;
		declare @IdAlum int;

					if(@idCatCurs != 0)
						BEGIN
								while(@CantAlumn>=@i)
								BEGIN
									SET @IdAlum = (select top 1 Alu.id
													from CatCursos Cat
													INNER JOIN Cursos Cu
													ON Cat.id = Cu.idCatCurso
													INNER JOIN CursosAlumnos CuAlu
													ON Cu.id = CuAlu.idCurso
													INNER JOIN Alumnos Alu
													ON CuAlu.idAlumno = Alu.id
													where Cat.id = @idCatCurs);
									exec eliminarAlumnos @IdAlum;
									SET @i= @i+1;
								END
						END
						ELSE
							BEGIN
								ROLLBACK;
								PRINT concat('No existe ningun curso con el nombre: ',@NomCurso);
							END
			COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
		PRINT concat('No existe ningun curso con el nombre: ',@NomCurso, ' idCAt: ', @idCatCurs, ' CantA: ',@CantAlumn, ' i: ',@i);
    END CATCH;


-------------------------------
	exec spEliminaAlumnosCurso 'ASP .NET C#';

	select * from CatCursos
	select * from Alumnos
	select * from CursosAlumnos
	select * from Cursos


									select Alu.id, Cat.nombre, Cu.id, Cu.idCatCurso
									from CatCursos Cat
									INNER JOIN Cursos Cu
									ON Cat.id = Cu.idCatCurso
									INNER JOIN CursosAlumnos CuAlu
									ON Cu.id = CuAlu.idCurso
									INNER JOIN Alumnos Alu
									ON CuAlu.idAlumno = Alu.id
									where Cat.nombre = 'ASP .NET C#'