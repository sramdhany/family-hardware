using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2.CustomTypes
{
    public class Product
    {
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int QuantityOnHand { get; set; }
        public byte[] ProductImage { get; set; }
        public Product()
        {
            ProductDescription = "";
            ProductName = "";
            ProductPrice = 0;
            QuantityOnHand = 0;
            ProductImage = null;
        }
    }
}