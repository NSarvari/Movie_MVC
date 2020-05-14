using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataStructure;
using MovieReviews.Data;
using Microsoft.AspNetCore.Authorization;

namespace MovieReviews.Controllers
{
    public class MovieDirectorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieDirectorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MovieDirectors
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MovieDirectors.Include(m => m.Director).Include(m => m.Movie);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MovieDirectors/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            ViewData["directorId"] = new SelectList(_context.Directors, "ID", "ID");
            ViewData["movieId"] = new SelectList(_context.Movies, "ID", "ID");
            return View();
        }

        // POST: MovieDirectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("movieId,directorId")] MovieDirector movieDirector)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieDirector);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["directorId"] = new SelectList(_context.Directors, "ID", "ID", movieDirector.directorId);
            ViewData["movieId"] = new SelectList(_context.Movies, "ID", "ID", movieDirector.movieId);
            return View(movieDirector);
        }

        // GET: MovieDirectors/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDirector = await _context.MovieDirectors.FindAsync(id);
            if (movieDirector == null)
            {
                return NotFound();
            }
            ViewData["directorId"] = new SelectList(_context.Directors, "ID", "ID", movieDirector.directorId);
            ViewData["movieId"] = new SelectList(_context.Movies, "ID", "ID", movieDirector.movieId);
            return View(movieDirector);
        }

        // POST: MovieDirectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("movieId,directorId")] MovieDirector movieDirector)
        {
            if (id != movieDirector.movieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieDirector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieDirectorExists(movieDirector.movieId))
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
            ViewData["directorId"] = new SelectList(_context.Directors, "ID", "ID", movieDirector.directorId);
            ViewData["movieId"] = new SelectList(_context.Movies, "ID", "ID", movieDirector.movieId);
            return View(movieDirector);
        }

        // GET: MovieDirectors/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDirector = await _context.MovieDirectors
                .Include(m => m.Director)
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(m => m.movieId == id);
            if (movieDirector == null)
            {
                return NotFound();
            }

            return View(movieDirector);
        }

        // POST: MovieDirectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieDirector = await _context.MovieDirectors.FindAsync(id);
            _context.MovieDirectors.Remove(movieDirector);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieDirectorExists(int id)
        {
            return _context.MovieDirectors.Any(e => e.movieId == id);
        }
    }
}
