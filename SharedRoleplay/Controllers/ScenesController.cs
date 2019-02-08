using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SharedRoleplay.Data;
using SharedRoleplay.Models;

namespace SharedRoleplay.Controllers
{
    public class ScenesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScenesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Scenes
        public async Task<IActionResult> Index()
        {
            var sharedRoleplayContext = _context.Scene.Include(s => s.Story);
            return View(await sharedRoleplayContext.ToListAsync());
        }

        // GET: Scenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scene = await _context.Scene
                .Include(s => s.Story)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (scene == null)
            {
                return NotFound();
            }

            return View(scene);
        }

        // GET: Scenes/Create
        public IActionResult Create()
        {
            ViewData["StoryID"] = new SelectList(_context.Story, "ID", "Title");
            return View();
        }

        // POST: Scenes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Setting,StoryID")] Scene scene)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scene);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StoryID"] = new SelectList(_context.Story, "ID", "Title", scene.StoryID);
            return View(scene);
        }

        // GET: Scenes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scene = await _context.Scene.FindAsync(id);
            if (scene == null)
            {
                return NotFound();
            }
            ViewData["StoryID"] = new SelectList(_context.Story, "ID", "Title", scene.StoryID);
            return View(scene);
        }

        // POST: Scenes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Setting,StoryID")] Scene scene)
        {
            if (id != scene.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scene);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SceneExists(scene.ID))
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
            ViewData["StoryID"] = new SelectList(_context.Story, "ID", "Title", scene.StoryID);
            return View(scene);
        }

        // GET: Scenes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scene = await _context.Scene
                .Include(s => s.Story)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (scene == null)
            {
                return NotFound();
            }

            return View(scene);
        }

        // POST: Scenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scene = await _context.Scene.FindAsync(id);
            _context.Scene.Remove(scene);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SceneExists(int id)
        {
            return _context.Scene.Any(e => e.ID == id);
        }
    }
}
