using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.UmbracoContext;
using Umbraco.Cms.Web.Website.Controllers;

namespace umb_htmx.Controllers
{
    [ApiController]
    [Route("/htmx-views/home")]
    public class HomeSFViewController: Controller
    {

        public HomeSFViewController(IUmbracoContextAccessor umbracoContextAccessor)
        {
                
        }
        //public HomeSFController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        //{
        //}

        //public HomeController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor)
        // : base(logger, compositeViewEngine, umbracoContextAccessor)
        //{
        //}

        //public override IActionResult Index()
        //{
        //    return CurrentTemplate(CurrentPage);
        //}


        [HttpGet("updatesection")]
        public IActionResult UpdateSection()
        {
            // get CurrentPage from umbraco context
            //UmbracoContext.Current?.Page;


            return PartialView("htmx/home/_UpdatedSection");
        }

        [HttpPost()]
        public IActionResult UpdateSection2()
        {
            return PartialView("/home/_UpdatedSection");
        }
    }
}
