using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PediatricsDepartment.Data;
using PediatricsDepartment.Models;
using Microsoft.AspNetCore.Authorization;

namespace PediatricsDepartment.Controllers
{
    
    public class AssistantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssistantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Assistants()
        {
            var assistants = _context.Assistants.ToList();
            return View(assistants);
        }

        [Authorize(Roles = "Admin")]  // Only allow admins to access these actions
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Assistant assistant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assistant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Assistants));
            }
            return View(assistant);
        }

        // Delete Assistant
        public async Task<IActionResult> Delete(int id)
        {
            var assistant = await _context.Assistants.FindAsync(id);
            if (assistant != null)
            {
                _context.Assistants.Remove(assistant);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Assistants));
        }

    }
}
