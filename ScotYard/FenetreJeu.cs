using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScotYard.Graphe;
using System.Diagnostics;
using ScotAI;
using System.Threading;

namespace ScotYard
{

    /// <summary>
    /// Class FenetreJeu qui contient les différents composantes de la fenetre et la plupart des méthodes du jeu
    /// </summary>
    public partial class FenetreJeu : Form
    {

        // Variables dont j'aurai besoin
        public List<Button> _listeBoutons = new List<Button>();
        static Random rnd = new Random();
        int tourDetective = 0;
        int tourJeu = 1;
        bool repetable = true;
        string transportSelectionne;
        bool bloque = false;

        // Création des 3 détectives
        public Detective Detective1;
        public Detective Detective2;
        public Detective Detective3;
        public List<Detective> listeDetective;

        public List<Panel> listePnl = new List<Panel>();
        public List<Panel> listeDetectivePnl = new List<Panel>();

        //Création Mister X
        public Voleur MisterX;
        Transports? transportChoisi = null;
        bool? utiliseBlackTicket = null;

        /// <summary>
        /// Constructeur de la fenêtre
        /// </summary>
        public FenetreJeu()
        {
            InitializeComponent();
            InitialiserBoutons();
            Graphe.Case.CreerCases();
            initialisationDetectives();
            tourMisterX();
            Partie();
        }

