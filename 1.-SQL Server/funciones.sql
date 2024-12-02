use InstitutoTich;
GO

CREATE OR ALTER FUNCTION Suma
(
@N1 float,
@N2 float
)
RETURNS float
AS
BEGIN
 RETURN @N1+@N2
END

SELECT dbo.Suma(5.5,6.7) as Suma

CREATE FUNCTION GetGenero
(
@Curp char(18)
)
RETURNS char(18)
AS
BEGIN
 RETURN IIF(SUBSTRING(@curp, 11, 1) = 'H', 'Hombre', IIF(SUBSTRING(@curp, 11, 1) = 'M', 'Mujer','Error en Curp'))
END

SELECT nombre,dbo.GetGenero(curp) as Genero
FROM Alumnos

CREATE FUNCTION GetFechaNacimiento
(
@curp char(18)
)
RETURNS char(18)
AS
BEGIN
 RETURN  SUBSTRING(@curp, 5, 6)
END

SELECT nombre,CONVERT(DATE, dbo.GetFechaNacimiento(curp)) as FechaCurp
FROM Alumnos

CREATE FUNCTION GetidEstado
(
@curp char(18)
)
RETURNS char(18)
AS
BEGIN
	declare @Estado char(18);
		SET @Estado = SUBSTRING(@curp, 12, 2);
return	CASE @Estado
		WHEN 'AS' THEN  '01'
		WHEN 'BC' THEN '02'
		WHEN 'BS' THEN '03'
		WHEN 'CC' THEN '04'
		WHEN 'CH' THEN '05'
		WHEN 'CS' THEN '06'
		WHEN 'CL' THEN '07'
		WHEN  'CM' THEN '08'
		WHEN  'DG' THEN '09'
		WHEN  'GT' THEN '10'
		WHEN  'GR' THEN '11'
		WHEN 'HG' THEN '12'
		WHEN  'JC' THEN '13'
		WHEN  'MC' THEN '14'
		WHEN  'MN' THEN '15'
		WHEN  'MS' THEN '16'
		WHEN  'NT' THEN '17'
		WHEN  'NL' THEN '18'
		WHEN  'OC' THEN '19'
		WHEN  'PL' THEN '20'
		WHEN  'QT' THEN '21'
		WHEN  'QR' THEN '22'
		WHEN 'SP' THEN '23'
		WHEN  'SL' THEN '24'
		WHEN  'SR' THEN '25'
		WHEN  'TC' THEN '26'
		WHEN  'TS' THEN '27'
		WHEN 'TL' THEN '28'
		WHEN  'VZ' THEN '29'
		WHEN 'YN' THEN '30'
		WHEN  'ZS' THEN '31'
		ELSE 'No esta registrado el estado'	
		END
END

SELECT nombre, idEstadoOrigen AS 'IdEstadoOrigen', dbo.GetidEstado(curp) as 'EstadoCurp'
FROM Alumnos


alter FUNCTION calculadora
(
@N1 decimal(9,2),
@N2 decimal(9,2),
@operador char(1)
)
RETURNS varchar(100)
AS
BEGIN
	declare @operacion char(18);
	declare @sahfsha varchar(100);

	IF((@N2 = 0) AND (@operador = '/' OR @operador = '%'))
		BEGIN
		SET @sahfsha = 'No se puede realizar una división entre 0'
		END
	ELSE
		BEGIN
			SET @sahfsha = CASE @operador
					WHEN  '+' THEN CONVERT(varchar,@N1+@N2)
					WHEN  '-' THEN CONVERT(varchar,@N1-@N2)
					WHEN  '*' THEN CONVERT(varchar,@N1*@N2)
					WHEN  '/' THEN CONVERT(varchar,@N1/@N2)
					WHEN  '%' THEN CONVERT(varchar,@N1%@N2)
					ELSE 'Operación Invalida'
					END
		END
		RETURN @sahfsha
END

SELECT dbo.calculadora(30,0,'/') as calculadora


CREATE FUNCTION GetHonorarios
(
@IdIns int,
@IdCurso int
)
RETURNS varchar(100)
AS
BEGIN
	declare @operacion char(18);

	SET @operacion = (SELECT cuotaHora FROM Instructores WHERE id = @IdIns) * (SELECT Cat.horas FROM Cursos Cu INNER JOIN CatCursos Cat ON Cu.idCatCurso = Cat.id  WHERE Cu.id = @IdCurso)

	SET @operacion = CONVERT(varchar,@operacion)

 RETURN @operacion
