using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class ServiceOrderDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceOrderDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceOrderDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ServiceOrderDetails.Include(s => s.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ServiceOrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceOrderDetail = await _context.ServiceOrderDetails
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.OrderDetailId == id);
            if (serviceOrderDetail == null)
            {
                return NotFound();
            }

            return View(serviceOrderDetail);
        }

        // GET: ServiceOrderDetails/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
            return View();
        }

        // POST: ServiceOrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderDetailId,OrderId,ProductId,Quantity,ProductPrice")] ServiceOrderDetail serviceOrderDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceOrderDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", serviceOrderDetail.ProductId);
            return View(serviceOrderDetail);
        }

        // GET: ServiceOrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceOrderDetail = await _context.ServiceOrderDetails.FindAsync(id);
            if (serviceOrderDetail == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", serviceOrderDetail.ProductId);
            return View(serviceOrderDetail);
        }

        // POST: ServiceOrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderDetailId,OrderId,ProductId,Quantity,ProductPrice")] ServiceOrderDetail serviceOrderDetail)
        {
            if (id != serviceOrderDetail.OrderDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceOrderDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceOrderDetailExists(serviceOrderDetail.OrderDetailId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", serviceOrderDetail.ProductId);
            return View(serviceOrderDetail);
        }

        // GET: ServiceOrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceOrderDetail = await _context.ServiceOrderDetails
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.OrderDetailId == id);
            if (serviceOrderDetail == null)
            {
                return NotFound();
            }

            return View(serviceOrderDetail);
        }

        // POST: ServiceOrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceOrderDetail = await _context.ServiceOrderDetails.FindAsync(id);
            _context.ServiceOrderDetails.Remove(serviceOrderDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceOrderDetailExists(int id)
        {
            return _context.ServiceOrderDetails.Any(e => e.OrderDetailId == id);
        }
    }
}
