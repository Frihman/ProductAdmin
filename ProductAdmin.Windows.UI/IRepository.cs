using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdmin.Windows.UI
{
    interface IRepository
    {
        void Add(Product product);

        List<Product> GetProducts();
    }
}
