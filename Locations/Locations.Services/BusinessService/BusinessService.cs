namespace Locations.Services.BusinessService
{
    using System.Linq;
    using Locations.Models;
    using Locations.Services.Models;
    using Locations.Data;

    public class BusinessService : IBusinessService
    {
        public BusinessService()
        {
            this.Data = new LocationsContext();
        }

        public LocationsContext Data { get; set; }

        public Favorite AddFavorite(LocationBindingModel model)
        {
            var favorite = new Favorite
            {
                Name = model.Name
            };

            var location = this.Data.Locations
               .Where(l => l.Name == model.Name)
               .FirstOrDefault();
            location.HasFavorite = true;

            this.Data.Favorites.Add(favorite);
            this.Data.SaveChanges();

            return favorite;
        }

        public Location AddLocation(LocationBindingModel model)
        {
            var location = new Location
            {
                Name = model.Name,
                HasFavorite = false
            };

            this.Data.Locations.Add(location);
            this.Data.SaveChanges();

            return location;
        }

        public Location DeleteLocation(int id)
        {
            var location = this.Data.Locations.Find(id);

            if(location == null)
            {
                return null;
            }

            this.Data.Locations.Remove(location);
            this.Data.SaveChanges();

            return location;
        }

        public Location EditLocation(EditLocationBindingModel model)
        {
            var location = this.Data.Locations.Find(model.Id);

            if(location == null)
            {
                return null;
            }

            location.Name = model.Name;

            this.Data.SaveChanges();

            return location;
        }

        public IQueryable<Favorite> GetFavorites()
        {
            var favorites = this.Data.Favorites.AsQueryable();

            return favorites;
        }

        public IQueryable<Location> GetLocations()
        {
            var locations = this.Data.Locations.AsQueryable();

            return locations;
        }

        public Location SetFavorite(int id)
        {
            var location = this.Data.Locations.Find(id);

            if(location == null)
            {
                return null;
            }

            location.HasFavorite = true;

            this.Data.SaveChanges();

            return location;
        }
    }
}