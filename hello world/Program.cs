
using static System.Console;


namespace hello_world
{
    internal class Program
    { 
        /// <summary>
        /// код который выпоняется в первую очередь
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Hello World!!");

            WriteLine("\npress any button to exit");

            ReadKey(); //приложение не закроется пока небудет нажата какая нибудь кнопка
          
        }
    }
}
