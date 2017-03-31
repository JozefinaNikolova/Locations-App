namespace Locations.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LocationsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LocationsContext context)
        {
            if(!context.Locations.Any())
            {
                context.Locations.AddOrUpdate(
                  new Location { Name = "Abu Dhabi" },
                  new Location { Name = "Berlin" },
                  new Location { Name = "Bogota" },
                  new Location { Name = "Buenos Aires" },
                  new Location { Name = "Cairo" },
                  new Location { Name = "Chicago" },
                  new Location { Name = "Lima" },
                  new Location { Name = "London" },
                  new Location { Name = "Miami" },
                  new Location { Name = "Moscow" },
                  new Location { Name = "Mumbai" },
                  new Location { Name = "Paris" },
                  new Location { Name = "San Francisco" }
                );
            }
        }
    }
}
