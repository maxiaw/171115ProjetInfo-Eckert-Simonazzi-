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

        //Constructeur par défaut
        public Form2(List<Jour> tempListeJour, int tempJourSelection)
        {
            listeJour = tempListeJour;
            jourSelection = tempJourSelection;
            InitializeComponent();
            
        }
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

      

        private void Form2_Load(object sender, EventArgs e)
        {
            objetJourSelection = listeJour[jourSelection];
            listeActivitéTableau = objetJourSelection.getlisteActivite;
            
            string contenuListBox;
           foreach(Activités A in listeActivitéTableau)
           {

               contenuListBox = A.getHeureDebut.Hour + " " + A.GetNomActivité;
               listBox1.Items.Add(contenuListBox);

           }

            labelNumeroJour.Text = jourSelection.ToString();
     
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
            labelTypeActivité.Text = listeActivitéTableau[activiteSelectionne].GetNomActivité;
            labelJourActivité.Text = "Jour : " + jourSelection.ToString();

            DateTime horaireDebut = listeActivitéTableau[activiteSelectionne].getHeureDebut;

            DateTime dateDebutPlanning = objetJourSelection.GetPlanningJour.GetDateDebut;


            int tpsDebut = dateDebutPlanning.Day * 60 * 24 + dateDebutPlanning.Hour * 60 + dateDebutPlanning.Minute;
            int tps = horaireDebut.Day * 60 * 24 + horaireDebut.Hour * 60 + horaireDebut.Minute + horaireDebut.Day * 40 - tpsDebut;
            double doubleTps = tps - horaireDebut.Day * 60 * 24;

            int horaireDebutHeure = (int)Math.Truncate(doubleTps / 60);
            int horaireDebutMinute = tps - horaireDebutHeure*60;


            labelPlageHoraireActivité.Text = "Debut : " + horaireDebutHeure.ToString() + "h" + horaireDebutMinute.ToString() + "Fin : ";
        }
    }
}
