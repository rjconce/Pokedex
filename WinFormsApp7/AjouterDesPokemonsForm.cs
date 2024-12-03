using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class AjouterDesPokemonsForm : Form
    {
        public AjouterDesPokemonsForm(PokemonManager manager)
        {
            InitializeComponent();
            this.pokemonManager = manager;
        }

        new PokemonManager pokemonManager;
        private PokemonManager? manager;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPV_Click(object sender, EventArgs e)
        {

        }

        private PokemonManager PokemonManager => pokemonManager;

        private void buttonValider_Click(object sender, EventArgs e, PokemonManager pokemonManager)
        {


            string nom = textNom.Text;  
            string taille = textTaille.Text; 
            string poids = textPoids.Text;  
            string sexe = comboSexe.SelectedItem.ToString();  
            string dresseur = comboDresseur.SelectedItem.ToString(); 
            int pv = (int)numericPV.Value; 
            string description = textDescription.Text; 
            string evolution = textEvolution.Text;  

            Pokemon pokemon = new Pokemon(nom, taille, poids, sexe, dresseur, pv, description, evolution);

   
            PokemonManager.AjouterPokemon(pokemon);


            MessageBox.Show("Le Pokémon a été ajouté avec succès !");
        }

        private void AjouterDesPokemonsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
