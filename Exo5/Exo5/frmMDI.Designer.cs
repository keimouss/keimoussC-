namespace Exo5
{
    partial class frmMDI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMonwindows = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemchrono = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMonwindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMonwindows
            // 
            this.menuStripMonwindows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFichier,
            this.toolStripMenuItemFenetre,
            this.toolStripMenuItemAide});
            this.menuStripMonwindows.Location = new System.Drawing.Point(0, 0);
            this.menuStripMonwindows.MdiWindowListItem = this.toolStripMenuItemFenetre;
            this.menuStripMonwindows.Name = "menuStripMonwindows";
            this.menuStripMonwindows.Size = new System.Drawing.Size(800, 24);
            this.menuStripMonwindows.TabIndex = 1;
            this.menuStripMonwindows.Text = "Monwindows";
            // 
            // toolStripMenuItemFichier
            // 
            this.toolStripMenuItemFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQuitter});
            this.toolStripMenuItemFichier.Name = "toolStripMenuItemFichier";
            this.toolStripMenuItemFichier.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemFichier.Text = "Fichier";
            // 
            // toolStripMenuItemQuitter
            // 
            this.toolStripMenuItemQuitter.Name = "toolStripMenuItemQuitter";
            this.toolStripMenuItemQuitter.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemQuitter.Text = "Quitter";
            this.toolStripMenuItemQuitter.Click += new System.EventHandler(this.toolStripMenuItemQuitter_Click);
            // 
            // toolStripMenuItemFenetre
            // 
            this.toolStripMenuItemFenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemchrono,
            this.toolStripMenuItemNombre});
            this.toolStripMenuItemFenetre.Name = "toolStripMenuItemFenetre";
            this.toolStripMenuItemFenetre.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItemFenetre.Text = "Fenêtre";
            // 
            // toolStripMenuItemchrono
            // 
            this.toolStripMenuItemchrono.Name = "toolStripMenuItemchrono";
            this.toolStripMenuItemchrono.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemchrono.Text = "Chrono";
            this.toolStripMenuItemchrono.Click += new System.EventHandler(this.toolStripMenuItemchrono_Click);
            // 
            // toolStripMenuItemNombre
            // 
            this.toolStripMenuItemNombre.Name = "toolStripMenuItemNombre";
            this.toolStripMenuItemNombre.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemNombre.Text = "Nombre";
            this.toolStripMenuItemNombre.Click += new System.EventHandler(this.toolStripMenuItemNombre_Click);
            // 
            // toolStripMenuItemAide
            // 
            this.toolStripMenuItemAide.Name = "toolStripMenuItemAide";
            this.toolStripMenuItemAide.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItemAide.Text = "Aide ";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripMonwindows);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMonwindows;
            this.Name = "frmMDI";
            this.Text = "Exo5 - FenêtreMDI";
            this.menuStripMonwindows.ResumeLayout(false);
            this.menuStripMonwindows.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMonwindows;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFichier;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFenetre;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemchrono;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNombre;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuitter;
    }
}

