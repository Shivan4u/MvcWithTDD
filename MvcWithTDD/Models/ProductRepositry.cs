using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcWithTDD.Models;

namespace MvcWithTDD.Models
{
  public  class ProductRepositry : IRepositry
    {
        public IEnumerable<Product> GetProducts()
        {
            return null;
        }
    }
}
