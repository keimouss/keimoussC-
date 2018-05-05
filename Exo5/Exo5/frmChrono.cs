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

        /// <summary>
        /// constructeur par défaut de la form frmChrono
        /// </summary>
        public frmChrono()
        {
            InitializeComponent();
            frmExo5 frmPrinc;
            frmPrinc = new frmExo5();
            this.chronoC = frmPrinc.GetChrono();
            this.textChrono.Text = this.chronoC.ToString();
            
        }
        
        /// <summary>
        /// Quitte l'application: bouton fermer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
