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
    [PexClass(typeof(UnidadMedidaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnidadMedidaControllerTest
    {
        [PexMethod(MaxBranches = 320000)]
        public ActionResult Create([PexAssumeUnderTest]UnidadMedidaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method UnidadMedidaControllerTest.Create(UnidadMedidaController)
        }

        [PexMethod(MaxBranches = 320000)]
        public UnidadMedidaController Constructor()
        {
            UnidadMedidaController target = new UnidadMedidaController();
            return target;
            // TODO: add assertions to method UnidadMedidaControllerTest.Constructor()
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Create([PexAssumeUnderTest]UnidadMedidaController target, tbUnidadMedida tbUnidadMedida)
        {
            ActionResult result = target.Create(tbUnidadMedida);
            return result;
            // TODO: add assertions to method UnidadMedidaControllerTest.Create(UnidadMedidaController, tbUnidadMedida)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Edit([PexAssumeUnderTest]UnidadMedidaController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method UnidadMedidaControllerTest.Edit(UnidadMedidaController, Nullable`1<Int32>)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Edit(
            [PexAssumeUnderTest]UnidadMedidaController target,
            int? id,
            tbUnidadMedida tbUnidadMedida
        )
        {
            ActionResult result = target.Edit(id, tbUnidadMedida);
            return result;
            // TODO: add assertions to method UnidadMedidaControllerTest.Edit(UnidadMedidaController, Nullable`1<Int32>, tbUnidadMedida)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Details([PexAssumeUnderTest]UnidadMedidaController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method UnidadMedidaControllerTest.Details(UnidadMedidaController, Nullable`1<Int32>)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Index([PexAssumeUnderTest]UnidadMedidaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method UnidadMedidaControllerTest.Index(UnidadMedidaController)
        }
    }
}
