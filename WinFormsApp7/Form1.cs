namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private PokemonManager manager = new PokemonManager();

        public Form1(PokemonManager manager)
        {
            InitializeComponent();
        }

        private void buttonMesPokemons_Click(object sender, EventArgs e)
        {
            MesPokemonsForm mesPokemonsForm = new MesPokemonsForm(manager);
            mesPokemonsForm.Show();
        }

        private void buttonAjouterDesPokemons_Click(object sender, EventArgs e)
        {

            AjouterDesPokemonsForm ajouterDesPokemonsForm = new AjouterDesPokemonsForm(manager);
            ajouterDesPokemonsForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
