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
    public class DetailsModel : PageModel
    {
        private readonly ServiceTeamApplicationTracker.Data.ServiceTeamApplicationTrackerContext _context;

        public DetailsModel(ServiceTeamApplicationTracker.Data.ServiceTeamApplicationTrackerContext context)
        {
            _context = context;
        }

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
    }
}
