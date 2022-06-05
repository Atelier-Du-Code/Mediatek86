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
    public partial class Authentification : Form
    {
        private readonly ControleurAuth controleurAuth;
        private List<Utilisateur> liste;
        public int noService = 0;

        internal Authentification(ControleurAuth controleurAuth)
        {
            InitializeComponent();
            this.controleurAuth = controleurAuth;
        }

        public void RemplisListeBox()
        {
            liste = controleurAuth.GetAllUtilisateurs();

            for (int x = 0; x < liste.Count; x++)
            {
                lstBoxLogin.Items.Add(liste[x].Prenom);
            }
            
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(lstBoxLogin.SelectedIndex > -1)
            {
                string nomSelect = (string)lstBoxLogin.SelectedItem;
                bool bTrouve = false;
                int index = 0;
               

                while(!bTrouve)
                {

                    if(liste[index].Prenom != nomSelect)
                    {
                        index++;
                    }
                    else
                    {
                        bTrouve = true;

                        if(liste[index].Password != txtbPassword.Text)
                        {
                            MessageBox.Show("Le mot de passe n'est pas valide");
                        }
                        else
                        {
                            if (liste[index].Service != "culture")
                            {
                                if (liste[index].Service == "administration")
                                {
                                    noService = 1;
                                }
                                else
                                {
                                    if (liste[index].Service == "prets")
                                    {
                                        noService = 2;
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
