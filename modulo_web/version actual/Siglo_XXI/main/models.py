from django.db import models
from datetime import datetime
from django.utils.timezone import datetime
# Create your models here.

#Inicio Scrit.

class ClienteXxi(models.Model):
    id_cliente = models.BigIntegerField(primary_key=True)
    nombre_cli = models.CharField(max_length=30)
    correo_cli = models.CharField(max_length=30)
    telefono_cli = models.BigIntegerField()
    direccion_cli = models.CharField(max_length=50, blank=True, null=True)
    contrasena_cli = models.CharField(max_length=40)

    
    def __str__(self) :
        return self.nombre_cli



class EmpleadosXxi(models.Model):
    id_empleado = models.BigIntegerField(primary_key=True)
    nombre_emp = models.CharField(max_length=15)
    apellido_pat_emp = models.CharField(max_length=15)
    apellido_mat_emp = models.CharField(max_length=15)
    salario = models.BigIntegerField()
    fecha_nac = models.DateField()
    direccion_emp = models.CharField(max_length=30)
    telefono_emp = models.BigIntegerField()
    correo_emp = models.CharField(max_length=30)
    tipo_emplado_xxi_id_tipo_empleado = models.ForeignKey('TipoEmpladoXxi', models.DO_NOTHING, db_column='tipo_emplado_xxi_id_tipo_empleado')
    contrasena_emp = models.CharField(max_length=12)

    
    def __str__(self) :
        return self.nombre_emp

class FacturaXxi(models.Model):
    id_factura = models.BigIntegerField(primary_key=True)
    fecha = models.DateField()
    total = models.BigIntegerField()
    nom_proveedor = models.CharField(max_length=100, null=True)
    tipo_pago = models.CharField(max_length=50, null=True)
    media = models.FileField(upload_to="facturas" ,null=True)
    fecha_fact = models.CharField(max_length=15)
    
    
    def __str__(self) :
        return str(self.fecha)

class IngredientesXxi(models.Model):
    id_ingrediente = models.BigIntegerField(primary_key=True)
    ingrediente = models.CharField(max_length=50)
    marca = models.CharField(max_length=50)
    cantidad = models.BigIntegerField()
    issue_quantity = models.IntegerField(default='0', null=False)
    receive_quantity = models.IntegerField(default='0', null=False)
    export_to_CSV = models.BooleanField(default=False)

   
    def __str__(self) :
        return self.ingrediente

class MesaXxi(models.Model):
    id_mesa = models.BigIntegerField(primary_key=True)
    capacidad = models.BigIntegerField()

    
    def __str__(self) :
        return self.capacidad

class OrdenesXxi(models.Model):
    id_orden = models.BigIntegerField(primary_key=True)
    fecha = models.DateField()
    pagado = models.CharField(max_length=1)
    detalle = models.CharField(max_length=20)
    estado = models.CharField(max_length=12)
    cliente_xxi_id_cliente = models.ForeignKey(ClienteXxi, models.DO_NOTHING, db_column='cliente_xxi_id_cliente')
    mesa_xxi_id_mesa = models.ForeignKey(MesaXxi, models.DO_NOTHING, db_column='mesa_xxi_id_mesa')

    
    def __str__(self) :
        return self.estado

class ProductosXxi(models.Model):
    id_producto = models.BigIntegerField(primary_key=True)
    nombre = models.CharField(max_length=50)
    precio = models.BigIntegerField()
    img_producto = models.ImageField(upload_to="productos", null=True)
    tipo_producto_xxi_id_tipo_producto = models.ForeignKey('TipoProductoXxi', models.DO_NOTHING, db_column='tipo_producto_xxi_id_tipo_producto', null=True)
    reseta = models.CharField(max_length=800)
    

    
    def __str__(self) :
        return self.nombre

