public class Pokemon
{
    public string Nom { get; set; }
    public string Taille { get; set; }
    public string Poids { get; set; }
    public string Sexe { get; set; }
    public string Dresseur { get; set; }
    public int PV { get; set; }
    public string Description { get; set; }
    public string Evolution { get; set; }
    public object Type { get; internal set; }

    public Pokemon(string nom, string taille, string poids, string sexe, string dresseur, int pv, string description, string evolution)
    {
        Nom = nom;
        Taille = taille;
        Poids = poids;
        Sexe = sexe;
        Dresseur = dresseur;
        PV = pv;
        Description = description;
        Evolution = evolution;
    }

    // Ajoute la méthode ToString() pour afficher le nom dans la ListBox
    public override string ToString()
    {
        return this.Nom; // Affiche uniquement le nom du Pokémon dans la ListBox
    }
}
