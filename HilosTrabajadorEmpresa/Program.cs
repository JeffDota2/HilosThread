using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HilosTrabajadorEmpresa
{
    class Hilos
    {
        static void Main(string[] args)
        {
            // Se instancia una variable con la clase de apoyo 'Trabajador'
            var objTrabajador = new Trabajador();

            // Se declaran los 2 hilos, estableciendo que la función a ejecutar 
            Thread hilo1 = new Thread(objTrabajador.ImprimeEnunciado);
            Thread hilo2 = new Thread(objTrabajador.ImprimeEnunciado);

            // Se muestra el mensaje, desde el programa principal, que se llamarán a la ejecución de los hilos
            // En la impresión de mensaje se especifica el identificador del hilo que se asigna internamente
            Console.WriteLine("ID Hilo: {0} => Se llama a la ejecución de los hilos ", Thread.CurrentThread.ManagedThreadId.ToString());

            // Se llaman a ejecución los 2 hilos, y se pasa como parámetro el mensaje un hecho para imprimir
            hilo1.Start("Primer enunciado : El 'Trabajador' es Jefferson Cuello");
            hilo2.Start("Segundo enunciado: La  'Empresa' es Microsft");

            // Se espera a que termine la ejecución de ambos hilos
            while ((hilo1.IsAlive) || (hilo2.IsAlive))
            {
            }

            // Una vez terminados, se muestra el mensaje de finalización
            Console.WriteLine("ID Hilo: {0} => Finalizó ", Thread.CurrentThread.ManagedThreadId.ToString());
            Console.ReadLine();
        }
    }

    // Clase de apoyo que contiene la función que ejecutarán los hilos
    public class Trabajador
    {
        public void ImprimeEnunciado(object texto)
        {
            // Se muestra el mensaje de ejecución de la función
            // En la impresión de mensaje se especifica el identificador del hilo que se asigna internamente
            Console.WriteLine("ID Hilo: {0} => {1}.", Thread.CurrentThread.ManagedThreadId.ToString(), texto.ToString());
        }
    }
}