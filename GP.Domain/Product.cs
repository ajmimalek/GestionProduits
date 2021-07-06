using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Domain
{
    public class Product : Concept
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime DateProd { get; set; }
        //Foreign Keys
        public Category category { get; set; }
        public int CategoryFK { get; set; }
        public ICollection<Provider> providers { get; set; }
        //Override abstract method
        public override void GetDetails()
        {
            Console.WriteLine($"{nameof(ProductId)}={ProductId.ToString()}, {nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}, {nameof(Quantity)}={Quantity.ToString()}, {nameof(Description)}={Description}," +
                $" {nameof(DateProd)}={DateProd.ToString()}");
        }
        #region Partie 4 : Polymorphisme
        public virtual void GetMyType()
        {
            Console.WriteLine("UNKNOWN");
        }
        #endregion
    }
}
