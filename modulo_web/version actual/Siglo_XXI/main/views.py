from django.shortcuts import render, redirect, get_object_or_404
from django.contrib.auth import logout as do_logout
from django.contrib.auth import authenticate
from django.contrib.auth.forms import AuthenticationForm
from django.contrib.auth import login as do_login
from django.template import loader
from .forms import *
from .models import *
from django.contrib import messages
from main.Carrito import Carrito
from django.http import HttpResponse
import csv
from django.views.generic import ListView
from django.core.mail import EmailMessage
from django.core.mail import send_mail
from django.views.generic import TemplateView

import datetime

# Create your views here.

def index (request):
    template = loader.get_template('main/index.html')
    context = {}
    return HttpResponse(template.render(context, request))

def handler404 (request,*args,**argv):
    return render(request, 'main/index.html')

def login(request):
    
    form = AuthenticationForm()
    if request.method == "POST":
        form = AuthenticationForm(data=request.POST)
        if form.is_valid():
            username = form.cleaned_data['username']
            password = form.cleaned_data['password']

            user = authenticate(username=username, password=password)

            if user is not None:
                do_login(request, user)
                return redirect('/menu')
                

    return render(request, "main/login.html", {'form': form})

def logout(request):
    
    do_logout(request)
    
    return redirect('login')

## Vistas de Bodega.

def AddIngreddiente (request):
    form = IngredienteForm()

    if request.method == "POST":
        form = IngredienteForm(request.POST)
        if form.is_valid():
            prod = form.save(commit=False)
            prod.save()
            messages.success(request, "Agregado Correctamente")
            return redirect('/stock')
    context = {
		
        "icons":'success',
	}
    return render(request, 'main/bodega/bodega_ingrediente.html', context)
    

def lista_ingredientes (request):
    ingredientes = IngredientesXxi.objects.all()
    form = stock_csvForm(request.POST or None)

    data = {
        'IngredientesXxi': ingredientes,
        'form':form,
    }
    if request.method == 'POST':
        ingredientes = IngredientesXxi.objects.filter(ingrediente__icontains=form['ingrediente'].value())
        
        if form['export_to_CSV'].value() == True:
            response = HttpResponse(content_type='text/csv')
            response['Content-Diisposition'] = 'attachment; filename="List of stock.csv"'
            writer = csv.writer(response)
            writer.writerow(['INGREDIENTE', 'MARCA', 'CANTIDAD', 'ULTIMO DESCUENTO', 'ULTIMO AUMENTO'])
            instance = ingredientes
            for stock in instance:
                writer.writerow([stock.ingrediente, stock.marca, stock.cantidad, stock.issue_quantity, stock.receive_quantity])
            return response

        data = {
            'IngredientesXxi':ingredientes,
            'form':form,
        }

    return render(request, 'main/bodega/lista_ingredientes.html', data)


def eliminar_ingrediente(request, id):

    ingredientes = get_object_or_404(IngredientesXxi, id_ingrediente = id)
    ingredientes.delete()
    messages.success(request, "Eliminado correctamente")

    return redirect(to="stock")

def stock_detail(request, pk):
    queryset = IngredientesXxi.objects.get(id_ingrediente=pk)
    context = {
        "queryset": queryset,
    }
    return render(request, 'main/bodega/stock_detail.html', context)

#stock change

def issue_items(request, pk):
	queryset = IngredientesXxi.objects.get(id_ingrediente=pk)
	form = IssueForm(request.POST or None, instance=queryset)
	if form.is_valid():
		instance = form.save(commit=False)
		instance.cantidad -= instance.issue_quantity
		messages.success(request, "Modificado!, Quedan " + str(instance.cantidad) + " de " + str(instance.ingrediente))
		instance.save()

		return redirect('/stock')
		# return HttpResponseRedirect(instance.get_absolute_url())

	context = {
		"title": 'Restando stock: ' + str(queryset.ingrediente),
		"queryset": queryset,
		"form": form,
		"username": 'Issue By: ' + str(request.user),
        "icons":'info',
	}
	return render(request, "main/bodega/modificar_stock.html", context)



