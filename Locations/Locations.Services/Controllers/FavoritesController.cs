namespace Locations.Services.Controllers
{
    using Locations.Models;
    using Models;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;


    [EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*")]
    public class FavoritesController : BaseApiController
    {

        [HttpGet]
        public IHttpActionResult GetFavorites()
        {
            var favorites = this.BusinessService.GetFavorites();

            return this.Ok(favorites);
        }

        [HttpPost]
        public IHttpActionResult AddFavorite(LocationBindingModel model)
        {
            if (model == null)
            {
                return this.BadRequest("Missing data.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var favorite = this.BusinessService.AddFavorite(model);         

            return this.Ok(favorite);
        }
    }
}