class ProveedoresXxi(models.Model):
    id_proveedor = models.BigIntegerField(primary_key=True)
    nombre_proveedor = models.CharField(max_length=50)
    telefono = models.BigIntegerField()
    correo = models.CharField(max_length=30)

    
    def __str__(self) :
        return self.nombre_proveedor

class Relation10(models.Model):
    ordenes_xxi_id_orden = models.OneToOneField(OrdenesXxi, models.DO_NOTHING, db_column='ordenes_xxi_id_orden', primary_key=True)
    factura_xxi_id_factura = models.ForeignKey(FacturaXxi, models.DO_NOTHING, db_column='factura_xxi_id_factura')

    


class Relation12(models.Model):
    mesa_xxi_id_mesa = models.OneToOneField(MesaXxi, models.DO_NOTHING, db_column='mesa_xxi_id_mesa', primary_key=True)
    cliente_xxi_id_cliente = models.ForeignKey(ClienteXxi, models.DO_NOTHING, db_column='cliente_xxi_id_cliente')

   


class Relation13(models.Model):
    cliente_xxi_id_cliente = models.OneToOneField(ClienteXxi, models.DO_NOTHING, db_column='cliente_xxi_id_cliente', primary_key=True)
    reservas_xxi_id_reserva = models.ForeignKey('ReservasXxi', models.DO_NOTHING, db_column='reservas_xxi_id_reserva')

    

class Relation3(models.Model):
    empleados_xxi_id_empleado = models.OneToOneField(EmpleadosXxi, models.DO_NOTHING, db_column='empleados_xxi_id_empleado', primary_key=True)
    ordenes_xxi_id_orden = models.ForeignKey(OrdenesXxi, models.DO_NOTHING, db_column='ordenes_xxi_id_orden')

    


class Relation31(models.Model):
    productos_xxi_id_producto = models.OneToOneField(ProductosXxi, models.DO_NOTHING, db_column='productos_xxi_id_producto', primary_key=True)
    ingredientes_xxi_id_ingrediente = models.ForeignKey(IngredientesXxi, models.DO_NOTHING, db_column='ingredientes_xxi_id_ingrediente')

  


class Relation32(models.Model):
    productos_xxi_id_producto = models.OneToOneField(ProductosXxi, models.DO_NOTHING, db_column='productos_xxi_id_producto', primary_key=True)
    ordenes_xxi_id_orden = models.ForeignKey(OrdenesXxi, models.DO_NOTHING, db_column='ordenes_xxi_id_orden')

    


class Relation33(models.Model):
    ingredientes_xxi_id_ingrediente = models.OneToOneField(IngredientesXxi, models.DO_NOTHING, db_column='ingredientes_xxi_id_ingrediente', primary_key=True)
    proveedores_xxi_id_proveedor = models.ForeignKey(ProveedoresXxi, models.DO_NOTHING, db_column='proveedores_xxi_id_proveedor')

    

class Relation8(models.Model):
    cliente_xxi_id_cliente = models.OneToOneField(ClienteXxi, models.DO_NOTHING, db_column='cliente_xxi_id_cliente', primary_key=True)
    ordenes_xxi_id_orden = models.ForeignKey(OrdenesXxi, models.DO_NOTHING, db_column='ordenes_xxi_id_orden')



class ReservasXxi(models.Model):
    id_reserva = models.BigIntegerField(primary_key=True)
    fecha_hora = models.DateField()
    cliente_xxi_id_cliente = models.ForeignKey(ClienteXxi, models.DO_NOTHING, db_column='cliente_xxi_id_cliente')

    
    def __str__(self) :
        return self.fecha_hora

class TipoEmpladoXxi(models.Model):
    id_tipo_empleado = models.BigIntegerField(primary_key=True)
    tipo_empleado = models.CharField(max_length=15)

    
    def __str__(self) :
        return self.tipo_empleado

class TipoPagoXxi(models.Model):
    id_tipo_pago = models.BigIntegerField(primary_key=True)
    tipo_pago = models.CharField(max_length=50)

    
    def __str__(self) :
        return self.tipo_pago

