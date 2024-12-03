using System;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class MesPokemonsForm : Form
    {
        private PokemonManager pokemonManager;

        public MesPokemonsForm(PokemonManager manager)
        {
            InitializeComponent();
            this.pokemonManager = manager;
        }

        private void RafraichirListePokemons()
        {
            listBoxPokemons.Items.Clear();

            foreach (Pokemon pokemon in pokemonManager.ObtenirTousLesPokemons())
            {
                listBoxPokemons.Items.Add(pokemon); 
            }
        }

        private void MesPokemonsForm_Load(object sender, EventArgs e)
        {
            RafraichirListePokemons();
        }

        private void listBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPokemons.SelectedItem != null)
            {
                Pokemon selectedPokemon = (Pokemon)listBoxPokemons.SelectedItem;

                DetailsPokemons detailsForm = new DetailsPokemons(selectedPokemon);

              
                detailsForm.ShowDialog(); 
            }
        }
    }
}