END

SELECT Ins.nombre AS 'Instructor', Ins.cuotaHora, CatCurs.horas,CatCurs.nombre ,dbo.GetHonorarios('1','2') as 'Calculo de Honorarios'
FROM Instructores Ins
		INNER JOIN CursosInstructores CursIns 
		ON Ins.id = CursIns.idInstructor
		INNER JOIN Cursos Curs
        ON CursIns.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id
		WHERE Ins.id = '1' AND Curs.id='2';


CREATE OR ALTER FUNCTION GetHonorarios2
(
@IdIns int,
@IdCurso int
)
RETURNS varchar(100)
AS
BEGIN
	declare @operacion char(18);

	SET @operacion = (SELECT cuotaHora FROM Instructores WHERE id = @IdIns) * (SELECT Cat.horas FROM Instructores Ins INNER JOIN CursosInstructores CursIns  ON Ins.id = CursIns.idInstructor INNER JOIN Cursos Curs ON CursIns.idCurso = Curs.id INNER JOIN CatCursos Cat ON Curs.idCatCurso = Cat.id WHERE Curs.id = @IdCurso AND Ins.id = @IdIns)

	SET @operacion = CONVERT(varchar,@operacion)

 RETURN @operacion
END

		Print dbo.GetHonorarios2('1','1');




select * from Instructores
select * from CursosInstructores
select * from Cursos
select * from CatCursos


ALTER FUNCTION GetEdad
(
@FechaN1 date,
@FechaN2 date
)
RETURNS varchar(100)
AS
BEGIN
	declare @Anio varchar(50);

	IF(YEAR(@FechaN2) >= YEAR(@FechaN1))
		BEGIN
			SET @Anio = DATEDIFF(year,@FechaN1,@FechaN2)
					IF(MONTH(@FechaN2) >= MONTH(@FechaN1))
					BEGIN
							IF(DAY(@FechaN2)>= DAY(@FechaN1))
							BEGIN
							SET @Anio = DATEDIFF(year,@FechaN1,@FechaN2) + 1; 
							END
					END
		END
	ELSE
		BEGIN
		SET @Anio = 'Ingrese una fecha valida para calcular la edad'
		END
	--2021-02-17 -> 2024-05-20 = 3-3-3 -> 2024-05-20 -> 4 AÑOS
 RETURN @Anio
END


declare @fechaIng date='2000-05-20';

SELECT nombre, fechaNacimiento AS 'FechaN1','2024-05-20' as 'FechaN2' , DATEDIFF(year, fechaNacimiento, GETDATE()) AS 'Edad Actual',dbo.GetEdad('2000-11-22',GETDATE()) as 'Calculo Años'
FROM Alumnos

select * from alumnos;


CREATE OR ALTER FUNCTION Factorial
(
@N1 decimal(10,2)
)
RETURNS decimal(10,2)
AS
BEGIN
	declare @v1 decimal(10,2);
	SET @v1 = (@N1-1)

	while (@v1 > 1)
		BEGIN
			SET @N1 = @N1 * @v1;
			SET @v1 = @v1-1
		END
 RETURN @N1
END

SELECT dbo.Factorial(5) as Factorial

/*CREATE OR ALTER FUNCTION ReembolsoQuincenal
(
@SueldoM decimal(10,3)
)
RETURNS decimal(10,3)
AS
BEGIN
	declare @v1 decimal(10,3);

	SET @SueldoM = @SueldoM*2.5;
	SET @SueldoM = @SueldoM/6;
	SET @SueldoM = @SueldoM/2;
	
 RETURN @SueldoM
END

--Rembolso quincenal 7500
SELECT dbo.ReembolsoQuincenal('20000') as 'Calculo Rembolso Quincenal' */

CREATE OR ALTER FUNCTION ReembolsoQuincenal
(
@SueldoM decimal(10,3)
)
RETURNS decimal(10,3)
AS
BEGIN
	declare @v1 decimal(10,3);

	SET @SueldoM = @SueldoM*2.5;
	SET @SueldoM = @SueldoM/6;
	SET @SueldoM = @SueldoM/2;
	
 RETURN @SueldoM
