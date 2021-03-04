using System;
namespace _09092020_Garage.Models
{
    public class Camion : Vehicule
    {
        #region Props
        public int NombresKm { get; set; }

        #endregion

        #region Méthodes

        public override double calculPrixHoraire()
        {
            double tarif;
            if (NombresKm < 200000)
            {
               tarif = 50;
            }
            else
            {
                tarif = 75;
            }
            return tarif;
        }

        #endregion
    }
}