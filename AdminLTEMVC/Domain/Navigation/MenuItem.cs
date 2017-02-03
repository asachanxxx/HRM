using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Navigation
{
    //http://www.dotnetcurry.com/aspnet-mvc/811/dynamic-menus-aspnet-mvc-entity-framework-code-first-jquery
    public class Menu
    {

        public Menu()
        {
            MenuItemList = new List<MenuItems>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<MenuItems> MenuItemList { get; set; }

    }

    public class MenuItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string URL { get; set; }
        public Menu ParantMenu { get; set; }
    }
}
