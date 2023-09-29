using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
     class Outils
    {
       public static int DemanderNombrePositifNonNul(string question)
        {
            #region 1ère possibilité avec la fonction recurssive
            //int nombre = DemanderNombre(question);
            //if (nombre >0)
            //{
            //    return nombre;
            //}
            //Console.WriteLine("Veuillez Rentrer un nombre supérieure à 0");

            //return DemanderNombrePositifNonNul(question);
            #endregion

            #region deuxième méthode 

            return DemanderNombreEntre(question, 1, int.MaxValue);

            #endregion
        }


     public static int DemanderNombreEntre(string question, int min, int max)
        {
            Console.WriteLine("Le nombre min est : " + min + ", Le nombre max est : " + max);

            #region avec la boucle true 
            //while (true) 
            //{
            //    int nombre = DemanderNombre(question);
            //    if ((nombre >= min) && (nombre <= max))
            //    {
            //        return nombre;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Veuillez Rentrer un nombre Compris compris entre "+min+ " et "+max);
            //    }

            //}
            #endregion

            #region Avec la fonction recurssive 
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            Console.WriteLine("Veuillez Rentrer un nombre Compris compris entre " + min + " et " + max);
            return DemanderNombreEntre(question, min, max);
            #endregion

        }

       public static int DemanderNombre(string question)
        {
            // Poser question
            //   int responseSizeInt = 0;
            while (true)
            {
                Console.WriteLine(question);
                string response = Console.ReadLine();

                try
                {
                    int responseSizeInt = int.Parse(response);
                    return responseSizeInt;

                }
                catch (FormatException)
                {
                    Console.WriteLine("ERREUR: Veuillez Rentrer un nombre valide");
                }
            }

            // Récupérer la réponse 
            // Convertir 
            //Gérer l'erreur de conversion
            // Boucler tant qu'on a n'a pas recu une reponse valide(qui contien que des chiffres)
        }

    }
}
