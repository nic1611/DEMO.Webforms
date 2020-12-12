namespace DEMO.Webforms.Migrations
{
    using DEMO.Webforms.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DEMO.Webforms.DAL.BandContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DEMO.Webforms.DAL.BandContext context)
        {
            var bands = new List<Band>
            {
                new Band{BandName="Depeche Mode", Bio="A band from Basildon."},
                new Band{BandName="The Beatles", Bio="A band from Liverpool."}
            };
            bands.ForEach(e => context.Bands.AddOrUpdate(p => p.BandName, e));
            context.SaveChanges();
        }
    }
}
