namespace Exo5
{
    partial class frmExo5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChrono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.timerchrono = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chrono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Aléatoire";
            // 
            // lblChrono
            // 
            this.lblChrono.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChrono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChrono.Location = new System.Drawing.Point(177, 12);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(128, 23);
            this.lblChrono.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(177, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 23);
            this.lblNombre.TabIndex = 3;
            // 
            // timerchrono
            // 
            this.timerchrono.Enabled = true;
            this.timerchrono.Interval = 1000;
            this.timerchrono.Tick += new System.EventHandler(this.timerchrono_Tick);
            // 
            // frmExo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 113);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblChrono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExo5";
            this.Text = "frmExo5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Timer timerchrono;
    }
}