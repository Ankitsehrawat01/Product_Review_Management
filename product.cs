using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class product
    {
        public int ProductID { get; set; }
        public int Userid { get; set; }
        public double rating { get; set; }
        public string Review { get; set; }
        public bool Islike { get; set; }
    }
}
