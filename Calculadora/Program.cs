using System;

namespace Calculadora
{
    class Program
    {
        //reducir metodo grande en varios metodos pequeños
        static int Sumar(int numeroA, int numeroB)
        {
            return numeroA + numeroB;
        }
        static int Restar(int numeroA, int numeroB)
        {
            return numeroA - numeroB;
        }
        static int Multiplicar(int numeroA, int numeroB)
        {
            return numeroA * numeroB;
        }
        static int Dividir(int numeroA, int numeroB)
        {
            return numeroA / numeroB;
        }
        //reducimos el codigo duplicado en una funcion
        static void mostrarResultado(int num)
        {
            Console.WriteLine("El resultado es : " + num);
        }
        static void Calculadora()
        {
            string opcion;
            int numeroA, numeroB;
            do
            {
                Console.WriteLine("+. sumar");
                Console.WriteLine("-. restar");
                Console.WriteLine("*. multiplicar");
                Console.WriteLine("/. dividir");
                Console.Write("elija una funcion");
                opcion = Console.ReadLine();
                Console.WriteLine("ingrese los numeros");
                Console.Write("numero 1 :");
                numeroA = int.Parse(Console.ReadLine());
                Console.WriteLine("numero 2: ");
                numeroB = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case "+":
                        mostrarResultado(Sumar(numeroA, numeroB));
                        break;
                    case "-":
                        mostrarResultado(Restar(numeroA, numeroB));
                        break;
                    case "*":
                        mostrarResultado(Multiplicar(numeroA, numeroB));
                        break;
                    case "/":
                        mostrarResultado(Dividir(numeroA, numeroB));
                        break;       
                }
                Console.Write("n¿Desea Continuar? s/n: ");
                opcion = Console.ReadLine();
            } while (opcion == "s");

        }
        ///////funcion grande
        static void Main(string[] args)
        {
            //////////////indentificadores bastantes cortos
            /*
            int v1 = 0;
            int v2 = 0;
            string r;
            int r2 = 0;
            do { 
                Console.WriteLine("+. sumar");
                Console.WriteLine("-. restar");
                Console.WriteLine("*. multiplicar");
                Console.WriteLine("/. dividir");
                Console.Write("elija una funcion");
                ////////////asignacion peresosa
                r = Console.ReadLine();
                string opcion = Convert.ToString(r);
                Console.WriteLine("ingrese los numeros");
                Console.Write("v1 :");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("v2: ");
                v2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("el resultado de la suma es");
                        r2 = v1 + v2;
                        Console.WriteLine("{0}+{1}={2}", v1, v2, r2);
                        break;

                    case "-":
                        Console.WriteLine("el resultado de la resta es");
                        r2 = v1 - v2;
                        Console.WriteLine("{0}-{1}={2}", v1, v2, r2);
                        break;
                    case "*":
                        Console.WriteLine("el resultado de la multiplicacion es");
                        r2 = v1 * v2;
                        Console.WriteLine("{0}*{1}={2}", v1, v2, r2);
                        break;
                    case "/":
                        Console.WriteLine("el resultado de la multiplicacion es");
                        r2 = v1 / v2;
                        Console.WriteLine("{0}/{1}={2}", v1, v2, r2);
                        break;

                }
                    Console.Write("n¿Desea Continuar? s/n: ");
                     r = Console.ReadLine();
            } while (r == "s");
            */
            Calculadora();

        }
    }
}
