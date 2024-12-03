using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp7
{
    public partial class DetailsPokemons : Form
    {
        private Pokemon pokemon;


        public DetailsPokemons(Pokemon selectedPokemon)
        {
            InitializeComponent();
            this.pokemon = selectedPokemon; 
        }
        private void DetailsPokemons_Load(object sender, EventArgs e)
        {
            if (pokemon != null)
            {
                labelNom.Text = pokemon.Nom;
                labelTaille.Text = pokemon.Taille.ToString() + " m"; 
                labelPoids.Text = pokemon.Poids.ToString() + " kg"; 
                labelSexe.Text = pokemon.Sexe; 
                labelDresseur.Text = pokemon.Dresseur; 
                labelPV.Text = pokemon.PV.ToString(); 
                labelDescription.Text = pokemon.Description; 
                labelEvolution.Text = pokemon.Evolution;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
