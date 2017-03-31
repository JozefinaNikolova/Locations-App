namespace Locations.Services.BusinessService
{
    using Locations.Models;
    using Models;
    using System.Linq;

    interface IBusinessService
    {
        IQueryable<Location> GetLocations();

        Location AddLocation(LocationBindingModel model);

        Location EditLocation(EditLocationBindingModel model);

        Location SetFavorite(int id);

        Location DeleteLocation(int id);

        IQueryable<Favorite> GetFavorites();

        Favorite AddFavorite(LocationBindingModel model);
    }
}
