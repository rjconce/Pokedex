
namespace WinFormsApp7
{

    partial class AjouterDesPokemonsForm
    {
        
        private System.ComponentModel.IContainer components = null;

    
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textNom = new TextBox();
            textTaille = new TextBox();
            textPoids = new TextBox();
            comboSexe = new ComboBox();
            comboDresseur = new ComboBox();
            numericPV = new NumericUpDown();
            labelNom = new Label();
            labelTaille = new Label();
            labelPoids = new Label();
            labelSexe = new Label();
            labelDresseur = new Label();
            label4 = new Label();
            labelPV = new Label();
            labelDescription = new Label();
            labelEvolution = new Label();
            textDescription = new TextBox();
            textEvolution = new TextBox();
            label1 = new Label();
            buttonValider = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPV).BeginInit();
            SuspendLayout();
            // 
            // textNom
            // 
            textNom.Anchor = AnchorStyles.None;
            textNom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNom.Location = new Point(600, 112);
            textNom.Name = "textNom";
            textNom.Size = new Size(125, 38);
            textNom.TabIndex = 0;
            // 
            // textTaille
            // 
            textTaille.Anchor = AnchorStyles.None;
            textTaille.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTaille.Location = new Point(600, 154);
            textTaille.Name = "textTaille";
            textTaille.Size = new Size(125, 38);
            textTaille.TabIndex = 1;
            textTaille.TextChanged += textBox2_TextChanged;
            // 
            // textPoids
            // 
            textPoids.Anchor = AnchorStyles.None;
            textPoids.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPoids.Location = new Point(600, 199);
            textPoids.Name = "textPoids";
            textPoids.Size = new Size(125, 38);
            textPoids.TabIndex = 2;
            // 
            // comboSexe
            // 
            comboSexe.Anchor = AnchorStyles.None;
            comboSexe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboSexe.FormattingEnabled = true;
            comboSexe.Items.AddRange(new object[] { "Masculin", "Feminin" });
            comboSexe.Location = new Point(600, 242);
            comboSexe.Name = "comboSexe";
            comboSexe.Size = new Size(125, 39);
            comboSexe.TabIndex = 3;
            // 
            // comboDresseur
            // 
            comboDresseur.Anchor = AnchorStyles.None;
            comboDresseur.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboDresseur.FormattingEnabled = true;
            comboDresseur.Items.AddRange(new object[] { "Oui", "Non" });
            comboDresseur.Location = new Point(600, 287);
            comboDresseur.Name = "comboDresseur";
            comboDresseur.Size = new Size(125, 39);
            comboDresseur.TabIndex = 4;
            // 
            // numericPV
            // 
            numericPV.Anchor = AnchorStyles.None;
            numericPV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericPV.Location = new Point(600, 332);
            numericPV.Maximum = new decimal(new int[] { 450, 0, 0, 0 });
            numericPV.Name = "numericPV";
            numericPV.Size = new Size(125, 38);
            numericPV.TabIndex = 5;
            // 
            // labelNom
            // 
            labelNom.Anchor = AnchorStyles.None;
            labelNom.AutoSize = true;
            labelNom.BackColor = SystemColors.ButtonHighlight;
            labelNom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNom.Location = new Point(416, 115);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(56, 28);
            labelNom.TabIndex = 6;
            labelNom.Text = "Nom";
            // 
            // labelTaille
            // 
            labelTaille.Anchor = AnchorStyles.None;
            labelTaille.AutoSize = true;
            labelTaille.BackColor = SystemColors.ButtonHighlight;
            labelTaille.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTaille.Location = new Point(416, 157);
            labelTaille.Name = "labelTaille";
            labelTaille.Size = new Size(62, 28);
            labelTaille.TabIndex = 7;
            labelTaille.Text = "Taille";
            // 
            // labelPoids
            // 
            labelPoids.Anchor = AnchorStyles.None;
            labelPoids.AutoSize = true;
            labelPoids.BackColor = SystemColors.ButtonHighlight;
            labelPoids.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPoids.Location = new Point(416, 202);
            labelPoids.Name = "labelPoids";
            labelPoids.Size = new Size(60, 28);
            labelPoids.TabIndex = 8;
            labelPoids.Text = "Poids";
            // 
            // labelSexe
            // 
            labelSexe.Anchor = AnchorStyles.None;
            labelSexe.AutoSize = true;
            labelSexe.BackColor = SystemColors.ButtonHighlight;
            labelSexe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSexe.Location = new Point(416, 245);
            labelSexe.Name = "labelSexe";
            labelSexe.Size = new Size(52, 28);
            labelSexe.TabIndex = 9;
            labelSexe.Text = "Sexe";
            // 
            // labelDresseur
            // 
            labelDresseur.Anchor = AnchorStyles.None;
            labelDresseur.AutoSize = true;
            labelDresseur.BackColor = SystemColors.ButtonHighlight;
            labelDresseur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDresseur.Location = new Point(416, 290);
            labelDresseur.Name = "labelDresseur";
            labelDresseur.Size = new Size(91, 28);
            labelDresseur.TabIndex = 10;
            labelDresseur.Text = "Dresseur";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(416, 334);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 11;
            // 
            // labelPV
            // 
            labelPV.Anchor = AnchorStyles.None;
            labelPV.AutoSize = true;
            labelPV.BackColor = SystemColors.ButtonHighlight;
            labelPV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPV.Location = new Point(416, 334);
            labelPV.Name = "labelPV";
            labelPV.Size = new Size(37, 28);
            labelPV.TabIndex = 12;
            labelPV.Text = "PV";
            labelPV.Click += labelPV_Click;
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.None;
            labelDescription.AutoSize = true;
            labelDescription.BackColor = SystemColors.ButtonHighlight;
            labelDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(416, 377);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(115, 28);
            labelDescription.TabIndex = 13;
            labelDescription.Text = "Description";
            // 
            // labelEvolution
            // 
            labelEvolution.Anchor = AnchorStyles.None;
            labelEvolution.AutoSize = true;
            labelEvolution.BackColor = SystemColors.ButtonHighlight;
            labelEvolution.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEvolution.Location = new Point(416, 417);
            labelEvolution.Name = "labelEvolution";
            labelEvolution.Size = new Size(97, 28);
            labelEvolution.TabIndex = 14;
            labelEvolution.Text = "Evolution";
            // 
            // textDescription
            // 
            textDescription.Anchor = AnchorStyles.None;
            textDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescription.Location = new Point(601, 374);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(125, 34);
            textDescription.TabIndex = 15;
            // 
            // textEvolution
            // 
            textEvolution.Anchor = AnchorStyles.None;
            textEvolution.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEvolution.Location = new Point(601, 414);
            textEvolution.Name = "textEvolution";
            textEvolution.Size = new Size(125, 34);
            textEvolution.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 28);
            label1.Name = "label1";
            label1.Size = new Size(352, 46);
            label1.TabIndex = 17;
            label1.Text = "Ajouter un Pokémon";
            // 
            // buttonValider
            // 
            buttonValider.Anchor = AnchorStyles.None;
            buttonValider.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonValider.Location = new Point(843, 233);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(115, 54);
            buttonValider.TabIndex = 18;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // AjouterDesPokemonsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 525);
            Controls.Add(buttonValider);
            Controls.Add(label1);
            Controls.Add(textEvolution);
            Controls.Add(textDescription);
            Controls.Add(labelEvolution);
            Controls.Add(labelDescription);
            Controls.Add(labelPV);
            Controls.Add(label4);
            Controls.Add(labelDresseur);
            Controls.Add(labelSexe);
            Controls.Add(labelPoids);
            Controls.Add(labelTaille);
            Controls.Add(labelNom);
            Controls.Add(numericPV);
            Controls.Add(comboDresseur);
            Controls.Add(comboSexe);
            Controls.Add(textPoids);
            Controls.Add(textTaille);
            Controls.Add(textNom);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(640, 480);
            Name = "AjouterDesPokemonsForm";
            Text = "AjouterDesPokemonsForm";
            Load += AjouterDesPokemonsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericPV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string taille = textTaille.Text;
            string poids = textPoids.Text;
            string sexe = comboSexe.SelectedItem?.ToString() ?? "";
            string dresseur = comboDresseur.SelectedItem?.ToString() ?? "";
            int pv = (int)numericPV.Value;
            string description = textDescription.Text;
            string evolution = textEvolution.Text;
            Pokemon pokemon = new Pokemon(nom, taille, poids, sexe, dresseur, pv, description, evolution);
            pokemonManager.AjouterPokemon(pokemon);
            MessageBox.Show("Le Pokémon a été ajouté avec succès !");
        }


        private PokemonManager GetPokemonManager()
        {
            return pokemonManager;
        }

        #endregion

        private TextBox textNom;
        private TextBox textTaille;
        private TextBox textPoids;
        private ComboBox comboSexe;
        private ComboBox comboDresseur;
        private NumericUpDown numericPV;
        private Label labelNom;
        private Label labelTaille;
        private Label labelPoids;
        private Label labelSexe;
        private Label labelDresseur;
        private Label label4;
        private Label labelPV;
        private Label labelDescription;
        private Label labelEvolution;
        private TextBox textDescription;
        private TextBox textEvolution;
        private Label label1;
        private Button buttonValider;
    }
}