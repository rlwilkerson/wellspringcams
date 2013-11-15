using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebCamSite.Models
{
    public class Datacontext: DbContext
    {
        public Datacontext() : base("name=Datacontext")
        {
        }
   
   
        public DbSet<ImageFile> Images { get; set; }
    }
}