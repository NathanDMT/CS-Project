using System;
using CS_Project.Entity;
namespace CS_Project.Manager
{
    public static class ProduitManager
    {
        public static void Create(Produit produit)
        {
            string query = $"INSERT INTO produit (idProduit,designation,description,dateAjout,qte,prix,fichierImage,pk_fournisseur) VALUES ({produit.idProduit},{produit.designation},{produit.description},{produit.dateAjout},{produit.qte},{produit.prix},{produit.fichierImage},{produit.pk_fournisseur})";
        }

        public static void Read(Produit produit)
        {
            string query = $"SELECT * FROM produit";
        }

        public static void Update(Produit produit)
        {

        }

        public static void Delete(Produit produit)
        {

        }
    }
}