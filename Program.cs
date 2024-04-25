using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] citation = {
                "Le succès n'est pas la clé du bonheur. Le bonheur est la clé du succès.",
                "La vie est comme une bicyclette, il faut avancer pour ne pas perdre l'équilibre.",
                "Le seul véritable voyage, ce ne serait pas d'aller vers de nouveaux paysages, mais d'avoir d'autres yeux.", 
                "L'important, ce n'est pas de savoir où l'on va, c'est d'avancer."            
            };
            Random generateur = new Random();
            int index = generateur.Next(0, citation.Length); 
            Console.WriteLine(citation[index]);
        }
    }
}