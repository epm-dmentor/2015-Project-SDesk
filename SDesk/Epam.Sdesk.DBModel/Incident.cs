using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Sdesk.DBModel
{
    public class Incident
    {
        public Guid Id { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Impact { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
    }
}
