using System;
using System.Collections.Generic;

namespace GP.Domain
{
    class Provider : Concept
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateCreated  { get; set; }
        //Foreign Keys
        public ICollection<Product> products { get; set; }
        //Override abstract method
        public override void GetDetails()
        {
            Console.WriteLine("ID : "+ Id +" UserName : "+ UserName+" Password : "+Password+" Confirm Password : "+ConfirmPassword+" Email : "+Email+" IsApproved : "+IsApproved+" DateCreated : "+DateCreated);
        }
    }
}
