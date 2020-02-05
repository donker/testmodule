using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Web.Mvc;

namespace Dnn.Test.ModulesTestModule.Controllers
{
    [DnnHandleError]
    public class ItemController : DnnController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
