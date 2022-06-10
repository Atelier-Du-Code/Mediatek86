using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    /// <summary>
    /// Classe publique CommandeLivre
    /// </summary>
    public class CommandeLivre
    {
        private readonly string idLivre;
        private readonly DateTime dateDeCommande;
        private readonly int nbExemplaires;
        private readonly double montant;
        private string suivi;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idLivre"></param>
        /// <param name="dateDeCommande"></param>
        /// <param name="montant"></param>
        /// <param name="nbExemplaires"></param>
        /// <param name="suivi"></param>
        public CommandeLivre(string idLivre, DateTime dateDeCommande,double montant, int nbExemplaires, string suivi)
        {
            this.idLivre = idLivre;
            this.dateDeCommande = dateDeCommande;
            this.montant = montant; 
            this.nbExemplaires = nbExemplaires;
            this.suivi = suivi;
        }

        /// <summary>
        /// Getter sur l'identifiant d'un livre
        /// </summary>
        /// <returns>string CommandeLivre.idLivre</returns>
        public string IdLivre() { return idLivre; }

        /// <summary>
        /// Getter sur la date d'une commande
        /// </summary>
        /// <returns>DateTime dateCommande</returns>
        public DateTime DateDeCommande(){return dateDeCommande;}

        /// <summary>
        /// Getter sur le montant d'une commande
        /// </summary>
        /// <returns>double montant</returns>
        public double Montant() { return montant; }

        /// <summary>
        /// Getter sur le nombre d'exemplaires d'un livre
        /// </summary>
        /// <returns>int nbExemplaires</returns>
        public int NbExemplaires() { return nbExemplaires; }

        /// <summary>
        /// Getter sur l'étape du suivi d'une commande
        /// </summary>
        /// <returns>string suivi</returns>
        public string Suivi() { return suivi; }

        /// <summary>
        /// Setter sur l'étape de suivi d'une commande
        /// </summary>
        /// <param name="suivi"></param>
        public void setSuivi(string suivi)
        {
            this.suivi = suivi;             
        }

    }
}
