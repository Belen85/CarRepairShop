using System;
namespace _09092020_Garage.Models
{
    public class Personne


    {

        #region Champs
        private DateTime _dateDeNaissance;
        #endregion

        #region  Props
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateDeNaissance  //Comme datetime est une structure est obligé de avoir une valeur derriere donc par defaut ça va etre toujours 01-01-0001.  Pour avoir recupere un null on doit mettre derriere DateTime?
        {
            get { return _dateDeNaissance; }
            set
            {
                if (value < DateTime.Now)
                {
                    _dateDeNaissance = value;
                }
                
            }

        }

        #endregion
    }
}
