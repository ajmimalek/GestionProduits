using System;
using GP.Domain;

namespace GP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Partie 1 : Diagramme de classes
            Product product = new Product()
            {
                ProductId = 1,
                Name = "Batata",
                Description = "tetgarmech",
                Price = 0.2,
                Quantity = 10,
                DateProd = DateTime.Now
            };
            product.GetDetails();
            #endregion
            #region Partie 2 : Type valeur / Type référence
            Provider P1 = new Provider()
            {
                Id = 1,
                UserName = "ajmimalek",
                Password = "malek123",
                ConfirmPassword = "malek",
                IsApproved = true
            };
            //Testing B Method
            Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
            System.Console.WriteLine("B Method with passsword : " + P1.Password + " and confirmation : " + P1.ConfirmPassword + " is " + P1.IsApproved);
            //Testing A Method
            Provider.SetIsApproved(P1);
            System.Console.WriteLine("A Method with passsword : " + P1.Password + " and confirmation : " + P1.ConfirmPassword + " is " + P1.IsApproved);
            System.Console.WriteLine("We must here pass the object as parameter to change the values");
            #endregion

        }
    }
}
