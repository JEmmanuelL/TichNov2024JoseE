use InstitutoTich;
GO

CREATE or Alter PROCEDURE procedureCodigoAscii
AS
BEGIN
  DECLARE @i INT = 33;
   while(@i>32 AND @i<255) 
	BEGIN
		print (CONCAT(Char(@i),' ASCII => ',@i));
		SET @i = @i +1 ;
	END

END


EXEC procedureCodigoAscii;


CREATE or Alter PROCEDURE FactorialProc
	@N1 int,
	@Result DECIMAL(18,2) OUTPUT
AS
BEGIN
		SET  @Result = (SELECT dbo.Factorial(@N1) as Factorial);
END

DECLARE @Resultado DECIMAL(18,2);
EXEC FactorialProc 5,@Resultado OUTPUT
PRINT @Resultado


CREATE or Alter PROCEDURE FactorialProc
	@N1 int,
	@Result DECIMAL(18,2) OUTPUT
AS
BEGIN
		
		SET  @Result = (SELECT dbo.Factorial(@N1) as Factorial);
END

DECLARE @Resultado DECIMAL(18,2);
EXEC FactorialProc 5,@Resultado OUTPUT
PRINT @Resultado