def receive_items(request, pk):
	queryset = IngredientesXxi.objects.get(id_ingrediente=pk)
	form = ReceiveForm(request.POST or None, instance=queryset)
	if form.is_valid():
		instance = form.save(commit=False)
		instance.cantidad += instance.receive_quantity
		instance.save()
		messages.success(request, "Modificado!, Quedan " + str(instance.cantidad) + " de " + str(instance.ingrediente))

		return redirect('/stock')
		# return HttpResponseRedirect(instance.get_absolute_url())
	context = {
			"title": 'Agregando stock: ' + str(queryset.ingrediente),
			"instance": queryset,
			"form": form,
			"username": 'Receive By: ' + str(request.user),
            "icons":'info',
		}
	return render(request, "main/bodega/modificar_stock.html", context)

## End Vistas Bodega.



#carrito

def menu(request):
    productos = ProductosXxi.objects.all()
    orde = ordenes.objects.all()
    orden = ProductosXxi.objects.order_by('tipo_producto_xxi_id_tipo_producto')
    
    data = {
        'ProductosXxi': productos,
        'ordenes': orde,
        'ProductosXxi': orden
        
    }
    total = 0
    cant = 0
    idd = 0
    ##cant = request.session.carrito.items.cantidad.sum()

    try:
        for key, value in request.session["carrito"].items():
            total += int(value["acumulado"])
            cant = (value["cantidad"])
    except:
        request
        #data['mensaje'] = 'Te Esperabamos'
    if request.POST:
        orden = ordenes()
        
        #orden.id_orden = None
        orden.total = total
        orden.estado = 'Pendiente'
        orden.nombre_pedido = request.POST.get('txtnombre')
        orden.date = request.POST.get('date')


        try:
            orden.save()
            data['mensaje'] = 'Pedido Realizado'
        except:
            data['mensaje'] = 'Algo Fallo'

        try:
            for key, value in request.session["carrito"].items():
                    
                    detalle = detalle_ordenes()
                    id_or = ordenes.id_orden
                                        
                    detalle.detalle = (value["nombre"])
                    detalle.acumulado = (value["acumulado"])
                    detalle.cantidad = (value["cantidad"])
                    detalle.id_orde = orden.id_orden
                    detalle.nombre_pedido = request.POST.get('txtnombre')

                    detalle.save()
                    carrito = Carrito(request)
                    carrito.limpiar()    
        except:
            request

    return render(request, 'main/carrito/menu.html', data)

def agregar_producto(request, id_producto):
    carrito = Carrito(request)
    producto = ProductosXxi.objects.get(id_producto=id_producto)
    carrito.agregar(producto)
    return redirect("menu")

def eliminar_producto(request, id_producto):
    carrito = Carrito(request)
    producto = ProductosXxi.objects.get(id_producto=id_producto)
    carrito.eliminar(producto)
    return redirect("menu")

def restar_producto(request, id_producto):
    carrito = Carrito(request)
    producto = ProductosXxi.objects.get(id_producto=id_producto)
    carrito.restar(producto)
    return redirect("menu")

def limpiar_carrito(request):
    carrito = Carrito(request)
    carrito.limpiar()
    return redirect("menu")


#end Carrito

## Vistas de Finanzas.

def workstation_finanzas (request):
    template = loader.get_template('main/finanzas/workstation_finanzas.html')
    context = {}
    return HttpResponse(template.render(context, request))

def AddProveedor (request):
    form = proveedoresForm()
    form = proveedoresForm2()

    if request.method == "POST":
        form = proveedoresForm(request.POST)
        form = proveedoresForm2(request.POST)
        if form.is_valid():
            prov = form.save(commit=False)
            prov.save()
            messages.success(request, "Agregado Correctamente")
            return redirect('/lista_proveedores')

    return render(request, 'main/finanzas/finanzas_proveedores.html')

def lista____proveedores(request):
    proveedores = Proveedores.objects.all()

    data = {
        'Proveedores': proveedores
    }

    return render(request, 'main/finanzas/lista_proveedores.html', data)


def AddFactura(request):
    proveedores = Proveedores.objects.all()
    tipo_pago = TipoPagoXxi.objects.all()

    data = {
        'Proveedores': proveedores,
        'TipoPagoXxi': tipo_pago,
        'form':facturasForm
    }

    form = facturasForm()

    if request.method == "POST":
        form = facturasForm(request.POST, files=request.FILES)
        if form.is_valid():
            
            form.save()
            
            messages.success(request, "Agregado Correctamente")
            return redirect('/lista_facturas')

    return render(request, 'main/finanzas/finanzas_facturas.html', data)


