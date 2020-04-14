using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPCoreLearning.Controllers;

namespace ABPCoreLearning.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPCoreLearningControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
