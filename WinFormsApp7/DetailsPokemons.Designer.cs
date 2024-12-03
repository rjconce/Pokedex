namespace WinFormsApp7
{
    partial class DetailsPokemons
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
            labelNom = new Label();
            labelTaille = new Label();
            labelPoids = new Label();
            labelSexe = new Label();
            labelDresseur = new Label();
            labelPV = new Label();
            label7 = new Label();
            labelDescription = new Label();
            labelEvolution = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.Anchor = AnchorStyles.None;
            labelNom.AutoSize = true;
            labelNom.BackColor = SystemColors.ButtonHighlight;
            labelNom.Location = new Point(376, 46);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(42, 20);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelTaille
            // 
            labelTaille.Anchor = AnchorStyles.None;
            labelTaille.AutoSize = true;
            labelTaille.BackColor = SystemColors.ButtonHighlight;
            labelTaille.Location = new Point(376, 87);
            labelTaille.Name = "labelTaille";
            labelTaille.Size = new Size(43, 20);
            labelTaille.TabIndex = 1;
            labelTaille.Text = "Taille";
            // 
            // labelPoids
            // 
            labelPoids.Anchor = AnchorStyles.None;
            labelPoids.AutoSize = true;
            labelPoids.BackColor = SystemColors.ButtonHighlight;
            labelPoids.Location = new Point(376, 134);
            labelPoids.Name = "labelPoids";
            labelPoids.Size = new Size(44, 20);
            labelPoids.TabIndex = 2;
            labelPoids.Text = "Poids";
            // 
            // labelSexe
            // 
            labelSexe.Anchor = AnchorStyles.None;
            labelSexe.AutoSize = true;
            labelSexe.BackColor = SystemColors.ButtonHighlight;
            labelSexe.Location = new Point(376, 179);
            labelSexe.Name = "labelSexe";
            labelSexe.Size = new Size(40, 20);
            labelSexe.TabIndex = 3;
            labelSexe.Text = "Sexe";
            // 
            // labelDresseur
            // 
            labelDresseur.Anchor = AnchorStyles.None;
            labelDresseur.AutoSize = true;
            labelDresseur.BackColor = SystemColors.ButtonHighlight;
            labelDresseur.Location = new Point(376, 222);
            labelDresseur.Name = "labelDresseur";
            labelDresseur.Size = new Size(66, 20);
            labelDresseur.TabIndex = 4;
            labelDresseur.Text = "Dresseur";
            labelDresseur.Click += label5_Click;
            // 
            // labelPV
            // 
            labelPV.Anchor = AnchorStyles.None;
            labelPV.AutoSize = true;
            labelPV.BackColor = SystemColors.ButtonHighlight;
            labelPV.Location = new Point(376, 259);
            labelPV.Name = "labelPV";
            labelPV.Size = new Size(26, 20);
            labelPV.TabIndex = 5;
            labelPV.Text = "PV";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(457, 191);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 6;
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.None;
            labelDescription.AutoSize = true;
            labelDescription.BackColor = SystemColors.ButtonHighlight;
            labelDescription.Location = new Point(376, 300);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Description";
            // 
            // labelEvolution
            // 
            labelEvolution.Anchor = AnchorStyles.None;
            labelEvolution.AutoSize = true;
            labelEvolution.BackColor = SystemColors.ButtonHighlight;
            labelEvolution.Location = new Point(376, 343);
            labelEvolution.Name = "labelEvolution";
            labelEvolution.Size = new Size(71, 20);
            labelEvolution.TabIndex = 7;
            labelEvolution.Text = "Evolution";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(200, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "Nom";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(200, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "Taille";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(200, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            textBox3.Text = "Poids";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(200, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            textBox4.Text = "Sexe";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(200, 222);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            textBox5.Text = "Dresseur";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(200, 259);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 13;
            textBox6.Text = "PV";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.Location = new Point(200, 300);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 14;
            textBox7.Text = "Descritpion";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.Location = new Point(200, 343);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 15;
            textBox8.Text = "Text";
            // 
            // DetailsPokemons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.images__5_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(622, 433);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelEvolution);
            Controls.Add(labelDescription);
            Controls.Add(label7);
            Controls.Add(labelPV);
            Controls.Add(labelDresseur);
            Controls.Add(labelSexe);
            Controls.Add(labelPoids);
            Controls.Add(labelTaille);
            Controls.Add(labelNom);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(640, 480);
            Name = "DetailsPokemons";
            Text = "DetailsPokemons";
            Load += DetailsPokemons_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelTaille;
        private Label labelPoids;
        private Label labelSexe;
        private Label labelDresseur;
        private Label labelPV;
        private Label label7;
        private Label labelDescription;
        private Label labelEvolution;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}