using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesConsole
{
    // Neu in C# 8: Standardimplementierungen in Interfaces (nur Core!)
    interface ISampleWithStandards
    {
        string Name { get; set; }

        void MachWas();

        public  void TuWas(int wieOft)
        {
            for (int i = 0; i < wieOft; i++)
            {
                
            }
        }

        public void TuNochwas() => Console.WriteLine("Tu ich");

        public static int Zahl { get; set; } = 42;
    }

    public class Implementer : ISampleWithStandards
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MachWas()
        {
            throw new NotImplementedException();
        }

    }

    public class MyClass
    {
        public MyClass()
        {
            ISampleWithStandards impl = new Implementer();
            // Public-Methoden des Interfaces nur, wenn als Interface deklariert
            impl.TuWas(10);
        }
    }
}
