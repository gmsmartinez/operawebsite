using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //entityframework


namespace OperaWebSite.Models
{
    public class OperaInitializer: DropCreateDatabaseAlways<OperaDbContext>
    {
        protected override void Seed(OperaDbContext context)
        {
            var operas = new List<Opera>()
            {
                 new Opera(){ Title="Cosi fan tuttle", Year=1790,
            };

        }
        
     

           
        
    }
}