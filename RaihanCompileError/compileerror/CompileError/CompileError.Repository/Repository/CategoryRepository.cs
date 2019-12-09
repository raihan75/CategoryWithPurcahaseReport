using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CompileError.Model.Model;
using CompileError.DatabaseContext.DatabaseContext;


namespace CompileError.Repository.Repository
{
     public class CategoryRepository
    {
        ProjectDbContext _projectDbContext = new ProjectDbContext();
        public bool Add(Category category)
        {
            _projectDbContext.Categories.Add(category);

            return _projectDbContext.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            Category category = _projectDbContext.Categories.FirstOrDefault(c => c.Id == id);
            _projectDbContext.Categories.Remove(category);

            return _projectDbContext.SaveChanges() > 0;
        }
        public bool Update(Category category)
        {
            Category aCategory = _projectDbContext.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (aCategory != null)
            {
                aCategory.Code = category.Code;
                aCategory.Name = category.Name;

            }


            return _projectDbContext.SaveChanges() > 0;
        }
        public List<Category> GetAll()
        {

            return _projectDbContext.Categories.ToList();


        }
        public Category Search(int id)
        {
            return _projectDbContext.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
