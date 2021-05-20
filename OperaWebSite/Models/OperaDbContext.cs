using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //agregar

namespace OperaWebSite.Models
{
    public class OperaDbContext:DbContext
    {
        DbSet<Opera> Operas { get; set; }
    }
}