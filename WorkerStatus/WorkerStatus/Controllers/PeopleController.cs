using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkerStatus.Data;
using WorkerStatus.Models;

namespace WorkerStatus.Controllers
{
    public class PeopleController : Controller
    {
        private readonly WorkerStatusContext _context;

        public PeopleController(WorkerStatusContext context)
        {
            _context = context;
        }

        // GET: Person
        public async Task<IActionResult> Index(string personPosition, string searchString, string personTeam, string searchPersonTeam)
        {
            if (_context.Person == null)
            {
                return Problem("Entity set 'WorcerStatus.Person'  is null.");
            }

            // Use LINQ to get list of position.
            IQueryable<string> positionQuery = from p in _context.Person
                                            orderby p.Position
                                            select p.Position;

            IQueryable<string> teamQuery = from t in _context.Person
                                           orderby t.Team
                                           select t.Team;

            var persons = from p in _context.Person
                         select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                persons = persons.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(personPosition))
            {
                persons = persons.Where(x => x.Position == personPosition);
            }

            if (!string.IsNullOrEmpty(personTeam))
            {
                persons = persons.Where(x => x.Team == personTeam);
            }

            var personPositionVM = new WorkerStatistics
            {
                Positions = new SelectList(await positionQuery.Distinct().ToListAsync()),
                Teams = new SelectList(await teamQuery.Distinct().ToListAsync()),
                Persons = await persons.ToListAsync()
            };

            return View(personPositionVM);
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Patronymic,Age,Position,HourlyRate,Team")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Patronymic,Age,Position,HourlyRate,Team")] Person person)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.Id))
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
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person != null)
            {
                _context.Person.Remove(person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
