using System;

namespace LabJob5
{
    public class MissingProductException: Exception
    {
        public MissingProductException() : base("Product is over")
        {
            
        }
    }
}