def lista_facturas(request):
    facturas = FacturaXxi.objects.all()

    data = {
        'FacturaXxi': facturas
    }

    return render(request, 'main/finanzas/lista_facturas.html', data)

def editar_facturas(request, id):
    
    factura = get_object_or_404(FacturaXxi, id_factura = id)
    proveedores = ProveedoresXxi2.objects.all()
    tipo_pago = TipoPagoXxi.objects.all()

    data = {
        'form': facturasForm(instance=factura),
        'ProveedoresXxi2': proveedores,
        'TipoPagoXxi': tipo_pago,
    }
    if request.method == 'POST':
        formmulario = facturasForm(data=request.POST, instance=factura)

        if formmulario.is_valid():
            formmulario.save()
            messages.success(request, "Factura Modificada" )
            return redirect(to="lista_facturas")
        data["form"] = formmulario        
    
    return render(request, 'main/finanzas/editar_facturas.html', data)

def eliminar_factura(request, id):

    factura = get_object_or_404(FacturaXxi, id_factura = id)
    factura.delete()
    messages.success(request, "Eliminado correctamente")

    return redirect(to="lista_facturas")

def eliminar_proveedor(request, id):

    proveedor = get_object_or_404(Proveedores, id_proveedor = id)
    proveedor.delete()
    messages.success(request, "Eliminado correctamente")

    return redirect(to="lista_proveedores")
## End Vistas Finanzas.

## Vistas Test.
def workstation (request):
    template = loader.get_template('main/test/workstation.html')
    context = {}
    return HttpResponse(template.render(context, request))

## End Vistas Test.

## Vistas Cocina.

def AddProducto (request):
    
    tipo = TipoProductoXxi.objects.all()
    variables = {
        'tipo':tipo
    }

    if  request.POST:
        producto = ProductosXxi()
        producto.id_producto = request.POST.get('txtId')
        producto.nombre = request.POST.get('txtNombre')
        producto.precio = request.POST.get('txtPrecio')
        producto.img_producto = request.FILES.get('txtImagen')
        producto.reseta = request.POST.get('txtreseta')
        tipo_producto_xxi_id_tipo_producto = TipoProductoXxi()
        tipo_producto_xxi_id_tipo_producto.id_tipo_producto = request.POST.get('txtTipo')
        producto.tipo_producto_xxi_id_tipo_producto = tipo_producto_xxi_id_tipo_producto

        try:
            producto.save()
            variables['mensaje'] = 'Guardado Correctamente'
        except:
            variables['mensaje'] = 'Fallo Al Guardar'

    return render(request, 'main/cocina/cocina_productos.html', variables)

def workstation_cocina (request):
    #form = detalleform(request.POST or None)
    form1 = detalleform1(request.POST or None)
    

    
    if request:
        orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 1', estado__contains='Pendiente')
        #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0', id_orde__icontains=form['id_orde'].value())

        data = {
        ##'form': form,
        'ordenes': orden,
        #'detalle_ordenes': detalle,          
        }
    if request:
        ordene = ordenes.objects.filter( estado__contains='Pendiente')
        detalle = detalle_ordenes.objects.filter(id_orde__icontains=form1['id_orde'].value())
    
        data = {
            'form': form1,
            'ordenes': ordene,
            'detalle_ordenes': detalle,
                         
        }
    
    
    

    return render(request, 'main/cocina/workstation_cocina.html', data)

def AddOrden (request):

    variables={

    }
    if request.POST:
        
        detalle = testig_detalle()
        detalle.nombre = detalle_carrito_nombre
        detalle.acumulado = request.POST.get('txtacumulado')
        detalle.cantidad = request.POST.get('txtcantidad')
    
                      
        
        

        try:
            detalle.save()
            variables['mensaje'] = 'Pedido'
        except:
            variables['mensaje'] = 'Algo Fallo'

        
            

    return render(request, 'main/carrito/carrito.html', variables)

