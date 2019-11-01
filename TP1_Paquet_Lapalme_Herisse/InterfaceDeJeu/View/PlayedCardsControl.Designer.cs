namespace InterfaceDeJeu.View
{
    partial class PlayedCardsControl
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
            this.lastPlayerName = new System.Windows.Forms.Label();
            this.positionDernierJoueur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastPlayerName
            // 
            this.lastPlayerName.AutoSize = true;
            this.lastPlayerName.Location = new System.Drawing.Point(19, 16);
            this.lastPlayerName.Name = "lastPlayerName";
            this.lastPlayerName.Size = new System.Drawing.Size(109, 13);
            this.lastPlayerName.TabIndex = 0;
            this.lastPlayerName.Text = "NomDuDernierJoueur";
            // 
            // positionDernierJoueur
            // 
            this.positionDernierJoueur.AutoSize = true;
            this.positionDernierJoueur.Location = new System.Drawing.Point(22, 56);
            this.positionDernierJoueur.Name = "positionDernierJoueur";
            this.positionDernierJoueur.Size = new System.Drawing.Size(126, 13);
            this.positionDernierJoueur.TabIndex = 1;
            this.positionDernierJoueur.Text = "Position du dernier joueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dernières cartes jouées";
            // 
            // PlayedCardsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.positionDernierJoueur);
            this.Controls.Add(this.lastPlayerName);
            this.Name = "PlayedCardsControl";
            this.Size = new System.Drawing.Size(763, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastPlayerName;
        private System.Windows.Forms.Label positionDernierJoueur;
        private System.Windows.Forms.Label label2;
    }
}
