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
    public partial class Form2 : Form
    {
        private List<Jour> listeJour;
        private int jourSelection;
        private Jour objetJourSelection;
        private List<Activités> listeActivitéTableau;
        private List<Astronautes> listeAstronautes;
        private int activiteSelectionne;
        private Planning planning;
        private List<Lieu> listeLieu;



        //Constructeur par défaut
<<<<<<< HEAD
        public Form2(List<Jour> tempListeJour, int tempJourSelection, Planning tempPlanning, List<Astronautes> tempListeAstronautes,List<Lieu> tempListeLieu)
=======
        public Form2(List<Jour> tempListeJour, int tempJourSelection, Planning tempPlanning, List<Astronautes> tempListeAstronautes, List<Lieu> tempListeLieu)
>>>>>>> origin/master
        {
            listeJour = tempListeJour;
            jourSelection = tempJourSelection;
            InitializeComponent();
            planning = tempPlanning;
            listeAstronautes = tempListeAstronautes;
<<<<<<< HEAD
            listeDeLieux = tempListeLieu;
=======
            listeLieu = tempListeLieu;
            
>>>>>>> origin/master
            
        }
        //Accesseurs//

        public List<Jour> GetlisteJour
        {
            get { return listeJour; }
            set { listeJour = value; }
        }
        public int GetjourSelection
        {
            get { return jourSelection; }
            set { jourSelection = value; }
        }
        public List<Activités> GetlisteActivitésTableau
        {
            get { return listeActivitéTableau; }
            set { listeActivitéTableau = value; }
        }
        //FinAccesseurs//

        //Remplissage de la listbox
        public void remplissageListBox()
        {
            string contenuListBox;
            foreach (Activités A in listeActivitéTableau)
            {

                contenuListBox = A.getHoraireDebutMarsTexte() + "  : " + A.GetNomActivité;
                listBox1.Items.Add(contenuListBox);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            objetJourSelection = listeJour[jourSelection-1];
            listeActivitéTableau = objetJourSelection.getlisteActivite;

            remplissageListBox();

            DateTime dateDebutPlanning = new DateTime(2015, 11, 15, 0, 0, 0);
           

            labelNumeroJour.Text = jourSelection.ToString();

            listBox1.SelectedIndex = 0;
     
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Méthode qui affiche les caractéristiques d'une activité selectionnée
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            activiteSelectionne = listBox1.SelectedIndex;
            labelNomActivite.Text = listeActivitéTableau[activiteSelectionne].GetNomActivité;
            labelTypeActivité.Text = "Type : " + listeActivitéTableau[activiteSelectionne].GettypeActivite;
            labelJourActivité.Text = "Jour : "  + jourSelection.ToString();

            DateTime dateDebutPlanning = planning.GetDateDebut;
            string texteHoraire = listeActivitéTableau[activiteSelectionne].getHoraireDebutMarsTexte();
            texteHoraire = texteHoraire + " à " + listeActivitéTableau[activiteSelectionne].getHoraireFinMarsTexte();
            labelPlageHoraireActivité.Text = "Plage horaire : " + texteHoraire;

            // Recuperation du lieu
            Lieu lieuActivite = listeActivitéTableau[activiteSelectionne].GetLieuActivite;

            labelLieuActivite.Text = "Lieu : " + lieuActivite.GetnomLieu;

            // Recuperation de la liste d'astronautes
            List<Astronautes> listeAstronautesActivite = listeActivitéTableau[activiteSelectionne].GetlisteAstronautes;
            string contenuListBoxAstronautes;

            listBoxAstronautes.Items.Clear();

            foreach (Astronautes A in listeAstronautesActivite) 
            {

                contenuListBoxAstronautes = "" + A.GetprenomAstronaute + " " + A.GetnomAstronaute + "    age : " + A.GetageAstronaute.ToString() ;
                listBoxAstronautes.Items.Add(contenuListBoxAstronautes);

            }

            texteDescriptifActivite.Text = listeActivitéTableau[activiteSelectionne].GettexteDescriptif;
            
        }

        private void boutonJourSuivant_Click(object sender, EventArgs e)
        {
            if (jourSelection != 500)
            {
<<<<<<< HEAD
                Form2 fenetre = new Form2(listeJour, jourSelection + 1, planning, listeAstronautes,listeDeLieux);
=======
                Form2 fenetre = new Form2(listeJour, jourSelection + 1, planning, listeAstronautes, listeLieu);
>>>>>>> origin/master
                Form.ActiveForm.Close();
                fenetre.Show();
            }
        }

        private void boutonJourPrecedent_Click(object sender, EventArgs e)
        {
            if(jourSelection != 1)
            {

<<<<<<< HEAD
                Form2 fenetre = new Form2(listeJour, jourSelection - 1, planning, listeAstronautes,listeDeLieux);
=======
                Form2 fenetre = new Form2(listeJour, jourSelection - 1, planning, listeAstronautes, listeLieu);
>>>>>>> origin/master
                Form.ActiveForm.Close();
                fenetre.Show();
            }

        }

        private void boutonEffacerActivite_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            objetJourSelection.getlisteActivite.Clear();
        }

        private void buttonAjouterActivité_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FormAjouterActivite formAjout = new FormAjouterActivite(objetJourSelection, objetJourSelection, listeAstronautes, listeLieu, planning);
=======
<<<<<<< HEAD
            FormAjouterActivite formAjout = new FormAjouterActivite(objetJourSelection, listeAstronautes);
=======
            FormAjouterActivite formAjout = new FormAjouterActivite(objetJourSelection, jourSelection, listeAstronautes, listeLieu, planning);
>>>>>>> origin/master

>>>>>>> origin/master
            formAjout.ShowDialog();
            

            listBox1.Items.Clear();

            remplissageListBox();

        }

        private void buttonModifierActivité_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
            formModifierActivite formModificationActivite = new formModifierActivite(objetJourSelection, listeAstronautes, listeActivitéTableau[activiteSelectionne], listeDeLieux);
            formModificationActivite.Show();
=======
<<<<<<< HEAD
>>>>>>> origin/master

            formModifierActivite formModifier = new formModifierActivite(objetJourSelection, listeAstronautes, listeActivitéTableau[activiteSelectionne],listeLieu);
            formModifier.ShowDialog();
<<<<<<< HEAD
        }

        private void buttonSupprimerActivité_Click(object sender, EventArgs e)
        {
            activiteSelectionne = listBox1.SelectedIndex;
            objetJourSelection.supprimerActivite(activiteSelectionne);

            listBox1.Items.Clear();

            remplissageListBox();
         
=======
>>>>>>> origin/master
>>>>>>> origin/master
        } 

    }
}
