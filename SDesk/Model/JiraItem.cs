using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Sdesk.Model
{
    public class JiraItem
    {
        public long JiraItemId   { get; set; }   //(our internal)
        public int JiraSourceId { get; set; }
        public long RequestIdType { get; set; }
        public long JiraNumber { get; set; } 

    }
}
