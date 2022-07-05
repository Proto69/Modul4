using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static int countOfMoons = 0;

        static void Main(string[] args)
        {
            Dictionary<string, Galaxy> galaxies = new();
            Dictionary<string, Star> stars = new();
            Dictionary<string, Planet> planets = new();
            string[] input;
            while ((input = Console.ReadLine().Split(' ').ToArray())[0] != "exit")
            {
                List<string> names = new();
                if (input.Length > 1)
                {
                    //тук намираме имената и ги запазваме
                    bool thereIsName = false;
                    string name = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i][0] == '[')
                        {
                            name += (input[i].Trim('[') + " ");
                            thereIsName = true;
                        }
                        else if (thereIsName) name += (input[i] + " ");
                        if (input[i].Last() == ']')
                        {
                            thereIsName = false;
                            names.Add(name.Remove(name.Length - 2, 2));
                            name = "";
                        }
                    }
                }
                //махаме самите имена
                input = input.Where(x => !x.Contains('[') && !x.Contains(']')).ToArray();

                switch (input[0])
                {
                    case "add":
                        try
                        {
                            switch (input[1])
                            {
                                case "galaxy":
                                    galaxies.Add(names[0], new Galaxy(names[0], input[2], input[3]));
                                    break;
                                case "star":
                                    Star newStar = new(names[1], double.Parse(input[2]), double.Parse(input[3]),
                                        int.Parse(input[4]), double.Parse(input[5]));
                                    galaxies[names[0]].Stars.Add(newStar);
                                    stars.Add(names[1], newStar);
                                    break;
                                case "planet":
                                    Planet newPlanet = new(names[1], input[2], input[3]);
                                    stars[names[0]].Planets.Add(newPlanet);
                                    planets.Add(names[1], newPlanet);
                                    break;
                                case "moon":
                                    planets[names[0]].Moons.Add(new Moon(names[1]));
                                    countOfMoons++;
                                    break;
                            }
                            Console.WriteLine($"Added new {input[1]}.");
                        }
                        catch
                        {
                            Console.WriteLine($"Inappropriate sintaxis or invalid object name!");
                        }
                        break;
                    case "list":
                        switch (input[1])
                        {
                            case "galaxies":
                                Console.WriteLine("--- List of all researched galaxies ---");
                                foreach (var item in galaxies)
                                {
                                    Console.WriteLine(item.Key);
                                }
                                Console.WriteLine("--- End of galaxies list ---");
                                break;
                            case "stars":
                                Console.WriteLine("--- List of all researched stars ---");
                                foreach (var item in stars)
                                {
                                    Console.WriteLine(item.Key);
                                }
                                Console.WriteLine("--- End of stars list ---");
                                break;
                            case "planets":
                                Console.WriteLine("--- List of all researched planets ---");
                                foreach (var item in planets)
                                {
                                    Console.WriteLine(item.Key);
                                }
                                Console.WriteLine("--- End of planets list ---");
                                break;
                            case "moons":
                                Console.WriteLine("--- List of all researched moons ---");
                                foreach (var item in planets)
                                {
                                    foreach (var moon in item.Value.Moons)
                                    {
                                        Console.WriteLine(moon.Name);
                                    }
                                }
                                Console.WriteLine("--- End of moons list ---");
                                break;
                        }
                        break;
                    case "print":
                        try
                        {
                            if (galaxies.ContainsKey(names[0]))
                            {
                                Console.WriteLine($"--- Data for {names[0]} galaxy ---");
                                Console.WriteLine(galaxies[names[0]].ToString());
                                Console.WriteLine($"--- End of data for {names[0]} galaxy ---");
                            }
                            else
                            {
                                Console.WriteLine($"There is no galaxy named {names[0]}");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Inappropriate sintaxis!");
                        }
                        break;
                    case "stats":
                        Console.WriteLine("--- Stats ---");
                        Console.WriteLine($"Galaxies: {galaxies.Count}");
                        Console.WriteLine($"Stars: {stars.Count}");
                        Console.WriteLine($"Planets: {planets.Count}");
                        Console.WriteLine($"Moons: {countOfMoons}");
                        Console.WriteLine("--- End of stats ---");
                        break;
                }
            }
        }
    }

}

