using System.Web;
using System.Web.Mvc;

namespace New_Lab2_IT2030
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
