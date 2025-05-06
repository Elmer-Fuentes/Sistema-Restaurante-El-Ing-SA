use Proyecto_Restaurante
go
CREATE PROCEDURE MODO_GUERRA (
    @sources VARCHAR(20)
)
AS
BEGIN
    SET @sources = LOWER('%mi_compa%');

    IF @sources LIKE '%mi_compa%'
    BEGIN
        SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES;
    END;
END;