using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TSystems.MMS.Bewerbungsgenerator.Models
{
    public class TSystemsMMSBewerbungsgeneratorContext : DbContext
    {
        public TSystemsMMSBewerbungsgeneratorContext (DbContextOptions<TSystemsMMSBewerbungsgeneratorContext> options)
            : base(options)
        {
        }

        public DbSet<TSystems.MMS.Bewerbungsgenerator.Models.Form> Form { get; set; }
    }
}
