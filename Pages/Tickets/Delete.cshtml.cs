using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceTeamApplicationTracker.Data;
using ServiceTeamApplicationTracker.Models;

namespace ServiceTeamApplicationTracker.Pages.Tickets
{
    public class DeleteModel : PageModel
    {
        private readonly ServiceTeamApplicationTracker.Data.ServiceTeamApplicationTrackerContext _context;

        public DeleteModel(ServiceTeamApplicationTracker.Data.ServiceTeamApplicationTrackerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tickets_Tracking Tickets { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tickets = await _context.Tickets.FirstOrDefaultAsync(m => m.ID == id);

            if (Tickets == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tickets = await _context.Tickets.FindAsync(id);

            if (Tickets != null)
            {
                _context.Tickets.Remove(Tickets);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
