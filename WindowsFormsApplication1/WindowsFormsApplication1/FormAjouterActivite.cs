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

        private Jour objetJour;

        public FormAjouterActivite(Jour tempJour)
        {
            InitializeComponent();
            objetJour = tempJour;
        }



       
        private void FormAjouterActivite_Load(object sender, EventArgs e)
        {
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

            for (int i = 0; i < 24; i++)
            {
                comboBoxHeureDebut.Items.Add(i);
            }

            for (int i = 0; i < 60; i=i+10)
            {
                comboBoxMinuteDebut.Items.Add(i);
            }




        }

        private void boutonEnregistrerActivite_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void treeViewTypeActivite_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewTypeActivite.SelectedNode.Parent != null)
            {
                textBox2.Text = treeViewTypeActivite.SelectedNode.Parent.Text + " - " + treeViewTypeActivite.SelectedNode.Text;
            }
            else {

                textBox2.Text = treeViewTypeActivite.SelectedNode.Text;
            }

        }



    }
}