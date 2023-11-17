using System;
using CS_Project.Entity;
namespace CS_Project.Manager
{
    public static class CommandeManager
    {
        public static void Create(Commande commande)
        {
            string query = $"INSERT INTO commande (idCommande,date,estPayee,estExpediee,idClient) VALUES ({commande.idCommande},{commande.date},{commande.estPayee},{commande.estExpediee},{commande.idClient})";
        }

        public static void Read(Commande commande)
        {
            string query = $"SELECT * FROM commande";
        }

        public static void Update(Commande commande)
        {

        }

        public static void Delete(Commande commande)
        {

        }
    }
}