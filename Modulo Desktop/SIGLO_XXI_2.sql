--Mostrar Productos.
--CREATE OR REPLACE PROCEDURE MostrarProductos (registros OUT SYS_REFCURSOR)
--AS
    --BEGIN
        --OPEN registros FOR SELECT * FROM main_productosxxi;
    --END;
    
--Mostrar Tipo Producto.

--CREATE OR REPLACE PROCEDURE MostrarTipoProductos (registros OUT SYS_REFCURSOR)
--AS
    --BEGIN
       -- OPEN registros FOR SELECT * FROM main_tipoproductoxxi;
   -- END;
    
--Insertar Tipo Producto.

--CREATE OR REPLACE PROCEDURE InsertarTipoProducto (idp IN NUMBER, tipo IN VARCHAR2)
--AS
   -- BEGIN
        --INSERT INTO main_tipoproductoxxi (ID_TIPO_PRODUCTO, TIPO_PRODUCTO) VALUES (idp, tipo);
    --END;
    
--Insertar Tipo Producto 2.

--CREATE OR REPLACE PROCEDURE Insertar_Tipo_Producto (tipo IN VARCHAR2)
--AS
   --BEGIN
        --INSERT INTO main_tipoproductoxxi (TIPO_PRODUCTO) VALUES (tipo);
    --END;
    
--Sequencia id tipo producto.

--CREATE SEQUENCE TipoProductoSequencia START WITH 8;

--CREATE OR REPLACE TRIGGER TipoProductoTrig
    --BEFORE INSERT ON main_tipoproductoxxi
        --FOR EACH ROW
    --BEGIN
        --SELECT TipoProductoSequencia.NEXTVAL
        --INTO :new.ID_TIPO_PRODUCTO
        --FROM dual;
   -- END;
   
   
--

--Sequencia id.   
    --create SEQUENCE TipoProducto_sequencia START WITH 8;
    
--Tigger Proveedores

--CREATE OR REPLACE TRIGGER TipoProducto_trig
   -- BEFORE INSERT ON MAIN_TIPOPRODUCTOXXI
      --  FOR EACH ROW
   -- BEGIN
      --  SELECT TIPOPRODUCTO_SEQUENCIA.nextval
       -- INTO :new.ID_TIPO_PRODUCTO
       -- FROM dual;
   -- END;
   
--Modifiicar Tipo Producto.
--CREATE OR REPLACE PROCEDURE ActualizarTipoProducto (idp IN NUMBER, tipo IN VARCHAR2)
--AS
    --vid NUMBER := idp;
   -- vtipo VARCHAR2 (50) := tipo;
--BEGIN
   -- UPDATE MAIN_TIPOPRODUCTOXXI SET TIPO_PRODUCTO = vtipo WHERE ID_TIPO_PRODUCTO = vid;
--EXCEPTION
   -- WHEN NO_DATA_FOUND THEN
      --  null;
   -- WHEN OTHERS THEN
      --  RAISE;
   -- END ActualizarTipoProducto;
    
--Eliminar Tipo Producto.

--CREATE OR REPLACE PROCEDURE EliminarTipoProducto (idp IN NUMBER)
--AS
    --vid NUMBER := idp;
--BEGIN
    --DELETE FROM MAIN_TIPOPRODUCTOXXI WHERE ID_TIPO_PRODUCTO = vid;
--END;

--Mostrar Inventario.
--CREATE OR REPLACE PROCEDURE MostrarStock (registros OUT SYS_REFCURSOR)
--AS
    --BEGIN
       -- OPEN registros FOR SELECT * FROM main_ingredientesxxi;
   -- END;
   

--Mostrar Usuarios Desktop.
--CREATE OR REPLACE PROCEDURE MostrarUserDesktop (registros OUT SYS_REFCURSOR)
--AS
    --BEGIN
        --OPEN registros FOR SELECT * FROM main_usuarios_desktop;
   -- END;

--Insertar Usuario Desktop.

--CREATE OR REPLACE PROCEDURE InsertarUserDesktop (usern IN VARCHAR2, pass IN VARCHAR2, nom IN VARCHAR2, tip IN VARCHAR2)
--AS
   --BEGIN
    --    INSERT INTO main_usuarios_desktop (USERNAME, PASSWORD, NOMBRE, TIPO_USUARIO) VALUES (usern, pass, nom, tip);
   -- END;
   
--Modificar User Desktop.

--CREATE OR REPLACE PROCEDURE ActualizarUserDesktop (idu IN NUMBER, usern IN VARCHAR2, pass IN VARCHAR2, nom IN VARCHAR2, tip IN VARCHAR2)
--AS
    --vid NUMBER := idu;
    --vuser VARCHAR2 (50) := usern;
    --vpass VARCHAR2(50) := pass;
   -- vnom VARCHAR2(80) := nom;
   -- vtip VARCHAR2(50) := tip;
--BEGIN
   -- UPDATE main_usuarios_desktop SET USERNAME = vuser, PASSWORD = vpass, NOMBRE = vnom, TIPO_USUARIO = vtip WHERE ID = vid;
--EXCEPTION
   -- WHEN NO_DATA_FOUND THEN
    --    null;
   -- WHEN OTHERS THEN
    --    RAISE;
   -- END ActualizarUserDesktop;
   
--Eliminar Usuario Desktop.
--CREATE OR REPLACE PROCEDURE EliminarUserDesktop (idu IN NUMBER)
--AS
    --vid NUMBER := idu;
--BEGIN
    --DELETE FROM main_usuarios_desktop WHERE ID = vid;
--END;


    

    
    