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

        /// <summary>
        /// constructeur par défaut de la form frmNombre
        /// </summary>
        public frmNombre()
        {
            InitializeComponent();
            //instancie un objet frmExo5
            frmExo5 frmPrinc;
            frmPrinc = new frmExo5();
            this.nombreN = frmPrinc.GetNombre();
            this.txtNombre.Text = this.nombreN.ToString();
        }
        /// <summary>
        /// quitte l'pplication : bouton fermer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
