using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Domain
{
    public class Chemical : Product
    {
        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAdress { get; set; }
        #region Partie 4 : Polymorphisme
        public override void GetMyType()
        {
            Console.WriteLine("CHEMICAL");
        }
        #endregion
    }
}
 