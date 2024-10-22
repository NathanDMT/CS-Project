using System;
using System.Collections.ObjectModel;
using CS_Project.Entity;
using CS_Project.Service;
using MySql.Data.MySqlClient;

namespace CS_Project.Manager
{
    public static class CommandeManager
    {
        public static void Create(Commande commande)
        {
            string query = "INSERT INTO commande (idCommande, date, estPayee, estExpediee, idClient) VALUES (@idCommande, @date, @estPayee, @estExpediee, @idClient)";
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand createCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            createCommande.Parameters.AddWithValue("@idCommande", commande.idCommande);
            createCommande.Parameters.AddWithValue("@date", commande.date);
            createCommande.Parameters.AddWithValue("@estPayee", commande.estPayee);
            createCommande.Parameters.AddWithValue("@estExpediee", commande.estExpediee);
            createCommande.Parameters.AddWithValue("@idClient", commande.idClient);
            createCommande.ExecuteNonQuery();

            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }


        public static Commande Read(int idCommande)
        {
            string query = "SELECT * FROM commande WHERE id = @idCommande";
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand readCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            readCommande.Parameters.AddWithValue("@idCommande", idCommande);

            Commande commande = new Commande();
            MySqlDataReader reader = readCommande.ExecuteReader();
            while (reader.Read())
            {
                commande.idCommande = reader.GetInt32(0);
                commande.date = reader.GetDateTime(1);
                commande.estPayee = reader.GetInt32(2);
                commande.estExpediee = reader.GetInt32(3);
            }
            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            return commande;
        }

        public static Collection<Commande> ReadByClient(int idClient)
        {
            string query = "SELECT * FROM commande WHERE client = @idClient";
            Collection<Commande> commandeCollection = new Collection<Commande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand readCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            readCommande.Parameters.AddWithValue("@idClient", idClient);

            MySqlDataReader reader = readCommande.ExecuteReader();
            while (reader.Read())
            {
                Commande commande = new Commande();
                commande.idCommande = reader.GetInt32(0);
                commande.date = reader.GetDateTime(1);
                commande.estPayee = reader.GetInt32(2);
                commande.estExpediee = reader.GetInt32(3);
                commande.idClient = reader.GetInt32(4);

                commandeCollection.Add(commande);
            }
            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            return commandeCollection;
        }


        public static Collection<Commande> ReadWithFilters(Base basicCommandeSQL, Specific filterCommandeSQL, params int[] id)
        {
            string queryBase = "SELECT * FROM commande";
            Collection<string> conditions = new Collection<string>();

            switch (basicCommandeSQL)
            {
                case Base.ALL:
                    {
                        break;
                    }
                case Base.EST_EXPEDIEE:
                    {
                        conditions.Add("estExpediee = @estExpediee");
                        break;
                    }
                case Base.EST_PAYEE:
                    {
                        conditions.Add("estPayee = @estPayee");
                        break;
                    }
            }

            switch (filterCommandeSQL)
            {
                case Specific.NOTHING:
                    {
                        break;
                    }
                case Specific.CLIENT:
                    {
                        conditions.Add("client = " + id[0]);
                        break;
                    }
                case Specific.COMMANDE:
                    {
                        conditions.Add("id = " + id[0]);
                        break;
                    }
            }

            var query = conditions.Count == 0 ? queryBase : $"{queryBase} WHERE {String.Join(" AND ", conditions)}";


            Collection<Commande> commandeCollection = new Collection<Commande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand readCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            readCommande.Parameters.AddWithValue("@idCommande", id);
            readCommande.Parameters.AddWithValue("@estPayee", 0);
            readCommande.Parameters.AddWithValue("@estExpediee", 0);

            MySqlDataReader reader = readCommande.ExecuteReader();
            while (reader.Read())
            {
                Commande commande = new Commande();
                commande.idCommande = reader.GetInt32(0);
                commande.date = reader.GetDateTime(1);
                commande.estPayee = reader.GetInt32(2);
                commande.estExpediee = reader.GetInt32(3);
                commande.idClient = reader.GetInt32(4);
                commandeCollection.Add(commande);
            }
            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            return commandeCollection;
        }
        

        public enum Base
        {
            ALL,
            EST_EXPEDIEE,
            EST_PAYEE
        }

        public enum Specific
        {
            NOTHING,
            CLIENT,
            COMMANDE
        }

        public static Collection<Commande> ReadByCommande(int idCommande)
        {
            string query = "SELECT * FROM commande WHERE id = @idCommande";
            Collection<Commande> commandeCollection = new Collection<Commande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand readCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            readCommande.Parameters.AddWithValue("@idCommande", idCommande);

            Commande commande = new Commande();
            MySqlDataReader reader = readCommande.ExecuteReader();
            while (reader.Read())
            {
                commande.idCommande = reader.GetInt32(0);
                commande.date = reader.GetDateTime(1);
                commande.estPayee = reader.GetInt32(2);
                commande.estExpediee = reader.GetInt32(3);
                commande.idClient = reader.GetInt32(4);
                commandeCollection.Add(commande);
            }
            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            return commandeCollection;
        }

