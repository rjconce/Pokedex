namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonMesPokemons = new Button();
            buttonAjouterDesPokemons = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonMesPokemons, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonAjouterDesPokemons, 0, 1);
            tableLayoutPanel1.Location = new Point(393, 189);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(331, 170);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonMesPokemons
            // 
            buttonMesPokemons.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonMesPokemons.Location = new Point(3, 3);
            buttonMesPokemons.Name = "buttonMesPokemons";
            buttonMesPokemons.Size = new Size(325, 79);
            buttonMesPokemons.TabIndex = 0;
            buttonMesPokemons.Text = "Mes Pokemons";
            buttonMesPokemons.UseVisualStyleBackColor = true;
            buttonMesPokemons.Click += buttonMesPokemons_Click;
            // 
            // buttonAjouterDesPokemons
            // 
            buttonAjouterDesPokemons.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAjouterDesPokemons.Location = new Point(3, 88);
            buttonAjouterDesPokemons.Name = "buttonAjouterDesPokemons";
            buttonAjouterDesPokemons.Size = new Size(325, 79);
            buttonAjouterDesPokemons.TabIndex = 1;
            buttonAjouterDesPokemons.Text = "Ajouter des Pokemons";
            buttonAjouterDesPokemons.UseVisualStyleBackColor = true;
            buttonAjouterDesPokemons.Click += buttonAjouterDesPokemons_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1072, 555);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(640, 480);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonMesPokemons;
        private Button buttonAjouterDesPokemons;
    }
}
