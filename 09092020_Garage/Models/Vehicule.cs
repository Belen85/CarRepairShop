using System;
namespace _09092020_Garage.Models
{
    public abstract class Vehicule
    {
        #region Champs

        private string _immatriculation;

        #endregion


        #region Props
        public Personne Proprietaire { get; set; }
        public string Modele { get; set; }
        public string Immatriculation
        {
            get { return _immatriculation; }
            set
            {
                if (value.Length == 7)
                {
                    _immatriculation = value;
                }


            }

        }

        #endregion

        #region Méthodes

        public abstract double calculPrixHoraire();
       

        #endregion
    }
}
