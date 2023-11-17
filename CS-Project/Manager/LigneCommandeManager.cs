using System;

namespace CS_Project.Manager
{

    public static class LigneCommandeManager
    {
        public static void Create(LigneCommande lignecommande)
        {
            string query = $"INSERT INTO lignecommande (idProduit,idCommande,quantite) VALUES ({lignecommande.idProduit},{lignecommande.idCommande},{lignecommande.quantite})";
        }

        public static void Read(LigneCommande lignecommande)
        {
            string query = $"SELECT * FROM lignecommande";
        }

        public static void Update(LigneCommande lignecommande)
        {

        }

        public static void Delete(LigneCommande lignecommande)
        {

        }
    }
}