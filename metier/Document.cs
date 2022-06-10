
namespace Mediatek86.metier
{
    /// <summary>
    /// Classe publique Document
    /// </summary>
    public class Document
    {

        private readonly string id;
        private readonly string titre;
        private readonly string image;
        private readonly string idGenre;
        private readonly string genre;
        private readonly string idPublic;
        private readonly string lePublic;
        private readonly string idRayon;
        private readonly string rayon;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="image"></param>
        /// <param name="idGenre"></param>
        /// <param name="genre"></param>
        /// <param name="idPublic"></param>
        /// <param name="lePublic"></param>
        /// <param name="idRayon"></param>
        /// <param name="rayon"></param>
        public Document(string id, string titre, string image, string idGenre, string genre, 
            string idPublic, string lePublic, string idRayon, string rayon)
        {
            this.id = id;
            this.titre = titre;
            this.image = image;
            this.idGenre = idGenre;
            this.genre = genre;
            this.idPublic = idPublic;
            this.lePublic = lePublic;
            this.idRayon = idRayon;
            this.rayon = rayon;
        }

        /// <summary>
        /// Getter sur l'identifiant d'un document
        /// </summary>
        public string Id { get => id; }

        /// <summary>
        /// Getter sur le titre d'un document
        /// </summary>
        public string Titre { get => titre; }

        /// <summary>
        /// Getter sur l'image d'un document
        /// </summary>
        public string Image { get => image; }

        /// <summary>
        /// Getter sur l'identifiant d'un genre d'un document
        /// </summary>
        public string IdGenre { get => idGenre; }

        /// <summary>
        /// Getter sur le genre d'un document
        /// </summary>
        public string Genre { get => genre; }

        /// <summary>
        /// Getter sur l'identifiant du public d'un document
        /// </summary>
        public string IdPublic { get => idPublic; }

        /// <summary>
        /// Getter sur le public d'un document
        /// </summary>
        public string Public { get => lePublic; }

        /// <summary>
        /// Getter sur l'identifiant du rayon d'un document
        /// </summary>
        public string IdRayon { get => idRayon; }

        /// <summary>
        /// Getter sur le rayon d'un document
        /// </summary>
        public string Rayon { get => rayon; }

    }


}
