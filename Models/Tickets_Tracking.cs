using System;
using System.ComponentModel.DataAnnotations;


namespace ServiceTeamApplicationTracker.Models
{
    public class Tickets_Tracking
    {
        public int ID { get; set; }
        [Display(Name ="Incident Owner")]
        public string IncidentOwner { get; set; }
        public string Application { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Open Date")]
        public Nullable<DateTime> OpenDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Closed Date")]
        public Nullable<DateTime> ClosedDate { get; set; }

        [Display(Name = "Point of Contact")]
        public string Point_of_Contact { get; set; }
        [Display(Name = "External Ticket #")]
        public string External_Ticket_Number { get; set; }
        [Display(Name = "Category")]
        public string Ticket_Cat { get; set; }
        [Display(Name = "Description")]
        public string Ticket_Description { get; set; }
        [Display(Name = "Resolution Type")]
        public string Resolution_Type { get; set; }
        [Display(Name = "Resolution SubType")]
        public string Resolution_SubType { get; set; }
        [Display(Name = "Resolution Description")]
        public string Resolution_Description { get; set; }
        [Display(Name = "Work Notes")]
        public string Work_Notes { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Last Updated")]
        public Nullable<DateTime> Last_UpdateDate { get; set; }
        [Display(Name = "Agent")]
        public string AgentName { get; set; }
        

    }
}
