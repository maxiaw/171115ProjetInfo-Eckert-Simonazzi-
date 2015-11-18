﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private List<Jour> listeJour=new List<Jour>();
        private Planning planning;
        private int jourPivot;
        private int hauteurPanel;
        private int hauteurBouton;
        private int intervalleBouton;
        private int positionLigne1, positionLigne2, positionLigne3;
        private int nbJourAffichage;
        private int jourActuel;
        private List<Button> ListeBoutons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }


        //Au chargement de la page, on initialise le planning qui contient la liste de jour et propose un premier affichage par défaut.
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Cette boucle implémente 500 jours pour la liste de jour
            for (int i = 0; i <= 499; i++)
            {
                Jour j = new Jour();
                listeJour.Add(j);
            }


            //Initialisation du planning
            DateTime dateDebut = new DateTime (2015, 11, 15, 0,0,0);
            planning = new Planning("Planning de Mars", listeJour, dateDebut);

            jourPivot = 0;

            jourActuel = planning.getJourActuel();


            //Affiche les jours colorés selon leur temporalité
            
            ListeBoutons.Add(boutonJour1);
            ListeBoutons.Add(boutonJour2);
            ListeBoutons.Add(boutonJour3);
            ListeBoutons.Add(boutonJour4);
            ListeBoutons.Add(boutonJour5);
            ListeBoutons.Add(boutonJour6);
            ListeBoutons.Add(boutonJour7);
            ListeBoutons.Add(boutonJour8);
            ListeBoutons.Add(boutonJour9);
            ListeBoutons.Add(boutonJour10);
            ListeBoutons.Add(boutonJour11);
            ListeBoutons.Add(boutonJour12);
            ListeBoutons.Add(boutonJour13);
            ListeBoutons.Add(boutonJour14);
            ListeBoutons.Add(boutonJour15);
            ListeBoutons.Add(boutonJour16);
            ListeBoutons.Add(boutonJour17);
            ListeBoutons.Add(boutonJour18);
            ListeBoutons.Add(boutonJour19);
            ListeBoutons.Add(boutonJour20);
            ListeBoutons.Add(boutonJour21);

            //Affichage des jours, par défaut : 7 jours.
            afficherJour(jourPivot);
            affichage7Jours.PerformClick();

        }
        
        public void coloriseBouton()
        {
            foreach (Button b in ListeBoutons)
            {

                int JourBouton = int.Parse(b.Text);
                if (JourBouton == jourActuel)
                {
                    b.BackColor = Color.Blue;
                }
                else if (JourBouton < jourActuel)
                {
                    b.BackColor = Color.Gray;
                }
                else
                {
                    b.BackColor = Color.Green;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


           

        }

        public void affichageNiveau2(int tmpIdJour)
        {
            Form2 Niveau2=new Form2 ();
            Niveau2.Show();

        }

        /* Récupère le numéros des jours à partir du paramètre numJour et les affiche dans les boutons. 
        Elle prend en deuxième paramètre le nombre de jour à afficher par page.*/
        public void afficherJour(int  numJour)
        {
            
                boutonJour1.Text = planning.getJourParId(numJour).GetidJour.ToString();
                boutonJour2.Text = planning.getJourParId(numJour+1).GetidJour.ToString();
                boutonJour3.Text = planning.getJourParId(numJour+2).GetidJour.ToString();
                boutonJour4.Text = planning.getJourParId(numJour+3).GetidJour.ToString();
                boutonJour5.Text = planning.getJourParId(numJour+4).GetidJour.ToString();
                boutonJour6.Text = planning.getJourParId(numJour+5).GetidJour.ToString();
                boutonJour7.Text = planning.getJourParId(numJour+6).GetidJour.ToString();
            
            if (nbJourAffichage >7)
            {

                boutonJour8.Text = planning.getJourParId(numJour+7).GetidJour.ToString();
                boutonJour9.Text = planning.getJourParId(numJour + 8).GetidJour.ToString();
                boutonJour10.Text = planning.getJourParId(numJour + 9).GetidJour.ToString();
                boutonJour11.Text = planning.getJourParId(numJour + 10).GetidJour.ToString();
                boutonJour12.Text = planning.getJourParId(numJour + 11).GetidJour.ToString();
                boutonJour13.Text = planning.getJourParId(numJour + 12).GetidJour.ToString();
                boutonJour14.Text = planning.getJourParId(numJour + 13).GetidJour.ToString();

            }

            if (nbJourAffichage > 14)
            {
                boutonJour15.Text = planning.getJourParId(numJour + 14).GetidJour.ToString();
                boutonJour16.Text = planning.getJourParId(numJour + 15).GetidJour.ToString();
                boutonJour17.Text = planning.getJourParId(numJour + 16).GetidJour.ToString();
                boutonJour18.Text = planning.getJourParId(numJour + 17).GetidJour.ToString();
                boutonJour19.Text = planning.getJourParId(numJour + 18).GetidJour.ToString();
                boutonJour20.Text = planning.getJourParId(numJour + 19).GetidJour.ToString();
                boutonJour21.Text = planning.getJourParId(numJour + 20).GetidJour.ToString();
            }

            coloriseBouton();

        }

      

     

        private void button1_Click(object sender, EventArgs e)
        {
            affichageNiveau2(jourPivot);
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            if (jourPivot != 499 - nbJourAffichage)
            {
                if (jourPivot < 490 && nbJourAffichage ==7)
                {
                    jourPivot = jourPivot + nbJourAffichage;
                    afficherJour(jourPivot);
                }
                else if(jourPivot >= 490 && nbJourAffichage ==7)
                {
                    jourPivot = jourPivot + (500 - jourPivot - nbJourAffichage);
                    afficherJour(jourPivot);
                }
                else if (jourPivot != 476 && nbJourAffichage == 14)
                {
                    jourPivot = jourPivot + nbJourAffichage;
                    afficherJour(jourPivot);
                }
                else if (jourPivot == 476 && nbJourAffichage == 14)
                {
                    jourPivot = jourPivot + 10;
                    afficherJour(jourPivot);
                }
                else if (jourPivot != 483 && nbJourAffichage == 21)
                {
                    jourPivot = jourPivot + nbJourAffichage;
                    afficherJour(jourPivot);
                }
                else if (jourPivot == 483 && nbJourAffichage == 21)
                {
                    jourPivot = jourPivot + 17;
                    afficherJour(jourPivot);
                }
            }

        }

        //Bouton suivant, affiche les jours dans l'ordre chronlogique en fonction par page.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Bouton précedent
        private void Precedent_Click(object sender, EventArgs e)
        {
            if(nbJourAffichage==7)
            {
                if (jourPivot != 0)
                {
                    jourPivot -= 7;
                    afficherJour(jourPivot);
                }
            }
            else if(nbJourAffichage==14)
            {
                if (jourPivot !=0 && jourPivot != 7 )
                {
                    jourPivot -= 14;
                    afficherJour(jourPivot);

                }
                else if(jourPivot==7)
                {
                    jourPivot -= 7;
                    afficherJour(jourPivot);

                }
            }
            else if (nbJourAffichage==21)
            {
                if(jourPivot!=0 && jourPivot!=14 && jourPivot!=7)
                {
                    jourPivot -= 21;
                    afficherJour(jourPivot);

                }
                else if(jourPivot==14)
                {
                    jourPivot -= 14;
                    afficherJour(jourPivot);

                }
                else if(jourPivot==7)
                {
                    jourPivot -= 7;
                    afficherJour(jourPivot);

                }
            }
         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            hauteurPanel = panel1.Height;

            hauteurBouton = hauteurPanel / 3;
            intervalleBouton = hauteurBouton / 4;

            positionLigne1 = intervalleBouton;

            positionLigne2 = hauteurBouton + 2 * intervalleBouton;

            boutonJour1.Height = hauteurBouton;
            boutonJour8.Height = hauteurBouton;
            boutonJour1.Top = positionLigne1;
            boutonJour8.Top = positionLigne2;
            boutonJour8.Visible = true;

            boutonJour2.Height = hauteurBouton;
            boutonJour9.Height = hauteurBouton;
            boutonJour2.Top = positionLigne1;
            boutonJour9.Top = positionLigne2;
            boutonJour9.Visible = true;

            boutonJour3.Height = hauteurBouton;
            boutonJour10.Height = hauteurBouton;
            boutonJour3.Top = positionLigne1;
            boutonJour10.Top = positionLigne2;
            boutonJour10.Visible = true;

            boutonJour4.Height = hauteurBouton;
            boutonJour11.Height = hauteurBouton;
            boutonJour4.Top = positionLigne1;
            boutonJour11.Top = positionLigne2;
            boutonJour11.Visible = true;

            boutonJour5.Height = hauteurBouton;
            boutonJour12.Height = hauteurBouton;
            boutonJour5.Top = positionLigne1;
            boutonJour12.Top = positionLigne2;
            boutonJour12.Visible = true;

            boutonJour6.Height = hauteurBouton;
            boutonJour13.Height = hauteurBouton;
            boutonJour6.Top = positionLigne1;
            boutonJour13.Top = positionLigne2;
            boutonJour13.Visible = true;

            boutonJour7.Height = hauteurBouton;
            boutonJour14.Height = hauteurBouton;
            boutonJour7.Top = positionLigne1;
            boutonJour14.Top = positionLigne2;
            boutonJour14.Visible = true;

            boutonJour15.Visible = false;
            boutonJour16.Visible = false;
            boutonJour17.Visible = false;
            boutonJour18.Visible = false;
            boutonJour19.Visible = false;
            boutonJour20.Visible = false;
            boutonJour21.Visible = false;

            nbJourAffichage = 14;

            afficherJour(jourPivot);

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            hauteurPanel = panel1.Height;

            hauteurBouton = hauteurPanel / 4 ;
            intervalleBouton = hauteurBouton / 4;

            positionLigne1 = intervalleBouton;

            positionLigne2 = hauteurBouton + 2 * intervalleBouton;

            positionLigne3 = 2 * hauteurBouton + 3 * intervalleBouton;

            boutonJour1.Height = hauteurBouton;
            boutonJour8.Height = hauteurBouton;
            boutonJour15.Height = hauteurBouton;
            boutonJour1.Top = positionLigne1;
            boutonJour8.Top = positionLigne2;
            boutonJour15.Top = positionLigne3;
            boutonJour8.Visible = true;
            boutonJour15.Visible = true;

            boutonJour2.Height = hauteurBouton;
            boutonJour9.Height = hauteurBouton;
            boutonJour16.Height = hauteurBouton;
            boutonJour2.Top = positionLigne1;
            boutonJour9.Top = positionLigne2;
            boutonJour16.Top = positionLigne3;
            boutonJour9.Visible = true;
            boutonJour16.Visible = true;

            boutonJour3.Height = hauteurBouton;
            boutonJour10.Height = hauteurBouton;
            boutonJour17.Height = hauteurBouton;
            boutonJour3.Top = positionLigne1;
            boutonJour10.Top = positionLigne2;
            boutonJour17.Top = positionLigne3;
            boutonJour10.Visible = true;
            boutonJour17.Visible = true;

            boutonJour4.Height = hauteurBouton;
            boutonJour11.Height = hauteurBouton;
            boutonJour18.Height = hauteurBouton;
            boutonJour4.Top = positionLigne1;
            boutonJour11.Top = positionLigne2;
            boutonJour18.Top = positionLigne3;
            boutonJour11.Visible = true;
            boutonJour18.Visible = true;

            boutonJour5.Height = hauteurBouton;
            boutonJour12.Height = hauteurBouton;
            boutonJour19.Height = hauteurBouton;
            boutonJour5.Top = positionLigne1;
            boutonJour12.Top = positionLigne2;
            boutonJour19.Top = positionLigne3;
            boutonJour12.Visible = true;
            boutonJour19.Visible = true;

            boutonJour6.Height = hauteurBouton;
            boutonJour13.Height = hauteurBouton;
            boutonJour20.Height = hauteurBouton;
            boutonJour6.Top = positionLigne1;
            boutonJour13.Top = positionLigne2;
            boutonJour20.Top = positionLigne3;
            boutonJour13.Visible = true;
            boutonJour20.Visible = true;

            boutonJour7.Height = hauteurBouton;
            boutonJour14.Height = hauteurBouton;
            boutonJour21.Height = hauteurBouton;
            boutonJour7.Top = positionLigne1;
            boutonJour14.Top = positionLigne2;
            boutonJour21.Top = positionLigne3;
            boutonJour14.Visible = true;
            boutonJour21.Visible = true;

            nbJourAffichage = 21;

            afficherJour(jourPivot);

        }

        private void affichage7Jours_Click(object sender, EventArgs e)
        {

            hauteurPanel = panel1.Height;

            hauteurBouton = (2 * hauteurPanel) / 3 ;
            intervalleBouton = hauteurBouton / 4;

            positionLigne1 = intervalleBouton;

            boutonJour1.Height = hauteurBouton;
            boutonJour1.Top = positionLigne1;

            boutonJour2.Height = hauteurBouton;
            boutonJour2.Top = positionLigne1;

            boutonJour3.Height = hauteurBouton;
            boutonJour3.Top = positionLigne1;

            boutonJour4.Height = hauteurBouton;
            boutonJour4.Top = positionLigne1;

            boutonJour5.Height = hauteurBouton;
            boutonJour5.Top = positionLigne1;

            boutonJour6.Height = hauteurBouton;
            boutonJour6.Top = positionLigne1;

            boutonJour7.Height = hauteurBouton;
            boutonJour7.Top = positionLigne1;

            boutonJour8.Visible = false;
            boutonJour9.Visible = false;
            boutonJour10.Visible = false;
            boutonJour11.Visible = false;
            boutonJour12.Visible = false;
            boutonJour13.Visible = false;
            boutonJour14.Visible = false;
            boutonJour15.Visible = false;
            boutonJour16.Visible = false;
            boutonJour17.Visible = false;
            boutonJour18.Visible = false;
            boutonJour19.Visible = false;
            boutonJour20.Visible = false;
            boutonJour21.Visible = false;

            nbJourAffichage = 7;

            afficherJour(jourPivot);

        }

        private void boutonJour2_Click(object sender, EventArgs e)
        {

        }

        private void boutonJour3_Click(object sender, EventArgs e)
        {

        }

        private void boutonJour4_Click(object sender, EventArgs e)
        {

        }



    }
}
