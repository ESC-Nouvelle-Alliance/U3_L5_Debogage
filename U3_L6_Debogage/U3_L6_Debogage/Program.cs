/* Projet U3_L6_Debogage
 * Programme en C#
 * Écrit par Mme Northrup
 * 
 * Ce programme demande à l'utilisateur pour le nombre
 * de termes voulu, et affiche à l'écran ce nombre
 * de termes de la suite Fibonacci.
 */

// Il y a plusieurs bogues dans ce programme:
// des erreurs de syntaxe, d'exécution et de logique.
// C'est à toi de les découvrir et de les corriger.
// Bonne chance!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_L6_Debogage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1 = 0, t2 = 1, t3, i, nombreTermes;

            Console.WriteLine("Combien de termes de la suite Fibonacci veux-tu afficher?: ");
            nombreTermes = Console.ReadLine();

            Console.WriteLine("\nVoici les " + nombreTermes + " premiers termes de la suite Fibonacci: ");

            Console.Write(t1 + " " + t2 + " ");           // Affiche les deux premiers termes (0 et 1)    
            for (i = 1; i < nombreTermes; ++i)            // Affiche les autres termes de la suite     
            {
                t3 = t1 + t2
                Console.WriteLine(t3 + " ");
                t1 = t2;
                t2 = t3;

                // Attends pour la touche ENTER pour fermer la console.
                Console.WriteLine("Appuie sur ENTER pour terminer.");
                Console.Read();

            }

        }
    }
}
