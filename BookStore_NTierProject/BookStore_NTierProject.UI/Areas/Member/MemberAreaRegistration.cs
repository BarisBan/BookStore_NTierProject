using System.Web.Mvc;

namespace BookStore_NTierProject.UI.Areas.Member
{
    public class MemberAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Member";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Member_default",
                "Member/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces:new[]{"BookStore_NTierProject.UI.Areas.Member.Controllers"} // multiple Home hatası alıyorum...
            );
        }
    }
}