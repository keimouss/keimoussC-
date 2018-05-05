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
    public partial class frmNombre : Form
    {
        private double nombreN;
        private frmExo5 frmPrinc; //amélioration 2 : stocké - réference au form appelant

        /// <summary>
        /// constructeur par défaut de la form frmNombre
        /// </summary>
        public frmNombre(frmExo5 f) //amélioration 2 - constructeur paramétré
        {
            InitializeComponent();
            //instancie un objet frmExo5
            /* frmExo5 frmPrinc;            //avant l'amélioration 2, objet
             frmPrinc = new frmExo5();
             this.nombreN = frmPrinc.GetNombre();
             this.txtNombre.Text = this.nombreN.ToString();
             */
            this.frmPrinc = f; //amélioration 2 - mémorise la ref au form appelant
        }
        /// <summary>
        /// quitte l'pplication : bouton fermer -  amélioration2 /libère la ref au form courant et le ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        /// <summary>
        /// bouton Actualiser: recopie Nombre depuis form appelant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //recopie depuis le form appelant
            //this.txtNombre.Text = this.frmPrinc.nombre.ToString(); //ce code du cours produit 1 exception
            this.nombreN = frmPrinc.GetNombre();
            this.txtNombre.Text = this.nombreN.ToString();
        }
        /// <summary>
        /// méthode appelée lors de la fermeture du form==>déréférencer la fenêtre Nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNombre_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmMDI)(this.frmPrinc.MdiParent)).fermeNombre(); //libère la référence à ce form 
            //nécissite de Caster à MdiParent
        }
    }
}
