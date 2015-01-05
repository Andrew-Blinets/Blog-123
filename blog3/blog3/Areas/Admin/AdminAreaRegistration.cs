using System.Web.Mvc;

namespace blog3.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        private static readonly string[] Namespaces = new[] { "blog3.Areas.Admin.Controllers" };
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                , Namespaces
                );
        }
    }
}
