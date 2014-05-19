using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcWithTDD.Models
{
   public interface IRepositry
    {

        IEnumerable<Product> GetProducts();

    }
}
