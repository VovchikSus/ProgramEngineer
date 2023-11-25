namespace LabJob5
{
    public class Stock
    {
        private int ProductCount { get; set; }

        public Stock(int productCount)
        {
            ProductCount = productCount;
        }
        
        

        public int WriteOfProduct(int requireProduct)
        {
            if (requireProduct>ProductCount)
            {
                ProductCount = 0;
                throw new MissingProductException();
            }
            else
            {
                ProductCount -= requireProduct;
            }

            return ProductCount;
        }

        public int GetProductCount()
        {
            return ProductCount;
        }
    }
}