using rent_A_car.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_A_car.Entities.Concrete
    {
    public class Product:IEntity
        {
        public int productId { get; set; }

        public string productName { get; set; }

        public string productDesription { get; set; }

        public int unitInStock { get; set; }

        public string productImage { get; set; }

        public double productPrice { get; set; }

        public int productModelYears { get; set; }

        }
    }
