using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScotYard
{
    public partial class FenetreOptions : Form
    {
        FenetreJeu FenetreJeu;
        public FenetreOptions(FenetreJeu FenetreJeu)
        {
            this.FenetreJeu = FenetreJeu;
            InitializeComponent();
            this.BtnColor1.BackColor = FenetreJeu.PicDetective1.BackColor;
            this.BtnColor2.BackColor = FenetreJeu.PicDetective2.BackColor;
            this.BtnColor3.BackColor = FenetreJeu.PicDetective3.BackColor;
            this.TxtBox1.Text = FenetreJeu.LblDetective1.Text;
            this.TxtBox2.Text = FenetreJeu.LblDetective2.Text;
            this.TxtBox3.Text = FenetreJeu.LblDetective3.Text;
        }

        private void BtnColor1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog Clr = new System.Windows.Forms.ColorDialog();
            if (Clr.ShowDialog() == DialogResult.OK)
            {
                this.BtnColor1.BackColor = Clr.Color;
            }
        }

        private void BtnColor2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog Clr = new System.Windows.Forms.ColorDialog();
            if (Clr.ShowDialog() == DialogResult.OK)
            {
                this.BtnColor2.BackColor = Clr.Color;
            }
        }

        private void BtnColor3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog Clr = new System.Windows.Forms.ColorDialog();
            if (Clr.ShowDialog() == DialogResult.OK)
            {
                this.BtnColor3.BackColor = Clr.Color;
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            FenetreJeu.PicDetective1.BackColor = BtnColor1.BackColor;
            FenetreJeu.PnlDetective1.BackColor = BtnColor1.BackColor;
            FenetreJeu.PicDetective2.BackColor = BtnColor2.BackColor;
            FenetreJeu.PnlDetective2.BackColor = BtnColor2.BackColor;
            FenetreJeu.PicDetective3.BackColor = BtnColor3.BackColor;
            FenetreJeu.PnlDetective3.BackColor = BtnColor3.BackColor;
            FenetreJeu.LblDetective1.Text = TxtBox1.Text;
            FenetreJeu.LblDetective2.Text = TxtBox2.Text;
            FenetreJeu.LblDetective3.Text = TxtBox3.Text;
            FenetreJeu._listeBoutons[FenetreJeu.Detective1.position].BackColor = BtnColor1.BackColor;
            FenetreJeu._listeBoutons[FenetreJeu.Detective2.position].BackColor = BtnColor2.BackColor;
            FenetreJeu._listeBoutons[FenetreJeu.Detective3.position].BackColor = BtnColor3.BackColor;
            this.Close();
        }
    }
}