class TipoProductoXxi(models.Model):
    id_tipo_producto = models.BigIntegerField(primary_key=True)
    tipo_producto = models.CharField(max_length=50)

    
    def __str__(self) :
        return self.tipo_producto

#Fin Scrit.

class UserCocina(models.Model):
    id_cocina = models.IntegerField()

class UserBodega(models.Model):
    id_bodega = models.IntegerField()

class UserFinanzas(models.Model):
    id_finanzas = models.IntegerField()

class UserCliente(models.Model):
    id_cliente = models.IntegerField()

class FacturasXxi(models.Model):
    id_factura = models.AutoField(primary_key=True)
    fecha = models.DateField()
    total = models.BigIntegerField()
    nom_proveedor = models.CharField(max_length=100, null=True)
    tipo_pago = models.CharField(max_length=50, null=True)
    media = models.FileField(upload_to="facturas", null=True)
    
    
    def __str__(self) :
        return self.fecha

class ProveedoresXxi2(models.Model):
    id_proveedor = models.AutoField(primary_key=True)
    nombre_proveedor = models.CharField(max_length=50)
    telefono = models.BigIntegerField()
    correo = models.CharField(max_length=50)
    

    
    def __str__(self) :
        return self.nombre_proveedor

class Proveedores(models.Model):
    id_proveedor = models.AutoField(primary_key=True)
    nombre_proveedor = models.CharField(max_length=50)
    telefono = models.IntegerField()
    correo = models.CharField(max_length=50)
    nombre_contacto = models.CharField(max_length=50)
    region = models.CharField(max_length=50)
    #datos Banco.
    nombre_banco = models.CharField(max_length=50)
    banco = models.CharField(max_length=50)
    rut = models.IntegerField()
    numero_cuenta = models.IntegerField()
    tipo_cuenta = models.CharField(max_length=50)
    export_to_CSV = models.BooleanField(default=False)

    
    def __str__(self) :
        return self.nombre_proveedor

class USUARIOS_DESKTOP (models.Model):
    USERNAME = models.CharField(max_length=50)
    PASSWORD = models.CharField(max_length=50)
    NOMBRE = models.CharField(max_length=80)
    TIPO_USUARIO = models.CharField(max_length=50)

class TestXxi(models.Model):
    id_test = models.AutoField(primary_key=True)
    nombre = models.CharField(max_length=50)
    precio = models.BigIntegerField()
    img_producto = models.ImageField(upload_to="productos", null=True)
    img = models.ImageField(null=True)

class ordenes (models.Model):
    id_orden = models.AutoField(primary_key=True)
    total = models.BigIntegerField()
    datefield = models.DateTimeField(auto_now_add=True, auto_now=False)
    nombre_pedido = models.CharField(max_length=80, default='(null)')
    estado = models.CharField(max_length=50)
    export_to_CSV = models.BooleanField(default=False)
    date = models.CharField(max_length=50)
    
class detalle_ordenes(models.Model):
    id_detalle = models.AutoField(primary_key=True)
    detalle = models.CharField(max_length=800)
    acumulado = models.IntegerField()
    cantidad = models.IntegerField()
    datefield = models.DateTimeField(auto_now_add=True, auto_now=False)
    id_orde = models.IntegerField(default='(null)')
    nombre_pedido = models.CharField(max_length=80, default='(null)')

    
    

class testig_detalle(models.Model):
    id_test = models.AutoField(primary_key=True)
    nombre = models.CharField(max_length=800)
    acumulado = models.IntegerField()
    cantidad = models.IntegerField()
    
class grafic(models.Model):
    id = models.AutoField(primary_key=True)
    total = models.IntegerField()
    date = models.DateField(auto_now_add=True)

    def toJSON(self):
        item = model_to_dict(self)
        item ['date'] = self.date.strftime('%y-%m-%d')
        return item