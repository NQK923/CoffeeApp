using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ProductBLL
    {
        private ProductDAL ProductDAL = new ProductDAL();
        public List<ProductDTO> GetProducts()
        {
            return ProductDAL.GetProducts();
        }
        public void UpdateDrink(ProductDTO product)
        {
            ProductDAL.UpdateDrink(product);
        }

        public ProductDTO GetProductByName(string productName)
        {
            return ProductDAL.GetProductByName(productName);
        }

        public ProductDTO GetProductById(string productId)
        {
            return ProductDAL.GetProductById(productId);
        }

        public void UpdateProduct(ProductDTO product)
        {
            ProductDAL.UpdateProduct(product);
        }

        public int GetDrinkID(String drinkName)
        {
            return ProductDAL.GetDrinkID(drinkName);

        }
    }
}