

namespace Mediatek86.metier
{
    /// <summary>
    /// Classe publique Etat
    /// </summary>
    public class Etat
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Etat(string id, string libelle)
        {
            this.GetId = id;
            this.GetLibelle = libelle;
        }

        /// <summary>
        /// Getter et setter sur l'identifiant de l'état
        /// </summary>
        public string GetId { get; set; }

        /// <summary>
        /// Getter et setter sur l'état
        /// </summary>
        public string GetLibelle { get; set; }
    }
}
