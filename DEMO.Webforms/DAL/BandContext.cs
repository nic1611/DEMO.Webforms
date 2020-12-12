using DEMO.Webforms.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DEMO.Webforms.DAL
{
    public class BandContext : DbContext
    {
        public BandContext() : base("BandContext")
        {
        }
        public DbSet<Band> Bands { get; set; }
    }
}