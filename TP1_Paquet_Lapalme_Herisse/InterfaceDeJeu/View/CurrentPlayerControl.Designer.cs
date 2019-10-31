namespace InterfaceDeJeu.View
{
    partial class CurrentPlayerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentPlayerControl));
            this.buttonProchainJoueur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.card1 = new System.Windows.Forms.Label();
            this.positionJoueur = new System.Windows.Forms.Label();
            this.nomJoueur = new System.Windows.Forms.Label();
            this.buttonResetMain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProchainJoueur
            // 
            this.buttonProchainJoueur.Location = new System.Drawing.Point(883, 177);
            this.buttonProchainJoueur.Name = "buttonProchainJoueur";
            this.buttonProchainJoueur.Size = new System.Drawing.Size(151, 51);
            this.buttonProchainJoueur.TabIndex = 0;
            this.buttonProchainJoueur.Text = "Prochain joueur";
            this.buttonProchainJoueur.UseVisualStyleBackColor = true;
            this.buttonProchainJoueur.Click += new System.EventHandler(this.ButtonProchainJoueur_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.card1);
            this.panel1.Location = new System.Drawing.Point(140, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 231);
            this.panel1.TabIndex = 1;
            // 
            // card1
            // 
            this.card1.Image = ((System.Drawing.Image)(resources.GetObject("card1.Image")));
            this.card1.Location = new System.Drawing.Point(17, 23);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(125, 171);
            this.card1.TabIndex = 0;
            // 
            // positionJoueur
            // 
            this.positionJoueur.AutoSize = true;
            this.positionJoueur.Location = new System.Drawing.Point(3, 120);
            this.positionJoueur.Name = "positionJoueur";
            this.positionJoueur.Size = new System.Drawing.Size(137, 13);
            this.positionJoueur.TabIndex = 2;
            this.positionJoueur.Text = "Placeholder position joueur ";
            // 
            // nomJoueur
            // 
            this.nomJoueur.AutoSize = true;
            this.nomJoueur.Location = new System.Drawing.Point(6, 85);
            this.nomJoueur.Name = "nomJoueur";
            this.nomJoueur.Size = new System.Drawing.Size(118, 13);
            this.nomJoueur.TabIndex = 3;
            this.nomJoueur.Text = "Placeholder nom joueur";
            // 
            // buttonResetMain
            // 
            this.buttonResetMain.Location = new System.Drawing.Point(883, 110);
            this.buttonResetMain.Name = "buttonResetMain";
            this.buttonResetMain.Size = new System.Drawing.Size(151, 51);
            this.buttonResetMain.TabIndex = 4;
            this.buttonResetMain.Text = "Réinitialiser main";
            this.buttonResetMain.UseVisualStyleBackColor = true;
            this.buttonResetMain.Click += new System.EventHandler(this.ButtonResetMain_Click);
            // 
            // CurrentPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonResetMain);
            this.Controls.Add(this.nomJoueur);
            this.Controls.Add(this.positionJoueur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonProchainJoueur);
            this.Name = "CurrentPlayerControl";
            this.Size = new System.Drawing.Size(1050, 246);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProchainJoueur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label positionJoueur;
        private System.Windows.Forms.Label nomJoueur;
        private System.Windows.Forms.Label card1;
        private System.Windows.Forms.Button buttonResetMain;
    }
}
