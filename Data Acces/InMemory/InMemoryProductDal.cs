using rent_A_car.Data_Acces.Abstract;
using rent_A_car.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_A_car.Data_Acces.InMemory
    {
    public class InMemoryProductDal : IProductDal
        {
        List<Product> _products;

        public InMemoryProductDal()
            {
            _products = new List<Product> {
                new Product{productId=1, productName="Bardak",productPrice=15},

                new Product{productId=2, productName="Çardak",productPrice=18},

                new Product{productId=3, productName="Tabak",productPrice=20},

                new Product{productId=1, productName="Bardak",productPrice=35}
                };
            }

        public void Add(Product product)
            {
            _products.Add(product);         
            }

        public void Delete(Product product)
            {
            Product productToDelete;

            foreach (var p in _products)
                {
                if (p.productId==p.productId)
                    {

                    productToDelete = p;

                    }
                }
            }

        public List<Product> GetAll()
            {
            throw new NotImplementedException();
            }

        public List<Product> GetAllByCategory(int categoryId)
            {
            throw new NotImplementedException();
            }

        public void Update(Product product)
            {
  
            }
        }
    }
