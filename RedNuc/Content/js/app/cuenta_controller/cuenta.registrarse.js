$(function () {
    // Validar la forma
    $("#forma-registrarse").formValidation({
        framework: "bootstrap",
        fields: {
            CorreoElectronico: {
                validators: {
                    notEmpty: {
                        message: "Por favor ingresa tu dirección de correo"
                    },
                    emailAddress: {
                        message: "Por favor ingresa una dirección de correo válida"
                    },
                    remote: {
                        message: "La dirección de correo que ingresaste ya está siendo usada",
                        url: "/Cuenta/EsCorreoNoExistente/"
                    }
                }
            },
            Contrasena: {
                validators: {
                    notEmpty: {
                        message: "Por favor ingresa una contraseña"
                    },
                    stringLength: {
                        min: 6,
                        max: 12,
                        message: "Por favor escribe una contraseña que contenga entre 6 y 12 caracteres"
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

    // Submit la forma utilizando ajax
    $("#btn-registrarse").click(function () {

        $.post("/Cuenta/Registrarse", $("#forma-registrarse").serialize()).done(function (data) {
            swal("¡Has sido registrado!", "Por favor estate atento(a) a nuestra siguiente convocatoria", "success");
        }).fail(function (jqXhr, textStatus, errorThrown) {

            if (errorThrown === "MODELO_INVALIDO") {

                swal("¡Ha ocurrido un error!", "Por favor verifica que hayas ingresado los datos requeridos", "error");

            } else if (errorThrown === "ERROR_REGISTRO") {

                swal("¡Ha ocurrido un error!", "Por favor intentalo de nuevo", "error");

            }


        });
    });


})