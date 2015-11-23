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
        private List<Activités> listeActivitéTableau;

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
            listeActivitéTableau = listeJour[jourSelection].getlisteActivite;

            string contenuListBox;
           foreach(Activités A in listeActivitéTableau)
           {

               contenuListBox = A.getHeureDebut.Hour + " " + A.GetNomActivité;
               listBox1.Items.Add(contenuListBox);

               
           }


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
    }
}