        /// <summary>
        /// Insertion des boutons dans une liste
        /// </summary>
        private void InitialiserBoutons()
        {
            _listeBoutons.Add(new Button()); // Bouton bidon
            _listeBoutons.Add(btn1);
            _listeBoutons.Add(btn2);
            _listeBoutons.Add(btn3);
            _listeBoutons.Add(btn4);
            _listeBoutons.Add(btn5);
            _listeBoutons.Add(btn6);
            _listeBoutons.Add(btn7);
            _listeBoutons.Add(btn8);
            _listeBoutons.Add(btn9);
            _listeBoutons.Add(btn10);
            _listeBoutons.Add(btn11);
            _listeBoutons.Add(btn12);
            _listeBoutons.Add(btn13);
            _listeBoutons.Add(btn14);
            _listeBoutons.Add(btn15);
            _listeBoutons.Add(btn16);
            _listeBoutons.Add(btn17);
            _listeBoutons.Add(btn18);
            _listeBoutons.Add(btn19);
            _listeBoutons.Add(btn20);
            _listeBoutons.Add(btn21);
            _listeBoutons.Add(btn22);
            _listeBoutons.Add(btn23);
            _listeBoutons.Add(btn24);
            _listeBoutons.Add(btn25);
            _listeBoutons.Add(btn26);
            _listeBoutons.Add(btn27);
            _listeBoutons.Add(btn28);
            _listeBoutons.Add(btn29);
            _listeBoutons.Add(btn30);
            _listeBoutons.Add(btn31);
            _listeBoutons.Add(btn32);
            _listeBoutons.Add(btn33);
            _listeBoutons.Add(btn34);
            _listeBoutons.Add(btn35);
            _listeBoutons.Add(btn36);
            _listeBoutons.Add(btn37);
            _listeBoutons.Add(btn38);
            _listeBoutons.Add(btn39);
            _listeBoutons.Add(btn40);
            _listeBoutons.Add(btn41);
            _listeBoutons.Add(btn42);
            _listeBoutons.Add(btn43);
            _listeBoutons.Add(btn44);
            _listeBoutons.Add(btn45);
            _listeBoutons.Add(btn46);
            _listeBoutons.Add(btn47);
            _listeBoutons.Add(btn48);
            _listeBoutons.Add(btn49);
            _listeBoutons.Add(btn50);
            _listeBoutons.Add(btn51);
            _listeBoutons.Add(btn52);
            _listeBoutons.Add(btn53);
            _listeBoutons.Add(btn54);
            _listeBoutons.Add(btn55);
            _listeBoutons.Add(btn56);
            _listeBoutons.Add(btn57);
            _listeBoutons.Add(btn58);
            _listeBoutons.Add(btn59);
            _listeBoutons.Add(btn60);
            _listeBoutons.Add(btn61);
            _listeBoutons.Add(btn62);
            _listeBoutons.Add(btn63);
            _listeBoutons.Add(btn64);
            _listeBoutons.Add(btn65);
            _listeBoutons.Add(btn66);
            _listeBoutons.Add(btn67);
            _listeBoutons.Add(btn68);
            _listeBoutons.Add(btn69);
            _listeBoutons.Add(btn70);
            _listeBoutons.Add(btn71);
            _listeBoutons.Add(btn72);
            _listeBoutons.Add(btn73);
            _listeBoutons.Add(btn74);
            _listeBoutons.Add(btn75);
            _listeBoutons.Add(btn76);
            _listeBoutons.Add(btn77);
            _listeBoutons.Add(btn78);
            _listeBoutons.Add(btn79);
            _listeBoutons.Add(btn80);
            _listeBoutons.Add(btn81);
            _listeBoutons.Add(btn82);
            _listeBoutons.Add(btn83);
            _listeBoutons.Add(btn84);
            _listeBoutons.Add(btn85);
            _listeBoutons.Add(btn86);
            _listeBoutons.Add(btn87);
            _listeBoutons.Add(btn88);
            _listeBoutons.Add(btn89);
            _listeBoutons.Add(btn90);
            _listeBoutons.Add(btn91);
            _listeBoutons.Add(btn92);
            _listeBoutons.Add(btn93);
            _listeBoutons.Add(btn94);
            _listeBoutons.Add(btn95);
            _listeBoutons.Add(btn96);
            _listeBoutons.Add(btn97);
            _listeBoutons.Add(btn98);
            _listeBoutons.Add(btn99);
            _listeBoutons.Add(btn100);
            _listeBoutons.Add(btn101);
            _listeBoutons.Add(btn102);
            _listeBoutons.Add(btn103);
            _listeBoutons.Add(btn104);
            _listeBoutons.Add(btn105);
            _listeBoutons.Add(btn106);
            _listeBoutons.Add(btn107);
            _listeBoutons.Add(btn108);
            _listeBoutons.Add(btn109);
            _listeBoutons.Add(btn110);
            _listeBoutons.Add(btn111);
            _listeBoutons.Add(btn112);
            _listeBoutons.Add(btn113);
            _listeBoutons.Add(btn114);
            _listeBoutons.Add(btn115);
            _listeBoutons.Add(btn116);
            _listeBoutons.Add(btn117);
            _listeBoutons.Add(btn118);
            _listeBoutons.Add(btn119);
            _listeBoutons.Add(btn120);
            _listeBoutons.Add(btn121);
            _listeBoutons.Add(btn122);
            _listeBoutons.Add(btn123);
            _listeBoutons.Add(btn124);
            _listeBoutons.Add(btn125);
            _listeBoutons.Add(btn126);
            _listeBoutons.Add(btn127);
            _listeBoutons.Add(btn128);
            _listeBoutons.Add(btn129);
            _listeBoutons.Add(btn130);
            _listeBoutons.Add(btn131);
            _listeBoutons.Add(btn132);
            _listeBoutons.Add(btn133);
            _listeBoutons.Add(btn134);
            _listeBoutons.Add(btn135);
            _listeBoutons.Add(btn136);
            _listeBoutons.Add(btn137);
            _listeBoutons.Add(btn138);
            _listeBoutons.Add(btn139);
            _listeBoutons.Add(btn140);
            _listeBoutons.Add(btn141);
            _listeBoutons.Add(btn142);
            _listeBoutons.Add(btn143);
            _listeBoutons.Add(btn144);
            _listeBoutons.Add(btn145);
            _listeBoutons.Add(btn146);
            _listeBoutons.Add(btn147);
            _listeBoutons.Add(btn148);
            _listeBoutons.Add(btn149);
            _listeBoutons.Add(btn150);
            _listeBoutons.Add(btn151);
            _listeBoutons.Add(btn152);
            _listeBoutons.Add(btn153);
            _listeBoutons.Add(btn154);
            _listeBoutons.Add(btn155);
            _listeBoutons.Add(btn156);
            _listeBoutons.Add(btn157);
            _listeBoutons.Add(btn158);
            _listeBoutons.Add(btn159);
            _listeBoutons.Add(btn160);
            _listeBoutons.Add(btn161);
            _listeBoutons.Add(btn162);
            _listeBoutons.Add(btn163);
            _listeBoutons.Add(btn164);
            _listeBoutons.Add(btn165);
            _listeBoutons.Add(btn166);
            _listeBoutons.Add(btn167);
            _listeBoutons.Add(btn168);
            _listeBoutons.Add(btn169);
            _listeBoutons.Add(btn170);
            _listeBoutons.Add(btn171);
            _listeBoutons.Add(btn172);
            _listeBoutons.Add(btn173);
            _listeBoutons.Add(btn174);
            _listeBoutons.Add(btn175);
            _listeBoutons.Add(btn176);
            _listeBoutons.Add(btn177);
            _listeBoutons.Add(btn178);
            _listeBoutons.Add(btn179);
            _listeBoutons.Add(btn180);
            _listeBoutons.Add(btn181);
            _listeBoutons.Add(btn182);
            _listeBoutons.Add(btn183);
            _listeBoutons.Add(btn184);
            _listeBoutons.Add(btn185);
            _listeBoutons.Add(btn186);
            _listeBoutons.Add(btn187);
            _listeBoutons.Add(btn188);
            _listeBoutons.Add(btn189);
            _listeBoutons.Add(btn190);
            _listeBoutons.Add(btn191);
            _listeBoutons.Add(btn192);
            _listeBoutons.Add(btn193);
            _listeBoutons.Add(btn194);
            _listeBoutons.Add(btn195);
            _listeBoutons.Add(btn196);
            _listeBoutons.Add(btn197);
            _listeBoutons.Add(btn198);
            _listeBoutons.Add(btn199);

            //Ajouter le meme event pour tout les boutons de la liste
            for (int i = 0; i < _listeBoutons.Count; i++)
            {
                _listeBoutons[i].Click += btn_Click;
            }
        }