END

SELECT dbo.ReembolsoQuincenal('22000') as 'Calculo Rembolso Quincenal'

select * from Instructores


CREATE OR ALTER FUNCTION ImpuestoPagar
(
@IdIns int,
@IdCurso int
)
RETURNS varchar(100)
AS
BEGIN
	declare @operacion bigint;
	declare @Estado char(18);
	declare @curp char(18) = (SELECT curp FROM Instructores WHERE id = @IdIns);
	SET @Estado = SUBSTRING(@curp, 12, 2);

	SET @operacion = (SELECT cuotaHora FROM Instructores WHERE id = @IdIns) * (SELECT Cat.horas FROM Cursos Cu INNER JOIN CatCursos Cat ON Cu.idCatCurso = Cat.id  WHERE Cu.id = @IdCurso)

SET @operacion =CASE @Estado
				WHEN 'CS' THEN  @operacion*0.05
				WHEN 'SR' THEN	@operacion*0.10
				WHEN 'VZ' THEN	@operacion*0.07
				ELSE @operacion*0.08
				END

	SET @operacion = CONVERT(varchar,@operacion)

 RETURN @operacion
END

SELECT Ins.nombre AS 'Instructor',  SUBSTRING(curp, 12, 2) AS 'Estado Curp',Ins.cuotaHora, CatCurs.horas,CatCurs.nombre ,dbo.ImpuestoPagar(Ins.id,CatCurs.id) as 'Calculo de Impuesto a pagar'
FROM Instructores Ins
		INNER JOIN CursosInstructores CursIns 
		ON Ins.id = CursIns.idInstructor
		INNER JOIN Cursos Curs
        ON CursIns.idCurso = Curs.id
		INNER JOIN CatCursos CatCurs
		ON Curs.idCatCurso = CatCurs.id;



SELECT Alu.nombre, fechaInscripcion AS 'FechaN1', GETDATE()  as 'FechaN2' , DATEDIFF(year, Alu.fechaNacimiento, GETDATE()) AS 'Edad Actual',dbo.GetEdad(CursAlu.fechaInscripcion ,GETDATE()) as 'Calculo Años'
FROM Alumnos Alu
INNER JOIN CursosAlumnos CursAlu 
ON Alu.id = CursAlu.idAlumno
WHERE (dbo.GetEdad( Alu.fechaNacimiento,GETDATE()) > 25 )



CREATE OR ALTER FUNCTION MayusPrimer
(
@palabra varchar(100)
)
RETURNS varchar(100)
AS
BEGIN
		declare @NLetras int = len(@palabra);
		declare @i int = 0;
		SET @palabra = LOWER(@palabra);

			while (@NLetras>@i)
			BEGIN
				IF(SUBSTRING(@palabra,@i,1) = ' ' OR  @i = 0)
					BEGIN
					SET @palabra = STUFF(@palabra,(@i+1), 1,UPPER(SUBSTRING(@palabra,(@i+1),1)));
					SET @i = @i+1;
					END
				ELSE
					SET @i = @i+1;

			END

		RETURN @palabra
END

SELECT dbo.MayusPrimer('hola MUNDO yo soy  jose 1  ') as 'Modo Oracion'

CREATE OR ALTER FUNCTION DesconRem
(
@SueldoM decimal(10,3),
@Mes int
)
RETURNS float
AS
BEGIN
	declare @rembolso decimal(10,3);
	declare @porce float;
	/*IF(@Mes>6)
			SET @rembolso = 0;
	ELSE
		BEGIN
			IF(@Mes = 1)
				SET @rembolso = @SueldoM/1000;
			ELSE
				BEGIN
				SET @rembolso = @SueldoM/(@Mes*1000);
				END

		END*/
		SET @porce = @SueldoM/1000;
		SET @rembolso = CASE @Mes
				WHEN '1' THEN	@porce*0.1
				WHEN '2' THEN	@porce*0.75
				WHEN '3' THEN	@porce*0.50
				WHEN '4' THEN	@porce*0.25
				ELSE 0
				END 
	
 RETURN @rembolso 
END

SELECT dbo.DesconRem('50000','2') as 'porcentaje a descontar en los reembolsos'
