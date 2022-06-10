

namespace Mediatek86.metier
{
    /// <summary>
    /// Classe abstraite Catégorie
    /// </summary>
    public abstract class Categorie
    {
        private readonly string id;
        private readonly string libelle;

        /// <summary>
        /// Contructeur de la classe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        protected Categorie(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        /// <summary>
        /// Getter sur l'identifiant d'une catégorie
        /// </summary>
        public string Id { get => id; }

        /// <summary>
        /// Getter sur le libelllé d'une catégorie
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Récupération du libellé pour l'affichage dans les combos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.libelle;
        }

    }
}
