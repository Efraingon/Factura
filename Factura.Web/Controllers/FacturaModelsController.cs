using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FacturaApp.EntityFramework;
using FacturaApp.Models;
using Abp.Runtime.Validation;
using Abp.UI;

namespace FacturaApp.Web.Controllers {
    public class FacturaModelsController:Controller {
        private static readonly ICollection<FacturaModel> facturas = new HashSet<FacturaModel>();

        private static readonly ICollection<FacturaManager> Facturas = new HashSet<FacturaManager>();
        private FacturaAppDbContext db = new FacturaAppDbContext();

        // GET: FacturaModels
        public async Task<ActionResult> Index() {
            return View(await db.Factura.ToListAsync());
        }

        // GET: FacturaModels/Details/5
        public async Task<ActionResult> Details(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaModel facturaModel = await db.Factura.FindAsync(id);
            if(facturaModel == null) {
                return HttpNotFound();
            }
            return View(facturaModel);
        }

        [HttpGet]
        public ActionResult Create() {
            ViewBag.Facturas = new SelectList(db.Factura,"IdFactura","Nombre");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [DisableValidation]
        public async Task<ActionResult> Create(FacturaModel facturaModel) {
            try {
                if(!ModelState.IsValid) {
                    if(ViewBag.Facturas == null) {
                        ViewBag.Facturas = new SelectList(db.Factura,"IdFactura","Nombre");
                    }
                    return View(facturaModel);
                }
                if(facturaModel.FacturaDocumento == null || facturaModel.FacturaDocumento.Count == 0) {
                    ModelState.AddModelError("Detalle","Debe agregar al menos un detalle para la factura");
                    return View(facturaModel);

                } else {
                    db.Factura.Add(facturaModel);

                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            } catch(Exception vEx) {
                throw new UserFriendlyException(vEx.Message,vEx.InnerException);
            }
        }

        // GET: FacturaModels/Edit/5
        public async Task<ActionResult> Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaModel facturaModel = await db.Factura.FindAsync(id);
            if(facturaModel == null) {
                return HttpNotFound();
            }
            return View(facturaModel);
        }

        // POST: FacturaModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idFactura,TenantId,Numero,Descripcion,Status,IsDeleted,DeleterUserId,DeletionTime,LastModificationTime,LastModifierUserId,CreationTime,CreatorUserId,Id")] FacturaModel facturaModel) {
            if(ModelState.IsValid) {
                db.Entry(facturaModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(facturaModel);
        }

        // GET: FacturaModels/Delete/5
        public async Task<ActionResult> Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaModel facturaModel = await db.Factura.FindAsync(id);
            if(facturaModel == null) {
                return HttpNotFound();
            }
            return View(facturaModel);
        }

        // POST: FacturaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id) {
            FacturaModel facturaModel = await db.Factura.FindAsync(id);
            db.Factura.Remove(facturaModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
