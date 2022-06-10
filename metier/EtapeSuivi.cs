using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    /// <summary>
    /// Classe public EtapeSuivi
    /// </summary>
    public class EtapeSuivi
    {
        private readonly int idSuivi;
        private readonly string etapeSuivi;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="idSuivi"></param>
        /// <param name="etapeSuivi"></param>
        public EtapeSuivi(int idSuivi, string etapeSuivi)
        {
            this.idSuivi = idSuivi;
            this.etapeSuivi = etapeSuivi;

        }

        /// <summary>
        /// Getter sur l'identifiant d'une étape de suivi
        /// </summary>
        /// <returns></returns>
        public int IdSuivi() { return idSuivi; }

        /// <summary>
        /// Getter sur les étapes de suivi
        /// </summary>
        /// <returns></returns>
        public string EtapeDeSuivi() { return etapeSuivi; }
    }
}
