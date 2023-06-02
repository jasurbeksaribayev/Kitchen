using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFwithEFApp.Domain.Commons
{
    public class Auditable
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string ImagePath { get; set; }

    }
}
