﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP_GMEDINA.Models;
using System.Transactions;

namespace ERP_ZORZAL.Controllers
{
    public class EntradaController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /Entrada/
        public ActionResult Index()
        {
            var tbentrada = db.tbEntrada.Include(t => t.tbBodega).Include(t => t.tbEstadoMovimiento).Include(t => t.tbProveedor).Include(t => t.tbTipoEntrada);
            return View(tbentrada.ToList());
        }

        // GET: /Entrada/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEntrada tbEntrada = await db.tbEntrada.FindAsync(id);
            ViewBag.UsuarioCrea = db.tbUsuario.Find(tbEntrada.ent_UsuarioCrea).usu_NombreUsuario;
            var UsuarioModfica = tbEntrada.ent_UsuarioModifica;
            if (UsuarioModfica == null)
            {
                ViewBag.UsuarioModifica = "";
            }
            else
            {
                ViewBag.UsuarioModifica = db.tbUsuario.Find(UsuarioModfica).usu_NombreUsuario;
            };
            if (tbEntrada == null)
            {
                return HttpNotFound();
            }
            //vista parcial de entrada detalle
            ViewBag.ent_Id = new SelectList(db.tbEntrada, "ent_Id", "ent_Id");
            ViewBag.prod_Codigo = new SelectList(db.tbProducto, "prod_Codigo", "prod_Descripcion");
            ViewBag.uni_Id = new SelectList(db.tbUnidadMedida, "uni_Id", "uni_Descripcion");
            return View(tbEntrada);
        }

        // GET: /Entrada/Create
        public ActionResult Create()
        {
            ViewBag.bod_Id = new SelectList(db.tbBodega, "bod_Id", "bod_Nombre");
            ViewBag.estm_Id = new SelectList(db.tbEstadoMovimiento, "estm_Id", "estm_Descripcion");
            ViewBag.prov_Id = new SelectList(db.tbProveedor, "prov_Id", "prov_Nombre");
            ViewBag.tent_Id = new SelectList(db.tbTipoEntrada, "tent_Id", "tent_Descripcion");

            //vista parcial de entrada detalle
            ViewBag.ent_Id = new SelectList(db.tbEntrada, "ent_Id", "ent_Id");
            ViewBag.prod_Codigo = new SelectList(db.tbProducto, "prod_Codigo", "prod_Descripcion");
            ViewBag.uni_Id = new SelectList(db.tbUnidadMedida, "uni_Id", "uni_Descripcion");
            ViewBag.bod_Idd = new SelectList(db.tbBodega, "bod_Id", "bod_Nombre");
            ViewBag.Producto = db.tbProducto.ToList();
            return View();
        }
        
        // GET: /Entrada/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEntrada tbEntrada = db.tbEntrada.Find(id);
            
            if (tbEntrada == null)
            {
                return HttpNotFound();
            }
            ViewBag.bod_Id = new SelectList(db.tbBodega, "bod_Id", "bod_Nombre", tbEntrada.bod_Id);
            ViewBag.estm_Id = new SelectList(db.tbEstadoMovimiento, "estm_Id", "estm_Descripcion", tbEntrada.estm_Id);
            ViewBag.prov_Id = new SelectList(db.tbProveedor, "prov_Id", "prov_Nombre", tbEntrada.prov_Id);
            ViewBag.tent_Id = new SelectList(db.tbTipoEntrada, "tent_Id", "tent_Descripcion", tbEntrada.tent_Id);

            //vista parcial de entrada detalle
            ViewBag.ent_Id = new SelectList(db.tbEntrada, "ent_Id", "ent_Id");
            ViewBag.prod_Codigo = new SelectList(db.tbProducto, "prod_Codigo", "prod_Descripcion");
            ViewBag.uni_Id = new SelectList(db.tbUnidadMedida, "uni_Id", "uni_Descripcion");
            ViewBag.bod_Idd = new SelectList(db.tbBodega, "bod_Id", "bod_Nombre");
            
            ViewBag.Producto = db.tbProducto.ToList();
            return View(tbEntrada);
        }
        
        // GET: /Entrada/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEntrada tbEntrada = await db.tbEntrada.FindAsync(id);
            if (tbEntrada == null)
            {
                return HttpNotFound();
            }
            return View(tbEntrada);
        }

        // POST: /Entrada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tbEntrada tbEntrada = await db.tbEntrada.FindAsync(id);
            db.tbEntrada.Remove(tbEntrada);
            await db.SaveChangesAsync();
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

        //creacion de vistas parciales
        public ActionResult _EditarDetalleEntrada()
        {
            return View();
        }
        public ActionResult _CrearDetalleEntrada()
        {
            return View();
        }
        public ActionResult _DetallesDeEntrada()
        {
            return View();
        }
        public ActionResult _IndexDetalleEntrada()
        {
            return View();
        }
        public ActionResult _IndexEditar()
        {
            return View();
        }

        //para añadir datos temporales a la tabla
        [HttpPost]
        public JsonResult Guardardetalleentrada(tbEntradaDetalle EntradaDetalle)
        {
            List<tbEntradaDetalle> sessionentradadetalle = new List<tbEntradaDetalle>();
            var list = (List<tbEntradaDetalle>)Session["CrearDetalleEntrada"];
            if (list == null)
            {
                sessionentradadetalle.Add(EntradaDetalle);
                Session["CrearDetalleEntrada"] = sessionentradadetalle;
            }
            else
            {
                list.Add(EntradaDetalle);
                Session["CrearDetalleEntrada"] = list;
            }
            return Json("Exito", JsonRequestBehavior.AllowGet);
        }

        //para q actualize la tabla
        [HttpPost]
        public JsonResult entradadetalle_actualizar(tbEntradaDetalle actualizarEntradaDetalle)
        {
            string Msj = "";
            try
            {
                
                //tbBodegaDetalle obj = db.tbBodegaDetalle.Find(id);
                IEnumerable<object> list = null;
                //var MsjError = "";
                list = db.UDP_Inv_tbEntradaDetalle_Update(actualizarEntradaDetalle.entd_Id
                                            , actualizarEntradaDetalle.ent_Id
                                           , actualizarEntradaDetalle.prod_Codigo
                                           , actualizarEntradaDetalle.entd_Cantidad
                                           , actualizarEntradaDetalle.entd_UsuarioCrea
                                           , actualizarEntradaDetalle.entd_FechaCrea
                                           , actualizarEntradaDetalle.uni_Id
                                                               );
                foreach (UDP_Inv_tbEntradaDetalle_Update_Result entrada in list)
                    Msj = entrada.MensajeError;

                if (Msj.Substring(0, 2) == "-1")
                {
                    ModelState.AddModelError("", "No se Actualizo el registro");


                }
                else
                {
                    
                    return Json("Index");
                }

            }
            catch (Exception Ex)
            {
                Ex.Message.ToString();
                ModelState.AddModelError("", "No se Actualizo el registro");
            }
            return Json(Msj, JsonRequestBehavior.AllowGet);
        }

        //para borrar registros en la tabla temporal
        [HttpPost]
        public JsonResult Eliminardetalleentrada(tbEntradaDetalle eliminardetalle)
        {
            var list = (List<tbEntradaDetalle>)Session["_CrearDetalleEntrada"];

            if (list != null)
            {
                var itemToRemove = list.Single(r => r.ent_Id == eliminardetalle.ent_Id);
                list.Remove(itemToRemove);
                Session["_CrearDetalleEntrada"] = list;
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }
        
        // POST: /Entrada/Create
        //Para inserte en la master y la detalle

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ent_NumeroFormato,ent_FechaElaboracion,bod_Id,estm_Id,prov_Id,ent_FacturaCompra,ent_FechaCompra,fact_Id,ent_RazonDevolucion,ent_BodegaDestino,tent_Id")] tbEntrada tbEntrada)
        {
            //var tipoEntrada = tbEntrada.tent_Id;
            //if (tipoEntrada == 1)
            //{
            //    Campos de Traslado
            //    if (tbEntrada.ent_BodegaDestino != null)
            //    {
            //        tbEntrada.ent_BodegaDestino = 9999;
            //    }

            //    campos de devolucion
            //    if (tbEntrada.ent_RazonDevolucion == null)
            //    {
            //        tbEntrada.ent_RazonDevolucion = "##";
            //    }
            //    if (tbEntrada.fact_Id == null)
            //    {
            //        tbEntrada.fact_Id = 9999;
            //    }
            //}
            //if (tipoEntrada == 2)
            //{
            //    campos de Compra
            //    if (tbEntrada.fact_Id == null)
            //    {
            //        tbEntrada.fact_Id = 9999;
            //    }
            //    if (tbEntrada.ent_FacturaCompra == null)
            //    {
            //        tbEntrada.ent_FacturaCompra = "99";
            //    }
            //    if (tbEntrada.ent_FechaCompra == null)
            //    {
            //        tbEntrada.ent_FechaCompra = Convert.ToDateTime("####-##-##");
            //    }
            //    campos de Traslado
            //    if (tbEntrada.ent_BodegaDestino != null)
            //    {
            //        tbEntrada.ent_BodegaDestino = 9999;
            //    }
            //}
            //if (tipoEntrada == 3)
            //{
            //    campos de Compra
            //    if (tbEntrada.fact_Id == null)
            //    {
            //        tbEntrada.fact_Id = 9999;
            //    }
            //    if (tbEntrada.ent_FacturaCompra == null)
            //    {
            //        tbEntrada.ent_FacturaCompra = "####";
            //    }
            //    if (tbEntrada.ent_FechaCompra == null)
            //    {
            //        tbEntrada.ent_FechaCompra = Convert.ToDateTime("####-##-##");
            //    }
            //    campos de devolucion
            //    if (tbEntrada.ent_RazonDevolucion == null)
            //    {
            //        tbEntrada.ent_RazonDevolucion = "##";
            //    }
            //    if (tbEntrada.fact_Id == null)
            //    {
            //        tbEntrada.fact_Id = 9999;
            //    }
            //}

            IEnumerable<object> ENTRADA = null;
            IEnumerable<object> DETALLE = null;
            var idMaster = 0;
            var MensajeError = "";
            var MsjError = "";
            var listaDetalle = (List<tbEntradaDetalle>)Session["CrearDetalleEntrada"];

            ViewBag.bod_Id = new SelectList(db.tbBodega, "bod_Id", "bod_Nombre", tbEntrada.bod_Id);
            //ViewBag.estm_Id = new SelectList(db.tbEstadoMovimiento, "estm_Id", "estm_Descripcion", tbEntrada.estm_Id);
            ViewBag.prov_Id = new SelectList(db.tbProveedor, "prov_Id", "prov_Nombre", tbEntrada.prov_Id);
            ViewBag.tent_Id = new SelectList(db.tbTipoEntrada, "tent_Id", "tent_Descripcion", tbEntrada.tent_Id);
            ViewBag.ent_BodegaDestino = new SelectList(db.tbBodega, "bod_Id", "bod_ResponsableBodega", tbEntrada.ent_BodegaDestino);
            ViewBag.Producto = db.tbProducto.ToList();

            if (ModelState.IsValid)
            {
                using (TransactionScope _Tran = new TransactionScope())
                {
                    try
                    {
                    
                    ENTRADA = db.UDP_Inv_tbEntrada_Insert(tbEntrada.ent_NumeroFormato,
                                                        tbEntrada.ent_FechaElaboracion,
                                                        tbEntrada.bod_Id,
                                                        tbEntrada.estm_Id,
                                                        tbEntrada.prov_Id,
                                                        tbEntrada.ent_FacturaCompra,
                                                        tbEntrada.ent_FechaCompra,
                                                        tbEntrada.fact_Id,
                                                        tbEntrada.ent_RazonDevolucion,
                                                        tbEntrada.ent_BodegaDestino,
                                                        tbEntrada.tent_Id);
                    foreach (UDP_Inv_tbEntrada_Insert_Result Entrada in ENTRADA)
                            idMaster = Convert.ToInt32(Entrada.MensajeError);

                    if (MsjError =="-")
                    {
                        ModelState.AddModelError("", "No se guardo el registro");
                            return View(tbEntrada);
                    }
                    else
                    {
                            if (listaDetalle != null)
                            {
                                if (listaDetalle.Count > 0)
                                {
                                    foreach (tbEntradaDetalle entd in listaDetalle)
                                    {
                                        DETALLE = db.UDP_Inv_tbEntradaDetalle_Insert( idMaster
                                                                                    , entd.prod_Codigo
                                                                                    , entd.entd_Cantidad
                                                                                    , entd.uni_Id);
                                        foreach (UDP_Inv_tbEntradaDetalle_Insert_Result B_detalle in DETALLE)

                                        //if (MensajeError == "-1")
                                        {
                                            ModelState.AddModelError("", "No se Guardo el Registro");
                                            //return View(tbEntrada);
                                            //}
                                            //else
                                            //{
                                            //    _Tran.Complete();
                                            //    return RedirectToAction("Index");
                                        }
                                    }
                                }
                            }
                            {
                                _Tran.Complete();
                                //return RedirectToAction("Index");
                            }

                        }

                    }
                    catch (Exception Ex)
                    {
                        Ex.Message.ToString();
                        //ModelState.AddModelError("", "No se Guardo el Registro");
                        //return View(tbBodega);
                        MsjError = "-1";
                    }
                }
                return RedirectToAction("Index");
            }
            
            return View(tbEntrada);
        }


        // POST: /Entrada/Edit/5
        //Para q edite la master y el detalle
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, [Bind(Include = "ent_Id,ent_NumeroFormato,ent_FechaElaboracion,bod_Id,estm_Id,prov_Id,ent_FacturaCompra,ent_FechaCompra,fact_Id,ent_RazonDevolucion,ent_BodegaDestino,tent_Id,ent_usuarioCrea,ent_FechaCrea,ent_UsuarioModifica,ent_FechaModifica")] tbEntrada tbEntrada)
        {
            IEnumerable<object> ENTRADA = null;
            IEnumerable<object> DETALLE = null;
            var idMaster = 0;
            var MensajeError = "";
            var MsjError = "";
            var listaDetalle = (List<tbEntradaDetalle>)Session["tbEntradaDetalle"];

            ViewBag.bod_Id = new SelectList(db.tbBodega, "bod_Id", "bod_Nombre", tbEntrada.bod_Id);
            //ViewBag.estm_Id = new SelectList(db.tbEstadoMovimiento, "estm_Id", "estm_Descripcion", tbEntrada.estm_Id);
            ViewBag.prov_Id = new SelectList(db.tbProveedor, "prov_Id", "prov_Nombre", tbEntrada.prov_Id);
            ViewBag.tent_Id = new SelectList(db.tbTipoEntrada, "tent_Id", "tent_Descripcion", tbEntrada.tent_Id);
            ViewBag.ent_BodegaDestino = new SelectList(db.tbBodega, "bod_Id", "bod_ResponsableBodega", tbEntrada.ent_BodegaDestino);
            ViewBag.prod_Codigo = new SelectList(db.tbProducto, "prod_Codigo", "prod_Descripcion");
            ViewBag.uni_Id = new SelectList(db.tbUnidadMedida, "uni_Id", "uni_Descripcion");
            ViewBag.Producto = db.tbProducto.ToList();

            if (ModelState.IsValid)
            {
                using (TransactionScope _Tran = new TransactionScope())
                {
                    try
                    {

                        ENTRADA = db.UDP_Inv_tbEntrada_Update(tbEntrada.ent_Id,
                                                                        tbEntrada.ent_NumeroFormato,
                                                                        tbEntrada.ent_FechaElaboracion,
                                                                        tbEntrada.bod_Id,
                                                                        tbEntrada.estm_Id,
                                                                        tbEntrada.prov_Id,
                                                                        tbEntrada.ent_FacturaCompra,
                                                                        tbEntrada.ent_FechaCompra,
                                                                        tbEntrada.fact_Id, 
                                                                        tbEntrada.ent_RazonDevolucion,
                                                                        tbEntrada.ent_BodegaDestino,
                                                                        tbEntrada.tent_Id,
                                                                        tbEntrada.ent_UsuarioCrea,
                                                                        tbEntrada.ent_FechaCrea);
                        foreach (UDP_Inv_tbEntrada_Update_Result Entrada in ENTRADA)
                            idMaster = Convert.ToInt32(Entrada.MensajeError);

                        if (MsjError == "-")
                        {
                            ModelState.AddModelError("", "No se guardo el registro");
                            return View(tbEntrada);
                        }
                        else
                        {
                            if (listaDetalle != null)
                            {
                                if (listaDetalle.Count > 0)
                                {
                                    foreach (tbEntradaDetalle entd in listaDetalle)
                                    {
                                        DETALLE = db.UDP_Inv_tbEntradaDetalle_Update(entd.ent_Id
                                                                                    , idMaster
                                                                                    ,entd.prod_Codigo
                                                                                    ,entd.entd_Cantidad
                                                                                    ,entd.entd_UsuarioCrea
                                                                                    , Convert.ToDateTime(entd.entd_FechaCrea)
                                                                                    ,entd.uni_Id);
                                        foreach (UDP_Inv_tbEntradaDetalle_Update_Result B_detalle in DETALLE)

                                        //if (MensajeError == "-1")
                                        {
                                            ModelState.AddModelError("", "No se Guardo el Registro");
                                            return View(tbEntrada);
                                            //}
                                            //else
                                            //{
                                            //    _Tran.Complete();
                                            //    return RedirectToAction("Index");
                                        }
                                    }
                                }
                            }
                            {
                                _Tran.Complete();
                                //return RedirectToAction("Index");
                            }

                        }

                    }
                    catch (Exception Ex)
                    {
                        Ex.Message.ToString();
                        //ModelState.AddModelError("", "No se Guardo el Registro");
                        //return View(tbBodega);
                        MsjError = "-1";
                    }
                }
                return RedirectToAction("Index");
            }
            ViewBag.bod_Id = new SelectList(db.tbBodega, "bod_Id", "bod_Nombre", tbEntrada.bod_Id);
            ViewBag.estm_Id = new SelectList(db.tbEstadoMovimiento, "estm_Id", "estm_Descripcion", tbEntrada.estm_Id);
            ViewBag.prov_Id = new SelectList(db.tbProveedor, "prov_Id", "prov_Nombre", tbEntrada.prov_Id);
            ViewBag.tent_Id = new SelectList(db.tbTipoEntrada, "tent_Id", "tent_Descripcion", tbEntrada.tent_Id);
            ViewBag.ent_BodegaDestino = new SelectList(db.tbBodega, "bod_Id", "bod_ResponsableBodega", tbEntrada.ent_BodegaDestino);
            ViewBag.prod_Codigo = new SelectList(db.tbProducto, "prod_Codigo", "prod_Descripcion");
            ViewBag.uni_Id = new SelectList(db.tbUnidadMedida, "uni_Id", "uni_Descripcion");
            ViewBag.Producto = db.tbProducto.ToList();
            return View(tbEntrada);
        }

    }
}
