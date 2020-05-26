using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculmental
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = 0, reponse = 0, i = 1;  // déclaration des entiers et initialisation du nombre de point, des reponses aux calculs et du compteur


            Console.WriteLine(" Bienvenue sur notre test de calcul mental" + Environment.NewLine +"Vous serez evalué sur 10 points !" + Environment.NewLine +"Tout d'abord, quel est votre nom?"); // ici démarrage, présentation + récuperation du nom utilisateur
            string name = Console.ReadLine(); // ici le texte de réponse
            Console.WriteLine("Bien! Alors " +  name  +  "Nous pouvons commencez, Bonne chance!");

            while (i != 10) // boucle tant que
            {
                Random chiffre = new Random(); // pour générer des nbres aléatoires

                int grand = chiffre.Next(300), petit = chiffre.Next(0, 11), grand2 = chiffre.Next(301, 650), petit2 = chiffre.Next(0, 11);
                Console.WriteLine("Question numéro" + i);
                if (i == 1 || i == 5 || i == 8) // condition si 
                {
                    Console.WriteLine(grand + " + " + grand2 + "="); // affichage avec opérateur +
                    reponse = Convert.ToInt32(Console.ReadLine());
                    int reponseCalcul = grand + grand2;
                    if (reponse == reponseCalcul)
                    {
                        point++; // ici j'ai un compteur
                        Console.WriteLine("Bravo vous avez trouvé la bonne réponse!"); // réponse si résultat ok
                    }
                    else // ou
                    {
                        Console.WriteLine("Désolé la réponse était: " + reponseCalcul); // réponse si réponse fausse
                    }

                }
                else if (i == 2 || i == 9) // si la condition est ok
                {
                    Console.WriteLine(petit + " * " + petit2 + "="); // affichage avec opérateur *
                    reponse = Convert.ToInt32(Console.ReadLine()); // le joueur déclare sa réponse
                    int reponseCalcul = petit * petit2;
                    if (reponse == reponseCalcul)
                    {
                        point++;
                        Console.WriteLine("Bravo vous avez trouvé la bonne réponse!");
                    }
                    else
                    {
                        Console.WriteLine("Désolé la réponse était: " + reponseCalcul);
                    }
                }
                else if (i == 3 || i == 6 || i == 10)
                {
                    Console.WriteLine(grand2 + " - " + grand + "="); // affichage avec opérateur -
                    reponse = Convert.ToInt32(Console.ReadLine());
                    int reponseCalcul = grand2 - grand;
                    if (reponse == reponseCalcul)
                    {
                        point++;
                        Console.WriteLine("Bravo vous avez trouvé la bonne réponse!");
                    }
                    else
                    {
                        Console.WriteLine("Désolé la réponse était: " + reponseCalcul);
                    }
                }
                else
                {
                    Console.WriteLine(grand + " / " + petit + "="); // affichage avec opérateur /
                    reponse = Convert.ToInt32(Console.ReadLine());
                    int reponseCalcul = grand / petit;
                    if (reponse == reponseCalcul)
                    {
                        point++;
                        Console.WriteLine("Bravo vous avez trouvé la bonne réponse!");
                    }
                    else
                    {
                        Console.WriteLine("Désolé la réponse était: " + reponseCalcul);
                    }
                }
                i++; // compteur
            }
            Console.WriteLine("Vous avez cumulé un total de " + point + "points"); // affichage nombre de points
        }
    }
}
