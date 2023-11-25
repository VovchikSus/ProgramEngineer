using System;

namespace LabJob5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stock tomatoStock = new Stock(100);
            try
            {
                tomatoStock.WriteOfProduct(10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(tomatoStock.GetProductCount());
            }
        }
    }
}