using System;
using System.Collections.Generic;
using Mediatek86.bdd;
using Mediatek86.metier;

namespace Mediatek86.modele
{
    /// <summary>
    /// Classe publique Dao
    /// </summary>
    public static class Dao
    {

        private static readonly string server = "localhost";
        private static readonly string userid = "root";
        private static readonly string password = "";
        private static readonly string database = "mediatek86";
        private static readonly string connectionString = "server=" + server + ";user id=" + userid + ";password=" + password + ";database=" + database + ";SslMode=none";

        /// <summary>
        /// Titre du livre en cours d'utilisation
        /// </summary>
        public static string titreLivreCourant;

        /// <summary>
        /// ISBN du livre en cours d'utilisation
        /// </summary>
        public static string isbnLivreCourant;

        /// <summary>
        /// Retourne tous les genres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public static List<Categorie> GetAllGenres()
        {
            List<Categorie> lesGenres = new List<Categorie>();
            string req = "Select * from genre order by libelle";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Genre genre = new Genre((string)curs.Field("id"), (string)curs.Field("libelle"));
                lesGenres.Add(genre);
            }
            curs.Close();
            return lesGenres;
        }

        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Collection d'objets Rayon</returns>
        public static List<Categorie> GetAllRayons()
        {
            List<Categorie> lesRayons = new List<Categorie>();
            string req = "Select * from rayon order by libelle";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Rayon rayon = new Rayon((string)curs.Field("id"), (string)curs.Field("libelle"));
                lesRayons.Add(rayon);
            }
            curs.Close();
            return lesRayons;
        }

        /// <summary>
        /// Retourne toutes les catégories de public à partir de la BDD
        /// </summary>
        /// <returns>Collection d'objets Public</returns>
        public static List<Categorie> GetAllPublics()
        {
            List<Categorie> lesPublics = new List<Categorie>();
            string req = "Select * from public order by libelle";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Public lePublic = new Public((string)curs.Field("id"), (string)curs.Field("libelle"));
                lesPublics.Add(lePublic);
            }
            curs.Close();
            return lesPublics;
        }
               
        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public static List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            string req = "Select l.id, l.ISBN, l.auteur, d.titre, d.image, l.collection, ";
            req += "d.idrayon, d.idpublic, d.idgenre, g.libelle as genre, p.libelle as public, r.libelle as rayon ";
            req += "from livre l join document d on l.id=d.id ";
            req += "join genre g on g.id=d.idGenre ";
            req += "join public p on p.id=d.idPublic ";
            req += "join rayon r on r.id=d.idRayon ";
            req += "order by titre ";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                string id = (string)curs.Field("id");
                string isbn = (string)curs.Field("ISBN");
                string auteur = (string)curs.Field("auteur");
                string titre = (string)curs.Field("titre");
                string image = (string)curs.Field("image");
                string collection = (string)curs.Field("collection");
                string idgenre = (string)curs.Field("idgenre");
                string idrayon = (string)curs.Field("idrayon");
                string idpublic = (string)curs.Field("idpublic");
                string genre = (string)curs.Field("genre");
                string lepublic = (string)curs.Field("public");
                string rayon = (string)curs.Field("rayon");
                Livre livre = new Livre(id, titre, image, isbn, auteur, collection, idgenre, genre, 
                    idpublic, lepublic, idrayon, rayon);
                lesLivres.Add(livre);
            }
            curs.Close();

            return lesLivres;
        }

        /// <summary>
        /// Retourne toutes les dvd à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Dvd</returns>
        public static List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = new List<Dvd>();
            string req = "Select l.id, l.duree, l.realisateur, d.titre, d.image, l.synopsis, ";
            req += "d.idrayon, d.idpublic, d.idgenre, g.libelle as genre, p.libelle as public, r.libelle as rayon ";
            req += "from dvd l join document d on l.id=d.id ";
            req += "join genre g on g.id=d.idGenre ";
            req += "join public p on p.id=d.idPublic ";
            req += "join rayon r on r.id=d.idRayon ";
            req += "order by titre ";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                string id = (string)curs.Field("id");
                int duree = (int)curs.Field("duree");
                string realisateur = (string)curs.Field("realisateur");
                string titre = (string)curs.Field("titre");
                string image = (string)curs.Field("image");
                string synopsis = (string)curs.Field("synopsis");
                string idgenre = (string)curs.Field("idgenre");
                string idrayon = (string)curs.Field("idrayon");
                string idpublic = (string)curs.Field("idpublic");
                string genre = (string)curs.Field("genre");
                string lepublic = (string)curs.Field("public");
                string rayon = (string)curs.Field("rayon");
                Dvd dvd = new Dvd(id, titre, image, duree, realisateur, synopsis, idgenre, genre,
                    idpublic, lepublic, idrayon, rayon);
                lesDvd.Add(dvd);
            }
            curs.Close();

            return lesDvd;
        }

        /// <summary>
        /// Retourne toutes les revues à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public static List<Revue> GetAllRevues()
        {
            List<Revue> lesRevues = new List<Revue>();
            string req = "Select l.id, l.empruntable, l.periodicite, d.titre, d.image, l.delaiMiseADispo, ";
            req += "d.idrayon, d.idpublic, d.idgenre, g.libelle as genre, p.libelle as public, r.libelle as rayon ";
            req += "from revue l join document d on l.id=d.id ";
            req += "join genre g on g.id=d.idGenre ";
            req += "join public p on p.id=d.idPublic ";
            req += "join rayon r on r.id=d.idRayon ";
            req += "order by titre ";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                string id = (string)curs.Field("id");
                bool empruntable = (bool)curs.Field("empruntable");
                string periodicite = (string)curs.Field("periodicite");
                string titre = (string)curs.Field("titre");
                string image = (string)curs.Field("image");
                int delaiMiseADispo = (int)curs.Field("delaimiseadispo");
                string idgenre = (string)curs.Field("idgenre");
                string idrayon = (string)curs.Field("idrayon");
                string idpublic = (string)curs.Field("idpublic");
                string genre = (string)curs.Field("genre");
                string lepublic = (string)curs.Field("public");
                string rayon = (string)curs.Field("rayon");
                Revue revue = new Revue(id, titre, image, idgenre, genre,
                    idpublic, lepublic, idrayon, rayon, empruntable, periodicite, delaiMiseADispo);
                lesRevues.Add(revue);
            }
            curs.Close();

            return lesRevues;
        }

        /// <summary>
        /// Retourne les exemplaires d'une revue
        /// </summary>
        /// <returns>Liste d'objets Exemplaire</returns>
        public static List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            List<Exemplaire> lesExemplaires = new List<Exemplaire>();
            string req = "Select e.id, e.numero, e.dateAchat, e.photo, e.idEtat ";
            req += "from exemplaire e join document d on e.id=d.id ";
            req += "where e.id = @id ";
            req += "order by e.dateAchat DESC";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@id", idDocument}
                };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                string idDoc = (string)curs.Field("id");
                int numero = (int)curs.Field("numero");
                DateTime dateAchat = (DateTime)curs.Field("dateAchat");
                string photo = (string)curs.Field("photo");
                string idEtat = (string)curs.Field("idEtat");
                Exemplaire exemplaire = new Exemplaire(numero, dateAchat, photo, idEtat, idDoc);
                lesExemplaires.Add(exemplaire);
            }
            curs.Close();

            return lesExemplaires;
        }

        /// <summary>
        /// Getter sur tous les exemplaires d'un livre
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns></returns>
        public static List<Exemplaire> GetAllExemplairesLivres(string idDocument)
        {

            List<Exemplaire> lesExemplairesLivres = new List<Exemplaire>();

            string req = "Select e.id, e.numero, e.dateAchat, e.libelle ";
            req += "from exemplaire e join document d on e.id=d.id ";
            req += "where e.id = @id ";
            req += "order by e.dateAchat DESC";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@id", idDocument}
                };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                //Description du protype d'un exemplaire de livre
                string idDoc = (string)curs.Field("id");
                int numero = (int)curs.Field("numero");
                DateTime dateAchat = (DateTime)curs.Field("dateAchat");
                string photo = (string)curs.Field("photo");
                string idEtat = (string)curs.Field("idEtat");

                //Création d'un exemplaire de livre
                Exemplaire exemplaire = new Exemplaire(numero, dateAchat, photo, idEtat, idDoc);
               
                //Ajout d'un exemplaire dans la liste
                lesExemplairesLivres.Add(exemplaire);
            }
            curs.Close();

            return lesExemplairesLivres;
        }

        /// <summary>
        /// ecriture d'un exemplaire en base de données
        /// </summary>
        /// <param name="exemplaire"></param>
        /// <returns>true si l'insertion a pu se faire</returns>
        public static bool CreerExemplaire(Exemplaire exemplaire)
        {
            try
            {
                string req = "insert into exemplaire values (@idDocument,@numero,@dateAchat,@photo,@idEtat)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idDocument", exemplaire.IdDocument},
                    { "@numero", exemplaire.Numero},
                    { "@dateAchat", exemplaire.DateAchat},
                    { "@photo", exemplaire.Photo},
                    { "@idEtat",exemplaire.IdEtat}
                };
                BddMySql curs = BddMySql.GetInstance(connectionString);
                curs.ReqUpdate(req, parameters);
                curs.Close();
                return true;
            }catch{
                return false;
            }
        }

        /// <summary>
        /// Récupère tous les utilisateurs avec leur mot de passe et leur service
        /// </summary>
        /// <returns></returns>

        public static List<Utilisateur> GetAllUtilisateurs()
        {
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            string req = "SELECT * FROM utilisateurs INNER JOIN services WHERE utilisateurs.id_service = services.id_service ORDER BY id_utilisateur ";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Utilisateur utilisateur = new Utilisateur((string)curs.Field("prenom"), 
                    (string)curs.Field("password"), 
                    (string)curs.Field("service"));

                lesUtilisateurs.Add(utilisateur);
            }
            curs.Close();
            return lesUtilisateurs;

        }
        /// <summary>
        /// Getter sur les commandes de livres
        /// </summary>
        /// <param name="idLivre"></param>
        /// <returns></returns>
        public static List<CommandeLivre> GetCommandeDeLivres(string idLivre)
        {
            List<CommandeLivre> lesCommandesLivres = new List<CommandeLivre>();


            string req = "Select livre.ISBN, document.titre, commandedocument.nbExemplaire, suivi.etape_suivi, commande.dateCommande, commande.montant FROM livre ";
            req += "JOIN document ON livre.id = document.id ";
            req += "JOIN commandedocument ON livre.id = commandedocument.id_CommandeDocument ";
            req += "JOIN suivi ON commandedocument.id_suivi = suivi.id_suivi ";
            req += "JOIN commande ON commandedocument.id_CommandeDocument = commande.id ";
            req += "WHERE livre.id = @id";            

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@id", idLivre}
                };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            bool bPrem = true;
            while (curs.Read())
            {
                if(bPrem)
                {
                    titreLivreCourant = (string)curs.Field("titre");
                    isbnLivreCourant = (string)curs.Field("isbn");
                    bPrem = false;
                }
                
                DateTime date = (DateTime)curs.Field("dateCommande");
                string id = idLivre;
                double montant = (double)curs.Field("montant");
                int nb = (int)curs.Field("nbExemplaire");
                string suivi = (string)curs.Field("etape_suivi");

                CommandeLivre commande = new CommandeLivre(id, date, montant ,nb ,suivi);
                lesCommandesLivres.Add(commande);
            }
            curs.Close();            

            return lesCommandesLivres; 
        }
        /// <summary>
        /// Méthode permettant de récupèrer les etapes de suivi pour le comboBox
        /// </summary>
        /// <returns></returns>
        public static List<EtapeSuivi> GetEtapeSuivi()
        {
            List<EtapeSuivi> lesEtapesSuivi = new List<EtapeSuivi>();

            string req = "SELECT * FROM suivi";

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req,null);


            while (curs.Read())
            {
                int idSuivi = (int)curs.Field("id_suivi");
                string etapeSuivi = (string)curs.Field("etape_suivi");

                EtapeSuivi listeEtapes = new EtapeSuivi(idSuivi, etapeSuivi);
                lesEtapesSuivi.Add(listeEtapes);
            }
            curs.Close();

            return lesEtapesSuivi;
        }

        /// <summary>
        /// Méthode qui update le suivi d'un livre dans la BDD
        /// </summary>
        /// <param name="idLivre"></param>
        /// <param name="indexSuivi"></param>
        public static void ChangeLeSuivi(string idLivre, int indexSuivi)
        {
            string req = "UPDATE commandedocument JOIN livres_dvd ON livres_dvd.id = commandedocument.id_CommandeDocument";
                   req += " SET commandedocument.id_suivi = @indexSuivi ";
                   req += "WHERE livres_dvd.id = @idLivre";
            
            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idLivre", idLivre},
                    { "@indexSuivi", indexSuivi}
                };

            BddMySql curs = BddMySql.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);      
            curs.Close();            
        }       
    }
}
