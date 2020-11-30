using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Cola1
{

    class Cola
    {
        private const int NumElementos = 20;
        private int[] elemento = new int[NumElementos];
        private int inicio, final;

        public Cola()
        {
            inicio = -1;
            final = -1;
        }

        public bool Vacio()
        {
            if (inicio == final)
                return true;
            else
                return false;
        }
        public void ImprimeCola()
        {

            for (int contador = inicio + 1; contador <= final; contador++)
            {
                Console.WriteLine("{0}", elemento[contador]);

            };
            Console.WriteLine("Esto es todo!");
        }

        public void Ingresa(int a)
        {

            if (final == NumElementos - 1)
                final = 0;
            //else final = final + 1
            elemento[final + 1] = a;
            final++;
            if (inicio == final)
            {
                Console.WriteLine("Cola Llena, no admite adicionar elementos.");
                return;
            }
        }


        public int Retira()
        {

            if (Vacio())
            {
                Console.WriteLine("Cola Vacia, no es posible extraer un elemento");
                return 0;
            }

            int auxiliar = elemento[inicio + 1];
            elemento[inicio + 1] = 0;
            if (inicio == NumElementos - 1)
                inicio = 0;
            else
                inicio++;
            return auxiliar;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Cola Cola1 = new Cola();
            Cola1.Ingresa(1);
            Cola1.Ingresa(2);
            Cola1.Ingresa(3);
            Cola1.Ingresa(4);
            Console.WriteLine("Esta es la cola con elementos ingresados");
            Cola1.ImprimeCola();
            Console.WriteLine("Se extrae un elemento de la cola");
            Console.WriteLine("{0}", Cola1.Retira());
            Console.WriteLine("Esta es la cola luego de haber extraido un elemento");
            Cola1.ImprimeCola();
            Console.WriteLine("Se extrae un elemento de la cola");
            Console.WriteLine("{0}", Cola1.Retira());
            Console.WriteLine("Esta es la cola luego de haber extraido un elemento");
            Cola1.ImprimeCola();
            Console.WriteLine("En este punto la cola SI tiene elementos, por lo que la función Vacio retorna {0}", Cola1.Vacio());
            Console.WriteLine("Se extrae un elemento de la cola");
            Cola1.Ingresa(1);
            Console.WriteLine("Esta es la cola luego de haber ingresado un elemento");
            Cola1.ImprimeCola();
            Console.WriteLine("En este punto la cola SI tiene elementos, por lo que la función Vacio retorna {0}", Cola1.Vacio());
        }
    }
}