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
    [PexClass(typeof(BoxController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BoxControllerTest
    {

        [PexMethod(MaxBranches = 320000)]
        public BoxController Constructor()
        {
            BoxController target = new BoxController();
            return target;
            // TODO: add assertions to method BoxControllerTest.Constructor()
        }

        [PexMethod(MaxBranches = 320000, MaxConditions = 1000, MaxConstraintSolverTime = 4)]
        public ActionResult Index([PexAssumeUnderTest]BoxController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method BoxControllerTest.Index(BoxController)
        }

        [PexMethod(MaxBranches = 320000, MaxConditions = 100000, MaxConstraintSolverTime = 40)]
        public ActionResult Create([PexAssumeUnderTest]BoxController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method BoxControllerTest.Create(BoxController)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Create([PexAssumeUnderTest]BoxController target, tbBox tbBox)
        {
            ActionResult result = target.Create(tbBox);
            return result;
            // TODO: add assertions to method BoxControllerTest.Create(BoxController, tbBox)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Edit([PexAssumeUnderTest]BoxController target, string id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method BoxControllerTest.Edit(BoxController, String)
        }

        [PexMethod(MaxBranches = 320000)]
        public ActionResult Delete([PexAssumeUnderTest]BoxController target, string id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method BoxControllerTest.Delete(BoxController, String)
        }
    }
}
