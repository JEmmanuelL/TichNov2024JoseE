use InstitutoTich;

GO

CREATE TABLE Saldos (
id int IDENTITY,
Nombre varchar(50),
Saldo Decimal(19, 2),
primary key (id)
);

CREATE TABLE Transacciones (
id int IDENTITY,
idOrigen int,
idDestino int,
Monto Decimal(19, 2),
primary key (id)
);

CREATE or Alter PROCEDURE TransaccionM
    @CuentaOrigen INT,
    @CuentaDestino INT,
    @Monto DECIMAL(19, 2)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @saldo DECIMAL(19, 2);
        SELECT @saldo = Saldo FROM Saldos WHERE ID = @CuentaOrigen;

        IF(@CuentaOrigen != @CuentaDestino)
		BEGIN 
				IF @saldo >= @Monto
				BEGIN
					UPDATE Saldos SET saldo = Saldo - @Monto WHERE ID = @CuentaOrigen;

					UPDATE Saldos SET saldo = Saldo + @Monto WHERE ID = @CuentaDestino;
					COMMIT;
					SELECT 'Transacción hecha.' AS 'ESTATUS', CONCAT('ID: ',@CuentaOrigen,' Nombre: ',S1.Nombre) AS 'Desde', CONCAT('ID: ',@CuentaDestino,' Nombre: ',S2.Nombre) AS 'Para', @Monto AS 'Monto Transferido', S1.Saldo AS 'Saldo en cuenta origen', S2.Saldo AS 'Saldo en cuenta destino' FROM Saldos S1 INNER JOIN (SELECT id,Nombre,Saldo FROM Saldos) AS S2 ON S2.id = @CuentaDestino WHERE S1.id = @CuentaOrigen;
				END
				ELSE
				BEGIN
					ROLLBACK;
					PRINT 'Saldo insuficiente';
				END
		END
		ELSE
		BEGIN
					ROLLBACK;
					PRINT 'No se puede transferir a si mismo';
		END
    END TRY
    BEGIN CATCH
        ROLLBACK;
        PRINT 'Error en la transacción.';
    END CATCH;
END;

EXEC TransaccionM 1,1,100;

INSERT INTO Saldos(Nombre, Saldo)
		   VALUES ('Jose', '2000');

SELECT * FROM Saldos