// <copyright file="ProductoControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ProductoController</summary>
    [PexClass(typeof(ProductoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProductoControllerTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ProductoController ConstructorTest()
        {
            ProductoController target = new ProductoController();
            return target;
            // TODO: add assertions to method ProductoControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod(MaxBranches = 320000, MaxConditions = 1000)]
        public ActionResult CreateTest([PexAssumeUnderTest]ProductoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method ProductoControllerTest.CreateTest(ProductoController)
        }

        /// <summary>Test stub for Create(tbProducto, Int32)</summary>
        [PexMethod(MaxBranches = 320000, MaxConditions = 1000)]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]ProductoController target,
            tbProducto tbProducto,
            int pcat_Id
        )
        {
            ActionResult result = target.Create(tbProducto, pcat_Id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.CreateTest01(ProductoController, tbProducto, Int32)
        }

        /// <summary>Test stub for DeleteConfirmed(String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]ProductoController target, string id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.DeleteConfirmedTest(ProductoController, String)
        }

        /// <summary>Test stub for Delete(String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult DeleteTest([PexAssumeUnderTest]ProductoController target, string id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.DeleteTest(ProductoController, String)
        }

        /// <summary>Test stub for Details(String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult DetailsTest([PexAssumeUnderTest]ProductoController target, string id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.DetailsTest(ProductoController, String)
        }

        /// <summary>Test stub for Edit(String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult EditTest([PexAssumeUnderTest]ProductoController target, string id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.EditTest(ProductoController, String)
        }

        /// <summary>Test stub for Edit(String, tbProducto, Int32)</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]ProductoController target,
            string id,
            tbProducto tbProducto,
            int pcat_Id
        )
        {
            ActionResult result = target.Edit(id, tbProducto, pcat_Id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.EditTest01(ProductoController, String, tbProducto, Int32)
        }

        /// <summary>Test stub for EstadoInactivar(String, Boolean, String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult EstadoInactivarTest(
            [PexAssumeUnderTest]ProductoController target,
            string prod_Codigo,
            bool Activo,
            string Razon_Inactivacion
        )
        {
            JsonResult result
               = target.EstadoInactivar(prod_Codigo, Activo, Razon_Inactivacion);
            return result;
            // TODO: add assertions to method ProductoControllerTest.EstadoInactivarTest(ProductoController, String, Boolean, String)
        }

        /// <summary>Test stub for Estadoactivar(String, Boolean, String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult EstadoactivarTest(
            [PexAssumeUnderTest]ProductoController target,
            string prod_Codigo,
            bool Activo,
            string Razon_Inactivacion
        )
        {
            JsonResult result
               = target.Estadoactivar(prod_Codigo, Activo, Razon_Inactivacion);
            return result;
            // TODO: add assertions to method ProductoControllerTest.EstadoactivarTest(ProductoController, String, Boolean, String)
        }

        /// <summary>Test stub for GetCategoriaProducto(Int32)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult GetCategoriaProductoTest(
            [PexAssumeUnderTest]ProductoController target,
            int codsubcategoria
        )
        {
            JsonResult result = target.GetCategoriaProducto(codsubcategoria);
            return result;
            // TODO: add assertions to method ProductoControllerTest.GetCategoriaProductoTest(ProductoController, Int32)
        }

        /// <summary>Test stub for GetScatList(Int32)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult GetScatListTest([PexAssumeUnderTest]ProductoController target, int pcat_Id)
        {
            JsonResult result = target.GetScatList(pcat_Id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.GetScatListTest(ProductoController, Int32)
        }

        /// <summary>Test stub for GetSubCategoriaProducto(Int32)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult GetSubCategoriaProductoTest(
            [PexAssumeUnderTest]ProductoController target,
            int CodCategoria
        )
        {
            JsonResult result = target.GetSubCategoriaProducto(CodCategoria);
            return result;
            // TODO: add assertions to method ProductoControllerTest.GetSubCategoriaProductoTest(ProductoController, Int32)
        }

        /// <summary>Test stub for GetValue(String, String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult GetValueTest(
            [PexAssumeUnderTest]ProductoController target,
            string pcat_Id,
            string pscat_Id
        )
        {
            JsonResult result = target.GetValue(pcat_Id, pscat_Id);
            return result;
            // TODO: add assertions to method ProductoControllerTest.GetValueTest(ProductoController, String, String)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult IndexTest([PexAssumeUnderTest]ProductoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method ProductoControllerTest.IndexTest(ProductoController)
        }
    }
}
