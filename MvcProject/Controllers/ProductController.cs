using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcProject.Controllers
{
    public class ProductController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };


        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }


    public class Product
    {
        private int id;
        private string name;
        private string category;
        private decimal price;


        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Name

        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }

}
