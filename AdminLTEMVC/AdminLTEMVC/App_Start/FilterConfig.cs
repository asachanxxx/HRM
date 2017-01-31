using System.Web;
using System.Web.Mvc;
using AdminLTEMVC.Filters;

namespace AdminLTEMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalActionFilters());
            filters.Add(new LogFilter());
            
        }
    }
}
