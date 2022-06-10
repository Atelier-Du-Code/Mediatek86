using System;

namespace Mediatek86.metier
{
    /// <summary>
    /// Classe publique Exemplaire
    /// </summary>
    public class Exemplaire
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="dateAchat"></param>
        /// <param name="photo"></param>
        /// <param name="idEtat"></param>
        /// <param name="idDocument"></param>
        public Exemplaire(int numero, DateTime dateAchat, string photo,string idEtat, string idDocument)
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.IdEtat = idEtat;
            this.IdDocument = idDocument;
        }

        /// <summary>
        /// Getter sur le numéro d'emplaire
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Getter sur la photo d'un exemplaire
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Getter sur la date d'achat d'un exemplaire
        /// </summary>
        public DateTime DateAchat { get; set; }

        /// <summary>
        /// Getter et setter sur l'identifiant de l'etat d'un exemplaire
        /// </summary>
        public string IdEtat { get; set; }

        /// <summary>
        /// Getter et setter sur l'identifiant d'un exemplaire
        /// </summary>
        public string IdDocument { get; set; }
    }
}
