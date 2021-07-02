using System;
using System.Collections.Generic;

namespace GP.Domain
{
    class Category : Concept
    {
        public int CategoryId  { get; set; }
        public string Name { get; set; }
        //Foreign Keys
        public ICollection<Product>  products { get; set; }
        //Override abstract method
        public override void GetDetails()
        {
            Console.WriteLine("Category ID : "+ CategoryId +" Category Name :" + Name);
        }
    }
}
