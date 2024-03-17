using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using FacturaApp.EntityFramework;
using FacturaApp.Models;

namespace FacturaApp.Web.Controllers
{
    public class FacturaDocumentoModelsController : Controller
    {
        private FacturaAppDbContext db = new FacturaAppDbContext();

        // GET: FacturaDocumentoModels
        public async Task<ActionResult> Index()
        {
            var facturaDocumento = db.FacturaDocumento.Include(f => f.idDocumento).Include(f => f.Factura);
            return View(await facturaDocumento.ToListAsync());
        }

        // GET: FacturaDocumentoModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaDocumentoModel facturaDocumentoModel = await db.FacturaDocumento.FindAsync(id);
            if (facturaDocumentoModel == null)
            {
                return HttpNotFound();
            }
            return View(facturaDocumentoModel);
        }

        // GET: FacturaDocumentoModels/Create
        public ActionResult Create()
        {
            ViewBag.DocumentoId = new SelectList(db.FacturaDocumento, "idDocumento", "Descripcion_Factura");
            ViewBag.FacturaId = new SelectList(db.Factura, "idFactura", "Descripcion");
            return View();
        }

        // POST: FacturaDocumentoModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idDocumento,FacturaId,DocumentoId,IsDeleted,DeleterUserId,DeletionTime,LastModificationTime,LastModifierUserId,CreationTime,CreatorUserId,Id")] FacturaDocumentoModel facturaDocumentoModel)
        {
            if (ModelState.IsValid)
            {
                db.FacturaDocumento.Add(facturaDocumentoModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.DocumentoId = new SelectList(db.FacturaDocumento, "idDocumento", "Descripcion_Factura", facturaDocumentoModel.idDocumento);
            ViewBag.FacturaId = new SelectList(db.Factura, "idFactura", "Descripcion", facturaDocumentoModel.FacturaId);
            return View(facturaDocumentoModel);
        }

        // GET: FacturaDocumentoModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaDocumentoModel facturaDocumentoModel = await db.FacturaDocumento.FindAsync(id);
            if (facturaDocumentoModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.DocumentoId = new SelectList(db.FacturaDocumento, "idDocumento", "Descripcion_Factura", facturaDocumentoModel.idDocumento);
            ViewBag.FacturaId = new SelectList(db.Factura, "idFactura", "Descripcion", facturaDocumentoModel.FacturaId);
            return View(facturaDocumentoModel);
        }

        // POST: FacturaDocumentoModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idDocumento,FacturaId,DocumentoId,IsDeleted,DeleterUserId,DeletionTime,LastModificationTime,LastModifierUserId,CreationTime,CreatorUserId,Id")] FacturaDocumentoModel facturaDocumentoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facturaDocumentoModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.DocumentoId = new SelectList(db.FacturaDocumento, "idDocumento", "Descripcion_Factura", facturaDocumentoModel.idDocumento);
            ViewBag.FacturaId = new SelectList(db.Factura, "idFactura", "Descripcion", facturaDocumentoModel.FacturaId);
            return View(facturaDocumentoModel);
        }

        // GET: FacturaDocumentoModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaDocumentoModel facturaDocumentoModel = await db.FacturaDocumento.FindAsync(id);
            if (facturaDocumentoModel == null)
            {
                return HttpNotFound();
            }
            return View(facturaDocumentoModel);
        }

        // POST: FacturaDocumentoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FacturaDocumentoModel facturaDocumentoModel = await db.FacturaDocumento.FindAsync(id);
            db.FacturaDocumento.Remove(facturaDocumentoModel);
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
