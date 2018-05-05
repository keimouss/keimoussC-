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
    public partial class frmMDI : Form
    {
        //Variables
        //déclaration variable de niveau classe
        private frmExo5 frmPrinc;//une instance de la form principal frmExo5
        private frmChrono frmC; // une instance de la form secondaire Chrono
        private frmNombre frmR; // une instance de la form secondaire Nombre

        //Nouvelles variables de niveau classe pour les valeurs actualisées de chrono et nombre
        private int chronoM;
        private double nombreM;

        /// <summary>
        /// Constructeur de la form frmMDI
        /// </summary>
        public frmMDI()
        {
            InitializeComponent();
            //instancie une form principal et l'affiche dans le conteneur frmMDI
            frmPrinc = new frmExo5();
            frmPrinc.MdiParent = this;
            frmPrinc.Show();
            
        }
        /// <summary>
        /// quitte l'application : bouton quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); //quitte l'application
        }
        /// <summary>
        /// Menu: Fenêtre / Chrono ===> instancie un form frmChrono ou le réactive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemchrono_Click(object sender, EventArgs e)
        {
            if(this.frmC == null)
            {
                //instancie une form secondaire frmChrono et l'affiche dans le conteneur
                frmC = new frmChrono();
                frmC.MdiParent = this;
                frmC.Show();
            }
            else // le form secondaire est affiché
            {
                this.frmC.Activate(); //réactive le form (lui donne le focus)
                this.chronoM = this.frmPrinc.chrono;
            }
            //recopie la valeur courante
            this.frmC.textChrono.Text = this.chronoM.ToString();
            
        }

        private void toolStripMenuItemNombre_Click(object sender, EventArgs e)
        {
            if(this.frmR == null)
            {
                //instancie une form secondaire frmNombre et l'affiche dans le conteneur
                frmR = new frmNombre();
                frmR.MdiParent = this;
                frmR.Show();
            }
            else //le form secondaire est affiché
            {
                this.frmR.Activate(); //réactive le form (lui donne le focus)
                this.nombreM = this.frmPrinc.nombre;
            }
            //recopie la valeur courante
            this.frmR.txtNombre.Text = this.nombreM.ToString();
            
        }
    }
}