        /// <summary>
        /// Fenetre à propos (nom et date de remise)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oussama Lourhmati 18 mars 2019", "À propos");
        }

        /// <summary>
        /// Fenetre options pour changer le nom et la couleur des détectives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ouverture d'une fenetre existante de la classe FenetreOptions
            FenetreOptions FrmOptions = new FenetreOptions(this);
            FrmOptions.ShowDialog();
        }

        /// <summary>
        /// Ouverture du fichier pdf (règles du jeu) lors du clique sur aide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuAide_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("aide.pdf");
        }

        /// <summary>
        /// Quitter la fenetre de jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void QuitterItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Nouvelle Partie (création d'une nouvelle fenetre de jeu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NvlPartieItem_Click(object sender, EventArgs e)
        {
            //FenetreJeu NouvelleFenetre = new FenetreJeu();
            //this.Close();
            //NouvelleFenetre.ShowDialog();

            for (int i = 0; i < _listeBoutons.Count; i++)
            {
                _listeBoutons[i].BackColor = SystemColors.Control;
                _listeBoutons[i].Enabled = true;
            }

            for (int i = 0; i < listePnl.Count; i++)
            {
                listePnl[i].BackgroundImage = null;
            }

            tourDetective = 0;
            tourJeu = 1;
            LblTour.Text = "Tour: " + tourJeu + "/22";
            initialisationDetectives();
            tourMisterX();
            Partie();

        }

        /// <summary>
        /// 
        /// </summary>
        private void tourMisterX()
        {
            MisterX.position = ScotAI.Case.ProchaineCaseVoleur(repetable, MisterX.position, MisterX.TicketTaxi, MisterX.TicketBus, MisterX.TicketMetro, MisterX.TicketBlack, out transportChoisi, out utiliseBlackTicket, Detective1.position, Detective2.position, Detective3.position);

            if (tourJeu == 3 || tourJeu == 8 || tourJeu == 13 || tourJeu == 22)
            {
                //Animation avec MisterX.position
                timerMisterX.Start();
            }
            else
            {
                timerMisterX.Stop();
            }

            if (transportChoisi == Transports.Taxi)
            {
                MisterX.TicketTaxi--;
                listePnl[tourJeu - 1].BackgroundImage = BtnTaxi1.BackgroundImage;
                listePnl[tourJeu - 1].BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (transportChoisi == Transports.Bus)
            {
                MisterX.TicketBus--;
                listePnl[tourJeu - 1].BackgroundImage = BtnBus1.BackgroundImage;
                listePnl[tourJeu - 1].BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (transportChoisi == Transports.Metro)
            {
                MisterX.TicketMetro--;
                listePnl[tourJeu - 1].BackgroundImage = BtnMetro1.BackgroundImage;
                listePnl[tourJeu - 1].BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (transportChoisi == Transports.Bateau)
            {
                MisterX.TicketBlack--;
                LblBlack.Text = "x" + MisterX.TicketBlack;
                listePnl[tourJeu - 1].BackgroundImage = BtnBlack.BackgroundImage;
                listePnl[tourJeu - 1].BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (utiliseBlackTicket == true)
            {
                MisterX.TicketBlack--;
                LblBlack.Text = "x" + MisterX.TicketBlack;
                listePnl[tourJeu - 1].BackgroundImage = BtnBlack.BackgroundImage;
                listePnl[tourJeu - 1].BackgroundImageLayout = ImageLayout.Stretch;

            }
        }


        /// <summary>
        /// Repérer les cases où le détective peut se déplacer avec un taxi
        /// </summary>
        /// <param name="numDetective"></param>
        /// <returns></returns>
        public List<int> repererCheminsTaxi(int numDetective)
        {
            List<int> listeCaseTaxis = new List<int>();


            for (int i = 0; i < Graphe.Case.ListeCases[numDetective].ListeTaxis.Count; i++)
            {
                //Si un détective se trouve déjà à la case, ne pas ajouter la position dans la listeCaseTaxis
                if (Graphe.Case.ListeCases[numDetective].ListeTaxis[i].Numero != Detective1.position
                    && Graphe.Case.ListeCases[numDetective].ListeTaxis[i].Numero != Detective2.position
                    && Graphe.Case.ListeCases[numDetective].ListeTaxis[i].Numero != Detective3.position)
                {
                    listeCaseTaxis.Add(Graphe.Case.ListeCases[numDetective].ListeTaxis[i].Numero);
                }

            }

            //retourne la listeCaseTaxis contenant tout les cases accessibles par taxi
            return listeCaseTaxis;
        }

        /// <summary>
        /// Repérer les cases où le détective peut se déplacer avec un bus
        /// </summary>
        /// <param name="numDetective"></param>
        /// <returns></returns>
        public List<int> repererCheminsBus(int numDetective)
        {
            List<int> listeCaseBus = new List<int>();


            for (int i = 0; i < Graphe.Case.ListeCases[numDetective].ListeBus.Count; i++)
            {
                if (Graphe.Case.ListeCases[numDetective].ListeBus[i].Numero != Detective1.position
                    && Graphe.Case.ListeCases[numDetective].ListeBus[i].Numero != Detective2.position
                    && Graphe.Case.ListeCases[numDetective].ListeBus[i].Numero != Detective3.position)
                {
                    listeCaseBus.Add(Graphe.Case.ListeCases[numDetective].ListeBus[i].Numero);
                }

            }
            return listeCaseBus;
        }

        /// <summary>
        /// Repérer les cases où le détective peut se déplacer avec un métro
        /// </summary>
        /// <param name="numDetective"></param>
        /// <returns></returns>
        public List<int> repererCheminsMetro(int numDetective)
        {
            List<int> listeCaseMetros = new List<int>();
            for (int i = 0; i < Graphe.Case.ListeCases[numDetective].ListeMetros.Count; i++)
            {
                if (Graphe.Case.ListeCases[numDetective].ListeMetros[i].Numero != Detective1.position
                    && Graphe.Case.ListeCases[numDetective].ListeMetros[i].Numero != Detective2.position
                    && Graphe.Case.ListeCases[numDetective].ListeMetros[i].Numero != Detective3.position)
                {
                    listeCaseMetros.Add(Graphe.Case.ListeCases[numDetective].ListeMetros[i].Numero);
                }

            }
            return listeCaseMetros;
        }

        /// <summary>
        /// Évenement clique de chaque bouton (case, position) de la carte de jeu (déplacement du pion)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            int buttonNumero = Int32.Parse(((Button)sender).Text);
            reinitialisationBouton(listeDetective[tourDetective]);

            //Si l'utilisateur a bel est bien choisi un transport, le déplacement peut se produire
            if (transportSelectionne != null)
            {
                deplacement(buttonNumero);
                tourDetective++;//Implémenter le tourDétective, un détective vient de jouer
                timerTransport.Stop();
            }
            else
            {
                MessageBox.Show("Veuillez choisir un moyen de transport!", "Avertissement");
            }

            transportSelectionne = null;
            Partie();//Continuer la partie
        }

        /// <summary>
        /// Méthode du déplacement du pion (couleur) du détective et ajustement de l'environnement
        /// </summary>
        /// <param name="buttonNumero"></param>
        private void deplacement(int buttonNumero)
        {
            _listeBoutons[buttonNumero].BackColor = _listeBoutons[listeDetective[tourDetective].position].BackColor;
            _listeBoutons[listeDetective[tourDetective].position].BackColor = SystemColors.Control;
            listeDetective[tourDetective].position = buttonNumero;
            LblTitre1.Text = "Scotland Yard";
            decrementer();
        }


        /// <summary>
        /// Decrémenter le nombre de tickets du détective selon le transport choisi
        /// </summary>
        private void decrementer()
        {
            if (transportSelectionne == "Taxi")
            {
                listeDetective[tourDetective].TicketTaxi--;
                MisterX.TicketTaxi++;
                restaurerLabel();//Mettre à jour les labels sur la table de jeu
            }

            if (transportSelectionne == "Bus")
            {
                listeDetective[tourDetective].TicketBus--;
                MisterX.TicketBus++;
                restaurerLabel();
            }

            if (transportSelectionne == "Metro")
            {
                listeDetective[tourDetective].TicketMetro--;
                MisterX.TicketMetro++;
                restaurerLabel();
            }
        }


        /// <summary>
        /// Méthode de la partie, vérification du tour du détective et du tour du jeu et déplacement 
        /// </summary>
        public void Partie()
        {
            restaurerLabel();
            verificationJeu();

            for (int i = 0; i < listeDetectivePnl.Count; i++)
            {
                if (i == tourDetective)
                {
                    listeDetective[i].pnlDetective.Enabled = true;
                    listeDetective[i].pnlDetective.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    listeDetective[i].pnlDetective.Enabled = false;
                    listeDetective[i].pnlDetective.BorderStyle = BorderStyle.None;
                }

            }

            verificationTicket(listeDetective[tourDetective]);
            verifierMoyenTransport(listeDetective[tourDetective]);
            verificationBloque();

        }

        /// <summary>
        /// Vérifier si le détective en jeu est bloqué, il faut passer au prochain si c'est la cas
        /// </summary>
        private void verificationBloque()
        {
            if (listeDetective[tourDetective].btnBus.Enabled == false && listeDetective[tourDetective].btnTaxi.Enabled == false && listeDetective[tourDetective].btnMetro.Enabled == false)
            {
                listeDetective[tourDetective].bloque = true;
                tourDetective++;
                Partie();
            }
        }

        /// <summary>
        /// Vérification de l'état du jeu, si il y a une défaite et vérifier les tours
        /// </summary>
        private void verificationJeu()
        {

            //Si les 3 détectives ont joué leurs tours respectifs, on recommence les tours des détectives et Mister X joue
            if (tourDetective > 2)
            {
                tourJeu++;//Implémtenter le nombre de tours de jeu
                LblTour.Text = "Tour: " + tourJeu.ToString() + "/22";

                //Mister X joue son tour
                _listeBoutons[MisterX.position].BackColor = SystemColors.Control;
                _listeBoutons[MisterX.position].Size = new Size(28, 20);
                tourMisterX();
                tourDetective = 0;
            }

            //Vérifier si victoire
            if (Detective1.position == MisterX.position || Detective2.position == MisterX.position || Detective3.position == MisterX.position)
            {
                Fin FrmFin = new Fin(this);
                FrmFin.LblMessage.Text = "Vous avez gagné!";
                FrmFin.ShowDialog();
            }

            //Vérifier si défaite
            if (tourJeu == 22)
            {
                Fin FrmFin = new Fin(this);
                FrmFin.LblMessage.Text = "Vous avez perdu!";
                FrmFin.ShowDialog();
            }

            //Si les trois détectives sont bloqués
            if (Detective1.bloque == true && Detective2.bloque == true && Detective3.bloque == true)
            {
                Fin FrmFin = new Fin(this);
                FrmFin.LblMessage.Text = "Vous avez perdu!";
                FrmFin.ShowDialog();
            }

        }


        /// <summary>
        /// Initialisation des boutons, des tickets, des positions et des couleurs de chaque détective et de Mister X
        /// </summary>
        private void initialisationDetectives()
        {
            //Initialiser détective
            Detective1 = new Detective(BtnTaxi1, BtnBus1, BtnMetro1, 10, 8, 4, PnlDetective1);
            Detective2 = new Detective(BtnTaxi2, BtnBus2, BtnMetro2, 10, 8, 4, PnlDetective2);
            Detective3 = new Detective(BtnTaxi3, BtnBus3, BtnMetro3, 10, 8, 4, PnlDetective3);
            listeDetective = new List<Detective>(new Detective[] { Detective1, Detective2, Detective3 });

            Detective1.bloque = false;
            Detective2.bloque = false;
            Detective3.bloque = false;

            //Initialiser la liste des panels (tours) du parcours de Mister X
            listePnl = new Panel[] { Pnl1, Pnl2, Pnl3, Pnl4, Pnl5, Pnl6, Pnl7, Pnl8, Pnl9, Pnl10, Pnl11, Pnl12, Pnl13, Pnl14, Pnl15, Pnl16, Pnl17, Pnl18, Pnl19, Pnl20, Pnl21, Pnl22 }.ToList();

            //Initialiser liste des panels des détective
            listeDetectivePnl = new Panel[] { PnlDetective1, PnlDetective2, PnlDetective3 }.ToList();

            //Initialiser les positions
            List<int> antiDoublons = new List<int>();
            for (int i = 0; i < listeDetective.Count; i++)
            {
                listeDetective[i].position = rnd.Next(1, 199);
                while (antiDoublons.Contains(listeDetective[i].position))
                {
                    listeDetective[i].position = rnd.Next(1, 199);
                }
                antiDoublons.Add(listeDetective[i].position);
            }

            //Initialiser les couleurs des détectives sur la carte de jeu
            _listeBoutons[Detective1.position].BackColor = PicDetective1.BackColor;
            _listeBoutons[Detective2.position].BackColor = PicDetective2.BackColor;
            _listeBoutons[Detective3.position].BackColor = PicDetective3.BackColor;

            //Initialiser les paramètres de Mister X

            MisterX = new Voleur(4, 3, 3, 3);
            MisterX.position = rnd.Next(1, 199);
            while (MisterX.position == Detective1.position || MisterX.position == Detective2.position || MisterX.position == Detective3.position)
            {
                MisterX.position = rnd.Next(1, 199);
            }
        }

        /// <summary>
        /// Vérifier si tout les moyen de transport sont accessibles pour le déplacement du détective
        /// </summary>
        /// <param name="detective"></param>
        private void verifierMoyenTransport(Detective detective)
        {
            List<int> listeCaseTaxis = repererCheminsTaxi(detective.position);
            List<int> listeCaseBus = repererCheminsBus(detective.position);
            List<int> listeCaseMetros = repererCheminsMetro(detective.position);


            for (int i = 0; i < _listeBoutons.Count; i++)
            {
                _listeBoutons[i].Enabled = false;
            }

            //Verifier pour chaque transport s'il y a 0 chemins accessibles
            if (listeCaseTaxis.Count == 0)
            {
                //S'il y a 0 cases accessibles par taxi, désactivation du bouton taxi
                detective.btnTaxi.Enabled = false;
            }
            if (listeCaseBus.Count == 0)
            {
                detective.btnBus.Enabled = false;
            }
            if (listeCaseMetros.Count == 0)
            {
                detective.btnMetro.Enabled = false;
            }

            LblTitre1.Text = "Choisis le transport";
        }


        /// <summary>
        /// Évenement lorsque l'utilisateur choisi un moyen de transport (bouton)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTransport_Click(object sender, EventArgs e)
        {
            Button btnClique = (Button)sender;
            Detective detective = listeDetective[tourDetective];
            List<int> listeCaseBus = repererCheminsBus(detective.position);
            List<int> listeCaseTaxis = repererCheminsTaxi(detective.position);
            List<int> listeCaseMetros = repererCheminsMetro(detective.position);
            reinitialisationBouton(detective);

            for (int i = 0; i < _listeBoutons.Count; i++)
            {
                _listeBoutons[i].Enabled = false;
            }

            //Si l'utilisateur a cliqué sur le bouton taxi (utilisation du tag)
            if (btnClique.Tag.Equals("Taxi"))
            {
                transportSelectionne = "Taxi";
                //Activer les boutons accessibles par taxi
                for (int i = 0; i < listeCaseTaxis.Count; i++)
                {
                    _listeBoutons[listeCaseTaxis[i]].Enabled = true;
                }
                timerTransport.Start();
            }

            if (btnClique.Tag.Equals("Bus"))
            {
                transportSelectionne = "Bus";
                for (int i = 0; i < listeCaseBus.Count; i++)
                {
                    _listeBoutons[listeCaseBus[i]].Enabled = true;
                }
                timerTransport.Start();
            }

            if (btnClique.Tag.Equals("Metro"))
            {
                transportSelectionne = "Metro";
                for (int i = 0; i < listeCaseMetros.Count; i++)
                {
                    _listeBoutons[listeCaseMetros[i]].Enabled = true;
                }
                timerTransport.Start();
            }

        }

        /// <summary>
        /// Méthode pour remettre les boutons à leurs couleurs et tailles normales après l'animation 
        /// </summary>
        /// <param name="detective"></param>
        private void reinitialisationBouton(Detective detective)
        {
            if (transportSelectionne == "Taxi")
            {
                for (int i = 0; i < repererCheminsTaxi(detective.position).Count; i++)
                {
                    _listeBoutons[repererCheminsTaxi(detective.position)[i]].BackColor = SystemColors.Control;
                    _listeBoutons[repererCheminsTaxi(detective.position)[i]].Size = new Size(28, 20);
                }
            }

            if (transportSelectionne == "Bus")
            {
                for (int i = 0; i < repererCheminsBus(detective.position).Count; i++)
                {
                    _listeBoutons[repererCheminsBus(detective.position)[i]].BackColor = SystemColors.Control;
                    _listeBoutons[repererCheminsBus(detective.position)[i]].Size = new Size(28, 20);
                }
            }

            if (transportSelectionne == "Metro")
            {
                for (int i = 0; i < repererCheminsMetro(detective.position).Count; i++)
                {
                    _listeBoutons[repererCheminsMetro(detective.position)[i]].BackColor = SystemColors.Control;
                    _listeBoutons[repererCheminsMetro(detective.position)[i]].Size = new Size(28, 20);
                }
            }
        }

        /// <summary>
        /// Vérifier le nombre de ticket
        /// </summary>
        /// <param name="detective"></param>
        private void verificationTicket(Detective detective)
        {
            detective.btnTaxi.Enabled = true;
            detective.btnBus.Enabled = true;
            detective.btnMetro.Enabled = true;

            //Lorsque le détective utilise tout ses tickets pour un moyen, il ne peut plus utiliser le moyen
            if (detective.TicketBus <= 0)
            {
                detective.btnBus.Enabled = false;
            }

            if (detective.TicketTaxi <= 0)
            {
                detective.btnTaxi.Enabled = false;
            }

            if (detective.TicketMetro <= 0)
            {
                detective.btnMetro.Enabled = false;
            }
        }

        /// <summary>
        /// Mettre à jour les différents labels sur la table de jeu (nombre de cartes restant pour chaque transport)
        /// </summary>
        private void restaurerLabel()
        {
            //Labels pour le nombre de tickets taxi
            LblTaxi1.Text = "x" + Detective1.TicketTaxi;
            LblTaxi2.Text = "x" + Detective2.TicketTaxi;
            LblTaxi3.Text = "x" + Detective3.TicketTaxi;

            //Labels pour le nombre de tickets bus
            LblBus1.Text = "x" + Detective1.TicketBus;
            LblBus2.Text = "x" + Detective2.TicketBus;
            LblBus3.Text = "x" + Detective3.TicketBus;

            //Labels pour le nombre de tickets metro
            LblMetro1.Text = "x" + Detective1.TicketMetro;
            LblMetro2.Text = "x" + Detective2.TicketMetro;
            LblMetro3.Text = "x" + Detective3.TicketMetro;
        }


        /// <summary>
        /// Timer pour montrer Mister X lors du tour 3,8,13 ou 22
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMisterX_Tick(object sender, EventArgs e)
        {
            if (_listeBoutons[MisterX.position].BackColor == SystemColors.Control)
            {
                _listeBoutons[MisterX.position].BackColor = Color.Gray;
                _listeBoutons[MisterX.position].Size = new Size(31, 23);
            }
            else
            {
                _listeBoutons[MisterX.position].BackColor = SystemColors.Control;
                _listeBoutons[MisterX.position].Size = new Size(28, 20);
            }
        }

        private void timerTransport_Tick(object sender, EventArgs e)
        {
            Detective detective = listeDetective[tourDetective];
            if (transportSelectionne.Equals("Taxi"))
            {
                if (_listeBoutons[repererCheminsTaxi(detective.position)[0]].BackColor == SystemColors.Control)
                {
                    for (int i = 0; i < repererCheminsTaxi(detective.position).Count; i++)
                    {
                        _listeBoutons[repererCheminsTaxi(detective.position)[i]].BackColor = Color.Yellow;
                        _listeBoutons[repererCheminsTaxi(detective.position)[i]].Size = new Size(31, 23);
                    }
                }
                else
                {
                    for (int i = 0; i < repererCheminsTaxi(detective.position).Count; i++)
                    {
                        _listeBoutons[repererCheminsTaxi(detective.position)[i]].BackColor = SystemColors.Control;
                        _listeBoutons[repererCheminsTaxi(detective.position)[i]].Size = new Size(28, 20);
                    }
                }
            }

            if (transportSelectionne.Equals("Bus"))
            {
                if (_listeBoutons[repererCheminsBus(detective.position)[0]].BackColor == SystemColors.Control)
                {
                    for (int i = 0; i < repererCheminsBus(detective.position).Count; i++)
                    {
                        _listeBoutons[repererCheminsBus(detective.position)[i]].BackColor = Color.Green;
                        _listeBoutons[repererCheminsBus(detective.position)[i]].Size = new Size(31, 23);
                    }
                }
                else
                {
                    for (int i = 0; i < repererCheminsBus(detective.position).Count; i++)
                    {
                        _listeBoutons[repererCheminsBus(detective.position)[i]].BackColor = SystemColors.Control;
                        _listeBoutons[repererCheminsBus(detective.position)[i]].Size = new Size(28, 20);
                    }
                }
            }

            if (transportSelectionne.Equals("Metro"))
            {
                if (_listeBoutons[repererCheminsMetro(detective.position)[0]].BackColor == SystemColors.Control)
                {
                    for (int i = 0; i < repererCheminsMetro(detective.position).Count; i++)
                    {
                        _listeBoutons[repererCheminsMetro(detective.position)[i]].BackColor = Color.Red;
                        _listeBoutons[repererCheminsMetro(detective.position)[i]].Size = new Size(31, 23);
                    }
                }
                else
                {
                    for (int i = 0; i < repererCheminsMetro(detective.position).Count; i++)
                    {
                        _listeBoutons[repererCheminsMetro(detective.position)[i]].BackColor = SystemColors.Control;
                        _listeBoutons[repererCheminsMetro(detective.position)[i]].Size = new Size(28, 20);
                    }
                }
            }
        }
    }
}


