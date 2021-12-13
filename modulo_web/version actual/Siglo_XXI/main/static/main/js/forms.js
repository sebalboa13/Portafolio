//js para las validaciones de los formularios.

$(function validacion1(){
    $("#form-login").validate({
        rules: {
            username:{
              required: true,
              minlength: 3
            },
            password:{
               required: true,
               minlength: 3
            },
        },
        messages: {
            username:{
              required: 'Ingrese Nombre de usuario!',
              minlength: "Al nombre de usuario le faltan caracteres"
  
            },
            password:{
                required: "Ingrese su Contraseña",
                minlength:"A la Contraseña le faltan caracteres"
            }, 
        }
    });
  });