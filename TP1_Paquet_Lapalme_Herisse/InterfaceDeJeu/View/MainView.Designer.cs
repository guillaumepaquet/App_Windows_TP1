namespace InterfaceDeJeu.View
{
    partial class MainView
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
            this.nouvellePartie = new System.Windows.Forms.Button();
            this.otherPlayerControl3 = new InterfaceDeJeu.View.OtherPlayerControl();
            this.otherPlayerControl2 = new InterfaceDeJeu.View.OtherPlayerControl();
            this.otherPlayerControl1 = new InterfaceDeJeu.View.OtherPlayerControl();
            this.currentPlayerControl1 = new InterfaceDeJeu.View.CurrentPlayerControl();
            this.playedCardsControl1 = new InterfaceDeJeu.View.PlayedCardsControl();
            this.SuspendLayout();
            // 
            // nouvellePartie
            // 
            this.nouvellePartie.Location = new System.Drawing.Point(12, 6);
            this.nouvellePartie.Name = "nouvellePartie";
            this.nouvellePartie.Size = new System.Drawing.Size(148, 23);
            this.nouvellePartie.TabIndex = 4;
            this.nouvellePartie.Text = "Nouvelle Partie";
            this.nouvellePartie.UseVisualStyleBackColor = true;
            // 
            // otherPlayerControl3
            // 
            this.otherPlayerControl3.Location = new System.Drawing.Point(755, 35);
            this.otherPlayerControl3.Name = "otherPlayerControl3";
            this.otherPlayerControl3.Size = new System.Drawing.Size(349, 166);
            this.otherPlayerControl3.TabIndex = 3;
            // 
            // otherPlayerControl2
            // 
            this.otherPlayerControl2.Location = new System.Drawing.Point(400, 35);
            this.otherPlayerControl2.Name = "otherPlayerControl2";
            this.otherPlayerControl2.Size = new System.Drawing.Size(349, 166);
            this.otherPlayerControl2.TabIndex = 2;
            // 
            // otherPlayerControl1
            // 
            this.otherPlayerControl1.Location = new System.Drawing.Point(45, 35);
            this.otherPlayerControl1.Name = "otherPlayerControl1";
            this.otherPlayerControl1.Size = new System.Drawing.Size(349, 166);
            this.otherPlayerControl1.TabIndex = 1;
            // 
            // currentPlayerControl1
            // 
            this.currentPlayerControl1.Location = new System.Drawing.Point(45, 401);
            this.currentPlayerControl1.Name = "currentPlayerControl1";
            this.currentPlayerControl1.Size = new System.Drawing.Size(1050, 246);
            this.currentPlayerControl1.TabIndex = 0;
            // 
            // playedCardsControl1
            // 
            this.playedCardsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playedCardsControl1.Location = new System.Drawing.Point(168, 207);
            this.playedCardsControl1.Name = "playedCardsControl1";
            this.playedCardsControl1.Size = new System.Drawing.Size(763, 198);
            this.playedCardsControl1.TabIndex = 5;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 659);
            this.Controls.Add(this.playedCardsControl1);
            this.Controls.Add(this.nouvellePartie);
            this.Controls.Add(this.otherPlayerControl3);
            this.Controls.Add(this.otherPlayerControl2);
            this.Controls.Add(this.otherPlayerControl1);
            this.Controls.Add(this.currentPlayerControl1);
            this.Name = "MainView";
            this.Text = "Trou de Cul";
            this.ResumeLayout(false);

        }

        #endregion

        private CurrentPlayerControl currentPlayerControl1;
        private OtherPlayerControl otherPlayerControl1;
        private OtherPlayerControl otherPlayerControl2;
        private OtherPlayerControl otherPlayerControl3;
        private System.Windows.Forms.Button nouvellePartie;
        private PlayedCardsControl playedCardsControl1;
    }
}

