﻿
var contador = 0;

$('#AgregarListaPrecioDetalle').click(function () {
    var Producto = $('#prod_Codigo').val();
    var PrecioMayorista = $('#lispd_PrecioMayorista').val();
    var PrecioMinorista = $('#lispd_PrecioMinorista').val();
    var DescuentoCaja = $('#lispd_DescCaja').val();
    var DescuentoGerente = $('#lispd_DescGerente').val();
    
    //Mayorista
    var mayorista = parseInt(PrecioMayorista);
    //Minorista
    var minorista = parseInt(PrecioMinorista);
    01
    if (PrecioMayorista == '' || PrecioMayorista== "0.00")
    {
        $('#ErrorProductoCreate').text('');
        $('#ErrorPrecioMayoristaCreate').text('');
        $('#ErrorPrecioMinoristaCreate').text('');
        $('#ErrorDescuentoCajaCreate').text('');
        $('#ErrorDescuentoGerenteCreate').text('');
        $('#validacionPrecioMayoristaCreate').after('<ul id="ErrorPrecioMayoristaCreate" class="validation-summary-errors text-danger">Campo Precio Mayorista requerido</ul>');

    }
    else if (PrecioMinorista == '' || PrecioMinorista == "0.00")
    {
        $('#ErrorProductoCreate').text('');
        $('#ErrorPrecioMayoristaCreate').text('');
        $('#ErrorPrecioMinoristaCreate').text('');
        $('#ErrorDescuentoCajaCreate').text('');
        $('#ErrorDescuentoGerenteCreate').text('');
        $('#validacionPrecioMinoristaCreate').after('<ul id="ErrorPrecioMinoristaCreate" class="validation-summary-errors text-danger">Campo Precio Minorista requerido</ul>');
    }
    else if (mayorista>minorista) {
        $('#ErrorProductoCreate').text('');
        $('#ErrorPrecioMayoristaCreate').text('');
        $('#ErrorPrecioMinoristaCreate').text('');
        $('#ErrorDescuentoCajaCreate').text('');
        $('#ErrorDescuentoGerenteCreate').text('');
        $('#validacionPrecioMinoristaCreate').after('<ul id="ErrorPrecioMinoristaCreate" class="validation-summary-errors text-danger">Precio Minorista debé ser Mayor a Precio Mayorista</ul>');
    }





    else if (DescuentoCaja=='')
    {
        $('#ErrorProductoCreate').text('');
        $('#ErrorPrecioMayoristaCreate').text('');
        $('#ErrorPrecioMinoristaCreate').text('');
        $('#ErrorDescuentoCajaCreate').text('');
        $('#ErrorDescuentoGerenteCreate').text('');
        $('#validacionDescuentoCajaCreate').after('<ul id="ErrorDescuentoCajaCreate" class="validation-summary-errors text-danger">Campo Descuento Caja requerido</ul>');
    }
    else if  (DescuentoGerente=='')
    {
        $('#ErrorProductoCreate').text('');
        $('#ErrorPrecioMayoristaCreate').text('');
        $('#ErrorPrecioMinoristaCreate').text('');
        $('#ErrorDescuentoCajaCreate').text('');
        $('#ErrorDescuentoGerenteCreate').text('');
        $('#validacionDescuentoGerenteCreate').after('<ul id="ErrorDescuentoGerenteCreate" class="validation-summary-errors text-danger">Campo Descuento Gerente requerido</ul>');
    }
     
    else if (Producto == '') {
        $('#ErrorProductoCreate').text('');
        $('#ErrorPrecioMayoristaCreate').text('');
        $('#ErrorPrecioMinoristaCreate').text('');
        $('#ErrorDescuentoCajaCreate').text('');
        $('#ErrorDescuentoGerenteCreate').text('');
        $('#validacionCodigoProductoCreate').after('<ul id="ErrorProductoCreate" class="validation-summary-errors text-danger">Campo Producto requerido</ul>');
    }
    else {
        contador = contador + 1;
        copiar = "<tr data-id=" + contador + ">";
        copiar += "<td id = 'prod_Codigo'>" + $('#prod_Codigo').val() + "</td>";
        copiar += "<td id = 'lispd_PrecioMayoristaCreate'>" + $('#lispd_PrecioMayorista').val() + "</td>";
        copiar += "<td id = 'lispd_PrecioMinoristaCreate'>" + $('#lispd_PrecioMinorista').val() + "</td>";
        copiar += "<td id = 'lispd_DescCajaCreate'>" + $('#lispd_DescCaja').val() + "</td>";
        copiar += "<td id = 'lispd_DescGerenteCreate'>" + $('#lispd_DescGerente').val() + "</td>";
        copiar += "<td>" + '<button id="removeListaPrecioDetalle" class="btn btn-danger btn-xs eliminar" type="button">-</button>' + "</td>";
        copiar += "</tr>";
        $('#tbListaPrecioDetalle').append(copiar);
               
        var PrecioDetalle = GetListaPrecioDetalle();
        $.ajax({
            url: "/ListaPrecios/SaveListaPrecioDetalle",
            method: "POST",
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ cPrecioDetalle: PrecioDetalle }),
        })
        .done(function (data) {
            $('#ErrorPrecioMayoristaCreate').text('');
            $('#ErrorPrecioMinoristaCreate').text('');
            $('#ErrorDescuentoCajaCreate').text('');
            $('#ErrorDescuentoGerenteCreate').text('');
            $('#ErrorProductoCreate').val('');

            //Input
            $('#prod_Codigo').val('');
            $('#lispd_PrecioMayorista').val('');
            $('#lispd_PrecioMinorista').val('');
            $('#lispd_DescCaja').val('');
            $('#lispd_DescGerente').val('');
          

        });

    }

});



function GetListaPrecioDetalle() {
    var ListaDetalle = {
        lispd_PrecioMayorista: $('#lispd_PrecioMayorista').val(),
        lispd_PrecioMinorista: $('#lispd_PrecioMinorista').val(),
        lispd_DescCaja: $('#lispd_DescCaja').val(),
        DescuentoGerente: $('#DescuentoGerente').val(),
        listpd_Id: contador
        //Fecha: $('#fechaCreate').val(),
    };
    return ListaDetalle;
}

$(document).on("click", "#tbListaPrecioDetalle tbody tr td button#removeListaPrecioDetalle", function () {
    $(this).closest('tr').remove();
    idItem = $(this).closest('tr').data('id');
    var PrecioDetalle = {
        listpd_Id: idItem,
    };
    $.ajax({
        url: "/ListaPrecios/QuitarPrecioDetalle",
        method: "POST",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ ListadoPrecioDetalle: PrecioDetalle }),




    });


});

