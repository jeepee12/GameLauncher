using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class FormGameTimeCalculator : Form
    {
        EnsembleDesDonnees leJeu;
        //La nouvelle facon de faire pour avoir le sync avec dropbox, c'est de mettre le fichier du logiciel
        //dans le meme dossier que le fichier de sauvegarde directement dans dropbox.
        //Ensuite, faire un racourcis vers la nouvelle version du programme.
        private string nomFichier = @".\\temps.jouer";
        private int jeuSelectionne;


        public FormGameTimeCalculator()
        {
            InitializeComponent();
        }

        private void FormGameTimeCalculator_Load(object sender, EventArgs e)
        {
            jeuSelectionne = (int)listeJeux.SC2;
            int compteur = 0;
            try
            {
                for (int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                    {
                        RadioButton boutton = new RadioButton();
                        boutton.Width = 80;
                        boutton.Height = 80;
                        boutton.Image = imageListIcone.Images[compteur];
                        boutton.Appearance = Appearance.Button;
                        boutton.Margin = new Padding(0, 0, 0, 0);
                        if (compteur == (int)listeJeux.SC2)
                        {
                            boutton.Checked = true;
                        }
                        tableLayoutPanel.Controls.Add(boutton, j, i);
                        compteur++;
                        boutton.Click += new System.EventHandler(Jeu_Click);
                    }
                }
            }
            catch
            {
            }


            BinaryFormatter formateur = new BinaryFormatter();
            try
            {
                Stream flux = new FileStream(nomFichier, FileMode.Open, FileAccess.Read, FileShare.Read);
                leJeu = (EnsembleDesDonnees)formateur.Deserialize(flux);
                flux.Close();
            }
            catch
            {
                leJeu = new EnsembleDesDonnees(compteur);
            }
            btnArret.Enabled = false;
            Actualiser();
        }

        private void Jeu_Click(object sender, EventArgs e)
        {
            SauvegarderNomEtUrl();
            Control jeuCliquer = (Control)sender;
            jeuSelectionne = tableLayoutPanel.GetRow(jeuCliquer) * 10 + tableLayoutPanel.GetColumn(jeuCliquer);
            Actualiser();
        }

        private void FormGameTimeCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sauvegarder();
        }

        private void Actualiser()
        {
            txtNom.Text = leJeu.TabLogiciel[jeuSelectionne].Nom;
            lblNbMinutes.Text = leJeu.TabLogiciel[jeuSelectionne].NbMinutes.ToString();
            lblNbHeures.Text = leJeu.TabLogiciel[jeuSelectionne].NbHeures.ToString();
            lblNbJours.Text = leJeu.TabLogiciel[jeuSelectionne].NbJours.ToString();
            imgJeuSelectionne.Image = imageListIcone.Images[jeuSelectionne];
            txtUrl.Text = leJeu.TabLogiciel[jeuSelectionne].UrlRacourcis;
            Refresh();
        }

        private void SauvegarderNomEtUrl()
        {
            leJeu.TabLogiciel[jeuSelectionne].Nom = txtNom.Text;
            leJeu.TabLogiciel[jeuSelectionne].UrlRacourcis = txtUrl.Text;
        }

        private void Minuterie_Tick(object sender, EventArgs e)
        {
            leJeu.TabLogiciel[jeuSelectionne].NbMinutes++;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Sauvegarder();
        }


        private void Sauvegarder()
        {
            SauvegarderNomEtUrl();
            BinaryFormatter formateur = new BinaryFormatter();
            try
            {
                Stream flux = new FileStream(nomFichier, FileMode.OpenOrCreate);
                formateur.Serialize(flux, leJeu);
                flux.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de sauvegarde!!!");
            }
            Actualiser();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            bool gameFailedTolaunch = false;
            try
            {
                System.Diagnostics.Process.Start(leJeu.TabLogiciel[jeuSelectionne].UrlRacourcis);
            }
            catch (Exception ex)
            {
                gameFailedTolaunch = true;
                MessageBox.Show("Incable de lancer le jeu!!! Erreur:" + ex.Message);
            }
            if (!gameFailedTolaunch)
            {
                for (int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                    {
                        RadioButton boutton = (RadioButton)tableLayoutPanel.GetControlFromPosition(j, i);
                        if (boutton != null)
                        {
                            boutton.Enabled = false;
                        }
                    }
                }
                Minuterie.Enabled = true;
                btnArret.Enabled = true;
                btnJouer.Enabled = false;
                Actualiser();
            }
        }

        private void btnArret_Click(object sender, EventArgs e)
        {
            //Si ça crash sur un boutton remettre un try catch sur la boucle(c'est pas propre mais ça marche)
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    RadioButton boutton = (RadioButton)tableLayoutPanel.GetControlFromPosition(j, i);
                    if (boutton != null)
                    {
                        boutton.Enabled = true;
                    }
                }
            }

            Minuterie.Enabled = false;
            btnArret.Enabled = false;
            btnJouer.Enabled = true;
            Actualiser();
        }

        private void btnChangerUrl_Click(object sender, EventArgs e)
        {
            SauvegarderNomEtUrl();
        }

        private void btnChangerNom_Click(object sender, EventArgs e)
        {
            SauvegarderNomEtUrl();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sauvegarder();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnQuitter.PerformClick();
        }
    }
}
