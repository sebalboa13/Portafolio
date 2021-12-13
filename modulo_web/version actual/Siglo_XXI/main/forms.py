from django import forms
from django.forms.widgets import NumberInput
from .models import *
from django.forms import ModelForm
from django.contrib.auth.models import Group, User
from django.contrib.auth.forms import UserCreationForm


class IngredienteForm(forms.ModelForm):
    class Meta:
        model = IngredientesXxi
        fields = [
                'id_ingrediente',
                'ingrediente',
                'marca',
                'cantidad',
                
                
                
            ]
        labels = {
                'id_ingrediente':'id_ingrediente',
                'ingrediente':'ingrediente',
                'marca':'marca',
                'cantidad':'cantidad',
                
                
                
        }

class stockform(forms.ModelForm):
    class Meta:
        model = IngredientesXxi
        widgets = {
            'cantidad': NumberInput(attrs={'type': 'number', }),
        }

        fields = [
                'cantidad',
                
                
            ]
        
        
class proveedoresForm(forms.ModelForm):
    class Meta:
        model = Proveedores
        fields = [
                'id_proveedor',
                'nombre_proveedor',
                'telefono',
                'correo',
                'nombre_contacto',
                'region',
                'nombre_banco',
                'banco',
                'rut',
                'numero_cuenta',
                'tipo_cuenta',
                 
            ]
        labels = {
                'id_proveedor':'id_proveedor',
                'nombre_proveedor':'nombre_proveedor',
                'telefono':'telefono',
                'correo':'correo',
                'nombre_contacto':'nombre_contacto',
                'region':'region',
                'nombre_banco':'nombre_banco',
                'banco':'banco',
                'rut':'rut',
                'numero_cuenta':'numero_cuenta',
                'tipo_cuenta':'tipo_cuenta',
                     
        }

class proveedoresForm2(forms.ModelForm):
    class Meta:
        model = Proveedores
        fields = [
                'id_proveedor',
                'nombre_proveedor',
                'telefono',
                'correo',
                'nombre_contacto',
                'region',
                
                 
            ]
        labels = {
                'id_proveedor':'id_proveedor',
                'nombre_proveedor':'nombre_proveedor',
                'telefono':'telefono',
                'correo':'correo',
                'nombre_contacto':'nombre_contacto',
                'region':'region',
                
                     
        }

class facturasForm(forms.ModelForm):
    class Meta:
        model = FacturaXxi
        
        fields = [
                'id_factura',
                'fecha_fact',
                'total',
                'nom_proveedor',
                'tipo_pago',
                'media',                                                                                   
            ]
        labels = {
                'id_factura':'id_factura',
                'fecha_fact':'fecha_fact',
                'total':'total',
                'nom_proveedor':'nom_proveedor',
                'tipo_pago':'tipo_pago',
                'media':'media',                                                                                          
        }

class estadoForm(forms.ModelForm):
    class Meta:
        model = ordenes
        
        fields = [
                'estado',
                                                                                                  
            ]
        labels = {
                'estado':'estado',
                                                                                                         
        }

class factura2Form(ModelForm):
    class Meta:
        model = FacturaXxi
        fields =['id_factura','fecha','total','nom_proveedor','tipo_pago',]

        widgets = {
            'fecha':forms.SelectDateWidget(years=range(1945, 2021))
        }


class IssueForm(forms.ModelForm):
    class Meta:
        model = IngredientesXxi
        fields = {'issue_quantity'} 

class ReceiveForm(forms.ModelForm):
    class Meta:
        model = IngredientesXxi
        fields = {'receive_quantity'} 


class productosForm(forms.ModelForm):
    class Meta:
        model = ProductosXxi
        fields = [
            'id_producto',
            'nombre',
            'precio',
            'img_producto',
            'tipo_producto_xxi_id_tipo_producto',


        ]


class FormProductos(forms.ModelForm):
    class Meta:
        model = ProductosXxi
        fields = [
                'id_producto',
                'nombre',
                'precio',
                'img_producto',
                'tipo_producto_xxi_id_tipo_producto',
                
                
                
            ]
       
#class ordenForm(forms.ModelForm):
    #class Meta:
       # model = ordenes
       # fields = [
           #     'detalle',
           #     'acumulado',
           #     'cantidad',
           #     'total',
                
                
                
                
           # ]
        #labels = {
                
            #    'detalle':'detalle',
           #     'acumulado':'acumulado',
           #     'cantidad':'cantidad',
           #     'total':'total',
                
                
                
        #}

class stock_csvForm(forms.ModelForm):
    export_to_CSV = forms.BooleanField(required=False)
    class Meta:
        model = IngredientesXxi
        fields = ['ingrediente']
        labels = {
            'ingreddiente:ingrediente'
            'export_to_CSV:export_to_CSV'
        }


class detalleform(forms.ModelForm):
    class Meta:
        model = detalle_ordenes
        fields = ['id_orde']
        labels = {'id_orde:id_orde'}

class detalleform1(forms.ModelForm):
    class Meta:
        model = detalle_ordenes
        fields = ['id_orde']
        labels = {'id_orde:id_orde'}

class FormularioContacto(forms.Form):
    correo = forms.EmailField()
    mensaje = forms.CharField()

class grupoForm(UserCreationForm):
    class Meta:
        model = User
        fields = ['first_name', 'last_name', 'email', 'username', 'password']
        labels = {
                'first_name':'first_name',
                'last_name':'last_name',
                'email':'email',
                'username':'username',
                'password':'password',
                
                                                                                                         
        }
        
class stock_csvForm2(forms.ModelForm):
    export_to_CSV = forms.BooleanField(required=False)
    class Meta:
        model = Proveedores
        fields = ['region']
        labels = {
            'region:region'
            'export_to_CSV:export_to_CSV'
        }

class stock_csvForm3(forms.ModelForm):
    export_to_CSV = forms.BooleanField(required=False)
    class Meta:
        model = ordenes
        fields = ['date']
        labels = {
            'date:date'
            'export_to_CSV:export_to_CSV'
        }

class RestaForm(forms.ModelForm):
    
    class Meta:
        model = ProductosXxi
        fields = ['nombre']
        labels = {
            'nombre:nombre'
            
        }