def download(request,path):
    file_path=os.path.join(settings.MEDIA_ROOT,path)
    if os.path.exists(file_path):
        with open(file_path,'rb')as fh:
            response=HttpResponse(fh.read(),content_type="application/media")
            response['Content-Disposition']='inlne;filename='+os.path.basename(file_path)
            return response
    raise Http404

# Mesas de Cocina

def OrdenesMesa0(request):
    form = detalleform(request.POST or None)
    orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 0', estado__contains='Pendiente')
    #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0')
    detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0', id_orde__icontains=form['id_orde'].value())
    

    data = {
        'ordenes': orden,
        'detalle_ordenes': detalle,
        'form': form,
        
        
    }

    return render(request, 'main/cocina/mesas/mesa_0.html', data)

def OrdenesMesa1(request):
    form1 = detalleform1(request.POST or None)
    orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 1', estado__contains='Pendiente')
    #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0')
    detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 1', id_orde__icontains=form1['id_orde'].value())
    

    data = {
        'ordenes': orden,
        'detalle_ordenes': detalle,
        'form1': form1,
        
        
    }

    return render(request, 'main/cocina/mesas/mesa_1.html', data)

def OrdenesMesa2(request):
    form = detalleform(request.POST or None)
    orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 2', estado__contains='Pendiente')
    #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0')
    detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 2', id_orde__icontains=form['id_orde'].value())
    

    data = {
        'ordenes': orden,
        'detalle_ordenes': detalle,
        'form': form,
        
        
    }

    return render(request, 'main/cocina/mesas/mesa_2.html', data)

def OrdenesMesa3(request):
    form = detalleform(request.POST or None)
    orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 3', estado__contains='Pendiente')
    #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0')
    detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 03', id_orde__icontains=form['id_orde'].value())
    

    data = {
        'ordenes': orden,
        'detalle_ordenes': detalle,
        'form': form,
        
        
    }

    return render(request, 'main/cocina/mesas/mesa_3.html', data)


def OrdenesMesa4(request):
    form = detalleform(request.POST or None)
    orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 4', estado__contains='Pendiente')
    #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0')
    detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 4', id_orde__icontains=form['id_orde'].value())
    

    data = {
        'ordenes': orden,
        'detalle_ordenes': detalle,
        'form': form,
        
        
    }

    return render(request, 'main/cocina/mesas/mesa_4.html', data)

def OrdenesMesa5(request):
    form = detalleform(request.POST or None)
    orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 5', estado__contains='Pendiente')
    #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0')
    detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 5', id_orde__icontains=form['id_orde'].value())
    

    data = {
        'ordenes': orden,
        'detalle_ordenes': detalle,
        'form': form,
        
        
    }

    return render(request, 'main/cocina/mesas/mesa_5.html', data)

def OrdenesMesa6(request):
    form = detalleform(request.POST or None)
    orden = ordenes.objects.filter(nombre_pedido__contains='Mesa 6', estado__contains='Pendiente')
    #detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 0')
    detalle = detalle_ordenes.objects.filter(nombre_pedido__contains='Mesa 6', id_orde__icontains=form['id_orde'].value())
    

    data = {
        'ordenes': orden,
        'detalle_ordenes': detalle,
        'form': form,
        
        
    }

    return render(request, 'main/cocina/mesas/mesa_6.html', data)

##End Mesas


def estado_orden(request, id):
    orde = ordenes()
    est = get_object_or_404(ordenes, id_orden = id)

    data = {
        'form': estadoForm(instance=est),
        
    }
    if request.method == 'POST':
        
        orde.estado = 'Finalizado'
        formmulario = estadoForm(data=request.POST, instance=est)
        orde.estado = 'Finalizado'
        if formmulario.is_valid():
            formmulario.save()
            messages.success(request, "Pedido Entregado" )
            return redirect(to="cocina")
        data["form"] = formmulario        
    return render(request, 'main/cocina/estado_orden.html', data)
    
def contactomail(request):
    if request.method == 'POST':
        formulario = FormularioContacto(request.POST)
        if formulario.is_valid():
            asunto = 'Este es un mensaje de Django'
            mensaje = formulario.cleaned_data['mensaje']
            mail = EmailMessage(asunto, mensaje, to=['sebastian.balboa13@gmail.com'])
            mail.send()
            
        return HttpResponseRedirect('/')
    
    else:
        formulario = FormularioContacto()

    #return render_to_response('main/send.html', {'formulario': formulario}, context_instance=RequestContext(request))
    return render(request, 'main/send.html', {'formulario': formulario})


