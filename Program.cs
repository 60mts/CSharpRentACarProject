using rent_A_car.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime;

namespace rent_A_car
    {
    class Program
        {
        static void Main(string[] args)
            {
            Product product1 = new Product();
            product1.productId = 00001;
            product1.productName = "Ford Custom";
            product1.productDesription = "Son model ve geniş hacimli bir araçtır.";
            product1.productImage = "/images/product1.png";
            product1.unitInStock = 50;
            product1.productModelYears = 2021;
            product1.productPrice = 50.000;
           
            Product product2 = new Product();
            product2.productId = 00002;
            product2.productName = "Ford Kuga";
            product2.productDesription = "Aradığınız her özellik var.";
            product2.productImage = "/images/product2.png";
            product2.productPrice = 300.000;
            product2.unitInStock = 20;
            product2.productModelYears = 2010;

            Product product3 = new Product();
            product3.productId = 0003;
            product3.productName = "Renault Kangoo";
            product3.productDesription = "Güzel bir aile arabasi";
            product3.productImage = "/images/product3.png";
            product3.productPrice = 30.000;
            product3.unitInStock = 10;
            product3.productModelYears = 2001;

            List<Product> list = new List<Product>
                {
             
                };

            String []products= {product1.productName,product2.productName };
            Console.WriteLine(products[0].Trim());
            Console.ReadKey();

            }
        }
    }
