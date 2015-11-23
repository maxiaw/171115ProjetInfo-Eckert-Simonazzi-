namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.panelInteractionActivité = new System.Windows.Forms.Panel();
            this.buttonAjouterActivité = new System.Windows.Forms.Button();
            this.buttonSupprimerActivité = new System.Windows.Forms.Button();
            this.buttonModifierActivité = new System.Windows.Forms.Button();
            this.buttonAfficherLieuActivité = new System.Windows.Forms.Button();
            this.labelPlageHoraireActivité = new System.Windows.Forms.Label();
            this.labelJourActivité = new System.Windows.Forms.Label();
            this.labelTypeActivité = new System.Windows.Forms.Label();
            this.texteDescriptifActivité = new System.Windows.Forms.RichTextBox();
            this.panelListeActivité = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelInteractionActivité.SuspendLayout();
            this.panelListeActivité.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInteractionActivité
            // 
            this.panelInteractionActivité.Controls.Add(this.buttonAjouterActivité);
            this.panelInteractionActivité.Controls.Add(this.buttonSupprimerActivité);
            this.panelInteractionActivité.Controls.Add(this.buttonModifierActivité);
            this.panelInteractionActivité.Controls.Add(this.buttonAfficherLieuActivité);
            this.panelInteractionActivité.Controls.Add(this.labelPlageHoraireActivité);
            this.panelInteractionActivité.Controls.Add(this.labelJourActivité);
            this.panelInteractionActivité.Controls.Add(this.labelTypeActivité);
            this.panelInteractionActivité.Controls.Add(this.texteDescriptifActivité);
            this.panelInteractionActivité.Location = new System.Drawing.Point(566, 90);
            this.panelInteractionActivité.Name = "panelInteractionActivité";
            this.panelInteractionActivité.Size = new System.Drawing.Size(706, 416);
            this.panelInteractionActivité.TabIndex = 0;
            // 
            // buttonAjouterActivité
            // 
            this.buttonAjouterActivité.Location = new System.Drawing.Point(558, 15);
            this.buttonAjouterActivité.Name = "buttonAjouterActivité";
            this.buttonAjouterActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonAjouterActivité.TabIndex = 7;
            this.buttonAjouterActivité.Text = "Ajouter activité";
            this.buttonAjouterActivité.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerActivité
            // 
            this.buttonSupprimerActivité.Location = new System.Drawing.Point(376, 15);
            this.buttonSupprimerActivité.Name = "buttonSupprimerActivité";
            this.buttonSupprimerActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonSupprimerActivité.TabIndex = 6;
            this.buttonSupprimerActivité.Text = "Supprimer activité";
            this.buttonSupprimerActivité.UseVisualStyleBackColor = true;
            // 
            // buttonModifierActivité
            // 
            this.buttonModifierActivité.Location = new System.Drawing.Point(205, 15);
            this.buttonModifierActivité.Name = "buttonModifierActivité";
            this.buttonModifierActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonModifierActivité.TabIndex = 5;
            this.buttonModifierActivité.Text = "Modifier Activité";
            this.buttonModifierActivité.UseVisualStyleBackColor = true;
            // 
            // buttonAfficherLieuActivité
            // 
            this.buttonAfficherLieuActivité.Location = new System.Drawing.Point(28, 15);
            this.buttonAfficherLieuActivité.Name = "buttonAfficherLieuActivité";
            this.buttonAfficherLieuActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonAfficherLieuActivité.TabIndex = 4;
            this.buttonAfficherLieuActivité.Text = "Afficher le lieu";
            this.buttonAfficherLieuActivité.UseVisualStyleBackColor = true;
            // 
            // labelPlageHoraireActivité
            // 
            this.labelPlageHoraireActivité.AutoSize = true;
            this.labelPlageHoraireActivité.Location = new System.Drawing.Point(17, 337);
            this.labelPlageHoraireActivité.Name = "labelPlageHoraireActivité";
            this.labelPlageHoraireActivité.Size = new System.Drawing.Size(35, 13);
            this.labelPlageHoraireActivité.TabIndex = 3;
            this.labelPlageHoraireActivité.Text = "label1";
            // 
            // labelJourActivité
            // 
            this.labelJourActivité.AutoSize = true;
            this.labelJourActivité.Location = new System.Drawing.Point(17, 289);
            this.labelJourActivité.Name = "labelJourActivité";
            this.labelJourActivité.Size = new System.Drawing.Size(35, 13);
            this.labelJourActivité.TabIndex = 2;
            this.labelJourActivité.Text = "label1";
            // 
            // labelTypeActivité
            // 
            this.labelTypeActivité.AutoSize = true;
            this.labelTypeActivité.Location = new System.Drawing.Point(17, 245);
            this.labelTypeActivité.Name = "labelTypeActivité";
            this.labelTypeActivité.Size = new System.Drawing.Size(35, 13);
            this.labelTypeActivité.TabIndex = 1;
            this.labelTypeActivité.Text = "label1";
            // 
            // texteDescriptifActivité
            // 
            this.texteDescriptifActivité.Location = new System.Drawing.Point(245, 215);
            this.texteDescriptifActivité.Name = "texteDescriptifActivité";
            this.texteDescriptifActivité.Size = new System.Drawing.Size(363, 168);
            this.texteDescriptifActivité.TabIndex = 0;
            this.texteDescriptifActivité.Text = "";
            this.texteDescriptifActivité.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panelListeActivité
            // 
            this.panelListeActivité.Controls.Add(this.listBox1);
            this.panelListeActivité.Location = new System.Drawing.Point(13, 90);
            this.panelListeActivité.Name = "panelListeActivité";
            this.panelListeActivité.Size = new System.Drawing.Size(547, 416);
            this.panelListeActivité.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 303);
            this.listBox1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 532);
            this.Controls.Add(this.panelListeActivité);
            this.Controls.Add(this.panelInteractionActivité);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelInteractionActivité.ResumeLayout(false);
            this.panelInteractionActivité.PerformLayout();
            this.panelListeActivité.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInteractionActivité;
        private System.Windows.Forms.RichTextBox texteDescriptifActivité;
        private System.Windows.Forms.Panel panelListeActivité;
        private System.Windows.Forms.Button buttonAjouterActivité;
        private System.Windows.Forms.Button buttonSupprimerActivité;
        private System.Windows.Forms.Button buttonModifierActivité;
        private System.Windows.Forms.Button buttonAfficherLieuActivité;
        private System.Windows.Forms.Label labelPlageHoraireActivité;
        private System.Windows.Forms.Label labelJourActivité;
        private System.Windows.Forms.Label labelTypeActivité;
        private System.Windows.Forms.ListBox listBox1;
    }
}