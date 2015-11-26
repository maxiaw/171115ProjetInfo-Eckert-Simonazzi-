using System;
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
        private int activiteSelectionne;
        private Planning planning;



        //Constructeur par défaut
        public Form2(List<Jour> tempListeJour, int tempJourSelection, Planning tempPlanning)
        {
            listeJour = tempListeJour;
            jourSelection = tempJourSelection;
            InitializeComponent();
            planning = tempPlanning;
            
            
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
      

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
     
            objetJourSelection = listeJour[jourSelection];
            listeActivitéTableau = objetJourSelection.getlisteActivite;
            
            //Remplissage de la listbox
            string contenuListBox;
            DateTime dateDebutPlanning = new DateTime(2015, 11, 15, 0, 0, 0);
            int i = 0;
           foreach(Activités A in listeActivitéTableau)
           {

               contenuListBox = A.getDateDebutMars(dateDebutPlanning) + "  : " + A.GetNomActivité;
               listBox1.Items.Add(contenuListBox);

               listView1.Items.Add("     ");
               if(A.GettypeActivite == "Sleeping")
               {

                   listView1.Items[i].BackColor = Color.DarkSeaGreen;

               }
               else if (A.GettypeActivite == "Exploration")
               {

                       listView1.Items[i].BackColor = Color.CadetBlue;

               }

               

               i++;

           }

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
            string texteHoraire = listeActivitéTableau[activiteSelectionne].getDateDebutMars(dateDebutPlanning);
            texteHoraire = texteHoraire + " à "+ listeActivitéTableau[activiteSelectionne].getDateFinMars(dateDebutPlanning);
            labelPlageHoraireActivité.Text = "Plage horaire : " + texteHoraire;

            // Recuperation du lieu
            Lieu lieuActivite = listeActivitéTableau[activiteSelectionne].GetLieuActivite;
            labelLieuActivite.Text = "Lieu : " + lieuActivite.GetnomLieu;

            listBoxAstronautes.Items.Clear();

            List<Astronautes> listeAstronautesActivite = listeActivitéTableau[activiteSelectionne].GetlisteAstronautes;
            string contenuListBoxAstronautes;
            foreach (Astronautes A in listeAstronautesActivite)
            {

                contenuListBoxAstronautes = A.GetprenomAstronaute + "  " + A.GetnomAstronaute + " Age :" + A.GetageAstronaute.ToString();
                listBoxAstronautes.Items.Add(contenuListBoxAstronautes);

            }


        }

        private void listBox2_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
