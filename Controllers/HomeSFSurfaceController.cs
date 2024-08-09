using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Website.Controllers;

namespace umb_htmx.Controllers
{
    //[ApiController]
    //[Route("/api/home")]
    public class HomeSFSurfaceController: SurfaceController
    {
        public HomeSFSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
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


        [IgnoreAntiforgeryToken]
        public IActionResult UpdateSection()
        {
            return PartialView("htmx/home/_UpdatedSection");
        }

        [HttpPost()]
        public IActionResult UpdateSection2()
        {
            return PartialView("htmx/home/_UpdatedSection");
        }
    }
}
