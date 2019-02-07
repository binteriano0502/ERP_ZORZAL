using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="TipoSalidaControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(TipoSalidaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TipoSalidaControllerTest
    {
        [PexMethod(MaxBranches = 320000)]
        public TipoSalidaController Constructor()
        {
            TipoSalidaController target = new TipoSalidaController();
            return target;
            // TODO: add assertions to method TipoSalidaControllerTest.Constructor()
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Create([PexAssumeUnderTest]TipoSalidaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method TipoSalidaControllerTest.Create(TipoSalidaController)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Create([PexAssumeUnderTest]TipoSalidaController target, tbTipoSalida tbTipoSalida)
        {
            ActionResult result = target.Create(tbTipoSalida);
            return result;
            // TODO: add assertions to method TipoSalidaControllerTest.Create(TipoSalidaController, tbTipoSalida)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexAllowedException(typeof(NullReferenceException))]
        public ActionResult Edit([PexAssumeUnderTest]TipoSalidaController target, byte? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method TipoSalidaControllerTest.Edit(TipoSalidaController, Nullable`1<Byte>)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Edit(
            [PexAssumeUnderTest]TipoSalidaController target,
            byte? id,
            tbTipoSalida tbTipoSalida
        )
        {
            ActionResult result = target.Edit(id, tbTipoSalida);
            return result;
            // TODO: add assertions to method TipoSalidaControllerTest.Edit(TipoSalidaController, Nullable`1<Byte>, tbTipoSalida)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Index([PexAssumeUnderTest]TipoSalidaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method TipoSalidaControllerTest.Index(TipoSalidaController)
        }


        [PexMethod(MaxBranches = 320000)]
        public ActionResult Details([PexAssumeUnderTest]TipoSalidaController target, byte? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method TipoSalidaControllerTest.Details(TipoSalidaController, Nullable`1<Byte>)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult GetTipoSalidaExist([PexAssumeUnderTest]TipoSalidaController target, string Descripcion)
        {
            JsonResult result = target.GetTipoSalidaExist(Descripcion);
            return result;
            // TODO: add assertions to method TipoSalidaControllerTest.GetTipoSalidaExist(TipoSalidaController, String)
        }
    }
}
