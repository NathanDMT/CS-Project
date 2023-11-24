using System;
using Microsoft.OData.Edm;

namespace CS_Project.Entity
{ 
public class Commande
{
    public int idCommande { get; set; }
    public Date date { get; set; }
    public int estPayee { get; set; }
    public int estExpediee { get; set; }
    public int idClient { get; set; }
    }
}