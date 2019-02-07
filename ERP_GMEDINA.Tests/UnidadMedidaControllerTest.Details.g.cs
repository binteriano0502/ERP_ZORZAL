using System.Data.Entity;
using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="UnidadMedidaControllerTest.Details.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ERP_ZORZAL.Controllers.Tests
{
    public partial class UnidadMedidaControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details472()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details231()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext = s0;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNotNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)unidadMedidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details208()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, new int?(0));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details23101()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext = s0;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNotNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)unidadMedidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details984()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext = s0;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, new int?(1));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNotNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)unidadMedidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details23102()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext = s0;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNotNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)unidadMedidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details383()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ViewEngineCollection viewEngineCollection;
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      IViewEngine[] iViewEngines = new IViewEngine[0];
      viewEngineCollection =
        new ViewEngineCollection((IList<IViewEngine>)iViewEngines);
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        viewEngineCollection;
      ((ControllerBase)unidadMedidaController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, new int?(1));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details38301()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ERP_ZORZALEntities eRP_ZORZALEntities;
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      eRP_ZORZALEntities = new ERP_ZORZALEntities();
      eRP_ZORZALEntities.tbInventarioFisico = (DbSet<tbInventarioFisico>)null;
      eRP_ZORZALEntities.tbAccesoRol = (DbSet<tbAccesoRol>)null;
      eRP_ZORZALEntities.tbObjeto = (DbSet<tbObjeto>)null;
      eRP_ZORZALEntities.tbRol = (DbSet<tbRol>)null;
      eRP_ZORZALEntities.tbRolesUsuario = (DbSet<tbRolesUsuario>)null;
      eRP_ZORZALEntities.tbUsuario = (DbSet<tbUsuario>)null;
      eRP_ZORZALEntities.sysdiagrams = (DbSet<sysdiagrams>)null;
      eRP_ZORZALEntities.tbActividadEconomica = (DbSet<tbActividadEconomica>)null;
      eRP_ZORZALEntities.tbBanco = (DbSet<tbBanco>)null;
      eRP_ZORZALEntities.tbCuentasBanco = (DbSet<tbCuentasBanco>)null;
      eRP_ZORZALEntities.tbDenominacion = (DbSet<tbDenominacion>)null;
      eRP_ZORZALEntities.tbDepartamento = (DbSet<tbDepartamento>)null;
      eRP_ZORZALEntities.tbEmpleado = (DbSet<tbEmpleado>)null;
      eRP_ZORZALEntities.tbIdentificacionCliente =
        (DbSet<tbIdentificacionCliente>)null;
      eRP_ZORZALEntities.tbMoneda = (DbSet<tbMoneda>)null;
      eRP_ZORZALEntities.tbMunicipio = (DbSet<tbMunicipio>)null;
      eRP_ZORZALEntities.tbParametro = (DbSet<tbParametro>)null;
      eRP_ZORZALEntities.tbTipoIdentificacion = (DbSet<tbTipoIdentificacion>)null;
      eRP_ZORZALEntities.tbUnidadMedida = (DbSet<tbUnidadMedida>)null;
      eRP_ZORZALEntities.tbBodega = (DbSet<tbBodega>)null;
      eRP_ZORZALEntities.tbBodegaDetalle = (DbSet<tbBodegaDetalle>)null;
      eRP_ZORZALEntities.tbBox = (DbSet<tbBox>)null;
      eRP_ZORZALEntities.tbEntradaDetalle = (DbSet<tbEntradaDetalle>)null;
      eRP_ZORZALEntities.tbEstadoInventarioFisico =
        (DbSet<tbEstadoInventarioFisico>)null;
      eRP_ZORZALEntities.tbEstadoMovimiento = (DbSet<tbEstadoMovimiento>)null;
      eRP_ZORZALEntities.tbInventarioFisicoDetalle =
        (DbSet<tbInventarioFisicoDetalle>)null;
      eRP_ZORZALEntities.tbProducto = (DbSet<tbProducto>)null;
      eRP_ZORZALEntities.tbProductoCategoria = (DbSet<tbProductoCategoria>)null;
      eRP_ZORZALEntities.tbProductoSubcategoria =
        (DbSet<tbProductoSubcategoria>)null;
      eRP_ZORZALEntities.tbProveedor = (DbSet<tbProveedor>)null;
      eRP_ZORZALEntities.tbTipoDevolucion = (DbSet<tbTipoDevolucion>)null;
      eRP_ZORZALEntities.tbTipoEntrada = (DbSet<tbTipoEntrada>)null;
      eRP_ZORZALEntities.tbTipoSalida = (DbSet<tbTipoSalida>)null;
      eRP_ZORZALEntities.DatosConsumidorFinal = (DbSet<DatosConsumidorFinal>)null;
      eRP_ZORZALEntities.tbCaja = (DbSet<tbCaja>)null;
      eRP_ZORZALEntities.tbCliente = (DbSet<tbCliente>)null;
      eRP_ZORZALEntities.tbCuponDescuento = (DbSet<tbCuponDescuento>)null;
      eRP_ZORZALEntities.tbDenominacionArqueo = (DbSet<tbDenominacionArqueo>)null;
      eRP_ZORZALEntities.tbDevolucion = (DbSet<tbDevolucion>)null;
      eRP_ZORZALEntities.tbDevolucionDetalle = (DbSet<tbDevolucionDetalle>)null;
      eRP_ZORZALEntities.tbDocumentoFiscal = (DbSet<tbDocumentoFiscal>)null;
      eRP_ZORZALEntities.tbEstadoFactura = (DbSet<tbEstadoFactura>)null;
      eRP_ZORZALEntities.tbEstadoPedido = (DbSet<tbEstadoPedido>)null;
      eRP_ZORZALEntities.tbEstadoSolicitudCredito =
        (DbSet<tbEstadoSolicitudCredito>)null;
      eRP_ZORZALEntities.tbExoneracion = (DbSet<tbExoneracion>)null;
      eRP_ZORZALEntities.tbFactura = (DbSet<tbFactura>)null;
      eRP_ZORZALEntities.tbFacturaDetalle = (DbSet<tbFacturaDetalle>)null;
      eRP_ZORZALEntities.tbFacturaHistorica = (DbSet<tbFacturaHistorica>)null;
      eRP_ZORZALEntities.tbListadoPrecioDetalle =
        (DbSet<tbListadoPrecioDetalle>)null;
      eRP_ZORZALEntities.tbListaPrecio = (DbSet<tbListaPrecio>)null;
      eRP_ZORZALEntities.tbMovimientoCaja = (DbSet<tbMovimientoCaja>)null;
      eRP_ZORZALEntities.tbNotaCredito = (DbSet<tbNotaCredito>)null;
      eRP_ZORZALEntities.tbPago = (DbSet<tbPago>)null;
      eRP_ZORZALEntities.tbPagosArqueo = (DbSet<tbPagosArqueo>)null;
      eRP_ZORZALEntities.tbPedido = (DbSet<tbPedido>)null;
      eRP_ZORZALEntities.tbPedidoDetalle = (DbSet<tbPedidoDetalle>)null;
      eRP_ZORZALEntities.tbPuntoEmision = (DbSet<tbPuntoEmision>)null;
      eRP_ZORZALEntities.tbPuntoEmisionDetalle = (DbSet<tbPuntoEmisionDetalle>)null;
      eRP_ZORZALEntities.tbSolicitudCredito = (DbSet<tbSolicitudCredito>)null;
      eRP_ZORZALEntities.tbSolicitudEfectivo = (DbSet<tbSolicitudEfectivo>)null;
      eRP_ZORZALEntities.tbSolicitudEfectivoDetalle =
        (DbSet<tbSolicitudEfectivoDetalle>)null;
      eRP_ZORZALEntities.tbSucursal = (DbSet<tbSucursal>)null;
      eRP_ZORZALEntities.tbTipoPago = (DbSet<tbTipoPago>)null;
      eRP_ZORZALEntities.UDV_Inv_Consultar_Existencias_Productos =
        (DbSet<UDV_Inv_Consultar_Existencias_Productos>)null;
      eRP_ZORZALEntities.tbEntrada = (DbSet<tbEntrada>)null;
      eRP_ZORZALEntities.tbSalida = (DbSet<tbSalida>)null;
      eRP_ZORZALEntities.tbSalidaDetalle = (DbSet<tbSalidaDetalle>)null;
      disposables.Add((IDisposable)eRP_ZORZALEntities);
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = eRP_ZORZALEntities;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, new int?(1));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details38302()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TempDataDictionary tempDataDictionary;
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      tempDataDictionary = new TempDataDictionary();
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)unidadMedidaController).TempData = tempDataDictionary;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, new int?(1));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(UnidadMedidaControllerTest))]
public void Details98401()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      UnidadMedidaController unidadMedidaController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      unidadMedidaController = new UnidadMedidaController();
      unidadMedidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)unidadMedidaController).Resolver = (IDependencyResolver)null;
      ((Controller)unidadMedidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)unidadMedidaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)unidadMedidaController).Url = (UrlHelper)null;
      ((Controller)unidadMedidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)unidadMedidaController).ControllerContext = s0;
      ((ControllerBase)unidadMedidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)unidadMedidaController).ValidateRequest = false;
      ((ControllerBase)unidadMedidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)unidadMedidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)unidadMedidaController);
      actionResult = this.Details(unidadMedidaController, new int?(1));
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)unidadMedidaController);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)unidadMedidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)unidadMedidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)unidadMedidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)unidadMedidaController).Url);
      Assert.IsNotNull(((ControllerBase)unidadMedidaController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)unidadMedidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)unidadMedidaController).ValidateRequest);
    }
}
    }
}
