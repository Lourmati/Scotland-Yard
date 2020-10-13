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
    public partial class Fin : Form
    {

        FenetreJeu fenetreJeu;
        public Fin(FenetreJeu fenetreJeu)
        {
            this.fenetreJeu = fenetreJeu;
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fenetreJeu.NvlPartieItem_Click(sender, e);
            this.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fenetreJeu.QuitterItem_Click(sender, e);
        }
    }
}
