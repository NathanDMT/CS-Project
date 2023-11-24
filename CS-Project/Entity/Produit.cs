using System;

namespace CS_Project.Entity
{

    public class Produit
    {
        public int idProduit { get; set; }
        public string designation { get; set; }
        public string description { get; set; }
        public DateTime dateAjout { get; set; }
        public int qte { get; set; }
        public string prix { get; set; }
        public string fichierImage { get; set; }
        public string pk_fournisseur { get; set; }
    }
}