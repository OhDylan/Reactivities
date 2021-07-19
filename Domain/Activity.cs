using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Activity
    {
        // Entity framwork is going to recognize this to be the primary key when Activities table created
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
        public ICollection<AppUser> Attendees { get; set; }
    }
}
