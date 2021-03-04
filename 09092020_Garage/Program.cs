using System;
using _09092020_Garage.Models;

namespace _09092020_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Instaciation personne

            Personne p = new Personne();
            p.Nom = "Rodriguez";
            p.Prenom = "Belen";
            p.DateDeNaissance = new DateTime(1985, 02, 01);

            Console.WriteLine($"Nom: {p.Nom} - Prenom: {p.Prenom}, Date de Naissance: {p.DateDeNaissance}");

            //2.1 Lier vehicule avec la personne
            //Vehicule v = new Vehicule();  //-->une fois que la classe devienne abstraite on ne pourra pas l'instancier
            //v.Proprietaire = p;
            //v.Modele = "Citadine";
            //v.Immatriculation = "1234567";

            //2.2 Instancier une voiture et un camion et les lier avec la personne

            Voiture v = new Voiture() { Proprietaire = p, Modele = "Citadine", Immatriculation = "1234567", NombresDePlace = 4 };  //les deux, camion et voiture ont le meme propietaire
            Camion c = new Camion() { Proprietaire = p, Modele = "Unknown", Immatriculation = "7891234", NombresKm = 300000 }; //les deux, camion et voiture ont le meme propietaire

            v.Proprietaire = p;
            c.Proprietaire = p;

            Console.WriteLine($"La personne {v.Proprietaire.Prenom}, {v.Proprietaire.Nom} possede la voiture modele {v.Modele} avec immatriculation {v.Immatriculation} et nombre de places {v.NombresDePlace}");
            Console.WriteLine($"La personne {v.Proprietaire.Prenom}, {v.Proprietaire.Nom} possede le camion modele {c.Modele} avec immatriculation {c.Immatriculation} ave nombres de km {c.NombresKm}");

            //3. Instaciation reparation
            Reparation reparationRoue = new Reparation();
            reparationRoue.Intitulé = "Reparation roues";
            reparationRoue.Duree = 2;

            Reparation reparationEssuiGlass = new Reparation();
            reparationEssuiGlass.Intitulé = "Reparation essui glass";
            reparationEssuiGlass.Duree = 3;

            Reparation reparationPneus = new Reparation();
            reparationPneus.Intitulé = "Reparation Pneus";
            reparationPneus.Duree = 4;

            Reparation reparationRetroviseur = new Reparation();
            reparationRetroviseur.Intitulé = "Reparation Retroviseur ";
            reparationRetroviseur.Duree = 1;

            Reparation reparationCoffre = new Reparation();
            reparationCoffre.Intitulé = "Reparation Coffre";
            reparationCoffre.Duree = 1;

            Reparation reparationPeinture = new Reparation();
            reparationPeinture.Intitulé = "Reparation Peinture";
            reparationPeinture.Duree = 1;

            //4. Lier le vehicule (voiture ou camion) avec la facture

            Facture fVoiture = new Facture();  // Instantiation de la facture pour la voiture
            fVoiture.Vehicule = v;  //Lié avec la voiture

            Facture fCamion = new Facture();
            fCamion.Vehicule = c; //Lié avec le camion

            //5. Mettre tous les reparations d'un vehicule dans la facture

            fVoiture.Ajouter(reparationRoue);
            fVoiture.Ajouter(reparationEssuiGlass);
            fVoiture.Ajouter(reparationPneus);
            fVoiture.Ajouter(reparationRetroviseur);
            fVoiture.Ajouter(reparationPeinture);
            fVoiture.Ajouter(reparationCoffre);
            //fVoiture.AfficherTousReparations();
            //f.CalculerCoutTotal(v);  // on ne peut acceder directement a la méthode car est uen méthode privée.


            //6.Afficher la facture
            //f.AfficherFacture(v);

            Console.WriteLine(v.calculPrixHoraire());  //Affiche le prix horaire applique à la voiture
            Console.WriteLine(c.calculPrixHoraire());  //Afficher le prix horarie applique au camion

            //6.Afficher la facture
           fVoiture.AfficherFacture();
           fCamion.AfficherFacture();


        }
    }
}
