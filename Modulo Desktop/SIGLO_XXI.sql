--Mostrar Proveedores.

--Create or REPLACE PROCEDURE seleccionarProveedores (registros out SYS_REFCURSOR)
--as
--BEGIN
    --open registros FOR SELECT * FROM main_proveedoresxxi2 ;
--END;

--Ingresar Proveedor.

--create or REPLACE PROCEDURE InsertarProveedor (nom in VARCHAR2, tel in NUMBER, mail in VARCHAR2)
--as
    --BEGIN
        --INSERT INTO main_proveedoresxxi2 (NOMBRE_PROVEEDOR, TELEFONO, CORREO) VALUES (nom,tel,mail);
    --END;

--Sequencia id.   
    --create SEQUENCE proveedores_sequencia START WITH 3;
    
--Tigger Proveedores

--CREATE OR REPLACE TRIGGER proveedor_trig
    --BEFORE INSERT ON main_proveedoresxxi2
        --FOR EACH ROW
    --BEGIN
        --SELECT PROVEEDORES_SEQUENCIA.nextval
        --INTO :new.ID_PROVEEDOR
        --FROM dual;
    --END;

--Modificar Proveedor.

--create or REPLACE PROCEDURE ModificarProveedor (idp in NUMBER, nom in VARCHAR2, tel in NUMBER, mail in VARCHAR2)
--as
    --vid NUMBER :=idp;
    --vnom VARCHAR2(50) := nom;
    --vtel NUMBER := tel;
    --vmail VARCHAR2(50) := mail;
--BEGIN
   -- UPDATE main_proveedoresxxi2 SET NOMBRE_PROVEEDOR = vnom, TELEFONO = vtel, CORREO = vmail WHERE ID_PROVEEDOR = vid;
--EXCEPTION
    --WHEN NO_DATA_FOUND THEN
        --null;
    --WHEN OTHERS THEN
        --raise;
    --END ModificarProveedor;
    
    
--Eliminar Proveedor.

--CREATE OR REPLACE PROCEDURE EliminarProveedor (idp in NUMBER)
--AS
    --vid number := idp;
--BEGIN
    --DELETE FROM main_proveedoresxxi2 WHERE ID_PROVEEDOR = vid;
--END;
    