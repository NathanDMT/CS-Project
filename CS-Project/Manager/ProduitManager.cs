using System;
using System.Collections.ObjectModel;
using CS_Project.Entity;
using CS_Project.Service;
using MySql.Data.MySqlClient;

namespace CS_Project.Manager
{
    public static class ProduitManager
    {
        public static void Create(Produit produit)
        {
            string query = "INSERT INTO produit (idProduit,designation,description,dateAjout,quantite,prix,fichierImage,pk_fournisseur) VALUES (@idProduit,@designation,@description,@dateAjout,@qte,@prix,@fichierImage,@pk_fournisseur)";
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand createProduit = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            createProduit.Parameters.AddWithValue("@idProduit", produit.idProduit);
            createProduit.Parameters.AddWithValue("@idCommande", produit.designation);
            createProduit.Parameters.AddWithValue("@quantite", produit.description);
            createProduit.Parameters.AddWithValue("@quantite", produit.dateAjout);
            createProduit.Parameters.AddWithValue("@quantite", produit.qte);
            createProduit.Parameters.AddWithValue("@quantite", produit.prix);
            createProduit.Parameters.AddWithValue("@quantite", produit.fichierImage);
            createProduit.Parameters.AddWithValue("@quantite", produit.pk_fournisseur);

            createProduit.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }

        public static void Read(Produit produit)
        {
            string query = "SELECT * FROM produit";
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand readCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }

        public static Collection<Produit> ReadAllProduit()
        {
            string query = "SELECT * FROM produit"; // Commande SQL "SELECT"
            Collection<Produit> produitCollection = new Collection<Produit>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand requestCommand = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            MySqlDataReader reader = requestCommand.ExecuteReader(); // Création du reader qui va lire la table commande
            try
            {
                while (reader.Read())
                {
                    Produit produit = new Produit(); // Création de commande

                    produit.idProduit = reader.GetInt32(0);
                    produit.designation = reader.GetString(1);
                    produit.description = reader.GetString(2);
                    produit.dateAjout = reader.GetDateTime(3);
                    produit.qte = reader.GetInt32(4);
                    produit.prix = reader.GetString(5);
                    produit.fichierImage = reader.GetString(6);
                    produit.pk_fournisseur = reader.GetString(7);

                    produitCollection.Add(produit); // Ajout de la commande à la liste
                }
            }
            catch (Exception) { }
            finally
            {
                DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            }
            return produitCollection; // Retour de la collection
        }

        public static void Update(Produit produit)
        {
            string query = "UPDATE produit SET (idProduit,designation,description,dateAjout,quantite,prix,fichierImage,pk_fournisseur) VALUES (@idProduit,@designation,@description,@dateAjout,@qte,@prix,@fichierImage,@pk_fournisseur) FROM WHERE idProduit = @idProduit"; // Création de la commande "UPDATE"


            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand updateProduit = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "UPDATE" et l'objet GetConnexion
            updateProduit.Parameters.AddWithValue("@idProduit", produit.idProduit);
            updateProduit.Parameters.AddWithValue("@idCommande", produit.designation);
            updateProduit.Parameters.AddWithValue("@description", produit.description);
            updateProduit.Parameters.AddWithValue("@dateAjout", produit.dateAjout);
            updateProduit.Parameters.AddWithValue("@qte", produit.qte);
            updateProduit.Parameters.AddWithValue("@prix", produit.prix);
            updateProduit.Parameters.AddWithValue("@fichierImage", produit.fichierImage);
            updateProduit.Parameters.AddWithValue("@pk_fournisseur", produit.pk_fournisseur);

            updateProduit.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }

        public static void Delete(Produit produit)
        {
            string query = "DELETE FROM produit WHERE idProduit = @idProduit";

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand deleteProduit = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "DELETE" et l'objet GetConnexion
            deleteProduit.Parameters.AddWithValue("@idProduit", produit.idProduit); // Paramètre de la commande préparée

            deleteProduit.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }
    }
}