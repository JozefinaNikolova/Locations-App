namespace Locations.Services.Controllers
{
    using Locations.Models;
    using Models;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;
    
    [EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*")]
    public class LocationsController : BaseApiController
    {
        [HttpGet]
        [Queryable]
        public IQueryable<Location> GetLocations()
        {
            var locations = this.BusinessService.GetLocations();

            return locations;
        }

        [HttpPost]
        public IHttpActionResult AddLocation(LocationBindingModel model)
        {
            if (model == null)
            {
                return this.BadRequest("Missing data.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var location = this.BusinessService.AddLocation(model);

            return this.Ok(location);
        }

        [HttpPut]
        public IHttpActionResult EditLocation(EditLocationBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("Invalid data.");
            }

            var location = this.BusinessService.EditLocation(model);

            if (location == null)
            {
                return this.BadRequest("No location with such ID.");
            }

            return this.Ok(location);
        }
        
        public IHttpActionResult SetFavorite(int id)
        {
            var location = this.BusinessService.SetFavorite(id);

            if (location == null)
            {
                return this.BadRequest("No location with such ID.");
            }

            return this.Ok(location);
        }

        [HttpDelete]
        public IHttpActionResult DeleteLocation(int id)
        {
            var location = this.BusinessService.DeleteLocation(id);

            if (location == null)
            {
                return this.BadRequest("No location with such ID.");
            }

            return this.Ok(location);
        }
    }
}