def graficov (request):

    #data = []
    #try:
        #year = datatime.now().year
       # for m in range(1, 13):
        #    grafic.objects.filter(date__joined__year=year, date__joined__month=m).aggregate(r=Coalesce(Sum('total'), 0)).get('r')
        #    data.append(float(total))
    #except:
       # pass
   # return data

   # context = {
      #  'graph_sales_year_month': data
    #}
    
    return render(request, 'main/test/grafico.html')

def list_orden(request):
    lis_orde = ordenes.objects.filter(estado__contains='Entregado')

    data = {
        'ordenes': lis_orde
    }

    return render(request, 'main/finanzas/list_ordenes.html', data)

def estado_ordenF(request, id):
    orde = ordenes()
    est = get_object_or_404(ordenes, id_orden = id)

    data = {
        'form': estadoForm(instance=est),
        
    }
    if request.method == 'POST':
        
        orde.estado = 'Finalizado'
        formmulario = estadoForm(data=request.POST, instance=est)
        orde.estado = 'Finalizado'
        if formmulario.is_valid():
            formmulario.save()
            messages.success(request, "Pedido Finalizado" )
            return redirect(to="list_ordenes")
        data["form"] = formmulario        
    return render(request, 'main/finanzas/estado_orden.html', data)
    

def addGroup (request):
    form = grupoForm()
    if request.method == 'POST':
        
       
        form = grupoForm(data=request.POST)
        
        if form.is_valid():
            form.save()
           
            
                
            return redirect('/')
        

    
    return render(request, 'main/test/none.html', {'form': form})

def lista_proveedores (request):
    proveedores = Proveedores.objects.all()
    form = stock_csvForm2(request.POST or None)

    data = {
        'Proveedores': proveedores,
        'form':form,
    }
    if request.method == 'POST':
        proveedores = Proveedores.objects.filter(region__icontains=form['region'].value())
        
        if form['export_to_CSV'].value() == True:
            response = HttpResponse(content_type='text/csv')
            response['Content-Diisposition'] = 'attachment; filename="List of proveedores.csv"'
            writer = csv.writer(response)
            writer.writerow(['NOMBRE_PROVEEDOR', 'TELEFONO', 'CORREO', 'NOMBRE_CONTACTO', 'REGION', 'TITULAR__CUENTA', 'NOMBRE_BANCO', 'RUT', 'NUMERO_CUENTA', 'TIPO_CUENTA'])
            instance = proveedores
            for prove in instance:
                writer.writerow([prove.nombre_proveedor, prove.telefono, prove.correo, prove.nombre_contacto, prove.region, prove.nombre_banco, prove.banco, prove.rut, prove.numero_cuenta, prove.tipo_cuenta])
            return response

        data = {
            'Proveedores':proveedores,
            'form':form,
        }

    return render(request, 'main/finanzas/lista_proveedores.html', data)

def ordenes_csv (request):
    orde = ordenes.objects.all()
    form = stock_csvForm3(request.POST or None)

    data = {
        'ordenes': orde,
        'form':form,
    }
    if request.method == 'POST':
        orde = ordenes.objects.filter(date__icontains=form['date'].value())
        
        if form['export_to_CSV'].value() == True:
            response = HttpResponse(content_type='text/csv')
            response['Content-Diisposition'] = 'attachment; filename="List of detalle.csv"'
            writer = csv.writer(response)
            writer.writerow(['ID', 'FECHA', 'MESA', 'ESTADO', 'TOTAL'])
            instance = orde
            for orden in instance:
                writer.writerow([orden.id_orden, orden.datefield, orden.nombre_pedido, orden.estado, orden.total])
            return response

        data = {
            'ordenes':orde,
            'form':form,
        }

    return render(request, 'main/finanzas/ordenes_csv.html', data)

