using Microsoft.AspNetCore.Antiforgery;
using angularAbp.Controllers;

namespace angularAbp.Web.Host.Controllers
{
    public class AntiForgeryController : angularAbpControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
