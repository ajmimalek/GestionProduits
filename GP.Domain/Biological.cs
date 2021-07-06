using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Domain
{
    public class Biological : Product
    {
        public string Herbs { get; set; }
        #region Partie 4 : Polymorphisme
        public override void GetMyType()
        {
            Console.WriteLine("BIOLOGICAL");

        }
        #endregion
    }
}
