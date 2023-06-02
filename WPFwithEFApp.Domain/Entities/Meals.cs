using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using WPFwithEFApp.Domain.Commons;

namespace WPFwithEFApp.Domain.Entities
{
    public class Meals :Auditable
    {
        public string Name { get; set; }
        public string Cost { get; set; }
    }
}