def AgreFactura (request):
    
    tipo = Proveedores.objects.all()
    variables = {
        'Proveedores':tipo
    }

    if  request.POST:
        fact = FacturaXxi()
        fact.id_factura = request.POST.get('txtId')
        fact.fecha_fact = request.POST.get('txtfecha')
        fact.total = request.POST.get('txttotal')
        fact.nom_proveedor = request.POST.get('txtnom')
        fact.tipo_pago = request.POST.get('txttipo')
        fact.media = request.FILES.get('media')
        

        try:
            fact.save()
            variables['mensaje'] = 'Guardado Correctamente'
        except:
            variables['mensaje'] = 'Fallo Al Guardar'

    return render(request, 'main/finanzas/factura_des.html', variables)

def reporte_ordenes (request):
    orde = ordenes.objects.all()
    form = stock_csvForm3(request.POST or None)

    data = {
        'ordenes': orde,
        'form':form,
    }
    if request.method == 'POST':
        orde = ordenes.objects.filter(date__icontains=form['date'].value())
        
        if form['export_to_CSV'].value() == True:
            response = HttpResponse(content_type='text/csv')
            response['Content-Diisposition'] = 'attachment; filename="List of detalle.csv"'
            writer = csv.writer(response)
            writer.writerow(['ID', 'FECHA', 'MESA', 'ESTADO', 'TOTAL'])
            instance = orde
            for orden in instance:
                writer.writerow([orden.id_orden, orden.datefield, orden.nombre_pedido, orden.estado, orden.total])
            return response

        data = {
            'ordenes':orde,
            'form':form,
        }
    return render(request, 'main/reportes/reporteOrden.html', data)

def reporte_ingredientes (request):
    ingredientes = IngredientesXxi.objects.all()
    form = stock_csvForm(request.POST or None)

    data = {
        'IngredientesXxi': ingredientes,
        'form':form,
    }
    if request.method == 'POST':
        ingredientes = IngredientesXxi.objects.filter(ingrediente__icontains=form['ingrediente'].value())
        
        if form['export_to_CSV'].value() == True:
            response = HttpResponse(content_type='text/csv')
            response['Content-Diisposition'] = 'attachment; filename="List of stock.csv"'
            writer = csv.writer(response)
            writer.writerow(['INGREDIENTE', 'MARCA', 'CANTIDAD', 'ULTIMO DESCUENTO', 'ULTIMO AUMENTO'])
            instance = ingredientes
            for stock in instance:
                writer.writerow([stock.ingrediente, stock.marca, stock.cantidad, stock.issue_quantity, stock.receive_quantity])
            return response

        data = {
            'IngredientesXxi':ingredientes,
            'form':form,
        }

    return render(request, 'main/reportes/reporteIngredientes.html', data)

def reporte_proveedores (request):
    proveedores = Proveedores.objects.all()
    form = stock_csvForm2(request.POST or None)

    data = {
        'Proveedores': proveedores,
        'form':form,
    }
    if request.method == 'POST':
        proveedores = Proveedores.objects.filter(region__icontains=form['region'].value())
        
        if form['export_to_CSV'].value() == True:
            response = HttpResponse(content_type='text/csv')
            response['Content-Diisposition'] = 'attachment; filename="List of proveedores.csv"'
            writer = csv.writer(response)
            writer.writerow(['NOMBRE_PROVEEDOR', 'TELEFONO', 'CORREO', 'NOMBRE_CONTACTO', 'REGION', 'TITULAR__CUENTA', 'NOMBRE_BANCO', 'RUT', 'NUMERO_CUENTA', 'TIPO_CUENTA'])
            instance = proveedores
            for prove in instance:
                writer.writerow([prove.nombre_proveedor, prove.telefono, prove.correo, prove.nombre_contacto, prove.region, prove.nombre_banco, prove.banco, prove.rut, prove.numero_cuenta, prove.tipo_cuenta])
            return response

        data = {
            'Proveedores':proveedores,
            'form':form,
        }

    return render(request, 'main/reportes/reporteProveedores.html', data)

def Resetas (request):
    productos = ProductosXxi.objects.all()
    form = RestaForm(request.POST or None)

    data = {
        'ProductosXxi': productos,
        'form':form,
    }
    if request.method == 'POST':
        productos = ProductosXxi.objects.filter(nombre__icontains=form['nombre'].value())

        data = {
            'ProductosXxi':productos,
            'form':form,
        }

    return render(request, 'main/cocina/resetas.html', data)




