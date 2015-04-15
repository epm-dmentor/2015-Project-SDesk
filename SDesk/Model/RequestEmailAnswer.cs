using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Sdesk.Model
{
    public class RequestEmailAnswer
    {
        public long MailId { get; set; }
        public long RequestId { get; set; }
        public long MailTemplateId { get; set; }
    }
}
