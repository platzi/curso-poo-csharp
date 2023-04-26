// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
superman.SuperPoderes = new []{ "Vision de rayos X", "Volar", "Super fueza", "Ojos rayos lazer" };

class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public string[] SuperPoderes;
    public bool PuedeVolar;
}