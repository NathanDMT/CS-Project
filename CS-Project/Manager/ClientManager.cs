using System;
using System.Collections.ObjectModel;
using CS_Project.Entity;
using CS_Project.Service;
using MySql.Data.MySqlClient;

namespace CS_Project.Manager
{
    public static class ClientManager
    {

        public static void Create(Client client)
        {
            string query = "INSERT INTO client (idClient,civilite,nom,prenom,adresse,ville,cp,mail,tel) VALUES (@idClient,@civilite,@nom,@prenom,@adresse,@ville,@cp,@mail,@tel)";
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand createCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            createCommande.Parameters.AddWithValue("@idClient", client.idClient);
            createCommande.Parameters.AddWithValue("@civilite", client.civilite);
            createCommande.Parameters.AddWithValue("@nom", client.nom);
            createCommande.Parameters.AddWithValue("@prenom", client.prenom);
            createCommande.Parameters.AddWithValue("@adresse", client.adresse);
            createCommande.Parameters.AddWithValue("@ville", client.ville);
            createCommande.Parameters.AddWithValue("@cp", client.cp);
            createCommande.Parameters.AddWithValue("@mail", client.mail);
            createCommande.Parameters.AddWithValue("@tel", client.tel);

            createCommande.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }


        public static Client Read(int idClient)
        {
            string query = "SELECT * FROM client WHERE idClient = @idClient";
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand readCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            readCommande.Parameters.AddWithValue("@idClient", idClient);

            Client client = new Client();
            MySqlDataReader reader = readCommande.ExecuteReader();
            while (reader.Read())
            {
                client.idClient = reader.GetInt32(0);
                client.civilite = reader.GetString(1);
                client.nom = reader.GetString(2);
                client.prenom = reader.GetString(3);
                client.adresse = reader.GetString(4);
                client.ville = reader.GetString(5);
                client.cp = reader.GetInt32(6);
                client.mail = reader.GetString(7);
                client.tel = reader.GetString(8);
            }
            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            return client;
        }

        public static Collection<Client> ReadAllClient()
        {
            string query = "SELECT * FROM client"; // Commande SQL "SELECT"
            Collection<Client> clientCollection = new Collection<Client>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand requestCommand = new MySqlCommand(query, DatabaseService.GetConnexion()); // Création de la commande
            MySqlDataReader reader = requestCommand.ExecuteReader(); // Création du reader qui va lire la table commande
            try
            {
                while (reader.Read())
                {
                    Client client = new Client(); // Création de commande

                    client.idClient = reader.GetInt32(0);
                    client.civilite = reader.GetString(1);
                    client.nom = reader.GetString(2);
                    client.prenom = reader.GetString(3);
                    client.adresse = reader.GetString(4);
                    client.ville = reader.GetString(5);
                    client.cp = reader.GetInt32(6);
                    client.mail = reader.GetString(7);
                    client.tel = reader.GetString(8);

                    clientCollection.Add(client); // Ajout de la commande à la liste
                }
            }
            catch (Exception) { }
            finally
            {
                DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            }
            return clientCollection; // Retour de la collection
        }


        public static void Update(Client client)
        {
            string query = "UPDATE client SET (idClient,civilite,nom,prenom,adresse,ville,cp,mail,tel) VALUES (@idClient,@civilite,@nom,@prenom,@adresse,@ville,@cp,@mail,@tel) FROM WHERE idClient = @idClient"; // Création de la commande "UPDATE"

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand updateClient = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "UPDATE" et l'objet GetConnexion
            updateClient.Parameters.AddWithValue("@idClient", client.idClient);
            updateClient.Parameters.AddWithValue("@civilite", client.civilite);
            updateClient.Parameters.AddWithValue("@nom", client.nom);
            updateClient.Parameters.AddWithValue("@prenom", client.prenom);
            updateClient.Parameters.AddWithValue("@adresse", client.adresse);
            updateClient.Parameters.AddWithValue("@ville", client.ville);
            updateClient.Parameters.AddWithValue("@cp", client.cp);
            updateClient.Parameters.AddWithValue("@mail", client.mail);
            updateClient.Parameters.AddWithValue("@tel", client.tel);

            updateClient.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }


        public static void Delete(Client client)
        {
            string query = "DELETE FROM client WHERE idClient = @idClient";

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand deleteClient = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "DELETE" et l'objet GetConnexion
            deleteClient.Parameters.AddWithValue("@idCommande", client.idClient); // Paramètre de la commande préparée

            deleteClient.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }
    }
}