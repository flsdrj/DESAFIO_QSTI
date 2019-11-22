using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.Data;
using Projeto.Models;

namespace Projeto.Controllers
{
    [Authorize]
    public class ServicoClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicoClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServicoClientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServicoCliente.ToListAsync());
        }

        // GET: ServicoClientes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoCliente = await _context.ServicoCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicoCliente == null)
            {
                return NotFound();
            }

            return View(servicoCliente);
        }

        // GET: ServicoClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServicoClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ServicoId,ClienteId,Versao")] ServicoCliente servicoCliente)
        {
            if (ModelState.IsValid)
            {
                servicoCliente.Id = Guid.NewGuid();
                _context.Add(servicoCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicoCliente);
        }

        // GET: ServicoClientes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoCliente = await _context.ServicoCliente.FindAsync(id);
            if (servicoCliente == null)
            {
                return NotFound();
            }
            return View(servicoCliente);
        }

        // POST: ServicoClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ServicoId,ClienteId,Versao")] ServicoCliente servicoCliente)
        {
            if (id != servicoCliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicoCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicoClienteExists(servicoCliente.Id))
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
            return View(servicoCliente);
        }

        // GET: ServicoClientes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoCliente = await _context.ServicoCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servicoCliente == null)
            {
                return NotFound();
            }

            return View(servicoCliente);
        }

        // POST: ServicoClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var servicoCliente = await _context.ServicoCliente.FindAsync(id);
            _context.ServicoCliente.Remove(servicoCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicoClienteExists(Guid id)
        {
            return _context.ServicoCliente.Any(e => e.Id == id);
        }
    }
}
