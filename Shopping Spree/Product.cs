using System;

namespace Shopping_Spree
{
    public class Product
    {
        private string name;
        public decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value== string.Empty||string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get { return this.cost; }
            private set { this.cost = value; }
        }

    }
}
