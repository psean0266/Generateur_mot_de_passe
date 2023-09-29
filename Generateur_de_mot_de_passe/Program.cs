using FormationCS;
using System;

namespace Generateur_de_mot_de_passe
{
     class Program
    {

        //static int DemanderNombrePositifNonNul(string question)
        //{
        //    #region 1ère possibilité avec la fonction recurssive
        //    //int nombre = DemanderNombre(question);
        //    //if (nombre >0)
        //    //{
        //    //    return nombre;
        //    //}
        //    //Console.WriteLine("Veuillez Rentrer un nombre supérieure à 0");

        //    //return DemanderNombrePositifNonNul(question);
        //    #endregion

        //    #region deuxième méthode 

        //    return DemanderNombreEntre(question, 1, int.MaxValue);
                      
        //    #endregion
        //}

        //static int DemanderNombreEntre(string question, int min,  int max)
        //{
        //    Console.WriteLine("Le nombre min est : " + min + ", Le nombre max est : " + max);

        //    #region avec la boucle true 
        //    //while (true) 
        //    //{
        //    //    int nombre = DemanderNombre(question);
        //    //    if ((nombre >= min) && (nombre <= max))
        //    //    {
        //    //        return nombre;
        //    //    }
        //    //    else 
        //    //    {
        //    //        Console.WriteLine("Veuillez Rentrer un nombre Compris compris entre "+min+ " et "+max);
        //    //    }

        //    //}
        //    #endregion

        //    #region Avec la fonction recurssive 
        //        int nombre = DemanderNombre(question);
        //        if ((nombre >= min) && (nombre <= max))
        //        {
        //            return nombre;
        //        }
        //            Console.WriteLine("Veuillez Rentrer un nombre Compris compris entre " + min + " et " + max);
        //            return DemanderNombreEntre(question, min, max);   
        //    #endregion

        //}

        //static int DemanderNombre(string question)
        //{
        //    // Poser question
        ////   int responseSizeInt = 0;
        //    while (true)
        //    {
        //        Console.WriteLine(question);
        //        string response = Console.ReadLine();

        //        try
        //        {
        //            int responseSizeInt = int.Parse(response);
        //            return responseSizeInt;

        //        }
        //        catch(FormatException)
        //        {
        //            Console.WriteLine("ERREUR: Veuillez Rentrer un nombre valide");
        //        }
        //    }
            
        //    // Récupérer la réponse 
        //    // Convertir 
        //    //Gérer l'erreur de conversion
        //    // Boucler tant qu'on a n'a pas recu une reponse valide(qui contien que des chiffres)
        //}
        static void Main(string[] args)
        {
            // Demander la longueur du mot de passe (DemanderNombre)
            // 2 - alphabet "abcd1234" 4 ""
            // 3 - Comment choisir un caractère aléatoire
            // 4 - Générer le mot de passe 
            // 5 - Amélioration


            const int NOMBRE_MAX = 10; 
            const int NOMBRE_MIN = 1;


            string question = "Pourrais-tu rentrer un nombre pour la taille ?";
            //DemanderNombre(question);

            //int nombrEntre = Outils.DemanderNombrePositifNonNul(question, NOMBRE_MIN, NOMBRE_MAX);

            int nombrEntre = Outils.DemanderNombrePositifNonNul(question);
        }
    }
}
