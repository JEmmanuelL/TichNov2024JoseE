use InstitutoTich;
GO

CREATE OR ALTER FUNCTION TablaAmortiz 
(
@SueldoM decimal(10,3)
)
RETURNS @tablaAmortizacion TABLE
(
       Quincena SMALLINT identity(1,1),
       SaldoAnterior decimal(10,3),
       Pago decimal(10,3),
       SaldoNuevo decimal(10,3)
)
AS
BEGIN
	declare @Pago decimal(10,3) = @SueldoM;
	SET @Pago = @Pago*2.5;
	SET @Pago = @Pago/6;
	SET @Pago = @Pago/2;

	declare @SaldoA decimal(10,3) = @SueldoM*2.5;
	declare @SaldoN decimal(10,3);


	while (@SaldoA> 0)
		BEGIN
			SET @SaldoN = @SaldoA-@Pago;
			INSERT INTO @tablaAmortizacion ( [SaldoAnterior], [Pago], [SaldoNuevo])
									VALUES ( @SaldoA		,@Pago	, @SaldoN);
			SET @SaldoA = @SaldoN;

		END

       RETURN
END
GO

SELECT * FROM TablaAmortiz('50000')

select * from Alumnos

CREATE OR ALTER FUNCTION TablaAmortizPresIns 
(
@idIns int
)
RETURNS @tablaAmortizacionIns TABLE
(
       Mes SMALLINT identity(1,1),
       SaldoAnterior decimal(10,3),
	   Intereses decimal(10,3),
       Pago decimal(10,3),
       SaldoNuevo decimal(10,3)
)
AS
BEGIN
	declare @ImportePres decimal(10,3) = ((SELECT cuotaHora FROM Instructores WHERE id = @IdIns) * 200);
	declare @InteresAnual decimal(10,3);

	IF((SELECT cuotaHora FROM Instructores WHERE id = @IdIns) > 200)
		SET @InteresAnual = 0.24/12;
	ELSE
		SET @InteresAnual = 0.18/12;

	declare @Pago decimal(10,3) = ((SELECT cuotaHora FROM Instructores WHERE id = @IdIns) * 25);
	declare @SaldoN decimal(10,3);
	declare @SInteresPago decimal(10,3);


	while (@ImportePres> 0)
		BEGIN
			SET @SInteresPago = @ImportePres*@InteresAnual;
			IF(@Pago>@ImportePres)
				BEGIN
				SET @Pago = @ImportePres+@SInteresPago;
				END
			SET @SaldoN = (@ImportePres+@SInteresPago)-@Pago;
			INSERT INTO @tablaAmortizacionIns ( [SaldoAnterior], [Intereses], [Pago], [SaldoNuevo])
									VALUES ( @ImportePres	, @SInteresPago	,@Pago	, @SaldoN);
			SET @ImportePres = @SaldoN;

		END

       RETURN
END

SELECT * FROM TablaAmortizPresIns(4)

select * from Instructores

declare @ImportePres decimal(10,3)
set @ImportePres = (SELECT cuotaHora * 200 FROM Instructores WHERE id = 1 );
print @ImportePres;
declare @InteresAnual decimal(10,3);
declare @Pago decimal(10,3) = (SELECT cuotaHora * 25 FROM Instructores WHERE id = 1 );
declare @SaldoN decimal(10,3);
declare @SInteresPago decimal(10,3);





create or alter function Prestamos(@idInstructor int)
returns @amortizacion table(
	mes int,
	saldoAnterior decimal(9,3),
	intereses decimal(9,3),
	pago decimal(9,3),
	saldoNuevo decimal(9,3))
as
begin
	declare @mes int = 1
	declare @saldoAnterior decimal(9,3) = (select cuotaHora * 200 from Instructores where @idInstructor = id)
	declare @intereses decimal(9,3)

	if((select cuotaHora from Instructores where @idInstructor = id) > 200)
	set @intereses = 0.24/12
	else
	set @intereses = 0.18/12

	declare @interesPago decimal(9,3)
	declare @pago decimal(9,3) = ((select cuotaHora from Instructores where @idInstructor = id)*25)
	declare @saldoNuevo decimal(9,3)

	while(@saldoAnterior > 0)
		begin		
		set @interesPago = @intereses * @saldoAnterior
		
		if(@pago > @saldoAnterior)
			begin
			set @pago = @saldoAnterior + @interesPago
			end
			set @saldoNuevo = (@saldoAnterior +@interesPago) - @pago

			INSERT INTO @amortizacion
				select @mes, @saldoAnterior, @interesPago, @pago, @saldoNuevo;
				set @saldoAnterior = @saldoNuevo
				set @mes = @mes + 1	
		end
	return
end

SELECT * FROM Prestamos(1)

CREATE OR ALTER FUNCTION TablaAmortizacionY
(
	@idInstructor INT
)
RETURNS @tablaAmortizacion TABLE
(
	Mes INT IDENTITY(1,1),
	[Saldo Anterior] DECIMAL(19,4),
	Intereses DECIMAL(19,4),
	Pago DECIMAL(19,4),
	[Saldo Nuevo] DECIMAL(19,4)
)
AS
BEGIN
	DECLARE @importe DECIMAL(19,4);
	DECLARE @interes DECIMAL(19,4);
	DECLARE @pagoMensual DECIMAL(19,4);
	DECLARE @deudaInicial DECIMAL(19,4);
	DECLARE @deudaFinal DECIMAL(19,4);

	SELECT @importe = cuotaHora FROM Instructores WHERE id = @idInstructor;

	SET @deudaInicial = @importe * 200

	IF (@importe > 200)
	SET @interes = 0.02
	ELSE
	SET @interes = 0.015

	SET @pagoMensual = @importe * 25;
	declare @interes2 decimal(19,4);

	WHILE (@deudaInicial>0)
	BEGIN 
			--53000 	--17800		*	0.015
		SET @interes2 = @deudaInicial * @interes
			--17800			--20000	      --300		   --2500
		SET @deudaFinal = (@deudaInicial + @interes2) - @pagoMensual

		INSERT INTO @tablaAmortizacion
						--20000			--300		--2500		-17800
				SELECT @deudaInicial, @interes2, @pagoMensual, @deudaFinal
				--17800		--17800
		SET @deudaInicial = @deudaFinal 
		
	END
	RETURN
END

SELECT * FROM TablaAmortizacionY(1)
