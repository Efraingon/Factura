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

namespace FacturaApp.Web.Controllers
{
    public class contactoClientesController : FacturaAppControllerBase
    {
        private FacturaAppDbContext db = new FacturaAppDbContext();

        // GET: contactoClientes
        public async Task<ActionResult> Index()
        {
            return View(await db.ContactoCliente.ToListAsync());
        }

        // GET: contactoClientes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contactoClientes contactoClientes = await db.ContactoCliente.FindAsync(id);
            if (contactoClientes == null)
            {
                return HttpNotFound();
            }
            return View(contactoClientes);
        }

        // GET: contactoClientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: contactoClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdContacto,Nombre,Telefono,Email,Contacto,IsDeleted,DeleterUserId,DeletionTime,LastModificationTime,LastModifierUserId,CreationTime,CreatorUserId,Id")] contactoClientes contactoClientes)
        {
            if (ModelState.IsValid)
            {
                db.ContactoCliente.Add(contactoClientes);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(contactoClientes);
        }

        // GET: contactoClientes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contactoClientes contactoClientes = await db.ContactoCliente.FindAsync(id);
            if (contactoClientes == null)
            {
                return HttpNotFound();
            }
            return View(contactoClientes);
        }

        // POST: contactoClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdContacto,Nombre,Telefono,Email,Contacto,IsDeleted,DeleterUserId,DeletionTime,LastModificationTime,LastModifierUserId,CreationTime,CreatorUserId,Id")] contactoClientes contactoClientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactoClientes).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(contactoClientes);
        }

        // GET: contactoClientes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contactoClientes contactoClientes = await db.ContactoCliente.FindAsync(id);
            if (contactoClientes == null)
            {
                return HttpNotFound();
            }
            return View(contactoClientes);
        }

        // POST: contactoClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            contactoClientes contactoClientes = await db.ContactoCliente.FindAsync(id);
            db.ContactoCliente.Remove(contactoClientes);
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
    }
}
