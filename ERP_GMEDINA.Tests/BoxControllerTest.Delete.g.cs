using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="BoxControllerTest.Delete.g.cs">Copyright ©  2014</copyright>
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
    public partial class BoxControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(BoxControllerTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Delete01()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      BoxController boxController;
      ActionResult actionResult;
      boxController = new BoxController();
      boxController.db = (ERP_ZORZALEntities)null;
      ((Controller)boxController).Resolver = (IDependencyResolver)null;
      ((Controller)boxController).ActionInvoker = (IActionInvoker)null;
      ((Controller)boxController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)boxController).Url = (UrlHelper)null;
      ((Controller)boxController).ViewEngineCollection = (ViewEngineCollection)null;
      ((ControllerBase)boxController).ControllerContext = (ControllerContext)null;
      ((ControllerBase)boxController).TempData = (TempDataDictionary)null;
      ((ControllerBase)boxController).ValidateRequest = false;
      ((ControllerBase)boxController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)boxController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)boxController);
      actionResult = this.Delete(boxController, (string)null);
      disposables.Dispose();
    }
}
    }
}
