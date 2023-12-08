using System;
using System.Collections.ObjectModel;
using CS_Project.Entity;
using CS_Project.Service;
using MySql.Data.MySqlClient;

namespace CS_Project.Manager
{

    public static class LigneCommandeManager
    {
        public static void Create(LigneCommande ligneCommande)
        {
            string query = "INSERT INTO ligneCommande (idProduit,idCommande,quantite) VALUES (@idProduit,@idCommande,@quantite)";

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand createLigneCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            createLigneCommande.Parameters.AddWithValue("@idProduit", ligneCommande.idProduit);
            createLigneCommande.Parameters.AddWithValue("@idCommande", ligneCommande.idCommande);
            createLigneCommande.Parameters.AddWithValue("@quantite", ligneCommande.quantite);

            createLigneCommande.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }

        public static Collection<LigneCommande> ReadAllCommandeByOne(int idCommande)
        {
            string query = "SELECT * FROM lignecommande WHERE commande = @idCommande"; // Commande SQL "SELECT"
            Collection<LigneCommande> commandeCollection = new Collection<LigneCommande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand requestCommand = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            requestCommand.Parameters.AddWithValue("@idCommande", idCommande);
            MySqlDataReader reader = requestCommand.ExecuteReader(); // Création du reader qui va lire la table commande
            try
            {
                while (reader.Read())
                {
                    LigneCommande ligneCommande = new LigneCommande(); // Création de commande

                    ligneCommande.idProduit = reader.GetInt32(0);
                    ligneCommande.idCommande = reader.GetInt32(1);
                    ligneCommande.quantite = reader.GetInt32(2);
                    Console.WriteLine(reader.GetInt32(1));

                    commandeCollection.Add(ligneCommande); // Ajout de la commande à la liste
                }
            }
            catch (Exception) { }
            finally
            {
                DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            }
            return commandeCollection; // Retour de la collection
        }

        public static Collection<LigneCommande> ReadAllLigneCommande()
        {
            string query = "SELECT * FROM ligneCommande"; // Commande SQL "SELECT"

            Collection<LigneCommande> ligneCommandeCollection = new Collection<LigneCommande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand requestCommand = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            MySqlDataReader reader = requestCommand.ExecuteReader(); // Création du reader qui va lire la table commande
            try
            {
                while (reader.Read())
                {
                    LigneCommande ligneCommande = new LigneCommande(); // Création de commande

                    ligneCommande.idProduit = reader.GetInt32(0);
                    ligneCommande.idCommande = reader.GetInt32(1);
                    ligneCommande.quantite = reader.GetInt32(2);

                    ligneCommandeCollection.Add(ligneCommande); // Ajout de la commande à la liste
                }
            }
            catch (Exception) { }
            finally
            {
                DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            }
            return ligneCommandeCollection; // Retour de la collection
        }


        public static void Update(LigneCommande ligneCommande)
        {
            string query = "UPDATE ligneCommande SET (idProduit,estPayee,estExpediee) VALUES (@idProduit,@estPayee,@estExpediee) FROM WHERE idCommande = @idCommande"; // Création de la commande "UPDATE"

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand updateLigneCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "UPDATE" et l'objet GetConnexion
            updateLigneCommande.Parameters.AddWithValue("@idProduit", ligneCommande.idProduit); // Paramètre de la commande préparée
            updateLigneCommande.Parameters.AddWithValue("@idCommande", ligneCommande.idCommande);
            updateLigneCommande.Parameters.AddWithValue("@quantite", ligneCommande.quantite);

            updateLigneCommande.Parameters.AddWithValue("@idCommande", ligneCommande.idCommande);

            updateLigneCommande.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }


        public static void Delete(LigneCommande ligneCommande)
        {
            string query = "DELETE FROM ligneCommande WHERE idCommande = @idCommande";

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand deleteLigneCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "DELETE" et l'objet GetConnexion
            deleteLigneCommande.Parameters.AddWithValue("@idCommande", ligneCommande.idCommande); // Paramètre de la commande préparée

            deleteLigneCommande.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }
    }
}