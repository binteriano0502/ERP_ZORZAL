﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA.Controllers
{
    public class ProveedorController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();
        GeneralFunctions Function = new GeneralFunctions();

        // GET: /Proveedor/
        public ActionResult Index()
        {
            if (Function.Sesiones("Proveedor/Index"))
            {

            }
            else
            {
                return RedirectToAction("ModificarPass/" + Session["UserLogin"], "Usuario");
            }

            return View(db.tbProveedor.ToList());
        }

        // GET: /Proveedor/Details/5
        public ActionResult Details(int? id)
        {
            if (Function.Sesiones("Proveedor/Details"))
            {

            }
            else
            {
                return RedirectToAction("ModificarPass/" + Session["UserLogin"], "Usuario");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProveedor tbProveedor = db.tbProveedor.Find(id);
            ViewBag.UsuarioCrea = db.tbUsuario.Find(tbProveedor.prov_UsuarioCrea).usu_NombreUsuario;
            var UsuarioModfica = tbProveedor.prov_UsuarioModifica;
            if (UsuarioModfica == null)
            {
                ViewBag.UsuarioModifica = "";
            }
            else
            {
                ViewBag.UsuarioModifica = db.tbUsuario.Find(UsuarioModfica).usu_NombreUsuario;
            };
            if (tbProveedor == null)
            {
                return HttpNotFound();
            }
            return View(tbProveedor);
        }

        // GET: /Proveedor/Create
        public ActionResult Create()
        {
            if (Function.Sesiones("Proveedor/Create"))
            {

            }
            else
            {
                return RedirectToAction("ModificarPass/" + Session["UserLogin"], "Usuario");
            }

            try
            {
                ViewBag.smserror = TempData["smserror"].ToString();
            }
            catch { }
            return View();
        }

        // POST: /Proveedor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="prov_Nombre,prov_NombreContacto,prov_Direccion,prov_Email,prov_Telefono,prov_RTN,prov_UsuarioCrea,prov_FechaCrea")] tbProveedor tbProveedor)
        {
            if (ModelState.IsValid)
            {
                //db.tbUnidadMedida.Add(tbProveedor);
                //db.SaveChanges();
                try
                {
                    IEnumerable<object> List = null;
                    var MsjError = "";
                    List = db.UDP_Inv_tbProveedor_Insert(tbProveedor.prov_Nombre,tbProveedor.prov_NombreContacto,tbProveedor.prov_Direccion,tbProveedor.prov_Email,tbProveedor.prov_Telefono,tbProveedor.prov_RTN,tbProveedor.acte_Id);
                    foreach (UDP_Inv_tbProveedor_Insert_Result Proveedor in List)
                        MsjError = Proveedor.MensajeError;

                    if (MsjError == "-1")
                    {
                      
                        ModelState.AddModelError("", "No se guardo el registro, Contacte al Administrador");
                        return RedirectToAction("Index");
                    }

                    else if (MsjError == "")
                    {
                       
                        ModelState.AddModelError("prov_RTN", "No se guardo el registro, Contacte al Administrador");
                        return RedirectToAction("Create");
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }


                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    ModelState.AddModelError("", "No se Guardo el registro, Contacte al Administrador");
                }
                return RedirectToAction("Index");
            }

            return View(tbProveedor);
        }

        // GET: /Proveedor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (Function.Sesiones("Proveedor/Edit"))
            {

            }
            else
            {
                return RedirectToAction("ModificarPass/" + Session["UserLogin"], "Usuario");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProveedor tbProveedor = db.tbProveedor.Find(id);
            ViewBag.UsuarioCrea = db.tbUsuario.Find(tbProveedor.prov_UsuarioCrea).usu_NombreUsuario;
            var UsuarioModfica = tbProveedor.prov_UsuarioModifica;
            if (UsuarioModfica == null)
            {
                ViewBag.UsuarioModifica = "";
            }
            else
            {
                ViewBag.UsuarioModifica = db.tbUsuario.Find(UsuarioModfica).usu_NombreUsuario;
            };
            if (tbProveedor == null)
            {
                return HttpNotFound();
            }
            return View(tbProveedor);
        }





        [HttpPost]
        public JsonResult GuardarProveedor(string prov_RTN, string prov_Nombre, string prov_NombreContacto, string prov_Direccion, string prov_Email, string prov_Telefono,byte acte_Id)
        {
            var MsjError = "";
            if (ModelState.IsValid)
            {
                //db.tbUnidadMedida.Add(tbProveedor);
                //db.SaveChanges();
                try
                {
                    IEnumerable<object> List = null;
                   


                    List = db.UDP_Inv_tbProveedor_Insert(prov_Nombre, prov_NombreContacto, prov_Direccion, prov_Email, prov_Telefono, prov_RTN,acte_Id);
                    foreach (UDP_Inv_tbProveedor_Insert_Result Proveedor in List)
                        MsjError = Proveedor.MensajeError;

                    if (MsjError == "-1")
                    {

                        ModelState.AddModelError("", "No se guardo el registro, Contacte al Administrador");
                     
                    }

                    else if (MsjError == "")
                    {

                        ModelState.AddModelError("prov_RTN", "No se guardo el registro, Contacte al Administrador");
                       
                    }
                  

                }
                catch (Exception Ex)
                {
                    MsjError = "-1";
                    Ex.Message.ToString();
                    ModelState.AddModelError("", "No se Guardo el registro, Contacte al Administrador");
                }
              
            }
            return Json(MsjError, JsonRequestBehavior.AllowGet);

        }
        // POST: /Proveedor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(byte? id,[Bind(Include="prov_Id,prov_Nombre,prov_NombreContacto,prov_Direccion,prov_Email,prov_Telefono,prov_UsuarioCrea,prov_FechaCrea,prov_UsuarioModifica,prov_FechaModifica")] tbProveedor tbProveedor)
        {
           
            if (ModelState.IsValid)
            {
              
                try
                {
                    tbProveedor vtbProveedor = db.tbProveedor.Find(id);
                    /*:ssTZD*/
                    IEnumerable<object> List = null;
                    var MsjError ="";
                    List = db.UDP_Inv_tbProveedor_Update(tbProveedor.prov_Id,
                                                         tbProveedor.prov_Nombre,
                                                         tbProveedor.prov_NombreContacto,
                                                         tbProveedor.prov_Direccion,
                                                         tbProveedor.prov_Email,
                                                         tbProveedor.prov_Telefono,
                                                         tbProveedor.prov_RTN,
                                                         tbProveedor.acte_Id);
                    foreach (UDP_Inv_tbProveedor_Update_Result Proveedor in List)
                        MsjError = Proveedor.MensajeError;

                    if (MsjError== "-1")
                    {
                        ModelState.AddModelError("", "No se Actualizo el registro");
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }

                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    ModelState.AddModelError("", "No se Guardo el registro , Contacte al Administrador");
                }
                return RedirectToAction("Index");
            }
            return View(tbProveedor);
        }

    

    // GET: /Proveedor/Delete/5
    public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProveedor tbProveedor = db.tbProveedor.Find(id);
            if (tbProveedor == null)
            {
                return HttpNotFound();
            }
            return View(tbProveedor);
        }

        // POST: /Proveedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbProveedor tbProveedor = db.tbProveedor.Find(id);
            db.tbProveedor.Remove(tbProveedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }






    }
}
