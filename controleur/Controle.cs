using System.Collections.Generic;
using Mediatek86.modele;
using Mediatek86.metier;
using Mediatek86.vue;
using System.Windows.Forms;

namespace Mediatek86.controleur
{
    internal class Controle
    {
        private readonly List<Livre> lesLivres;
        private readonly List<Dvd> lesDvd;
        private readonly List<Revue> lesRevues;
        private readonly List<Categorie> lesRayons;
        private readonly List<Categorie> lesPublics;
        private readonly List<Categorie> lesGenres;

        public int lesDroits;


        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle(int _lesDroits)
        {
            lesDroits = _lesDroits;
            lesLivres = Dao.GetAllLivres();
            lesDvd = Dao.GetAllDvd();
            lesRevues = Dao.GetAllRevues();
            lesGenres = Dao.GetAllGenres();
            lesRayons = Dao.GetAllRayons();
            lesPublics = Dao.GetAllPublics();            
            FrmMediatek frmMediatek = new FrmMediatek(this);

            frmMediatek.ShowDialog();
                         
        }       
        
        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Collection d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return lesGenres;
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Collection d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return lesLivres;
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Collection d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return lesDvd;
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Collection d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return lesRevues;
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Collection d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return lesRayons;
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Collection d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return lesPublics;
        }

        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <returns>Collection d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return Dao.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Getter sur la liste des exemplaires d'un livre
        /// </summary>
        /// <param name="idDoc"></param>
        /// <returns></returns>
        public List<Exemplaire> GetExemplairesLivres(string idDoc)
        {
            return Dao.GetAllExemplairesLivres(idDoc);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return Dao.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// Getter sur les commandes d'un livre
        /// </summary>
        /// <param name="idLivre"></param>
        /// <returns></returns>
        public List<CommandeLivre> GetCommandeLivres(string idLivre)
        {
            return Dao.GetCommandeDeLivres(idLivre);
        }

        /// <summary>
        /// Getter sur le titre du livre en cours d'utilisation
        /// </summary>
        /// <returns></returns>
        public string GetTitreLivreCourant()
        {
            return Dao.titreLivreCourant;
        }

        /// <summary>
        /// Getter sur l'isbn du livre en cours d'utilisation
        /// </summary>
        /// <returns></returns>
        public string GetIsbnLivreCourant()
        {
            return Dao.isbnLivreCourant;
        }

        /// <summary>
        /// Getter sur les étapes du suivi
        /// </summary>
        /// <returns></returns>
        public List<EtapeSuivi> GetLesEtapesSuivis()
        {
            return Dao.GetEtapeSuivi();
        }

        /// <summary>
        /// Méthode modifie l'état de suivi d'un livre dans la BDD
        /// </summary>
        /// <param name="idLivre"></param>
        /// <param name="indexSuivi"></param>
        public void ChangeLeSuivi(string idLivre, int indexSuivi)
        {
            Dao.ChangeLeSuivi(idLivre, indexSuivi);
        }       
    }
}

