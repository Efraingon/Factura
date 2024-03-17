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

namespace FacturaApp.Web.Controllers {
    public class ClientesController:Controller {
        private FacturaAppDbContext db = new FacturaAppDbContext();

        // GET: Clientes
        public async Task<ActionResult> Index() {
        var cliente = db.Cliente.Include(c => c.contactoClientes);
        return View(await cliente.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<ActionResult> Details(int? id) {
        if(id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Clientes clientes = await db.Cliente.FindAsync(id);
        if(clientes == null) {
        return HttpNotFound();
        }
        return View(clientes);
        }

        // GET: Clientes/Create
        public ActionResult Create() {
        ViewBag.IdContacto = new SelectList(db.ContactoCliente,"IdContacto","Nombre");
        return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdCliente,Nombre,RFC,NIT,Direccion,Telefono,IdContacto,IsDeleted,DeleterUserId,DeletionTime,LastModificationTime,LastModifierUserId,CreationTime,CreatorUserId,Id")] Clientes clientes) {
        if(ModelState.IsValid) {
        db.Cliente.Add(clientes);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
        }

        ViewBag.IdContacto = new SelectList(db.ContactoCliente,"IdContacto","Nombre",clientes.IdContacto);
        return View(clientes);
        }

        // GET: Clientes/Edit/5
        public async Task<ActionResult> Edit(int? id) {
        if(id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Clientes clientes = await db.Cliente.FindAsync(id);
        if(clientes == null) {
        return HttpNotFound();
        }
        ViewBag.IdContacto = new SelectList(db.ContactoCliente,"IdContacto","Nombre",clientes.IdContacto);
        return View(clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdCliente,Nombre,RFC,NIT,Direccion,Telefono,IdContacto,IsDeleted,DeleterUserId,DeletionTime,LastModificationTime,LastModifierUserId,CreationTime,CreatorUserId,Id")] Clientes clientes) {
        if(ModelState.IsValid) {
        db.Entry(clientes).State = EntityState.Modified;
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
        }
        ViewBag.IdContacto = new SelectList(db.ContactoCliente,"IdContacto","Nombre",clientes.IdContacto);
        return View(clientes);
        }

        // GET: Clientes/Delete/5
        public async Task<ActionResult> Delete(int? id) {
        if(id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Clientes clientes = await db.Cliente.FindAsync(id);
        if(clientes == null) {
        return HttpNotFound();
        }
        return View(clientes);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id) {
        Clientes clientes = await db.Cliente.FindAsync(id);
        db.Cliente.Remove(clientes);
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
