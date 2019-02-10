using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDisposeExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingMethod();
            DisposeMethod();
        }
        static void UsingMethod()
        {
            String example ="Hola con using";
            using (DisposeExercice exercice = new DisposeExercice(example))
            {
                Console.WriteLine($"Usando using: {exercice}");
                Console.Read();
            }

        }
        static void DisposeMethod()
        {
            String example = "Hola con dispose";
            DisposeExercice exercice = new DisposeExercice(example);
            exercice.DisposeFunction();
            Console.WriteLine($"Usando dispose{exercice}");
            Console.Read();
        }
    }
}
