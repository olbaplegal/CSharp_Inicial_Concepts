using System.Security.Cryptography.X509Certificates;

namespace CShrpSemaphores
{
    internal class Program
    {
        public static Semaphore threadPool = new Semaphore(3, 5);//criando instancia semaphore atendendo no maximo 5, atendendo inicialmente 3
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Thread threadObject =
                    new Thread(new ThreadStart(ProcessarOperacao));

                threadObject.Name = "thread: " + i;
                threadObject.Start();
            }
            Console.ReadLine();
        }
        private static void ProcessarOperacao()
        {
            threadPool.WaitOne();//controle do fluxo de acordo com a definição do objeto da classe 

            Console.WriteLine($"Thread {Thread.CurrentThread.Name} entrou na sessão critica...");

            Thread.Sleep(6000);

            threadPool.Release();//liberação das threads de forma que não exceda os valores definidos no semaphores
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} foi liberada...");
        }
    }
}
