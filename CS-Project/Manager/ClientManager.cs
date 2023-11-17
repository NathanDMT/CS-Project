using System;
using CS_Project.Entity;
namespace CS_Project.Manager
{
    public static class ClientManager
    {
        public static void Create(Client client)
        {
            string query = $"INSERT INTO client (idClient,civilite,nom,prenom,adresse,ville,cp,mail,tel) VALUES ({client.idClient},{client.civilite},{client.nom},{client.prenom},{client.adresse},{client.ville},{client.cp},{client.mail},{client.tel})";
        }


        public static void Read(Client client)
        {
            string query = $"SELECT * FROM client";
        }

        public static void Update(Client client)
        {

        }

        public static void Delete(Client client)
        {

        }

    }
}