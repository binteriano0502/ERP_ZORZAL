﻿$(function () {
    console.log('devd_CantidadProducto');
    $("#devd_CantidadProducto,#PrecioUnitario").keyup(function (e) {

        var Cantidad = $("#devd_CantidadProducto").val(),
            Precio = $("#PrecioUnitario").val(),
            porcentajeDesc = $("#Descuento").val(),
            Subtotal = $("#Subtotal").val(),
            Impuesto = $("#Impuesto").val(),

            valorSubtotal = "";
            MontoTotal = "";
            ValorImpuesto = "";
            ValorDescuento = "";
            Impuesto1 = (parseFloat(Impuesto)/ 100)
            porcentajeDesc1 = (parseFloat(porcentajeDesc) / 100)
            if (Cantidad.length && Precio.length > 0) {
            valorSubtotal += (parseFloat(Cantidad) * parseFloat(Precio));
            ValorImpuesto += (valorSubtotal * parseFloat(Impuesto1));
            ValorDescuento += (parseFloat(valorSubtotal) * parseFloat(porcentajeDesc1));
            console.log(ValorDescuento)
            MontoTotal += (parseFloat(valorSubtotal) + parseFloat(ValorImpuesto)) - parseFloat(ValorDescuento);

        }
        $("#Subtotal").val(valorSubtotal);
        $("#devd_Monto").val(MontoTotal);
        $("#ValorImpuesto").val(ValorImpuesto);
        $("#MontoDescuento").val(ValorDescuento);
    });

});

$(document).ready(function () {
    var Cliente = $('#tbFactura_clte_Identificacion').val();
    var Factura = $('#tbFactura_fact_Codigo').val();
if (Cliente === '') {
    document.getElementById("Factura").disabled = true;
    document.getElementById("tbFactura_fact_Codigo").disabled = true;
}
if (Factura === '') {
    document.getElementById("btnProducto").disabled = true;
    document.getElementById("prod_Codigo").disabled = true;
}
});
