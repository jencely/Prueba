using System;
using System.Threading;

namespace JenifferGuañunaPruebaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola esta es una prueba");



            Thread hilo1 = new Thread(NumeroHabitantes);
            Thread hilo2 = new Thread(NumeroHabitantes);

            Console.WriteLine("vamos a empezar a contar hilo1");
            hilo1.Start();

            Console.WriteLine("vamos a contar hilo2");
            hilo2.Start();

            Thread.Sleep(100);

            hilo1.Join();
            hilo2.Join();
        }

        static void NumeroHabitantes()
        {

            var hiloActual = Thread.CurrentThread;

            Console.WriteLine("Hilo actual {0}: ", hiloActual.ManagedThreadId);
           
            var random = new Random();

            var numeroTotal = 0;
            for (int i = 1; i <= 100; i++)
            {
                var habitantes = new Random().Next(1, 6);
                Console.WriteLine("Hilo {0} Edificio {1} Personas {2}", hiloActual.ManagedThreadId, i, habitantes);
                numeroTotal += habitantes;

                Thread.Sleep(random.Next(100, 500));
            }
            Console.WriteLine("El numero total de personas en el edificio: " + numeroTotal);
            
      

        }
    }
}
