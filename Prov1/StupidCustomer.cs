using System;

namespace Prov1
{
    public class StupidCustomer : Customer
    {

        public StupidCustomer()
        {
            customerKnowledge = (float)(generator.NextDouble() * 0.25);

        }
    }
}