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
    public partial class ModfierUneActivite : Form
    {
        public ModfierUneActivite()
        {
            InitializeComponent();
        }
        private Jour objetJour;
        private List<Astronautes> listeAstronautes;
        private Activités activiteAModifier;
        private List<Lieu> listeLieux;

        public ModfierUneActivite(Jour objetJourSelection, List<Astronautes> tempListeAstronautes, Activités tempActiviteAModifier, List<Lieu> tempListeDeLieux)
        {
            objetJour = objetJourSelection;
            activiteAModifier = tempActiviteAModifier;
            listeAstronautes = tempListeAstronautes;
            listeLieux = tempListeDeLieux;
        }

       
        private void formModifierActivite_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.activiteAModifier.GetnomActivite;
            textBox3.Text = this.objetJour.GetidJour.ToString();
            // Remplir heure debut

            for (int i = 0; i < 25; i++)
            {
                comboBoxHeureDebut.Items.Add(i);
            }
            //remplir minute debut
            for (int i = 0; i < 60; i = i + 10)
            {
                comboBoxMinuteDebut.Items.Add(i);
            }
            // On remet l'heure initiale qu'avait l'activité qu'on doit modifier
            comboBoxHeureDebut.SelectedIndex = activiteAModifier.getHeureDebut.Hour;
            comboBoxMinuteDebut.SelectedIndex = activiteAModifier.getHeureDebut.Minute;
            // On rempli le comboBox de lieu avec la liste de lieu
            foreach(Lieu L in listeLieux)
            {
                comboBoxListeLieu.Items.Add(L.GetnomLieu);

            }
            // On remet le lieu initial qu'avait l'activité à modifier
            
            foreach(Lieu l in listeLieux)
            {
                if (l.GetnomLieu == activiteAModifier.GetnomLieuDeActivite)
                {
                    comboBoxListeLieu.SelectedIndex = int.Parse(l.GetnomLieu);
                }

            }
            // on récupère le descriptif initial de l'activité à modifier

            richTextBox2.Text = activiteAModifier.GettexteDescriptif;

            // On remplie le CheckListeBoxAstronaute avec la liste des astronautes

            foreach(Astronautes A in listeAstronautes)
            {
                checkedListBox1.Items.Add(A);
            }

            //On récupère la liste des astronoautes initiale de l'activité à modifier
            foreach(Astronautes astro in listeAstronautes)
            {
                if(astro.GetnomAstronaute==activiteAModifier.GetlisteAstronautes.Find(x=>x.GetnomAstronaute==astro.GetnomAstronaute).ToString())
                {
                    checkedListBox1.SelectedIndex = int.Parse(astro.GetnomAstronaute);
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHeureDebut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxListeLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxAstronautes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }


      
    }
    }

