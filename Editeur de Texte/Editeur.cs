using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Editeur_de_Texte
{
    public partial class Editeur : Form
    {
        public Editeur()
        {
            InitializeComponent();
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            texte.Clear();
            texte.Focus();
        }

        private void ouvrir_Click(object sender, EventArgs e)
        {
            if (Ouverture.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(Ouverture.FileName);
                texte.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (Sauvegarde.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(Sauvegarde.FileName);
                sw.Write(texte.Text);
                sw.Close();
            }
        }

        private void enregistrersous_Click(object sender, EventArgs e)
        {
            if (texte.Text != null)
            {
                if (MessageBox.Show("Mon information", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
                {
                    if (Sauvegarde.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sws = new StreamWriter(Sauvegarde.FileName);
                        sws.AutoFlush = true;
                        sws.Write(texte.Text);
                        sws.Flush();
                        sws.Close();
                    }
                }
            }
            
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            texte.Undo();
        }

        private void rétablir_Click(object sender, EventArgs e)
        {
            texte.Redo();
        }

        private void couper_Click(object sender, EventArgs e)
        {
            texte.Cut();
        }

        private void copier_Click(object sender, EventArgs e)
        {
            texte.Copy();
        }

        private void coller_Click(object sender, EventArgs e)
        {
            texte.Paste();
        }

        private void sélectionnertout_Click(object sender, EventArgs e)
        {
            texte.SelectAll();
        }

        private void police_Click(object sender, EventArgs e)
        {
            if (Font.ShowDialog() == DialogResult.OK)
            {
                texte.SelectionFont = Font.Font;
                ;
            }
        }

        private void couleurdetexte_Click(object sender, EventArgs e)
        {
            if (Couleur.ShowDialog() == DialogResult.OK)
            {
                texte.SelectionColor = Couleur.Color;
            }
        }

    }
}
