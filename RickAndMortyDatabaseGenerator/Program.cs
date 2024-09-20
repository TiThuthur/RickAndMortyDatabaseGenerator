

using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RickAndMortyDatabaseGenerator;

class Program
{
    static async Task Main(string[] args)
    {
        //string url = "https://rickandmortyapi.com/api/character";
        // Déclaration de la list de character
        //List<Character> characters = new List<Character>();
        using (var db = new RickAndMortyDBContext())
        {
            Console.WriteLine("Entrer A pour ajouter tous les charactère dans la base de données");
            Console.WriteLine("Entrer B pour afficher les tables de la base de données");
            Console.WriteLine("Entrer C pour afficher le noms de tous les characters de la base de données");
            
            switch (Console.ReadLine()) {
                case "A":
                    
                    using 
                    Console.WriteLine("Characters créés dans la base de données");

                break;
                case "B":
                    
                    var tables = db.Database
                        .SqlQuery<string>($"SELECT name FROM sqlite_master WHERE type='table'")
                        .ToList();
                    foreach(var table in tables)
                    {
                        Console.WriteLine(table);
                    }
                break;
                case "C":
                    var characters = db.Characters.ToList();
                    foreach (var character in characters) {
                        Console.WriteLine($"Nom : {character.Name}\tgenre: {character.Gender}");
                    }
                break;
                
            }

            //si la base de données, le fichier, n'existe pas alors on le crée
        }
    }
}
