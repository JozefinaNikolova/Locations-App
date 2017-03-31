namespace Locations.Data
{
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class LocationsContext : DbContext
    {
        public LocationsContext()
            : base("name=LocationsContext")
        {
            Database.SetInitializer
                (new MigrateDatabaseToLatestVersion<LocationsContext, Configuration>());
        }

        public virtual IDbSet<Location> Locations { get; set; }

        public virtual IDbSet<Favorite> Favorites { get; set; }
    }
}