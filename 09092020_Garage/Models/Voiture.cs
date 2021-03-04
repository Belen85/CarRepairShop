using System;
namespace _09092020_Garage.Models
{
    public class Voiture : Vehicule
    {
        #region Props
        public int NombresDePlace { get; set; }
        #endregion

        #region Méthodes

        public override double calculPrixHoraire()
        {
            double tarif;
            tarif = (double)NombresDePlace * 10;
            return tarif;
        }

        #endregion
    }
}
