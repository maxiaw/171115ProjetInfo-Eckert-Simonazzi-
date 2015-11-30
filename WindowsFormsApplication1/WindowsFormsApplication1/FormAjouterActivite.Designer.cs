namespace WindowsFormsApplication1
{
    partial class FormAjouterActivite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelAstronautesActivite = new System.Windows.Forms.Label();
            this.labelDescriptifActivite = new System.Windows.Forms.Label();
            this.labelLieuActivite = new System.Windows.Forms.Label();
            this.labelPlageHoraireActivité = new System.Windows.Forms.Label();
            this.labelJourActivité = new System.Windows.Forms.Label();
            this.labelTypeActivité = new System.Windows.Forms.Label();
            this.labelNomActivite = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.boutonEnregistrerActivite = new System.Windows.Forms.Button();
            this.treeViewTypeActivite = new System.Windows.Forms.TreeView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxHeureDebut = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuteDebut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(92, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(216, 31);
            this.labelTitre.TabIndex = 9;
            this.labelTitre.Text = "Nouvelle Activité";
            // 
            // labelAstronautesActivite
            // 
            this.labelAstronautesActivite.AutoSize = true;
            this.labelAstronautesActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAstronautesActivite.Location = new System.Drawing.Point(12, 469);
            this.labelAstronautesActivite.Name = "labelAstronautesActivite";
            this.labelAstronautesActivite.Size = new System.Drawing.Size(181, 20);
            this.labelAstronautesActivite.TabIndex = 17;
            this.labelAstronautesActivite.Text = "Liste des astronautes :";
            // 
            // labelDescriptifActivite
            // 
            this.labelDescriptifActivite.AutoSize = true;
            this.labelDescriptifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptifActivite.Location = new System.Drawing.Point(12, 391);
            this.labelDescriptifActivite.Name = "labelDescriptifActivite";
            this.labelDescriptifActivite.Size = new System.Drawing.Size(181, 20);
            this.labelDescriptifActivite.TabIndex = 16;
            this.labelDescriptifActivite.Text = "Descriptif de l\'activité :";
            // 
            // labelLieuActivite
            // 
            this.labelLieuActivite.AutoSize = true;
            this.labelLieuActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuActivite.Location = new System.Drawing.Point(12, 351);
            this.labelLieuActivite.Name = "labelLieuActivite";
            this.labelLieuActivite.Size = new System.Drawing.Size(51, 20);
            this.labelLieuActivite.TabIndex = 15;
            this.labelLieuActivite.Text = "Lieu :";
            // 
            // labelPlageHoraireActivité
            // 
            this.labelPlageHoraireActivité.AutoSize = true;
            this.labelPlageHoraireActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlageHoraireActivité.Location = new System.Drawing.Point(12, 314);
            this.labelPlageHoraireActivité.Name = "labelPlageHoraireActivité";
            this.labelPlageHoraireActivité.Size = new System.Drawing.Size(84, 20);
            this.labelPlageHoraireActivité.TabIndex = 14;
            this.labelPlageHoraireActivité.Text = "Horaires :";
            // 
            // labelJourActivité
            // 
            this.labelJourActivité.AutoSize = true;
            this.labelJourActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJourActivité.Location = new System.Drawing.Point(12, 276);
            this.labelJourActivité.Name = "labelJourActivité";
            this.labelJourActivité.Size = new System.Drawing.Size(52, 20);
            this.labelJourActivité.TabIndex = 13;
            this.labelJourActivité.Text = "Jour :";
            // 
            // labelTypeActivité
            // 
            this.labelTypeActivité.AutoSize = true;
            this.labelTypeActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeActivité.Location = new System.Drawing.Point(12, 129);
            this.labelTypeActivité.Name = "labelTypeActivité";
            this.labelTypeActivité.Size = new System.Drawing.Size(55, 20);
            this.labelTypeActivité.TabIndex = 12;
            this.labelTypeActivité.Text = "Type :";
            // 
            // labelNomActivite
            // 
            this.labelNomActivite.AutoSize = true;
            this.labelNomActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomActivite.Location = new System.Drawing.Point(12, 84);
            this.labelNomActivite.Name = "labelNomActivite";
            this.labelNomActivite.Size = new System.Drawing.Size(54, 20);
            this.labelNomActivite.TabIndex = 18;
            this.labelNomActivite.Text = "Nom :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(209, 477);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(327, 79);
            this.checkedListBox1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 353);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 24;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(209, 379);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 81);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // boutonEnregistrerActivite
            // 
            this.boutonEnregistrerActivite.Location = new System.Drawing.Point(425, 572);
            this.boutonEnregistrerActivite.Name = "boutonEnregistrerActivite";
            this.boutonEnregistrerActivite.Size = new System.Drawing.Size(111, 38);
            this.boutonEnregistrerActivite.TabIndex = 26;
            this.boutonEnregistrerActivite.Text = "Enregistrer la nouvelle Activité";
            this.boutonEnregistrerActivite.UseVisualStyleBackColor = true;
            this.boutonEnregistrerActivite.Click += new System.EventHandler(this.boutonEnregistrerActivite_Click);
            // 
            // treeViewTypeActivite
            // 
            this.treeViewTypeActivite.Location = new System.Drawing.Point(83, 129);
            this.treeViewTypeActivite.Name = "treeViewTypeActivite";
            this.treeViewTypeActivite.Size = new System.Drawing.Size(181, 130);
            this.treeViewTypeActivite.TabIndex = 28;
            this.treeViewTypeActivite.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTypeActivite_AfterSelect);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            // 
            // comboBoxHeureDebut
            // 
            this.comboBoxHeureDebut.FormattingEnabled = true;
            this.comboBoxHeureDebut.Location = new System.Drawing.Point(98, 314);
            this.comboBoxHeureDebut.Name = "comboBoxHeureDebut";
            this.comboBoxHeureDebut.Size = new System.Drawing.Size(71, 21);
            this.comboBoxHeureDebut.TabIndex = 29;
            // 
            // comboBoxMinuteDebut
            // 
            this.comboBoxMinuteDebut.FormattingEnabled = true;
            this.comboBoxMinuteDebut.Location = new System.Drawing.Point(209, 314);
            this.comboBoxMinuteDebut.Name = "comboBoxMinuteDebut";
            this.comboBoxMinuteDebut.Size = new System.Drawing.Size(72, 21);
            this.comboBoxMinuteDebut.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "H";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 20);
            this.textBox2.TabIndex = 32;
            // 
            // FormAjouterActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 619);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinuteDebut);
            this.Controls.Add(this.comboBoxHeureDebut);
            this.Controls.Add(this.treeViewTypeActivite);
            this.Controls.Add(this.boutonEnregistrerActivite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelNomActivite);
            this.Controls.Add(this.labelAstronautesActivite);
            this.Controls.Add(this.labelDescriptifActivite);
            this.Controls.Add(this.labelLieuActivite);
            this.Controls.Add(this.labelPlageHoraireActivité);
            this.Controls.Add(this.labelJourActivité);
            this.Controls.Add(this.labelTypeActivité);
            this.Controls.Add(this.labelTitre);
            this.Name = "FormAjouterActivite";
            this.Text = "FormAjouterActivite";
            this.Load += new System.EventHandler(this.FormAjouterActivite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelAstronautesActivite;
        private System.Windows.Forms.Label labelDescriptifActivite;
        private System.Windows.Forms.Label labelLieuActivite;
        private System.Windows.Forms.Label labelPlageHoraireActivité;
        private System.Windows.Forms.Label labelJourActivité;
        private System.Windows.Forms.Label labelTypeActivité;
        private System.Windows.Forms.Label labelNomActivite;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button boutonEnregistrerActivite;
        private System.Windows.Forms.TreeView treeViewTypeActivite;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxHeureDebut;
        private System.Windows.Forms.ComboBox comboBoxMinuteDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}