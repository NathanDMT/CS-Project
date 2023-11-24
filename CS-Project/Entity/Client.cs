using System;

namespace CS_Project.Entity
{
    public class Client
    {
        public int? idClient { get; set; }
        public string civilite { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public int cp { get; set; }
        public string mail { get; set; }
        public string tel { get; set; }
    }
}