using System.Web;
using System.Web.Mvc;

namespace AzureFagmoot_GITHUB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
