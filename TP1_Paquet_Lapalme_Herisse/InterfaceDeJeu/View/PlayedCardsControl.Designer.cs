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
            this.cartesCeTour = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // cartesCeTour
            // 
            this.cartesCeTour.AutoSize = true;
            this.cartesCeTour.Location = new System.Drawing.Point(492, 16);
            this.cartesCeTour.Name = "cartesCeTour";
            this.cartesCeTour.Size = new System.Drawing.Size(107, 13);
            this.cartesCeTour.TabIndex = 5;
            this.cartesCeTour.Text = "Cartes jouées ce tour";
            // 
            // label4
            // 
            this.label4.Image = global::InterfaceDeJeu.Properties.Resources.joker2;
            this.label4.Location = new System.Drawing.Point(492, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 105);
            this.label4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Image = global::InterfaceDeJeu.Properties.Resources.Joker1;
            this.label3.Location = new System.Drawing.Point(348, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 105);
            this.label3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Image = global::InterfaceDeJeu.Properties.Resources.VALET_Trefle;
            this.label1.Location = new System.Drawing.Point(268, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 105);
            this.label1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Image = global::InterfaceDeJeu.Properties.Resources.joker2;
            this.label5.Location = new System.Drawing.Point(572, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 105);
            this.label5.TabIndex = 7;
            // 
            // PlayedCardsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cartesCeTour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cartesCeTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
