using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Empresa1aN.Models;

namespace Empresa1aN.Controllers
{
    public class DepartamentoesController : Controller
    {
        private readonly Empresa1aNContext _context;

        public DepartamentoesController(Empresa1aNContext context)
        {
            _context = context;
        }

        // GET: Departamentoes
        public async Task<IActionResult> Index(int? id, string nombre)
        {
           
            if (id != null && nombre == null)
            {
                DepartamentoEmpleadosViewModel viewModel = new DepartamentoEmpleadosViewModel {
                    Departamentos = await _context.Departamento.Where(m => m.Id == id).ToListAsync(),
                    Empleados = await _context.Empleado.Where(x=>x.DepartamentoId == id).ToListAsync(),
                    Id = Convert.ToInt32(id)

            };
                return View(viewModel);
            }
            else if (id == null && nombre != null)
            {
                DepartamentoEmpleadosViewModel viewModel = new DepartamentoEmpleadosViewModel
                {
                    Departamentos = await _context.Departamento.ToListAsync(),
                    Empleados = await _context.Empleado.Where(y => y.Nombre.ToLower().Contains(nombre.ToLower())).ToListAsync(),

                };

                return View(viewModel);

            }
            else if (id != null && nombre != null)
            {
                DepartamentoEmpleadosViewModel viewModel = new DepartamentoEmpleadosViewModel
                {
                    Departamentos = await _context.Departamento.Where(m => m.Id == id).ToListAsync(),
                    Empleados = await _context.Empleado.Where(y => y.Nombre.ToLower().Contains(nombre.ToLower())).Where(m=>m.DepartamentoId==id).ToListAsync(),
                    Id = Convert.ToInt32(id)


                };

                return View(viewModel);
            }
            else
            {
                DepartamentoEmpleadosViewModel viewModel = new DepartamentoEmpleadosViewModel
                {
                    Departamentos = await _context.Departamento.ToListAsync(),
                    Empleados = await _context.Empleado.ToListAsync(),

                };
                return View(viewModel);
            }
        }

        // GET: Departamentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // GET: Departamentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departamentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Codigo")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departamento);
        }

        // GET: Departamentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamento.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }
            return View(departamento);
        }

        // POST: Departamentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Codigo")] Departamento departamento)
        {
            if (id != departamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartamentoExists(departamento.Id))
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
            return View(departamento);
        }

        // GET: Departamentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // POST: Departamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departamento = await _context.Departamento.FindAsync(id);
            _context.Departamento.Remove(departamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartamentoExists(int id)
        {
            return _context.Departamento.Any(e => e.Id == id);
        }
    }
}
