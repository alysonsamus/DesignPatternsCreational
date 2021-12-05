using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your Name:");
            string NameConsole = Console.ReadLine();

            Console.WriteLine("Type your Age:");
            int Age = Console.ReadLine().Length > 2 ? int.Parse(s: Console.ReadLine()) : 10;


            Console.WriteLine("Choose (F)ighter or (M)age: \n");
            string CType = Console.ReadLine().ToUpper();
            try
            {
                var MyChar = CharacterFactory.CreateCharacter(CType, NameConsole, Age);
                Console.WriteLine("Congratulation your {0} named {1}  was created successfully!", MyChar.Classe, NameConsole); ;
                Console.ReadKey();
            }
            catch (Exception e) {
                Console.WriteLine("Erro: \n {0}", e);
            }



        }
    }
}
