using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using agcMVC.Models;

namespace agcMVC.Controllers
{
    public class analisesController : Controller
    {
        private anacriEntities db = new anacriEntities();

        // GET: analises
        public async Task<ActionResult> Index()
        {
            return View(await db.analise.ToListAsync());
        }

        // GET: analises/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            analise analise = await db.analise.FindAsync(id);
            if (analise == null)
            {
                return HttpNotFound();
            }
            return View(analise);
        }

        // GET: analises/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: analises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,client_id,date_emissao,date_retorno,date_entrega,prod_id,prod_desc,pcp_captec,pcp_captec_obs,pcp_capope,pcp_capope_obs,pcp_proj,pcp_proj_obs,conclusao")] analise analise)
        {
            if (ModelState.IsValid)
            {
                db.analise.Add(analise);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(analise);
        }

        // GET: analises/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            analise analise = await db.analise.FindAsync(id);
            if (analise == null)
            {
                return HttpNotFound();
            }
            // teste
            return View(analise);
        }

        // POST: analises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,client_id,date_emissao,date_retorno,date_entrega,prod_id,prod_desc,pcp_captec,pcp_captec_obs,pcp_capope,pcp_capope_obs,pcp_proj,pcp_proj_obs,conclusao")] analise analise)
        {
            if (ModelState.IsValid)
            {
                db.Entry(analise).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(analise);
        }

        // GET: analises/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            analise analise = await db.analise.FindAsync(id);
            if (analise == null)
            {
                return HttpNotFound();
            }
            return View(analise);
        }

        // POST: analises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            analise analise = await db.analise.FindAsync(id);
            db.analise.Remove(analise);
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
