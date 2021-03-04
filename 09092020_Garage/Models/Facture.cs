using System;
using System.Collections.Generic;
using System.Linq;

namespace _09092020_Garage.Models
{
    public class Facture


    {
        #region Champs



        #endregion

        #region Props

        public Vehicule Vehicule { get; set; }

        public List<Reparation> Reparations { get; set; } = new List<Reparation>();



        #endregion
        #region Méthodes

        //Ajouter les differents reparations a la facture

        public void Ajouter(Reparation r)
        {
            Reparations.Add(r);
        }

        public void AfficherTousReparations()

        {
            foreach (var reparation in Reparations)
            {

                Console.WriteLine($"Type reparation: {reparation.Intitulé} - Duree estimé: {reparation.Duree}");

            }
        }

        private double CalculerCoutTotal()

        {

            //double coutTotal = 0;
            double dureeTotal = 0;
            double coutTotal = 0;

            //foreach (var reparation in Reparations)
            //{
            //    //double total = Reparations.Sum(reparation.Duree);

            //    double dure = reparation.Duree;
            //    dureeTotal = dureeTotal + dure;

            //    coutTotal = dureeTotal * Vehicule.calculPrixHoraire();

            //    if (Reparations.Count > 5)
            //    {
            //        coutTotal = (dureeTotal * Vehicule.calculPrixHoraire()) - ((dureeTotal * Vehicule.calculPrixHoraire()) * 0.10);
            //    }
            //    else
            //    {
            //        coutTotal = dureeTotal * Vehicule.calculPrixHoraire();
            //    }


            //Autre maniere de le faire sans foreach


            for (int i = 0; i < Reparations.Count; i++)
            {

                double duree = Reparations[i].Duree;
                dureeTotal += duree;
                coutTotal = dureeTotal * Vehicule.calculPrixHoraire(); ;

            }
            if (Reparations.Count > 5)
            {
                coutTotal = (dureeTotal * Vehicule.calculPrixHoraire()) - ((dureeTotal * Vehicule.calculPrixHoraire()) * 0.10);
            }
            else
            {
                coutTotal = dureeTotal * Vehicule.calculPrixHoraire();
            }


            return coutTotal;
        }
           
           
        

        public void AfficherFacture()
        {
            //On affichera ensuite la facture qui contiendra les infos du proprio, du véhicule, la liste des réparations et le coût total

            Console.WriteLine($"------FACTURE--------");

            if (Vehicule is Voiture)
            {
                Console.WriteLine($"Propietaire du vehicule: {Vehicule.Proprietaire.Prenom}, {Vehicule.Proprietaire.Nom}.\nVehicule: {Vehicule.Immatriculation} Modele: {Vehicule.Modele}.\nNombre de places: {((Voiture)Vehicule).NombresDePlace}");
            }
            else
            {
                Console.WriteLine($"Propietaire du vehicule: {Vehicule.Proprietaire.Prenom}, {Vehicule.Proprietaire.Nom}.\nVehicule: {Vehicule.Immatriculation} Modele: {Vehicule.Modele}.\nNombre de places: {((Camion)Vehicule).NombresKm}");
            }
            AfficherTousReparations();
            Console.WriteLine($"Le prix total a payer est {CalculerCoutTotal()} Euros"); 
        }

        }

        #endregion

    }

