using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Repository;

namespace SmallBusinessManagementSystem.Manager
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool Save(CategoryModel categoryModel)
        {
            return _categoryRepository.Save(categoryModel);
        }

        public bool IsExists(CategoryModel categoryModel)
        {
            return _categoryRepository.IsExists(categoryModel);
        }

        public List<CategoryModel> ShowAll()
        {
            return _categoryRepository.ShowAll();
        }

        public DataTable SearchCategory(CategoryModel categoryModel)
        {
            return _categoryRepository.SearchCategory(categoryModel);
        }

        public bool UpdateCategory(CategoryModel categoryModel)
        {
            return _categoryRepository.UpdateCategory(categoryModel);
        }
    }
}
