using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceTeamApplicationTracker.Data;
using ServiceTeamApplicationTracker.Models;

namespace ServiceTeamApplicationTracker.Pages.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly ServiceTeamApplicationTracker.Data.ServiceTeamApplicationTrackerContext _context;

        public IndexModel(ServiceTeamApplicationTracker.Data.ServiceTeamApplicationTrackerContext context)
        {
            _context = context;
        }

        public IList<Tickets_Tracking> Tickets { get;set; }
        [BindProperty(SupportsGet = true)]
        // Text that user enters in search box
        public string SearchString { get; set; }
        public SelectList Applications { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Ticket_Application { get; set; }
        public async Task OnGetAsync()
        {
            var tickets = from t in _context.Tickets
                          select t;
            if (!string.IsNullOrEmpty(SearchString))
            {
                tickets = tickets.Where(s => s.Application.Contains(SearchString));
            }

            Tickets = await _context.Tickets.ToListAsync();
        }
    }
}
