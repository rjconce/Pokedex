namespace WinFormsApp7
{
    partial class MesPokemonsForm
    {
        private System.ComponentModel.IContainer components = null;
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

        private void InitializeComponent()
        {
            listBoxPokemons = new ListBox();
            SuspendLayout();
            // 
            // listBoxPokemons
            // 
            listBoxPokemons.Anchor = AnchorStyles.None;
            listBoxPokemons.BackColor = SystemColors.Highlight;
            listBoxPokemons.FormattingEnabled = true;
            listBoxPokemons.Location = new Point(12, 12);
            listBoxPokemons.Name = "listBoxPokemons";
            listBoxPokemons.Size = new Size(776, 424);
            listBoxPokemons.TabIndex = 0;
            listBoxPokemons.SelectedIndexChanged += listBoxPokemons_SelectedIndexChanged;
            // 
            // MesPokemonsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPokemons);
            Name = "MesPokemonsForm";
            Text = "MesPokemonsForm";
            Load += MesPokemonsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPokemons;
    }
}