using MAUIdemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIdemo.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProduct();
    }
}
