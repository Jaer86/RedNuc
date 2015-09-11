$(function () {

    $("#forma-registrarse").formValidation({
        
        framework: 'bootstrap',
        fields: {
            CorreoElectronico: {
                validators: {
                    notEmpty: {
                        message:"Por favor ingresa tu dirección de correo"
                    }
                }
            },
            Contrasena: {
                validators: {
                    notEmpty: {
                        message: "Por favor ingresa una contraseña"
                    }
                }
            },

            EsAceptado: {
                validators: {
                    notEmpty: {
                        message: "Para poder registrarte debes aceptar los términos y condiciones"
                    }
                }
            }

        }



    });


})