﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP_GMEDINA.Models;

namespace ERP_ZORZAL.Controllers
{
    public class TipoSalidaController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /TipoSalida/
        public ActionResult Index()
        {
            return View(db.tbTipoSalida.ToList());
        }

        // GET: /TipoSalida/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoSalida tbTipoSalida = db.tbTipoSalida.Find(id);
            //ViewBag.UsuarioCrea = db.tbUsuario.Find(tbTipoSalida.tsal_UsuarioCrea).usu_NombreUsuario;
            //var UsuarioModifica = tbTipoSalida.tsal_UsuarioModifica;
            //if (UsuarioModifica == null)
            //{
            //    ViewBag.UsuarioModifica = "";
            //}
            //else
            //{
            //    ViewBag.UsuarioModifica = db.tbUsuario.Find(UsuarioModifica).usu_NombreUsuario;
            //};
            if (tbTipoSalida == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoSalida);
        }

        // GET: /TipoSalida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TipoSalida/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include= "tsal_Id,tsal_Descripcion,tsal_UsuarioCrea,tsal_FechaCrea,tsal_UsarioModifica,tsal_FechaCrea")] tbTipoSalida tbTipoSalida)
        {
            if (ModelState.IsValid)
            {
                //db.tbTipoSalida.Add(tbTipoSalida);
                //db.SaveChanges();
                try
                {
                    IEnumerable<object> List = null;
                    var MsjError = "";
                    List = db.UDP_Inv_tbTipoSalida_Insert(tbTipoSalida.tsal_Descripcion);
                    foreach (UDP_Inv_tbTipoSalida_Insert_Result TipoSalida in List)
                        MsjError = TipoSalida.MensajeError;

                    if (MsjError == "-1")
                    {
                        ModelState.AddModelError("", "No se Guardo el registro , Contacte al Administrador");
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

            return View(tbTipoSalida);
        }

        // GET: /TipoSalida/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoSalida tbTipoSalida = db.tbTipoSalida.Find(id);
            //ViewBag.UsuarioCrea = db.tbUsuario.Find(tbTipoSalida.tsal_UsuarioCrea).usu_NombreUsuario;
            //var UsuarioModifica = tbTipoSalida.tsal_UsuarioModifica;
            //if (UsuarioModifica == null)
            //{
            //    ViewBag.UsuarioModifica = "";
            //}
            //else
            //{
            //    ViewBag.UsuarioModifica = db.tbUsuario.Find(UsuarioModifica).usu_NombreUsuario;
            //};
            if (tbTipoSalida == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoSalida);
        }

        // POST: /TipoSalida/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(byte? id, [Bind(Include= "tsal_Id,tsal_Descripcion,tsal_UsuarioCrea,tsal_FechaCrea,tsal_UsuarioModifica,tsal_FechaModifica,tbUsuario,tbUsuario1")] tbTipoSalida tbTipoSalida)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    tbTipoSalida TipoSalida = db.tbTipoSalida.Find(id);
                    IEnumerable<object> List = null;
                    var MsjError = "";
                    List = db.UDP_Inv_tbTipoSalida_Update(tbTipoSalida.tsal_Id,
                                                            tbTipoSalida.tsal_Descripcion,
                                                             tbTipoSalida.tsal_UsuarioCrea,
                                                            tbTipoSalida.tsal_FechaCrea);
                    foreach (UDP_Inv_tbTipoSalida_Update_Result tsal in List)
                        MsjError = tsal.MensajeError;

                    if (MsjError == "-1")
                    {
                        ModelState.AddModelError("", "No se guardo el cambio");
                        //return RedirectToAction("Index");
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
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            return View(tbTipoSalida);
        }

        // GET: /TipoSalida/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoSalida tbTipoSalida = db.tbTipoSalida.Find(id);
            if (tbTipoSalida == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoSalida);
        }

        // POST: /TipoSalida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            tbTipoSalida tbTipoSalida = db.tbTipoSalida.Find(id);
            db.tbTipoSalida.Remove(tbTipoSalida);
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