        public static Collection<Commande> ReadAllCommandes()
        {
            string query = "SELECT * FROM commande"; // Commande SQL "SELECT"
            Collection<Commande> commandeCollection = new Collection<Commande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion
                
            MySqlCommand requestCommand = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            MySqlDataReader reader = requestCommand.ExecuteReader(); // Cr�ation du reader qui va lire la table commande
            try
            {
                while (reader.Read())
                {
                    Commande commande = new Commande(); // Cr�ation de commande
                    commande.idCommande = reader.GetInt32(0);
                    commande.date = reader.GetDateTime(1);
                    commande.estPayee = reader.GetInt32(2);
                    commande.estExpediee = reader.GetInt32(3);
                    commande.idClient = reader.GetInt32(4);
                    commandeCollection.Add(commande); // Ajout de la commande � la liste
                }
            }
            catch (Exception){}
            finally
            {
                DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            }
            return commandeCollection; // Retour de la collection
        }


        public static Collection<Commande> ReadPayableCommandes()
        {
            string query = "SELECT * FROM commande WHERE estPayee = 0"; // Commande SQL "SELECT"
            Collection<Commande> commandeCollection = new Collection<Commande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand requestCommand = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            MySqlDataReader reader = requestCommand.ExecuteReader(); // Cr�ation du reader qui va lire la table commande
            try
            {
                while (reader.Read())
                {
                    Commande commande = new Commande(); // Cr�ation de commande
                    commande.idCommande = reader.GetInt32(0);
                    commande.date = reader.GetDateTime(1);
                    commande.estPayee = reader.GetInt32(2);
                    commande.estExpediee = reader.GetInt32(3);
                    commande.idClient = reader.GetInt32(4);
                    commandeCollection.Add(commande); // Ajout de la commande � la liste
                }
            }
            catch (Exception) { }
            finally
            {
                DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            }
            return commandeCollection; // Retour de la collection
        }

        public static Collection<Commande> ReadToShipCommandes()
        {
            string query = "SELECT * FROM commande WHERE estExpediee = 0"; // Commande SQL "SELECT"
            Collection<Commande> commandeCollection = new Collection<Commande>(); // Collection qui est une instance de type Collection
            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion

            MySqlCommand requestCommand = new MySqlCommand(query, DatabaseService.GetConnexion()); // Cr�ation de la commande
            MySqlDataReader reader = requestCommand.ExecuteReader(); // Cr�ation du reader qui va lire la table commande
            try
            {
                while (reader.Read())
                {
                    Commande commande = new Commande(); // Cr�ation de commande
                    commande.idCommande = reader.GetInt32(0);
                    commande.date = reader.GetDateTime(1);
                    commande.estPayee = reader.GetInt32(2);
                    commande.estExpediee = reader.GetInt32(3);
                    commande.idClient = reader.GetInt32(4);
                    commandeCollection.Add(commande); // Ajout de la commande � la liste
                }
            }
            catch (Exception) { }
            finally
            {
                DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
            }
            return commandeCollection; // Retour de la collection
        }

        public static void Update(Commande commande)
        {
            string query = "UPDATE commande SET date = @date, estPayee = @estPayee, estExpediee = @estExpediee WHERE id = @idCommande;"; // Cr�ation de la commande "UPDATE"

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion
            MySqlCommand updateCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "UPDATE" et l'objet GetConnexion
            updateCommande.Parameters.AddWithValue("@date", commande.date); // Param�tre de la commande pr�par�e
            updateCommande.Parameters.AddWithValue("@estPayee", commande.estPayee);
            updateCommande.Parameters.AddWithValue("@estExpediee", commande.estExpediee);
            updateCommande.Parameters.AddWithValue("@idCommande", commande.idCommande);
            updateCommande.ExecuteNonQuery();
            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }


        public static void Delete(Commande commande)
        {
            string query = "DELETE FROM commande WHERE idCommande = @idCommande";

            DatabaseService.GetConnexion().Open(); // Ouverture de la connexion
            MySqlCommand deleteCommande = new MySqlCommand(query, DatabaseService.GetConnexion()); // Commande SQL updateCommande avec "DELETE" et l'objet GetConnexion
            deleteCommande.Parameters.AddWithValue("@idCommande", commande.idCommande); // Param�tre de la commande pr�par�e
            deleteCommande.ExecuteNonQuery();
            DatabaseService.GetConnexion().Close(); // Fermeture de la connexion
        }
    }
}