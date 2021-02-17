using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)


        {
            const string login = "jirlinge";
            const string psw = "coucou";
            

            Console.WriteLine("veuillez renseigner votre login");
            string loginUs = Console.ReadLine();
            Console.WriteLine("veuillez renseigner votre mdp");
            string pswUs = Console.ReadLine();



            switch (loginUs, pswUs)
            {
                case (login, psw):
                
                    Console.WriteLine("bienvenu a la Manu");
                    break;

              
                   
                default:
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de pass");
                    break;
            }

            
           

        
        }
    }
}
