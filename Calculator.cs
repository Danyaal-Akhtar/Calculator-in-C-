using System;

class Calculator
{
    static void Main()
    {
    
        Console.Write("Entrez le premier nombre : ");
        double num1 = double.Parse(Console.ReadLine() ?? "null");

        Console.Write("Entrez un opérateur (+, -, *, /): ");
        string operateur = Console.ReadLine() ?? "null";

        Console.Write("Entrez le second nombre : ");
        double num2 = double.Parse(Console.ReadLine() ?? "null");

      

        double res = 0;

        switch (operateur) 
        {
            case "+":
                res = num1 + num2; 
                break;

            case "-":
                res = num1 - num2;
                break;

            case "*":
                res = num1 * num2;
                break;

            case "/":
                if (num2 != 0)
                {
                    res = num1 / num2;

                }
                else
                {
                    Console.WriteLine("Erreur de la division par zéro !");
                    return;
                }
                break;
            default:
                Console.WriteLine("Veuillez saisir un opérateur valide !!!");
                return;

        }

        Console.Write($"Résultat : {num1} {operateur} {num2} = {res}");





    }

}
