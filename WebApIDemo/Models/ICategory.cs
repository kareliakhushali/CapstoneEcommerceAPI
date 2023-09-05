using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApIDemo.Models
{
   public interface ICategory
    {
        public Category GetCategoryById(int id);
        public IEnumerable<Category> GetAllCategory();
        public bool AddCategory(Category c);
        public bool UpdateCategory(Category c);
        public bool Delete(int id);
        public bool CheckUpdateUnique(string name, int id);
        public bool CheckInsertUnique(string name, int id);
    }
}
