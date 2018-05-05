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
    public partial class frmChrono : Form
    {
        private int chronoC;
        private frmExo5 frmPrinc; //amélioration 2 : stocké - réference au form appelant

        /// <summary>
        /// constructeur par défaut de la form frmChrono
        /// </summary>
        public frmChrono(frmExo5 f) //amélioration 2 - constructeur paramétré
        {
            InitializeComponent();
            /*frmExo5 frmPrinc;            //avant l'amélioration 2, objet 
            frmPrinc = new frmExo5();
            this.chronoC = frmPrinc.GetChrono();
            this.textChrono.Text = this.chronoC.ToString();
            */
            this.frmPrinc = f; //amélioration 2 - mémorise la ref au form appelant
            
        }
        
        /// <summary>
        /// Quitte l'application: bouton fermer - amélioration2 /libère la ref au form courant et le ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        /// <summary>
        /// Bouton Actualiser : recopie chrono depuis form appelant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //recopie depuis le form appelant
            // this.textChrono.Text = this.frmPrinc.chrono.ToString(); // ce code produit du cours produit 1 exception
            this.chronoC = frmPrinc.GetChrono();
            this.textChrono.Text = this.chronoC.ToString();
        }
        /// <summary>
        /// méthode appelée lors de la fermeture du form==>déréférencer la fenêtre Chrono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChrono_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmMDI)(this.frmPrinc.MdiParent)).fermeChrono(); //libère la référence à ce form 
            //nécissite de Caster à MdiParent
        }
    }
}
