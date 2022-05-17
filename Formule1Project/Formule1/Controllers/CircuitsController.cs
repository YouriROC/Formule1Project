﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using F1Lib.Models;
using F1MVC.Data;

namespace F1MVC.Controllers
{
    public class CircuitsController : Controller
    {
        private readonly Formule1Context _context;

        public CircuitsController(Formule1Context context)
        {
            _context = context;
        }

        // GET: Circuits
        public async Task<IActionResult> Index()
        {
              return _context.Circuit != null ? 
                          View(await _context.Circuit.Include(t => t.Country).ToListAsync()) :
                          Problem("Entity set 'Formule1Context.Circuit'  is null.");
        }

        // GET: Circuits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Circuit == null)
            {
                return NotFound();
            }

            var circuit = await _context.Circuit.Include(t => t.Country).Include(t => t.Races)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (circuit == null)
            {
                return NotFound();
            }

            return View(circuit);
        }

        // GET: Circuits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Circuits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,description,Latitude,Longitude,Wiki")] Circuit circuit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(circuit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circuit);
        }

        // GET: Circuits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Circuit == null)
            {
                return NotFound();
            }

            var circuit = await _context.Circuit.FindAsync(id);
            if (circuit == null)
            {
                return NotFound();
            }
            return View(circuit);
        }

        // POST: Circuits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,description,Latitude,Longitude,Wiki")] Circuit circuit)
        {
            if (id != circuit.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(circuit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CircuitExists(circuit.ID))
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
            return View(circuit);
        }

        // GET: Circuits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Circuit == null)
            {
                return NotFound();
            }

            var circuit = await _context.Circuit
                .FirstOrDefaultAsync(m => m.ID == id);
            if (circuit == null)
            {
                return NotFound();
            }

            return View(circuit);
        }

        // POST: Circuits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Circuit == null)
            {
                return Problem("Entity set 'Formule1Context.Circuit'  is null.");
            }
            var circuit = await _context.Circuit.FindAsync(id);
            if (circuit != null)
            {
                _context.Circuit.Remove(circuit);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CircuitExists(int id)
        {
          return (_context.Circuit?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
