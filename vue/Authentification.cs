using Mediatek86.controleur;
using Mediatek86.metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek86.vue
{
    /// <summary>
    /// Classe partielle Authentification héritant de Form
    /// </summary>
    public partial class Authentification : Form
    {
        private readonly ControleurAuth controleurAuth;
        private List<Utilisateur> liste;

        /// <summary>
        /// index du service d'un utilisateur
        /// </summary>
        public int noService = 0;

        internal Authentification(ControleurAuth controleurAuth)
        {
            InitializeComponent();
            this.controleurAuth = controleurAuth;
        }
        /// <summary>
        /// Rempli la listBox avec les noms des employés de la BDD
        /// </summary>
        public void RemplisListeBox()
        {
            liste = controleurAuth.GetAllUtilisateurs();

            for (int x = 0; x < liste.Count; x++)
            {
                lstBoxLogin.Items.Add(liste[x].GetPrenom);
            }
            
        }
        /// <summary>
        /// Valide la cohérance entre le prénom, le mot de passe saisi par l'utilisateur avec ceux de la base de données
        /// Gère également les droits des utiisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(lstBoxLogin.SelectedIndex > -1)
            {
                string nomSelect = (string)lstBoxLogin.SelectedItem;
                bool bTrouve = false;
                int index = 0;          

                while(!bTrouve)
                {
                    if(liste[index].GetPrenom != nomSelect)
                    {
                        index++;
                    }
                    else
                    {
                        bTrouve = true;

                        if(liste[index].GetPassword != txtbPassword.Text)
                        {
                            MessageBox.Show("Le mot de passe n'est pas valide");
                        }
                        else
                        {
                            if (liste[index].GetService != "culture")
                            {
                                if (liste[index].GetService == "administration")
                                {
                                    noService = 1;
                                }
                                else
                                {
                                    if (liste[index].GetService == "prets")
                                    {
                                        noService = 2;
                                        MessageBox.Show("Vous avez un droit de consultation des ressources");
                                    }
                                }
                            }
                            else
                            {
                                noService = 0;
                                MessageBox.Show("Vous n'avez pas les droits pour accèder à cette application");
                            }
                        }                        
                    }
                }

            }
            else
            {
                MessageBox.Show("Veuillez selectionner votre nom dans la liste");
            }
            Close();
        }


    }
}
