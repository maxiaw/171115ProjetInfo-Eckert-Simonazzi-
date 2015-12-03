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
    public partial class FormAjouterActivite : Form
    {

        private List<Astronautes> listeAstronautes;
        private List<Lieu> listeLieu;
        private Jour jourActuel;
        private Planning planning;

        public FormAjouterActivite(Jour tempJourActuel, List<Astronautes> tempListeAstronautes, List<Lieu> tempListeLieu, Planning tempPlanning)
        {
            InitializeComponent();
            jourActuel = tempJourActuel;
            listeAstronautes = tempListeAstronautes;
            listeLieu = tempListeLieu;
            planning = tempPlanning;
        }



       
        private void FormAjouterActivite_Load(object sender, EventArgs e)
        {

            labelJourActivité.Text = "Jour : " + jourActuel.GetidJour.ToString();


            //Remplissage de tree view type activite
            
            TreeNode treeNodeLiving = new TreeNode("Living");

                treeNodeLiving.Nodes.Add("Eating");
                treeNodeLiving.Nodes.Add("Sleeping");
                treeNodeLiving.Nodes.Add("Entertainment");
                treeNodeLiving.Nodes.Add("Private");
                treeNodeLiving.Nodes.Add("Health Control");
                treeNodeLiving.Nodes.Add("Medical Act");

            TreeNode treeNodeScience = new TreeNode("Science");

            TreeNode treeNodeExploration = new TreeNode("Exploration");
            
                treeNodeExploration.Nodes.Add("Space Suit");
                treeNodeExploration.Nodes.Add("Vehicle");

                treeNodeScience.Nodes.Add(treeNodeExploration);

                treeNodeScience.Nodes.Add("Briefing");
                treeNodeScience.Nodes.Add("Debriefing");
                treeNodeScience.Nodes.Add("Inside experiment");
                treeNodeScience.Nodes.Add("Outside experiment");

                TreeNode treeNodeMaintenance = new TreeNode("Maintenance");
                
                treeNodeMaintenance.Nodes.Add("Cleaning");
                treeNodeMaintenance.Nodes.Add("LSS air system");
                treeNodeMaintenance.Nodes.Add("LSS water system");
                treeNodeMaintenance.Nodes.Add("LSS food system");
                treeNodeMaintenance.Nodes.Add("Power systems");
                treeNodeMaintenance.Nodes.Add("Space suit");
                treeNodeMaintenance.Nodes.Add("Other");

            TreeNode treeNodeCommunication = new TreeNode("Communication");
                
                treeNodeCommunication.Nodes.Add("Sending message");
                treeNodeCommunication.Nodes.Add("Receiving message");

             TreeNode treeNodeRepair = new TreeNode("Repair");

                treeNodeRepair.Nodes.Add("LSS");
                treeNodeRepair.Nodes.Add("Power systems");
                treeNodeRepair.Nodes.Add("Communication systems");
                treeNodeRepair.Nodes.Add("Propulsion systems");
                treeNodeRepair.Nodes.Add("Habitat");
                treeNodeRepair.Nodes.Add("Space suit");
                treeNodeRepair.Nodes.Add("Vehicle");

             TreeNode treeNodeEmergency = new TreeNode("Emergency");

                
            treeViewTypeActivite.Nodes.Add(treeNodeLiving);
            treeViewTypeActivite.Nodes.Add(treeNodeScience);
            treeViewTypeActivite.Nodes.Add(treeNodeMaintenance);
            treeViewTypeActivite.Nodes.Add(treeNodeCommunication);
            treeViewTypeActivite.Nodes.Add(treeNodeRepair);
            treeViewTypeActivite.Nodes.Add(treeNodeEmergency);

            //Remplissage comboBox horaire

            for (int i = 0; i < 25; i++)
            {
                comboBoxHeureDebut.Items.Add(i);
            }

            for (int i = 0; i < 60; i=i+10)
            {
                comboBoxMinuteDebut.Items.Add(i);
            }

            for (int i = 0; i < 25; i++)
            {
                comboBoxHeureFin.Items.Add(i);
            }

            for (int i = 0; i < 60; i = i + 10)
            {
                comboBoxMinuteFin.Items.Add(i);
            }



            string texteAstronautes;

            //Remplissage checkbox astronautes
            foreach (Astronautes A in listeAstronautes)
            {
                texteAstronautes = A.GetprenomAstronaute + " " + A.GetnomAstronaute;
                checkedListBoxAstronautes.Items.Add(texteAstronautes);
            }



            string texteLieu;

            //Remplissage combox lieu
            foreach (Lieu L in listeLieu)
            {
                texteLieu = L.GetnomLieu;
                comboBoxListeLieu.Items.Add(texteLieu);
            }



        }

        

        private void boutonEnregistrerActivite_Click(object sender, EventArgs e)
        {
            //recuperation nom activite
            string nomActivite = textBoxNomActivite.Text;

            //recuperation type activite
            string typeActivite = treeViewTypeActivite.SelectedNode.Parent.Text + " - " +  treeViewTypeActivite.SelectedNode.Text;

            //recuperation horaire debut et horaire fin
            int horaireDebutActivite = int.Parse(comboBoxHeureDebut.Text) * 60 + int.Parse(comboBoxMinuteDebut.Text) ;
            int horaireFinActivite = int.Parse(comboBoxHeureFin.Text) * 60 + int.Parse(comboBoxMinuteFin.Text) ;

            //recuperation lieu
            Lieu lieuActivite = listeLieu[comboBoxListeLieu.SelectedIndex];
            List<Astronautes> listeAstronautesSelection = new List<Astronautes>();

            //recuperation de la liste d'astronautes selectionnee
            for (int i = 0; i <= (checkedListBoxAstronautes.Items.Count-1); i++)
            {
                    if (checkedListBoxAstronautes.GetItemChecked(i))
                    {
                         listeAstronautesSelection.Add(listeAstronautes[i]);
                    }
            }

            string texteDescriptif = richTextBox1.Text;

            Activités nouvelleActivite = new Activités(nomActivite, typeActivite, horaireDebutActivite, horaireFinActivite, lieuActivite, listeAstronautesSelection, texteDescriptif);

            jourActuel.ajouterActivite(nouvelleActivite);

            this.Dispose();
        }

        private void treeViewTypeActivite_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAstronautesActivite_Click(object sender, EventArgs e)
        {

        }

        private void labelDescriptifActivite_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                labelNomLieu.Visible = true;
                labelLieuCoordonneeX.Visible = true;
                labelLieuCoordonneeY.Visible = true;
                textBoxNomLieu.Visible = true;
                textBoxCoordonnéesX.Visible = true;
                textBoxCoordonnéesY.Visible = true;


            }
            else
            {
                labelNomLieu.Visible = false;
                labelLieuCoordonneeX.Visible = false;
                labelLieuCoordonneeY.Visible = false;
                textBoxNomLieu.Visible = false;
                textBoxCoordonnéesX.Visible = false;
                textBoxCoordonnéesY.Visible = false;

            }

        }

        private void labelJourActivité_Click(object sender, EventArgs e)
        {

        }

        private void labelPlageHoraireActivité_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMinuteDebut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHeureDebut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si jamais on selectionne l'horaire 24h40, on enleve le 50 dans la liste des minutes
            if (comboBoxHeureDebut.SelectedItem.ToString() == "24")
            {
                comboBoxMinuteDebut.Items.Clear();
 
                comboBoxMinuteDebut.Text = ""; 
                    

                for (int i = 0; i < 50; i = i + 10)
                {
                    comboBoxMinuteDebut.Items.Add(i);
                }

            }
            else
            {
                comboBoxMinuteDebut.Items.Clear();

                for (int i = 0; i < 60; i = i + 10)
                {
                    comboBoxMinuteDebut.Items.Add(i);
                }

            }


        }

        private void labelLieuActivite_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxListeLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHeureFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si jamais on selectionne l'horaire 24h40, on enleve le 50 dans la liste des minutes
            if (comboBoxHeureFin.SelectedItem.ToString() == "24")
            {
                comboBoxMinuteFin.Items.Clear();

                comboBoxMinuteFin.Text = "";


                for (int i = 0; i < 50; i = i + 10)
                {
                    comboBoxMinuteFin.Items.Add(i);
                }

            }
            else
            {
                comboBoxMinuteFin.Items.Clear();

                for (int i = 0; i < 60; i = i + 10)
                {
                    comboBoxMinuteFin.Items.Add(i);
                }

            }
        }



    }
}
