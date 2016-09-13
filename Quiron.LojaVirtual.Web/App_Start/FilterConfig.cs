using Quiron.LojaVirtual.Web.Infrastructure;

namespace Quiron.LojaVirtual.Web.App_Start
{
    public class FilterConfig
    {
        public static void Configure(System.Web.Mvc.GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
