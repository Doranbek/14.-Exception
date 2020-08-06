using System;

namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Student s = new Student("", "Арматов", 2);

            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");        

            }

            finally 
            {
                Console.WriteLine("Конец первой проверки");                
            }

                  
            try
            {
                Student s = new Student("Максим", "", 2);

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Конец второй проверки");               
            }

            Console.ReadKey();
        }
    }
}
