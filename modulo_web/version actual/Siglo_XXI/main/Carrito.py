class Carrito:
    def __init__(self, request):
        self.request = request
        self.session = request.session
        carrito = self.session.get("carrito")
        if not carrito:
            self.session["carrito"] = {}
            self.carrito = self.session["carrito"]
        else:
            self.carrito = carrito

    def agregar(self, ProductosXxi):
        id = str(ProductosXxi.id_producto)
        if id not in self.carrito.keys():
            self.carrito[id]={
                "id_producto": ProductosXxi.id_producto,
                "nombre": ProductosXxi.nombre,
                "acumulado": ProductosXxi.precio,
                "cantidad":1,
                
            }
        else:
            self.carrito[id]["cantidad"] +=1
            self.carrito[id]["acumulado"] += ProductosXxi.precio
        self.guardar_carrito()

    def guardar_carrito(self):
        self.session["carrito"] = self.carrito
        self.session.modified = True

    def eliminar(self, ProductosXxi):
        id = str(ProductosXxi.id_producto)
        if id in self.carrito.keys():
            del self.carrito[id]
            self.guardar_carrito()

    def restar(self, ProductosXxi):
        id =str(ProductosXxi.id_producto)
        if id in self.carrito.keys():
            self.carrito[id]["cantidad"] -=1
            self.carrito[id]["acumulado"]-= ProductosXxi.precio
            if self.carrito[id]["cantidad"] <= 0: self.eliminar(ProductosXxi)
            self.guardar_carrito()

    def limpiar(self):
        self.session["carrito"] = {}
        self.session.modified = True