using InventoryApp.Models;
using System;
using System.Collections.Generic;


namespace InventoryApp.Services
{
    public interface IProductService
    {
        Product AddProduct(string name, string description, decimal price, int quantity, Guid supplierId);
        Product UpdateProduct(Product updatedProduct);
        bool DeleteProduct(Guid productId);
        List<Product> GetAllProducts();
    }
}
