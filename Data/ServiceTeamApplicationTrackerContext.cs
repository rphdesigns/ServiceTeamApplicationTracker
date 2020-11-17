using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceTeamApplicationTracker.Models;

namespace ServiceTeamApplicationTracker.Data
{
    public class ServiceTeamApplicationTrackerContext : DbContext
    {
        public ServiceTeamApplicationTrackerContext (DbContextOptions<ServiceTeamApplicationTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<ServiceTeamApplicationTracker.Models.Tickets_Tracking> Tickets { get; set; }
    }
}
