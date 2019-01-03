namespace Editeur_de_Texte
{
    partial class Editeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editeur));
            this.texte = new System.Windows.Forms.RichTextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrersous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.aperçuavantimpression = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.edition = new System.Windows.Forms.ToolStripMenuItem();
            this.annuler = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.couper = new System.Windows.Forms.ToolStripMenuItem();
            this.copier = new System.Windows.Forms.ToolStripMenuItem();
            this.coller = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sélectionnertout = new System.Windows.Forms.ToolStripMenuItem();
            this.outils = new System.Windows.Forms.ToolStripMenuItem();
            this.police = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurdetexte = new System.Windows.Forms.ToolStripMenuItem();
            this.aide = new System.Windows.Forms.ToolStripMenuItem();
            this.sommaire = new System.Windows.Forms.ToolStripMenuItem();
            this.index = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.àproposde = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.FontDialog();
            this.Ouverture = new System.Windows.Forms.OpenFileDialog();
            this.Sauvegarde = new System.Windows.Forms.SaveFileDialog();
            this.Appercu = new System.Windows.Forms.PrintPreviewDialog();
            this.Impression = new System.Windows.Forms.PrintDialog();
            this.Couleur = new System.Windows.Forms.ColorDialog();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // texte
            // 
            this.texte.AcceptsTab = true;
            this.texte.BackColor = System.Drawing.Color.White;
            this.texte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texte.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texte.Location = new System.Drawing.Point(0, 24);
            this.texte.Name = "texte";
            this.texte.Size = new System.Drawing.Size(833, 486);
            this.texte.TabIndex = 0;
            this.texte.Text = "";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichier,
            this.edition,
            this.outils,
            this.aide});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(833, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // fichier
            // 
            this.fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveau,
            this.ouvrir,
            this.toolStripSeparator,
            this.enregistrer,
            this.enregistrersous,
            this.toolStripSeparator1,
            this.imprimer,
            this.aperçuavantimpression,
            this.toolStripSeparator2,
            this.quitter});
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(54, 20);
            this.fichier.Text = "&Fichier";
            // 
            // nouveau
            // 
            this.nouveau.Image = ((System.Drawing.Image)(resources.GetObject("nouveau.Image")));
            this.nouveau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveau.Name = "nouveau";
            this.nouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveau.Size = new System.Drawing.Size(205, 22);
            this.nouveau.Text = "&Nouveau";
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // ouvrir
            // 
            this.ouvrir.Image = ((System.Drawing.Image)(resources.GetObject("ouvrir.Image")));
            this.ouvrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrir.Name = "ouvrir";
            this.ouvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrir.Size = new System.Drawing.Size(205, 22);
            this.ouvrir.Text = "&Ouvrir";
            this.ouvrir.Click += new System.EventHandler(this.ouvrir_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
            // 
            // enregistrer
            // 
            this.enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("enregistrer.Image")));
            this.enregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrer.Size = new System.Drawing.Size(205, 22);
            this.enregistrer.Text = "&Enregistrer";
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // enregistrersous
            // 
            this.enregistrersous.Name = "enregistrersous";
            this.enregistrersous.Size = new System.Drawing.Size(205, 22);
            this.enregistrersous.Text = "Enregistrer &sous";
            this.enregistrersous.Click += new System.EventHandler(this.enregistrersous_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // imprimer
            // 
            this.imprimer.Image = ((System.Drawing.Image)(resources.GetObject("imprimer.Image")));
            this.imprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimer.Name = "imprimer";
            this.imprimer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimer.Size = new System.Drawing.Size(205, 22);
            this.imprimer.Text = "&Imprimer";
            // 
            // aperçuavantimpression
            // 
            this.aperçuavantimpression.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpression.Image")));
            this.aperçuavantimpression.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aperçuavantimpression.Name = "aperçuavantimpression";
            this.aperçuavantimpression.Size = new System.Drawing.Size(205, 22);
            this.aperçuavantimpression.Text = "Aperçu a&vant impression";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // quitter
            // 
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(205, 22);
            this.quitter.Text = "&Quitter";
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // edition
            // 
            this.edition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annuler,
            this.rétablir,
            this.toolStripSeparator3,
            this.couper,
            this.copier,
            this.coller,
            this.toolStripSeparator4,
            this.sélectionnertout});
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(56, 20);
            this.edition.Text = "&Edition";
            // 
            // annuler
            // 
            this.annuler.Name = "annuler";
            this.annuler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annuler.Size = new System.Drawing.Size(164, 22);
            this.annuler.Text = "&Annuler";
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // rétablir
            // 
            this.rétablir.Name = "rétablir";
            this.rétablir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rétablir.Size = new System.Drawing.Size(164, 22);
            this.rétablir.Text = "&Rétablir";
            this.rétablir.Click += new System.EventHandler(this.rétablir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // couper
            // 
            this.couper.Image = ((System.Drawing.Image)(resources.GetObject("couper.Image")));
            this.couper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couper.Name = "couper";
            this.couper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couper.Size = new System.Drawing.Size(164, 22);
            this.couper.Text = "&Couper";
            this.couper.Click += new System.EventHandler(this.couper_Click);
            // 
            // copier
            // 
            this.copier.Image = ((System.Drawing.Image)(resources.GetObject("copier.Image")));
            this.copier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copier.Name = "copier";
            this.copier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copier.Size = new System.Drawing.Size(164, 22);
            this.copier.Text = "Co&pier";
            this.copier.Click += new System.EventHandler(this.copier_Click);
            // 
            // coller
            // 
            this.coller.Image = ((System.Drawing.Image)(resources.GetObject("coller.Image")));
            this.coller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.coller.Name = "coller";
            this.coller.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.coller.Size = new System.Drawing.Size(164, 22);
            this.coller.Text = "Co&ller";
            this.coller.Click += new System.EventHandler(this.coller_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // sélectionnertout
            // 
            this.sélectionnertout.Name = "sélectionnertout";
            this.sélectionnertout.Size = new System.Drawing.Size(164, 22);
            this.sélectionnertout.Text = "Sélectio&nner tout";
            this.sélectionnertout.Click += new System.EventHandler(this.sélectionnertout_Click);
            // 
            // outils
            // 
            this.outils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.police,
            this.couleurdetexte});
            this.outils.Name = "outils";
            this.outils.Size = new System.Drawing.Size(50, 20);
            this.outils.Text = "&Outils";
            // 
            // police
            // 
            this.police.Name = "police";
            this.police.Size = new System.Drawing.Size(160, 22);
            this.police.Text = "&Police";
            this.police.Click += new System.EventHandler(this.police_Click);
            // 
            // couleurdetexte
            // 
            this.couleurdetexte.Name = "couleurdetexte";
            this.couleurdetexte.Size = new System.Drawing.Size(160, 22);
            this.couleurdetexte.Text = "&Couleur de texte";
            this.couleurdetexte.Click += new System.EventHandler(this.couleurdetexte_Click);
            // 
            // aide
            // 
            this.aide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaire,
            this.index,
            this.rechercher,
            this.toolStripSeparator5,
            this.àproposde});
            this.aide.Name = "aide";
            this.aide.Size = new System.Drawing.Size(43, 20);
            this.aide.Text = "&Aide";
            // 
            // sommaire
            // 
            this.sommaire.Name = "sommaire";
            this.sommaire.Size = new System.Drawing.Size(147, 22);
            this.sommaire.Text = "&Sommaire";
            // 
            // index
            // 
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(147, 22);
            this.index.Text = "&Index";
            // 
            // rechercher
            // 
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(147, 22);
            this.rechercher.Text = "&Rechercher";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
            // 
            // àproposde
            // 
            this.àproposde.Name = "àproposde";
            this.àproposde.Size = new System.Drawing.Size(147, 22);
            this.àproposde.Text = "À &propos de...";
            // 
            // Ouverture
            // 
            this.Ouverture.Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*";
            this.Ouverture.FilterIndex = 2;
            this.Ouverture.RestoreDirectory = true;
            // 
            // Sauvegarde
            // 
            this.Sauvegarde.Filter = "Fichiers textes *.txt | *.txt";
            this.Sauvegarde.FilterIndex = 2;
            this.Sauvegarde.RestoreDirectory = true;
            // 
            // Appercu
            // 
            this.Appercu.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Appercu.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Appercu.ClientSize = new System.Drawing.Size(400, 300);
            this.Appercu.Enabled = true;
            this.Appercu.Icon = ((System.Drawing.Icon)(resources.GetObject("Appercu.Icon")));
            this.Appercu.Name = "Appercu";
            this.Appercu.Visible = false;
            // 
            // Impression
            // 
            this.Impression.UseEXDialog = true;
            // 
            // Editeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 510);
            this.Controls.Add(this.texte);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Editeur";
            this.Text = "Editeur de texte";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox texte;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.FontDialog Font;
        private System.Windows.Forms.OpenFileDialog Ouverture;
        private System.Windows.Forms.SaveFileDialog Sauvegarde;
        private System.Windows.Forms.PrintPreviewDialog Appercu;
        private System.Windows.Forms.PrintDialog Impression;
        private System.Windows.Forms.ColorDialog Couleur;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem nouveau;
        private System.Windows.Forms.ToolStripMenuItem ouvrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem enregistrer;
        private System.Windows.Forms.ToolStripMenuItem enregistrersous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimer;
        private System.Windows.Forms.ToolStripMenuItem aperçuavantimpression;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitter;
        private System.Windows.Forms.ToolStripMenuItem edition;
        private System.Windows.Forms.ToolStripMenuItem annuler;
        private System.Windows.Forms.ToolStripMenuItem rétablir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem couper;
        private System.Windows.Forms.ToolStripMenuItem copier;
        private System.Windows.Forms.ToolStripMenuItem coller;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sélectionnertout;
        private System.Windows.Forms.ToolStripMenuItem outils;
        private System.Windows.Forms.ToolStripMenuItem police;
        private System.Windows.Forms.ToolStripMenuItem couleurdetexte;
        private System.Windows.Forms.ToolStripMenuItem aide;
        private System.Windows.Forms.ToolStripMenuItem sommaire;
        private System.Windows.Forms.ToolStripMenuItem index;
        private System.Windows.Forms.ToolStripMenuItem rechercher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem àproposde;
    }
}

