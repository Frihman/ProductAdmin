using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdmin.Windows.UI
{
    public partial class Product
    {
        public override string ToString()
        {
            return $"{Name} ({Price}kr)";
        }
    }
}
