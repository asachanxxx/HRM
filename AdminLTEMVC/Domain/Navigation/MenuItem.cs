using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Navigation
{
    public class MenuItem
    {
        public int id { get; set; }
        public string  Title { get; set; }
        public string Url { get; set; }
        public bool  hasSubitems { get; set; }
        public IEnumerable<MenuItem> SubMenuItems { get; set; }
        public string Section { get; set; }
        public bool isparant { get; set; }
      
    }
}
