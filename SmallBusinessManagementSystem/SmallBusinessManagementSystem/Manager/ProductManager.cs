using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using SmallBusinessManagementSystem.Repository;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();

        public DataTable LoadCategory(ProductModel productModel)
        {
            return _productRepository.LoadCategory(productModel);
        }

        public bool Save(ProductModel productModel)
        {
            return _productRepository.Save(productModel);
        }

        public bool IsExists(ProductModel productModel)
        {
            return _productRepository.IsExists(productModel);
        }

        public List<ProductModel> ShowAll()
        {
            return _productRepository.ShowAll();
        }

        public bool UpdateProduct(ProductModel productModel)
        {
            return _productRepository.UpdateProduct(productModel);
        }

        public DataTable SearchProduct(ProductModel productModel)
        {
            return _productRepository.SearchProduct(productModel);
        }
    }
}
