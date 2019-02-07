using ERP_GMEDINA.Models;
// <copyright file="SalidaControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para SalidaController</summary>
    [PexClass(typeof(SalidaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SalidaControllerTest
    {
        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult IndexTest([PexAssumeUnderTest]SalidaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.IndexTest(SalidaController)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Details([PexAssumeUnderTest]SalidaController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Details(SalidaController, Nullable`1<Int32>)
        }

        [PexMethod(MaxBranches = 320000, MaxConditions = 1000)]
        public ActionResult Create([PexAssumeUnderTest]SalidaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Create(SalidaController)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult GetProdList([PexAssumeUnderTest]SalidaController target)
        {
            JsonResult result = target.GetProdList();
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.GetProdList(SalidaController)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Edit([PexAssumeUnderTest]SalidaController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Edit(SalidaController, Nullable`1<Int32>)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult getSalidaDetalle([PexAssumeUnderTest]SalidaController target, string sald_Id)
        {
            JsonResult result = target.getSalidaDetalle(sald_Id);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.getSalidaDetalle(SalidaController, String)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult EditSalidaDetalle([PexAssumeUnderTest]SalidaController target, tbSalidaDetalle data)
        {
            ActionResult result = target.EditSalidaDetalle(data);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.EditSalidaDetalle(SalidaController, tbSalidaDetalle)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Edit(
            [PexAssumeUnderTest]SalidaController target,
            int? id,
            tbSalida tbSalida
        )
        {
            ActionResult result = target.Edit(id, tbSalida);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Edit(SalidaController, Nullable`1<Int32>, tbSalida)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Create([PexAssumeUnderTest]SalidaController target, tbSalida tbSalida)
        {
            ActionResult result = target.Create(tbSalida);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Create(SalidaController, tbSalida)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult SaveNewDatail([PexAssumeUnderTest]SalidaController target, tbSalidaDetalle SalidaDetalle)
        {
            JsonResult result = target.SaveNewDatail(SalidaDetalle);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.SaveNewDatail(SalidaController, tbSalidaDetalle)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Aplicar([PexAssumeUnderTest]SalidaController target, int? id)
        {
            ActionResult result = target.Aplicar(id);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Aplicar(SalidaController, Nullable`1<Int32>)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Imprimir([PexAssumeUnderTest]SalidaController target, int? id)
        {
            ActionResult result = target.Imprimir(id);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Imprimir(SalidaController, Nullable`1<Int32>)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult Anular([PexAssumeUnderTest]SalidaController target, tbSalida Salida)
        {
            JsonResult result = target.Anular(Salida);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Anular(SalidaController, tbSalida)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult SaveSalidaDetalle([PexAssumeUnderTest]SalidaController target, tbSalidaDetalle SalidaDetalle)
        {
            JsonResult result = target.SaveSalidaDetalle(SalidaDetalle);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.SaveSalidaDetalle(SalidaController, tbSalidaDetalle)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult RemoveSalidaDetalle([PexAssumeUnderTest]SalidaController target, tbSalidaDetalle SalidaDetalle)
        {
            JsonResult result = target.RemoveSalidaDetalle(SalidaDetalle);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.RemoveSalidaDetalle(SalidaController, tbSalidaDetalle)
        }

        [PexMethod(MaxBranches = 320000)]
        public JsonResult SaveCreateSalidaDetalle([PexAssumeUnderTest]SalidaController target, tbSalidaDetalle tbSalidaDetalle)
        {
            JsonResult result = target.SaveCreateSalidaDetalle(tbSalidaDetalle);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.SaveCreateSalidaDetalle(SalidaController, tbSalidaDetalle)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Delete([PexAssumeUnderTest]SalidaController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.Delete(SalidaController, Nullable`1<Int32>)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult DeleteConfirmed([PexAssumeUnderTest]SalidaController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método SalidaControllerTest.DeleteConfirmed(SalidaController, Int32)
        }
    }
}
