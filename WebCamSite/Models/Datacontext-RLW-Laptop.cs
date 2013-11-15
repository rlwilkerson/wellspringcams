using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCamSite.Models
{
    public class Datacontext : DbContext
    {
            public Datacontext() : base("name=Datacontext")
            {
            }

            public DbSet<Image> Images { get; set; }
        }

    }
}