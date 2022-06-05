using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class Utilisateur
    {
        
        private readonly string prenom;
        private readonly string service;
        private readonly string password;

        public Utilisateur(string prenom, string password, string service)
        {           
            this.prenom = prenom;
            this.password = password;
            this.service = service;
        }
        
        public string Prenom { get => prenom; }

        public string Password { get => password; }
        public string Service { get => service; }
    }
}