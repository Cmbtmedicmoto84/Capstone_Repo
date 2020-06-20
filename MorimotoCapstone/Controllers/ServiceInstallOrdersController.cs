//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using MorimotoCapstone.Data;
//using MorimotoCapstone.Models;

//namespace MorimotoCapstone.Controllers
//{
//    public class ServiceInstallOrdersController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public ServiceInstallOrdersController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: ServiceInstallOrders
//        public async Task<IActionResult> Index()
//        {
//            var applicationDbContext = _context.ServiceInstallOrders.Include(s => s.Customer).Include(s => s.InstallTech).Include(s => s.Product);
//            return View(await applicationDbContext.ToListAsync());
//        }

//        // GET: ServiceInstallOrders/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var serviceInstallOrder = await _context.ServiceInstallOrders
//                .Include(s => s.Customer)
//                .Include(s => s.InstallTech)
//                .Include(s => s.Product)
//                .FirstOrDefaultAsync(m => m.OrderId == id);
//            if (serviceInstallOrder == null)
//            {
//                return NotFound();
//            }

//            return View(serviceInstallOrder);
//        }

//        // GET: ServiceInstallOrders/Create
//        public IActionResult Create()
//        {
//            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne");
//            ViewData["TechId"] = new SelectList(_context.InstallTechs, "TechId", "TechId");
//            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
//            return View();
//        }

//        // POST: ServiceInstallOrders/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("OrderId,ServiceOrderStatus,OrderNotes,IsComplete,ProductId,CustomerAccountId,TechId")] ServiceInstallOrder serviceInstallOrder)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(serviceInstallOrder);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne", serviceInstallOrder.CustomerAccountId);
//            ViewData["TechId"] = new SelectList(_context.InstallTechs, "TechId", "TechId", serviceInstallOrder.TechId);
//            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", serviceInstallOrder.ProductId);
//            return View(serviceInstallOrder);
//        }

//        // GET: ServiceInstallOrders/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var serviceInstallOrder = await _context.ServiceInstallOrders.FindAsync(id);
//            if (serviceInstallOrder == null)
//            {
//                return NotFound();
//            }
//            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne", serviceInstallOrder.CustomerAccountId);
//            ViewData["TechId"] = new SelectList(_context.InstallTechs, "TechId", "TechId", serviceInstallOrder.TechId);
//            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", serviceInstallOrder.ProductId);
//            return View(serviceInstallOrder);
//        }

//        // POST: ServiceInstallOrders/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("OrderId,ServiceOrderStatus,OrderNotes,IsComplete,ProductId,CustomerAccountId,TechId")] ServiceInstallOrder serviceInstallOrder)
//        {
//            if (id != serviceInstallOrder.OrderId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(serviceInstallOrder);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ServiceInstallOrderExists(serviceInstallOrder.OrderId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne", serviceInstallOrder.CustomerAccountId);
//            ViewData["TechId"] = new SelectList(_context.InstallTechs, "TechId", "TechId", serviceInstallOrder.TechId);
//            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", serviceInstallOrder.ProductId);
//            return View(serviceInstallOrder);
//        }

//        // GET: ServiceInstallOrders/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var serviceInstallOrder = await _context.ServiceInstallOrders
//                .Include(s => s.Customer)
//                .Include(s => s.InstallTech)
//                .Include(s => s.Product)
//                .FirstOrDefaultAsync(m => m.OrderId == id);
//            if (serviceInstallOrder == null)
//            {
//                return NotFound();
//            }

//            return View(serviceInstallOrder);
//        }

//        // POST: ServiceInstallOrders/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var serviceInstallOrder = await _context.ServiceInstallOrders.FindAsync(id);
//            _context.ServiceInstallOrders.Remove(serviceInstallOrder);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ServiceInstallOrderExists(int id)
//        {
//            return _context.ServiceInstallOrders.Any(e => e.OrderId == id);
//        }
//    }
//}
