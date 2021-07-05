using System;
using System.Collections.Generic;

namespace GP.Domain
{
    public class Provider : Concept
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        #region Partie 3 : Encapsulation
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 5 && value.Length > 20)
                {
                    Console.WriteLine("Votre mot de passe doit contenir entre 5 et 20 caractéres");
                }
                else
                {
                    password = value;
                }
            }
        }
        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (value.Equals(Password))
                {
                    confirmPassword = value;
                }
                else
                {
                    Console.WriteLine("Les deux mdp sont pas identiques");
                }
            }
        }
        #endregion
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        #region Partie 2 : Type valeur / Type référence
        //mettre à jour l’attribut IsApproved de l’objet P passé en paramètre
        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = P.Password.Equals(P.ConfirmPassword);
        }
        //modifier le paramètre isApproved en fonction de l’égalité entre les deux autres paramètres.
        public static void SetIsApproved(string password, string confirmPassword, bool isApproved)
        {
            isApproved = password.Equals(confirmPassword);
        }
        #endregion
        public DateTime DateCreated { get; set; }
        //Foreign Keys
        public ICollection<Product> products { get; set; }
        //Override abstract method
        public override void GetDetails()
        {
            Console.WriteLine("ID : " + Id + " UserName : " + UserName + " Password : " + Password + " Confirm Password : " + ConfirmPassword + " Email : " + Email + " IsApproved : " + IsApproved + " DateCreated : " + DateCreated);
        }
        #region Partie 4 : Polymorphisme
        bool Login(string username, string pwd)
        {
            if (username.Equals(this.UserName) && pwd.Equals(this.Password))
            {
                return true;
            }
            return false;
        }
        /* En commentaire : meme nom et meme attributs
        bool Login(string username, string pwd, string email)
        {
            if (username.Equals(this.UserName) && pwd.Equals(this.Password) && email.Equals(this.Email))
            {
                return true;
            }
            return false;
        } */
        //Méthode qui va remplacer les 2 méthodes : Paramétre email optionnel
        bool Login(string username, string pwd, string email=null)
        {
            
        }
        #endregion
    }
}
