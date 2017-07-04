using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products= new List<Product>();
        }
        public string Name
        {
            get
            {
                { return this.name; }
            }
            private set
            {
                if (value == string.Empty || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void AddProductToBag(Product product)
        {
            this.products.Add(product);
        }

        public List<Product> SeeBag()
        {
            return this.products;
        }
    }
}
