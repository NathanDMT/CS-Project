using CS_Project.Entity;
using CS_Project.Manager;
using CS_Project.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Project
{
    public partial class FormProduitInfo : Form
    {
        public FormProduitInfo(Produit produit)
        {
            InitializeComponent();

            // Partie affichage du produit

            labelNomProduit.Text = produit.designation;
            labelDescriptionProduit.Text = produit.description;
            labelPrix1.Text = produit.prix + "€";
            pictureBoxProduit.Image = ResourceService.GetProductImage(produit.fichierImage);
        }
    }
}
