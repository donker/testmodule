using DotNetNuke.Web.Api;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dnn.Test.ModulesTestModule.Components
{
    public class TestController : DnnApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public HttpResponseMessage Tabs()
        {
            var res = TestRepository.Instance.GetTabs();
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("TestModule", "Route1", "{controller}/{action}", null, null, new[] { "Dnn.Test.ModulesTestModule.Components" });
        }
    }
}