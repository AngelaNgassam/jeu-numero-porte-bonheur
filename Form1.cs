using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace jeunumeroporte_bonheur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region entrer la date
        private void btnCalculer_Click(object sender, EventArgs e)
        {
            string dateNaissanceString = txt_date.Text;
            
            int numeroPorteBonheur;
            int num = 0;
            //determiner la valeur de "num" en fonction de l'etat civil selectionner
            if (radioCelibataire.Checked)
            {
                num = 3;
            }
            else if (radioMarie.Checked)
            {
                num = 2;
            }
            else if (radioDivorce.Checked)
            {
                num = 1;
            }
            else
            {
                MessageBox.Show("choisiser un statut");
            }

            DateTime dateNaissance;
            if (DateTime.TryParseExact(dateNaissanceString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateNaissance))
            {
                int jour = dateNaissance.Day;
                int mois = dateNaissance.Month;
                //calculer le numero porte bonheur
                numeroPorteBonheur = (jour * 2 + mois * 3 + num * 5) % 100;
                //afficher le numero porte bonheur dans la boite de dialogue 
                MessageBox.Show("Votre numero porte-bonheur est :" + numeroPorteBonheur, "Resultat du calcul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez saisir une date de naissance valide au format jj/MM/aaaa.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            #endregion

        }

        #region changer la couleur
        private void btnChanger_Click(object sender, EventArgs e)
        {
            //creer une boite de dialogue pour choisir la premiere couleur
            ColorDialog ColorDialog1 = new ColorDialog();
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Creer une boite de dialogue pour choisir la deuxieme couleur
               
                ColorDialog colorDialog2 = new ColorDialog();
                if (colorDialog2.ShowDialog() == DialogResult.OK)
                {

                    //appliquer un effet de degrade vertical
                    LinearGradientBrush LinearGradientBrush = new LinearGradientBrush(this.ClientRectangle, ColorDialog1.Color, colorDialog2.Color, 90F);
                    Graphics g = this.CreateGraphics();
                    g.FillRectangle(LinearGradientBrush, this.ClientRectangle);
                }
            }
            #endregion
        }
    }
}
