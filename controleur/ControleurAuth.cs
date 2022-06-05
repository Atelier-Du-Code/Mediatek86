using Mediatek86.metier;
using Mediatek86.modele;
using Mediatek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.controleur
{
    internal class ControleurAuth
    {
        private readonly List<Utilisateur> lesUtilisateurs;
        public int lesDroits;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public ControleurAuth()
        {
            lesUtilisateurs = Dao.GetAllUtilisateurs();

            Authentification auth = new Authentification(this);
            auth.RemplisListeBox();
            auth.ShowDialog();

            lesDroits = auth.noService;
        }

        /// <summary>
        /// Getter sur la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        public List<Utilisateur> GetAllUtilisateurs()
        {
            return lesUtilisateurs;
        }
    }
}
