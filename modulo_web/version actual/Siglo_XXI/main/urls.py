from django.urls import path
from django.conf import settings
from django.conf.urls.static import static
from . import views

urlpatterns = [
    path('', views.index, name='index'),
    path('login', views.login, name='login'),
    path('logout', views.logout),

    ## URL Boddega.
    path('ingrediente', views.AddIngreddiente, name='ingrediente'),
    path('stock', views.lista_ingredientes, name='stock'),
    path('delate-stock/<id>/', views.eliminar_ingrediente, name='delate-stock'),
    path('stock_detail/<str:pk>/', views.stock_detail, name='stock_detail'),
    path('issue_items/<str:pk>/', views.issue_items, name="issue_items"),
    path('receive_items/<str:pk>/', views.receive_items, name="receive_items"),
    ## End URL Bodega.

    ## URL Finanzas.
    path('workstation_finanzas', views.workstation_finanzas, name='workstation_finanzas'),
    path('AddFactura', views.AddFactura , name='AddFactura'),
    path('add_proveedor', views.AddProveedor, name='add_proveedor'),
    path('lista_proveedores', views.lista_proveedores, name='lista_proveedores'),
    path('lista_facturas', views.lista_facturas, name='lista_facturas'),
    path('editar-factura/<id>/', views.editar_facturas, name='editar-factura'),
    path('delate-factura/<id>/', views.eliminar_factura, name='delate-factura'),
    path('delate-proveedor/<id>/', views.eliminar_proveedor, name='delate-proveedor'),
    path('list_ordenes', views.list_orden, name='list_ordenes'),
    path('AgreFactura', views.AgreFactura, name='AgreFactura'),
    path('orden_csv', views.ordenes_csv, name='orden_csv'),
    path('estado_ordenF/<id>/', views.estado_ordenF, name='estado_ordenF'),
    
    ## End URL Finanzas.

    ## URL Carrito.
    path('menu', views.menu, name="menu"),
    path('agregar/<int:id_producto>/', views.agregar_producto, name='Add'),
    path('eliminar/<int:id_producto>/', views.eliminar_producto, name='Del'),
    path('restar/<int:id_producto>/', views.restar_producto, name='Sub'),
    path('limpiar/', views.limpiar_carrito, name='CLS'),
    path('orden', views.AddOrden, name='orden'),
    ## End URL Carrito.

    ## URL Test.
    path('workstation', views.workstation, name='workstation'),
    path('addProductos', views.AddProducto, name='addProductos'),
    path('contactomail', views.contactomail, name='contactomail'),
    path('grafico', views.graficov, name='grafico'),
    path('group', views.addGroup, name='group'),

    ## End URL Test.

    ##URL Reportes
    path('reporteOrden', views.reporte_ordenes, name='reporteOrden'),
    path('reporteIngredientes', views.reporte_ingredientes, name='reporteIngredientes'),
    path('reporteProveedores', views.reporte_proveedores, name='reporteProveedores'),
    
    ##End URL Reportes.
    
    

    ##URL Cocina.
    path('cocina', views.workstation_cocina, name='cocina'),
    path('mesa_0', views.OrdenesMesa0, name='mesa_0'),
    path('mesa_1', views.OrdenesMesa1, name='mesa_1'),
    path('resetas', views.Resetas, name='resetas'),
    #path('list', views.ordenviews, name='list'),
    path('estado_orden/<id>/', views.estado_orden, name='estado_orden'),
    
]

if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)