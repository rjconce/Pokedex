namespace WinFormsApp7
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            PokemonManager manager = new PokemonManager();

            Form1 form1 = new Form1(manager);

            Application.Run(form1); 
        }
    }
}
