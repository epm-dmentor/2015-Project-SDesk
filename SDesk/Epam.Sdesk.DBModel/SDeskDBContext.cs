using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Epam.Sdesk.DBModel
{
    public class SDeskDbContext : DbContext
    {
        DbSet<Incident> Incidents { get; set; }
    }
}
