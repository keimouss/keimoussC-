using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo5
{
    public partial class frmExo5 : Form
    {
    /// <summary>
    /// System.Random : générateur de nombre aléatoire
    /// </summary>
        private System.Random aleat; //variable de niveau classe

        /// <summary>
        /// nombre aléatoire tiré par NextDouble
        /// </summary>
        public double nombre; //amélioration 2: rendre public les 2 variables nombre et chrono

        public int chrono; //variable niveau pour stocker les valeurs du Tick du timer
                            //par intervalle d'1 seconde (1000millisecondes)
        /// <summary>
        /// Constructeur par défaut du frmExo5: génère un nombre aléatoire
        /// et affiche les valeurs courantes (stockées dans donnée)
        /// </summary>
        public frmExo5()
        {
            InitializeComponent();
            this.aleat = new System.Random(); //instancie un objet générateur aléatoire
            this.Affiche(); // calcul nouvelles valeurs et affichages
        }
        /// <summary>
        /// déclement Timer: affiche les valeurs courantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerchrono_Tick(object sender, EventArgs e)
        {
            this.Affiche(); // calcul nouvelles valeurs du Tick et l'affiche
        }

        private void Affiche()
        {
            //génère un nombre entre 0 et 1 et l'affiche en lableNombre du formExo5
            this.nombre = this.aleat.NextDouble();
            this.lblNombre.Text = this.nombre.ToString();

            //incremente chrono et l'affiche en labelchrono du formExo5
            this.chrono++;
            this.lblChrono.Text = this.chrono.ToString();
        }
        // Création de Getters pour obtenir les valeurs du nombre tiré et le chrono
        public int GetChrono()
        {
            return this.chrono;
            
        }

        public double GetNombre()
        {
            return this.nombre;
        }
    }
}
