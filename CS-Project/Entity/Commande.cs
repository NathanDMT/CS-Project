using System;
using Microsoft.OData.Edm;

namespace CS_Project.Entity
{ 
public class Commande
{
    public string idCommande { get; set; }
    public Date date { get; set; }
    public bool estPayee { get; set; }
    public bool estExpediee { get; set; }
    public int idClient { get; set; }
    }
}