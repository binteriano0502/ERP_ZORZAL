using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="SalidaControllerTest.Create.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace ERP_GMEDINA.Controllers.Tests
{
    public partial class SalidaControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(SalidaControllerTest))]
public void Create306()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      SalidaController salidaController;
      ActionResult actionResult;
      salidaController = new SalidaController();
      salidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)salidaController).Resolver = (IDependencyResolver)null;
      ((Controller)salidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)salidaController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)salidaController).Url = (UrlHelper)null;
      ((Controller)salidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)salidaController).ControllerContext = (ControllerContext)null;
      ((ControllerBase)salidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)salidaController).ValidateRequest = false;
      ((ControllerBase)salidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)salidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)salidaController);
      actionResult = this.Create(salidaController);
      disposables.Dispose();
      Assert.IsNotNull((object)salidaController);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)salidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)salidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)salidaController).Url);
      Assert.IsNull(((ControllerBase)salidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)salidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(SalidaControllerTest))]
public void Create232()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      SalidaController salidaController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      salidaController = new SalidaController();
      salidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)salidaController).Resolver = (IDependencyResolver)null;
      ((Controller)salidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)salidaController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)salidaController).Url = (UrlHelper)null;
      ((Controller)salidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)salidaController).ControllerContext = s0;
      ((ControllerBase)salidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)salidaController).ValidateRequest = false;
      ((ControllerBase)salidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)salidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)salidaController);
      actionResult = this.Create(salidaController);
      disposables.Dispose();
      Assert.IsNotNull((object)salidaController);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)salidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)salidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)salidaController).Url);
      Assert.IsNotNull(((ControllerBase)salidaController).ControllerContext);
      Assert.IsNull(((ControllerBase)salidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)salidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(SalidaControllerTest))]
public void Create23201()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      SalidaController salidaController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      salidaController = new SalidaController();
      salidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)salidaController).Resolver = (IDependencyResolver)null;
      ((Controller)salidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)salidaController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)salidaController).Url = (UrlHelper)null;
      ((Controller)salidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)salidaController).ControllerContext = s0;
      ((ControllerBase)salidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)salidaController).ValidateRequest = false;
      ((ControllerBase)salidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)salidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)salidaController);
      actionResult = this.Create(salidaController);
      disposables.Dispose();
      Assert.IsNotNull((object)salidaController);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)salidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)salidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)salidaController).Url);
      Assert.IsNotNull(((ControllerBase)salidaController).ControllerContext);
      Assert.IsNull(((ControllerBase)salidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)salidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(SalidaControllerTest))]
public void Create30601()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TempDataDictionary tempDataDictionary;
      SalidaController salidaController;
      ActionResult actionResult;
      tempDataDictionary = new TempDataDictionary();
      salidaController = new SalidaController();
      salidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)salidaController).Resolver = (IDependencyResolver)null;
      ((Controller)salidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)salidaController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)salidaController).Url = (UrlHelper)null;
      ((Controller)salidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)salidaController).ControllerContext = (ControllerContext)null;
      ((ControllerBase)salidaController).TempData = tempDataDictionary;
      ((ControllerBase)salidaController).ValidateRequest = false;
      ((ControllerBase)salidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)salidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)salidaController);
      actionResult = this.Create(salidaController);
      disposables.Dispose();
      Assert.IsNotNull((object)salidaController);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)salidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)salidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)salidaController).Url);
      Assert.IsNull(((ControllerBase)salidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)salidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(SalidaControllerTest))]
public void Create30602()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ViewEngineCollection viewEngineCollection;
      SalidaController salidaController;
      ActionResult actionResult;
      IViewEngine[] iViewEngines = new IViewEngine[0];
      viewEngineCollection =
        new ViewEngineCollection((IList<IViewEngine>)iViewEngines);
      salidaController = new SalidaController();
      salidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)salidaController).Resolver = (IDependencyResolver)null;
      ((Controller)salidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)salidaController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)salidaController).Url = (UrlHelper)null;
      ((Controller)salidaController).ViewEngineCollection = viewEngineCollection;
      ((ControllerBase)salidaController).ControllerContext = (ControllerContext)null;
      ((ControllerBase)salidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)salidaController).ValidateRequest = false;
      ((ControllerBase)salidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)salidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)salidaController);
      actionResult = this.Create(salidaController);
      disposables.Dispose();
      Assert.IsNotNull((object)salidaController);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)salidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)salidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)salidaController).Url);
      Assert.IsNull(((ControllerBase)salidaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)salidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(SalidaControllerTest))]
public void Create23202()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      SalidaController salidaController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      salidaController = new SalidaController();
      salidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)salidaController).Resolver = (IDependencyResolver)null;
      ((Controller)salidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)salidaController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)salidaController).Url = (UrlHelper)null;
      ((Controller)salidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)salidaController).ControllerContext = s0;
      ((ControllerBase)salidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)salidaController).ValidateRequest = false;
      ((ControllerBase)salidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)salidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)salidaController);
      actionResult = this.Create(salidaController);
      disposables.Dispose();
      Assert.IsNotNull((object)salidaController);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager);
      Assert.IsNotNull
          (((Controller)salidaController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)salidaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)salidaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)salidaController).Url);
      Assert.IsNotNull(((ControllerBase)salidaController).ControllerContext);
      Assert.IsNull(((ControllerBase)salidaController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)salidaController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(SalidaControllerTest))]
[Ignore]
[PexDescription("el estado de la prueba fue: path bounds exceeded")]
public void Create961()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      SalidaController salidaController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      salidaController = new SalidaController();
      salidaController.db = (ERP_ZORZALEntities)null;
      ((Controller)salidaController).Resolver = (IDependencyResolver)null;
      ((Controller)salidaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)salidaController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)salidaController).Url = (UrlHelper)null;
      ((Controller)salidaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)salidaController).ControllerContext = s0;
      ((ControllerBase)salidaController).TempData = (TempDataDictionary)null;
      ((ControllerBase)salidaController).ValidateRequest = false;
      ((ControllerBase)salidaController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)salidaController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)salidaController);
      actionResult = this.Create(salidaController, (tbSalida)null);
      disposables.Dispose();
    }
}
    }
}
