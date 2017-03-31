namespace Locations.Services.Controllers
{
    using Locations.Services.BusinessService;
    using System.Web.Http;
    using System.Web.Http.Cors;

    [EnableCors(origins: "http://localhost:63342/", headers: "*", methods: "*")]
    public class BaseApiController : ApiController
    {
        public BaseApiController()
            : this(new BusinessService())
        {
        }

        public BaseApiController(BusinessService businessService)
        {
            this.BusinessService = businessService;
        }

        protected BusinessService BusinessService { get; set; }
    }
}