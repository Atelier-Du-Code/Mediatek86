using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    /// <summary>
    /// Classe publique Utilisateur
    /// </summary>
    public class Utilisateur
    {
        
        private readonly string prenom;
        private readonly string service;
        private readonly string password;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="password"></param>
        /// <param name="service"></param>
        public Utilisateur(string prenom, string password, string service)
        {           
            this.prenom = prenom;
            this.password = password;
            this.service = service;
        }
        
        /// <summary>
        /// Getter sur le prénom
        /// </summary>
        public string GetPrenom { get => prenom; }

        /// <summary>
        /// Getter sur le mot de passe 
        /// </summary>
        public string GetPassword { get => password; }

        /// <summary>
        /// Getter sur le service
        /// </summary>
        public string GetService { get => service; }
    }
}