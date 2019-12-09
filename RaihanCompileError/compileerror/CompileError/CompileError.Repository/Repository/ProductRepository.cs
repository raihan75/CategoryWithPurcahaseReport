using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;
using CompileError.DatabaseContext.DatabaseContext;

namespace CompileError.Repository.Repository
{
    public class ProductRepository
    {
        private readonly ProjectDbContext _projectDbContext = new ProjectDbContext();
        public bool Add(ProductModel productModel)
        {
            _projectDbContext.Products.Add(productModel);
            return _projectDbContext.SaveChanges() > 0;
        }
    }
}
