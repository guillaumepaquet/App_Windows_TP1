namespace InterfaceDeJeu.View
{
    partial class OtherPlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomJoueur = new System.Windows.Forms.Label();
            this.positionJoueur = new System.Windows.Forms.Label();
            this.nbCartes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nbCartes);
            this.panel1.Controls.Add(this.positionJoueur);
            this.panel1.Controls.Add(this.nomJoueur);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 160);
            this.panel1.TabIndex = 0;
            // 
            // nomJoueur
            // 
            this.nomJoueur.Location = new System.Drawing.Point(3, 34);
            this.nomJoueur.Name = "nomJoueur";
            this.nomJoueur.Size = new System.Drawing.Size(137, 23);
            this.nomJoueur.TabIndex = 0;
            this.nomJoueur.Text = "PlaceholderNomJoueur";
            // 
            // positionJoueur
            // 
            this.positionJoueur.Location = new System.Drawing.Point(3, 102);
            this.positionJoueur.Name = "positionJoueur";
            this.positionJoueur.Size = new System.Drawing.Size(149, 23);
            this.positionJoueur.TabIndex = 1;
            this.positionJoueur.Text = "PlaceholderPositionJoueur";
            // 
            // nbCartes
            // 
            this.nbCartes.Location = new System.Drawing.Point(227, 54);
            this.nbCartes.Name = "nbCartes";
            this.nbCartes.Size = new System.Drawing.Size(100, 23);
            this.nbCartes.TabIndex = 2;
            this.nbCartes.Text = "nombre de cartes";
            // 
            // OtherPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "OtherPlayerControl";
            this.Size = new System.Drawing.Size(349, 166);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nomJoueur;
        private System.Windows.Forms.Label positionJoueur;
        private System.Windows.Forms.Label nbCartes;
    }
}
