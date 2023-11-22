using System;

namespace LabJob5
{
    public class Stock
    {
        private int ProductCount { get; set; }
        
        

        public int WriteOfProduct(int requireProduct)
        {
            if (requireProduct>ProductCount)
            {
                throw new MissingProductException();
                ProductCount = 0;
            }
            else
            {
                ProductCount -= requireProduct;
            }

            return ProductCount;
        }
    }
}