namespace InterfaceDeJeu.View
{
    partial class NouvellePartie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomJoueur1 = new System.Windows.Forms.TextBox();
            this.nomJoueur2 = new System.Windows.Forms.TextBox();
            this.nomJoueur3 = new System.Windows.Forms.TextBox();
            this.nomJoueur4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.butonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joueur 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrez les noms des joueurs";
            // 
            // nomJoueur1
            // 
            this.nomJoueur1.Location = new System.Drawing.Point(116, 64);
            this.nomJoueur1.Name = "nomJoueur1";
            this.nomJoueur1.Size = new System.Drawing.Size(338, 20);
            this.nomJoueur1.TabIndex = 2;
            // 
            // nomJoueur2
            // 
            this.nomJoueur2.Location = new System.Drawing.Point(116, 110);
            this.nomJoueur2.Name = "nomJoueur2";
            this.nomJoueur2.Size = new System.Drawing.Size(338, 20);
            this.nomJoueur2.TabIndex = 3;
            // 
            // nomJoueur3
            // 
            this.nomJoueur3.Location = new System.Drawing.Point(116, 160);
            this.nomJoueur3.Name = "nomJoueur3";
            this.nomJoueur3.Size = new System.Drawing.Size(338, 20);
            this.nomJoueur3.TabIndex = 4;
            // 
            // nomJoueur4
            // 
            this.nomJoueur4.Location = new System.Drawing.Point(116, 211);
            this.nomJoueur4.Name = "nomJoueur4";
            this.nomJoueur4.Size = new System.Drawing.Size(338, 20);
            this.nomJoueur4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Joueur 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Joueur 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Joueur 4:";
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Location = new System.Drawing.Point(378, 277);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(98, 32);
            this.buttonConfirmer.TabIndex = 11;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            // 
            // butonAnnuler
            // 
            this.butonAnnuler.Location = new System.Drawing.Point(275, 277);
            this.butonAnnuler.Name = "butonAnnuler";
            this.butonAnnuler.Size = new System.Drawing.Size(94, 32);
            this.butonAnnuler.TabIndex = 12;
            this.butonAnnuler.Text = "Annuler";
            this.butonAnnuler.UseVisualStyleBackColor = true;
            // 
            // NouvellePartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 316);
            this.Controls.Add(this.butonAnnuler);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomJoueur4);
            this.Controls.Add(this.nomJoueur3);
            this.Controls.Add(this.nomJoueur2);
            this.Controls.Add(this.nomJoueur1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NouvellePartie";
            this.Text = "Nouvelle Partie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomJoueur1;
        private System.Windows.Forms.TextBox nomJoueur2;
        private System.Windows.Forms.TextBox nomJoueur3;
        private System.Windows.Forms.TextBox nomJoueur4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button butonAnnuler;
    }
}